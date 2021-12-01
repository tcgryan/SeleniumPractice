using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNet.Pages;
using System;

namespace SeleniumCSharpNet
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Henlo!");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Cauliflower']")).Click();

            string comboControlName = "ContentPlaceHolder1_AllMealsCombo";
            string comboControlValue = "Almonds";

            CustomControl.ComboBox(comboControlName, comboControlValue);


            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            HomePage homePage = new HomePage();
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterLoginInfo();
        }
    }
}