using System;

namespace BlockchainScanner.Utils
{
    [AttributeUsage(AttributeTargets.Method,
            AllowMultiple = true) 
    ]
    public class ProRequiredAttribute : Attribute
    {

    }
}
