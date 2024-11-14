var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
export class SecureEndpoint {
    constructor() {
        this.cachedPublicKey = null;
        // TODO: tmp, delete after implementation of reading from jsApi
        this.testPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA4qrDDOykS8z6x51jlBZebPePuhnSlSHyMCEtyqUOETqavbHY9y8Kw5xBnDTzturd5vbtebw9YsotzRGY6ku9yCmc3uDF0P5DK6AVNxuDs4ziXXzCV1rKmB49ulqy53ygeIDZCFOGFpybFE6Qgg2W7taHfO+2Lkvx1zqtdhZmDl2Na1YwOhuXIq7Jym8Xn2Zb/2eYNQI5Y6jjDMwF3kJh3MpZhc6rw56fWKau4lkaxSx5IeH8U6L4Yzt63TyJ7PCLN5uNxkI25nUrHVW5nkmxexTA3ahk3hYH4MAd1GKNiXKTLPX1hzUq+fG3W9M++xv5i0NQrTU7YLlml19nfVSSFQIDAQAB";
    }
    // TODO: #1 Enable/disable secure-endpoint feature (could be implicit by loading JS lib, or existance of SecureEndpointPublicKey in html).
    // TODO: #2 window.crypto.subtle feature is available only in secure browser contexts (HTTPS). Need to provide warning and fallback when feature is missing.
    /**
     * Function to encrypt data
     * @param data - Data to encrypt
     * @returns Encrypted data containing the encrypted key, IV, and encrypted data
     */
    encryptData(data) {
        return __awaiter(this, void 0, void 0, function* () {
            // Fetch the RSA public key from the server
            const publicKeyPem = yield this.getPublicKey();
            // Import the RSA public key
            const publicKey = yield this.importPublicKey(publicKeyPem);
            // Generate a random AES key
            const aesKey = yield window.crypto.subtle.generateKey({
                name: "AES-CBC",
                length: 256,
            }, true, // extractable
            ["encrypt", "decrypt"]);
            // Export the AES key to raw bits
            const rawAesKey = yield window.crypto.subtle.exportKey("raw", aesKey);
            // Encrypt the AES key using RSA public key
            const encryptedKey = yield window.crypto.subtle.encrypt({
                name: "RSA-OAEP",
            }, publicKey, rawAesKey);
            // Generate a random IV
            const iv = window.crypto.getRandomValues(new Uint8Array(16)); // 16 bytes for AES-CBC
            // Convert the data to ArrayBuffer
            const enc = new TextEncoder();
            const encodedMessage = enc.encode(data);
            // Encrypt the data using AES key
            const encryptedData = yield window.crypto.subtle.encrypt({
                name: "AES-CBC",
                iv: iv,
            }, aesKey, encodedMessage);
            // Convert ArrayBuffers to base64 strings
            const encryptedKeyBase64 = this.arrayBufferToBase64(encryptedKey);
            const encryptedDataBase64 = this.arrayBufferToBase64(encryptedData);
            const ivBase64 = this.arrayBufferToBase64(iv.buffer);
            return { version: 1, data: encryptedDataBase64, key: encryptedKeyBase64, iv: ivBase64 };
        });
    }
    /**
     * Read the public key from the jsApi
     */
    getPublicKey() {
        if (this.cachedPublicKey !== null) {
            return this.cachedPublicKey;
        }
        // TODO: read form jsApi meta-tag in header
        this.cachedPublicKey = this.testPublicKey;
        return this.cachedPublicKey;
    }
    /**
     * Converts SPKI PEM format to DER ArrayBuffer
     * @param spkiPem - SPKI public key in PEM format
     * @returns ArrayBuffer of DER
     */
    getSpkiDer(spkiPem) {
        const pemContents = this.getPemContents(spkiPem);
        const binaryDerString = window.atob(pemContents);
        return this.str2ab(binaryDerString);
    }
    /**
     * Extracts the base64 content from a PEM formatted string
     * @param spkiPem - SPKI public key in PEM format
     * @returns Base64 string without PEM headers/footers and quotes
     */
    getPemContents(spkiPem) {
        let pemContent = spkiPem;
        pemContent = pemContent.replace(/\\r\\n/g, '');
        pemContent = this.removeFromStart(pemContent, "-----BEGIN PUBLIC KEY-----");
        pemContent = this.removeFromEnd(pemContent, "-----END PUBLIC KEY-----");
        pemContent = this.removeFromStart(pemContent, `"`);
        pemContent = this.removeFromEnd(pemContent, `"`);
        return pemContent;
    }
    /**
     * Removes a specified substring from the start of the content if it exists
     * @param content - Original string
     * @param remove - Substring to remove
     * @returns Modified string
     */
    removeFromStart(content, remove) {
        return content.startsWith(remove) ? content.substring(remove.length) : content;
    }
    /**
     * Removes a specified substring from the end of the content if it exists
     * @param content - Original string
     * @param remove - Substring to remove
     * @returns Modified string
     */
    removeFromEnd(content, remove) {
        return content.endsWith(remove) ? content.substring(0, content.length - remove.length) : content;
    }
    /**
     * Imports the public key for encryption
     * @param spkiPem - SPKI public key in PEM format
     * @returns CryptoKey usable for encryption
     */
    importPublicKey(spkiPem) {
        return __awaiter(this, void 0, void 0, function* () {
            // TODO: #2 window.crypto.subtle feature is available only in secure browser contexts (HTTPS). Need to provide warning and fallback when feature is missing.
            return yield window.crypto.subtle.importKey("spki", this.getSpkiDer(spkiPem), {
                name: "RSA-OAEP",
                hash: "SHA-256",
            }, true, ["encrypt"]);
        });
    }
    /**
     * Converts a string to an ArrayBuffer
     * @param str - Input string
     * @returns ArrayBuffer representation
     */
    str2ab(str) {
        const buf = new ArrayBuffer(str.length);
        const bufView = new Uint8Array(buf);
        for (let i = 0; i < str.length; i++) {
            bufView[i] = str.charCodeAt(i);
        }
        return buf;
    }
    /**
     * Converts an ArrayBuffer to a Base64 string
     * @param buffer - Input ArrayBuffer
     * @returns Base64 encoded string
     */
    arrayBufferToBase64(buffer) {
        const bytes = new Uint8Array(buffer);
        let binary = '';
        for (let i = 0; i < bytes.byteLength; i++) {
            binary += String.fromCharCode(bytes[i]);
        }
        return window.btoa(binary);
    }
}
