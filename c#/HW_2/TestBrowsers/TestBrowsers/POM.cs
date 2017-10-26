using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestBrowsers
{ 
    public class POM
    {
        By but1 = By.Id("1");
        By but2 = By.Id("2");
        By but3 = By.Id("3");
        By but4 = By.Id("4");
        By but5 = By.Id("5");
        By but6 = By.Id("6");
        By but7 = By.Id("7");
        By but8 = By.Id("8");
        By but9 = By.Id("9");
        By but0 = By.Id("0");
        By butPlus = By.Id("+");
        By butMinus = By.Id("-");
        By butMult = By.Id("*");
        By butDiv = By.Id("/");
        By butEqual = By.Id("=");
        By resField = By.Id("res");

        IWebDriver driver;
        public POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(string s)
        {
            IWebElement flag = null;
            switch (s)
            {
                case "but1":
                    flag = driver.FindElement(but1);
                    break;
                case "but2":
                    flag = driver.FindElement(but2);
                    break;
                case "but3":
                    flag = driver.FindElement(but3);
                    break;
                case "but4":
                    flag = driver.FindElement(but4);
                    break;
                case "but5":
                    flag = driver.FindElement(but5);
                    break;
                case "but6":
                    flag = driver.FindElement(but6);
                    break;
                case "but7":
                    flag = driver.FindElement(but7);
                    break;
                case "but8":
                    flag = driver.FindElement(but8);
                    break;
                case "but9":
                    flag = driver.FindElement(but9);
                    break;
                case "but0":
                    flag = driver.FindElement(but0);
                    break;
                case "butPlus":
                    flag = driver.FindElement(butPlus);
                    break;
                case "butMinus":
                    flag = driver.FindElement(butMinus);
                    break;
                case "butMult":
                    flag = driver.FindElement(butMult);
                    break;
                case "butDiv":
                    flag = driver.FindElement(butDiv);
                    break;
                case "butEqual":
                    flag = driver.FindElement(butEqual);
                    break;
                case "resField":
                    flag = driver.FindElement(resField);
                    break;
                default:
                    break;
            }
            return flag;
        }
    }    
}

