using System;
using System.Collections.Generic;
using System.Linq;

namespace AppCode.LightSpeed
{
    /// <summary>
    /// A simple in-memory store for external data snapshots, keyed by a string.
    /// This is intended for demonstration purposes and is not suitable for production use.
    /// </summary>

    public static class ExternalDataStore
    {
        private static readonly object SyncRoot = new object();
        private static readonly Dictionary<string, ExternalDataSnapshot> Data = new Dictionary<string, ExternalDataSnapshot>(StringComparer.OrdinalIgnoreCase);

        public static ExternalDataSnapshot Get(string key)
        {
            var normalized = NormalizeKey(key);
            lock (SyncRoot)
                return Data.TryGetValue(normalized, out var snapshot)
                    ? snapshot
                    : Data[normalized] = CreateSnapshot(normalized, 1);
        }

        public static ExternalDataSnapshot Regenerate(string key)
        {
            var normalized = NormalizeKey(key);
            lock (SyncRoot)
            {
                var generation = Data.TryGetValue(normalized, out var existing)
                    ? existing.Generation + 1
                    : 1;

                var snapshot = CreateSnapshot(normalized, generation);
                Data[normalized] = snapshot;
                return snapshot;
            }
        }

        public static IReadOnlyList<ExternalDataSnapshot> GetAll()
        {
            lock (SyncRoot)
                return Data.Values
                    .OrderBy(item => item.Key, StringComparer.OrdinalIgnoreCase)
                    .ToArray();
        }

        private static ExternalDataSnapshot CreateSnapshot(string key, int generation)
        {
            var utcNow = DateTime.UtcNow;
            return new ExternalDataSnapshot
            {
                Key = key,
                Generation = generation,
                GeneratedUtc = utcNow,
                GeneratedLocal = utcNow.ToLocalTime(),
                DisplayToken = $"{key.ToUpperInvariant()}-{generation:D2}-{utcNow:HHmmss.fff}",
                Details = $"Generated at {utcNow:O}"
            };
        }

        private static string NormalizeKey(string key)
            => string.IsNullOrWhiteSpace(key)
                ? "default"
                : key.Trim().ToLowerInvariant();
    }

    public class ExternalDataSnapshot{
        public string Key { get; set; }
        public int Generation { get; set; }
        public DateTime GeneratedUtc { get; set; }
        public DateTime GeneratedLocal { get; set; }
        public string DisplayToken { get; set; }
        public string Details { get; set; }
    }
}