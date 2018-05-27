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

        public static void Error(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Error(text);
        }

        public static void Warn(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Warn(text);
        }

        public static void Trace(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Trace(text);
        }

        public static void Fatal(Type type, string text)
        {
            LogManager.GetLogger(type.FullName).Fatal(text);
        }
    }
}