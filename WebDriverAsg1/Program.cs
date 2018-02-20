using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverAsg1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\SeleniumDrivers");
            driver.Url = "http://automationpractice.com";

            var addAProductToCart = driver.FindElement(By.XPath("//*[@id='homefeatured']/li[2]/div/div[2]/div[2]/a[1]/span"));
            addAProductToCart.Click();
            //driver.Manage().Timeouts().ImplicitWait
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(50));

            var goBack1 = driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span"));
            Thread.Sleep(2000);
            goBack1.Click();

            var yellowDress = driver.FindElement(By.XPath("//*[@id='homefeatured']/li[7]/div/div[2]/div[2]/a[2]/span"));
            yellowDress.Click();

            var yellowDressCount = driver.FindElement(By.XPath("//*[@id='quantity_wanted_p']/a[2]/span/i"));
            yellowDressCount.Click();
            yellowDressCount.Click();

            var addYellowDressToCart = driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span"));
            addYellowDressToCart.Click();

            
            var goBack2 = driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span"));
            Thread.Sleep(2000);
            goBack2.Click();

            var selectT_ShirtsOption = driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a"));
            selectT_ShirtsOption.Click();

            var selectSortByDropdown = driver.FindElement(By.XPath("//*[@id='selectProductSort']/option[2]"));
            selectSortByDropdown.Click();
            
            var addFirstSortedProduct = driver.FindElement(By.XPath("//*[@id='center_column']/ul/li/div/div[2]/div[2]/a[1]/span"));
            addFirstSortedProduct.Click();
            
            var goBack3 = driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span/span"));
            Thread.Sleep(2000);
            goBack3.Click();
            
            var gotoCartPage = driver.FindElement(By.XPath("//*[@id='header']/div[3]/div/div/div[3]/div/a/b"));
            gotoCartPage.Click();
            
            var increaseLastProductQty = driver.FindElement(By.XPath("//*[@id='cart_quantity_up_1_1_0_0']/span/i"));
            increaseLastProductQty.Click();
            increaseLastProductQty.Click();
            increaseLastProductQty.Click();
            increaseLastProductQty.Click();
            
            var proceedToCheckout = driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]/span"));
            proceedToCheckout.Click();

        }
    }
}
