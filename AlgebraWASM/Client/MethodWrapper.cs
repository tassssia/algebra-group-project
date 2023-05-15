﻿using System.Runtime.InteropServices;

namespace AlgebraWASM.Client
{
    public enum FinitiFieldMethods
    {
        addition=1,
        subtraction,
        multiplication,
        division,
        fastPow,
        inverse,
        factorizePolard,
        factorizeSimple,
        discreteSqrt,
        discreteLog,
        orderOfElement,
        isGenerator,
        CarmichaelFunction,
        isPrime
    }

    public static class MethodWrapper
    {
        [DllImport("addition")]
        private static extern byte addition(byte a, byte b, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte subtraction(byte a, byte b, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte multiplication(byte a, byte b, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte division(byte a, byte b, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte fastPow(byte a, byte degree, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte inverse(byte num, byte mod, byte errStr);

        [DllImport("addition")]
        private static extern byte factorizePolard(string a, string b);

        [DllImport("addition")]
        private static extern byte factorizeSimple(string a, string b);

        [DllImport("addition")]
        private static extern byte discreteSqrt(string a, string b);

        [DllImport("addition")]
        private static extern byte discreteLog(string a, string b);

        [DllImport("addition")]
        private static extern byte orderOfElement(string a, string b);

        [DllImport("addition")]
        private static extern byte isGenerator(string a, string b); 

        [DllImport("addition")]
        private static extern byte CarmichaelFunction(string a, string b); 

        [DllImport("addition")]
        private static extern byte isPrime(string a, string b);
    }
}