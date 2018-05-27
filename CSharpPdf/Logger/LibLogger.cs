using System;
using NLog;

namespace CSharpPdf.Logger
{
    static class LibLogger
    {
        public static void Info(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Info(text);
        }
        public static void Debug(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Debug(text);
        }

    }
}
