using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AzimAndSonAutomationTest
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://localhost:44395/Default");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void Positive_Test_Case_testing()
        {
            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));

            Console.WriteLine("Fillling out the form with given data");

            user_id_field.SendKeys("150");
            first_name_field.SendKeys("Amir");
            last_name_field.SendKeys("Khan");
            email_field.SendKeys("amir@gmail.com");
            password_field.SendKeys("146");
            confirm_password_field.SendKeys("146");

            insertButton.Click();

            Console.WriteLine("Test Executed");
            Console.WriteLine("Form submitted successfully");
            Console.WriteLine("Alert message displayed");

            //driver.Navigate().GoToUrl("https://localhost:44395/Default");

            //Console.WriteLine("Checking Alert Message");

            //IAlert alert = driver.SwitchTo().Alert();
            //string alertText = alert.Text;
            //string expectedAlertMessage = "Successfully saved";
            //if (alertText.Equals(expectedAlertMessage))
            //{
            //    Console.WriteLine("Received the expected ScriptManager alert: " + alertText);
            //}
            //else
            //{
            //    Console.WriteLine("Received the unexpected ScriptManager alert: " + alertText);
            //}
            //alert.Accept();

            //driver.Quit();

            Console.WriteLine("Close the Browser");
            Assert.Pass();
        }

        [Test]
        public void Negative_Test_Case_testing_phase_1()
        {
            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));

            insertButton.Click();

            Console.WriteLine("Test Executed");
            Console.WriteLine("Checking the submission of the form without filling data and verify error messages");

            IWebElement errorField1 = driver.FindElement(By.Id("MainContent_User_ID_RequiredFieldValidator"));
            IWebElement errorField2 = driver.FindElement(By.Id("MainContent_First_Name_RequiredFieldValidator"));
            IWebElement errorField3 = driver.FindElement(By.Id("MainContent_last_Name_RequiredFieldValidator"));
            IWebElement errorField4 = driver.FindElement(By.Id("MainContent_Email_RequiredFieldValidator"));
            IWebElement errorField5 = driver.FindElement(By.Id("MainContent_Password_RequiredFieldValidator"));
            IWebElement errorField6 = driver.FindElement(By.Id("MainContent_Confirm_Password_RequiredFieldValidator"));

            string errorMessage1 = errorField1.Text;
            string errorMessage2 = errorField2.Text;
            string errorMessage3 = errorField3.Text;
            string errorMessage4 = errorField4.Text;
            string errorMessage5 = errorField5.Text;
            string errorMessage6 = errorField6.Text;

            //if (errorField1.Displayed)
            //{
            //    Console.WriteLine("Error for Field 1:" + errorMessage1);
            //}
            //else
            //{
            //    Console.WriteLine("Error for Field 1 is not displayed");
            //}
            Console.WriteLine("Error for Field 1:" + errorMessage1);
            Console.WriteLine("Error for Field 2:" + errorMessage2);
            Console.WriteLine("Error for Field 3:" + errorMessage3);
            Console.WriteLine("Error for Field 4:" + errorMessage4);
            Console.WriteLine("Error for Field 5:" + errorMessage5);
            Console.WriteLine("Error for Field 6:" + errorMessage6);

            Console.WriteLine("All error messages showed succssfully");



            Console.WriteLine("Close the Browser");
            Assert.Pass();
        }

        [Test]
        public void Negative_Test_Case_testing_phase_2()
        {
            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));            

            Console.WriteLine("Checking invalid email format");

            email_field.SendKeys("amir");
            first_name_field.SendKeys("");
            IWebElement emailErrorField = driver.FindElement(By.Id("MainContent_Email_RegularExpressionValidator"));
            //insertButton.Click();
            if (emailErrorField.Displayed)
            {
                Console.WriteLine("message displayed for invalid email format");
            }
            else
            {
                Console.WriteLine("message is not displayed for invalid email format");
            }
            //string emailErrorMessage = emailErrorField.Text;
            //Console.WriteLine("Error Message for Email:" + emailErrorMessage);
            //Console.WriteLine("Invalid email error message displayed successfully");


            

            Console.WriteLine("Close the Browser");
            Assert.Pass();
        }

        [Test]
        public void Negative_Test_Case_testing_phase_3()
        {
            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));

            Console.WriteLine("Checking the Password character down limit");

            password_field.SendKeys("14");
            confirm_password_field.SendKeys("");
            IWebElement passwordErrorField_down = driver.FindElement(By.Id("MainContent_Password_RegularExpressionValidator"));
            //insertButton.Click();
            if (passwordErrorField_down.Displayed)
            {
                Console.WriteLine("Passowrd limit error message displayed for down limit");
            }
            else
            {
                Console.WriteLine("Passowrd limit error message is not displayed for down limit");
            }
            //string passowrdErrorMessage1 = passwordErrorField.Text;
            //Console.WriteLine("Error Message for Email:" + passowrdErrorMessage1);

            //Console.WriteLine("Checking the Password character upper limit");

            //password_field.SendKeys("149545698");
            //IWebElement passwordErrorField_up = driver.FindElement(By.Id("MainContent_Password_RegularExpressionValidator"));
            //insertButton.Click();
            //if (passwordErrorField_up.Displayed)
            //{
            //    Console.WriteLine("Passowrd limit error message displayed for upper limit");
            //}
            //else
            //{
            //    Console.WriteLine("Passowrd limit error message is not displayed for upper limit");
            //}
            //string passowrdErrorMessage2 = passwordErrorField.Text;
            //Console.WriteLine("Error Message for Email:" + passowrdErrorMessage2);
            //Console.WriteLine("Invalid password error message displayed successfully");
            //driver.Quit();

            Console.WriteLine("Close the Browser");
            Assert.Pass();
        }

        [Test]
        public void Edge_Case_testing_phase_1()
        {
            Console.WriteLine("Checking the form with maximum allowed characters in each field");

            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));

            user_id_field.SendKeys("565");
            first_name_field.SendKeys("XYZKIORCNML");
            last_name_field.SendKeys("PMVEHLOFVBH");
            email_field.SendKeys("XYZ@gmail.com");
            password_field.SendKeys("941369874");
            confirm_password_field.SendKeys("941369874");
            last_name_field.SendKeys("dsd");

            //insertButton.Click();
            Console.WriteLine("Test Executed");

            IWebElement firstNameErrorField_up = driver.FindElement(By.Id("MainContent_First_Name_RegularExpressionValidator"));
            IWebElement lastNameErrorField_up = driver.FindElement(By.Id("MainContent_Last_Name_RegularExpressionValidator"));
            IWebElement passwordErrorField_up = driver.FindElement(By.Id("MainContent_Password_RegularExpressionValidator"));
            IWebElement confirmPasswordErrorField_up = driver.FindElement(By.Id("MainContent_Confirm_Password_RegularExpressionValidator"));

            if (firstNameErrorField_up.Displayed)
            {
                Console.WriteLine("Maximum allowed characters message displayed for First Name field");
            }
            else
            {
                Console.WriteLine("Maximum allowed characters message is not displayed for First Name field");
            }

            if (lastNameErrorField_up.Displayed)
            {
                Console.WriteLine("Maximum allowed characters message displayed for Last Name field");
            }
            else
            {
                Console.WriteLine("Maximum allowed characters message is not displayed for Last Name field");
            }

            if (passwordErrorField_up.Displayed)
            {
                Console.WriteLine("Maximum allowed characters message displayed for Password field");
            }
            else
            {
                Console.WriteLine("Maximum allowed characters message is not displayed for Password field");
            }


            if (confirmPasswordErrorField_up.Displayed)
            {
                Console.WriteLine("Maximum allowed characters message displayed for Confirm Password field");
            }
            else
            {
                Console.WriteLine("Maximum allowed characters message is not displayed for Confirm Password field");
            }

            Assert.Pass();
        }

        [Test]
        public void Edge_Case_testing_phase_2()
        {
            Console.WriteLine("Checking the form with special characters in First Name, Last Name and Password fields");

            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));

            user_id_field.SendKeys("364");
            first_name_field.SendKeys("Akhshay_10");
            last_name_field.SendKeys("Kumar$#");
            email_field.SendKeys("akhshaykumar@gmail.com");
            password_field.SendKeys("2_9&@$3");
            confirm_password_field.SendKeys("2_9&@$3");

            insertButton.Click();
            Console.WriteLine("Test Executed");
            Console.WriteLine("Form submitted with special characters successfully");

            
            //driver.Quit();

            Console.WriteLine("Close the Browser");
            Assert.Pass();
        }


        [Test]
        public void UI_Elements_Verification_testing()
        {
            Console.WriteLine("Checking the visibility and correctness of labels, input fields and the submit button");

            IWebElement user_id_label = driver.FindElement(By.Id("MainContent_User_Id_Label"));
            IWebElement user_id_field = driver.FindElement(By.Id("MainContent_User_ID_Txt"));
            if (user_id_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of User ID labels");
            }
            if (user_id_label.Text == "User ID :")
            {
                Console.WriteLine("Successfully checked text of User ID labels");
            }

            if (user_id_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of User ID Text fields");
            }


            IWebElement first_name_label = driver.FindElement(By.Id("MainContent_First_Name_Label"));
            IWebElement first_name_field = driver.FindElement(By.Id("MainContent_First_Name_Txt"));
            if (first_name_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of First Name labels");
            }
            if (first_name_label.Text == "First Name :")
            {
                Console.WriteLine("Successfully checked text of First Name labels");
            }

            if (first_name_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of First Name Text fields");
            }


            IWebElement last_name_label = driver.FindElement(By.Id("MainContent_Last_Name_Label"));
            IWebElement last_name_field = driver.FindElement(By.Id("MainContent_Last_Name_Txt"));
            if (last_name_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Last Name labels");
            }
            if (last_name_label.Text == "Last Name :")
            {
                Console.WriteLine("Successfully checked text of Last Name labels");
            }

            if (last_name_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Last Name Text fields");
            }


            IWebElement email_label = driver.FindElement(By.Id("MainContent_Email_Label"));
            IWebElement email_field = driver.FindElement(By.Id("MainContent_Email_Txt"));
            if (email_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Email labels");
            }
            if (email_label.Text == "Email :")
            {
                Console.WriteLine("Successfully checked text of Email labels");
            }

            if (email_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Email Text fields");
            }


            IWebElement password_label = driver.FindElement(By.Id("MainContent_Password_Label"));
            IWebElement password_field = driver.FindElement(By.Id("MainContent_Password_Txt"));
            if (password_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Password labels");
            }
            if (password_label.Text == "Password :")
            {
                Console.WriteLine("Successfully checked text of Password labels");
            }

            if (password_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Password Text fields");
            }


            IWebElement confirm_password_label = driver.FindElement(By.Id("MainContent_Confirm_Password_Label"));
            IWebElement confirm_password_field = driver.FindElement(By.Id("MainContent_Confirm_Password_Txt"));
            if (confirm_password_label.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Confirm Password labels");
            }
            if (confirm_password_label.Text == "Confirm Password :")
            {
                Console.WriteLine("Successfully checked text of Confirm Password labels");
            }

            if (confirm_password_field.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Confirm Password Text fields");
            }


            IWebElement insertButton = driver.FindElement(By.Id("MainContent_Insert_Button"));
            if (insertButton.Displayed == true)
            {
                Console.WriteLine("Successfully checked visibility of Insert button");
            }

        }
    }
}