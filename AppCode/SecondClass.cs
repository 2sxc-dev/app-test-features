﻿
using System;

namespace AppCode
{
    public class SecondClass
    {
        // Property that returns a string
        public string MyProperty { get; set; } = "I'm from AppCode";

        public FirstClass GetFirstClass()
        {
            return firstClass != null ? firstClass : firstClass = new FirstClass();
        }
        private FirstClass firstClass;

        // Method that sums two numbers
        public int Sum(int a, int b)
        {
            return a + b + 1;
        }
    }
}

