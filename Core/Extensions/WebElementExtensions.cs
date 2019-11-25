using OpenQA.Selenium;
using System;
using System.Reflection;
using WebElements.WebElements;

namespace Core.Extensions
{
    public static class WebElementExtensions
    {
        public static T To<T>(this IWebElement webelement) where T : UiElement
        {
            Type type = typeof(T);
            ConstructorInfo ctor = type.GetConstructor(new[] { typeof(IWebElement) });
            object instance = ctor.Invoke(new object[] { webelement });
            return (T)instance;
        }
    }
}
