using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumCSharpNet
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
            comboControl.SendKeys(value);

            IWebElement comboDropDown = Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']"));

            comboDropDown.FindElement(By.XPath($".//li[text()='{value}']")).Click();
        }
    }
}
