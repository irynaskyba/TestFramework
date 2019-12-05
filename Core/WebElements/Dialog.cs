using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Extensions;
using OpenQA.Selenium;

namespace Core.WebElements
{
    class Dialog : UiElement
    {
        private readonly UiElement _dialog;

        public Dialog(IWebElement webElement) : base(webElement)
        {
            _dialog = webElement.To<UiElement>();
        }
    }
}
