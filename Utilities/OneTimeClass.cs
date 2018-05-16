using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System.Net.Mail;
using AutomationFramework.SupportLibrary;

namespace AutomationFramework.POM.TestCases
{
    [SetUpFixture]
    class OneTimeClass:ExtentReportClass
    {
       
        [OneTimeSetUp]
        public void LogOpen()
        {
            //Create a instance of Extenport            
            ExtentReportClass.CreateExtentReportInstacne();
            
        }              
       [OneTimeTearDown]
        public void logClose()
        {
            //End Extent test
            ExtentReportClass.EndExtentTest();
            dr.Quit();
            email_send();
        }
        public void email_send()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("");
            //mail.To.Add("vamsi.gattupalli@utelogy.com");
            //mail.To.Add("ananya.bose@utelogy.com");
            mail.Subject = "Automation Report";            
            mail.Body = "mail with attachment";

           Attachment attachment;
            attachment = new Attachment(ProjectPath.getProjectPath()+@"\Reports\Reports.html");
            mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("vamsi.gattupalli@utelogy.com", "T1rumala@@");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
       
    }
}
