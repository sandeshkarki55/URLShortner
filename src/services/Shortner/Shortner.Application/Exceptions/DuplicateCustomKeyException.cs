using System;

namespace Shortner.Application.Exceptions
{
    public class DuplicateCustomKeyException : Exception
    {
        public DuplicateCustomKeyException(string customKey) : base($"Url with key {customKey} already exists.")
        {

        }
    }
}
