using OpenQA.Selenium;
using System;
using System.Reflection;
using Core.WebElements;

namespace Core.Extensions
{
    public static class WebElementExtensions
    {
        public static T To<T>(this IWebElement webElement) where T : UiElement
        {
            Type type = typeof(T);
            ConstructorInfo ctor = type.GetConstructor(new[] { typeof(IWebElement) });
            object instance = ctor.Invoke(new object[] { webElement });
            return (T)instance;
        } 
    }
}
