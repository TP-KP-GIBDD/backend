using System;
using System.Globalization;

namespace Registration.Helpers
{
    // класс исключений, специфичных для приложения,
    // которые могут быть обнаружены и обработаны в нем
    public class AppException : Exception
    {
        public AppException() : base() {}

        public AppException(string message) : base(message) { }

        public AppException(string message, params object[] args) 
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}