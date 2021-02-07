using Microsoft.Office.Tools.Ribbon;
using System;
using System.Windows.Forms;

namespace TimeSheetReminder
{
    public partial class TimeSheet
    {
        private bool dontEnter = false;

        private void TimeSheet_Load(object sender, RibbonUIEventArgs e)
        {
            timerReminder.Interval = 10000;
            timerReminder.Enabled = true;
            timerReminder.Tick += new EventHandler(timerReminder_Tick);
            timerReminder.Start();
        }

        private void timerReminder_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var hour = 17;
            var minute = 0;
            if (!dontEnter && now.Hour == hour && now.Minute == minute)
            {
                dontEnter = true;
                sendTimeSheetReminderEmail();
                MessageBox.Show("Lütfen zaman girişlerini yapmayı unutmayalım!", "Time Sheet");
            }
        }

        private void sendTimeSheetReminderEmail()
        {
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            var emailAddress = app.ActiveExplorer().Session.CurrentUser.AddressEntry.GetExchangeUser().PrimarySmtpAddress;

            mailItem.Subject = "Time Sheet Hatırlatma";
            mailItem.To = emailAddress;
            mailItem.HTMLBody = "<b>Kendime not</b><br /><br />Bugün zaman girişi yapmayı unutmamalıyım :)";
            mailItem.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;
            mailItem.Send();
        }

        private void btnAdd_Click(object sender, RibbonControlEventArgs e)
        {
            var urlFiori = "https://fiori.coskunoz.com.tr/sap/bc/ui5_ui5/ui2/ushell/shells/abap/Fiorilaunchpad.html";
            System.Diagnostics.Process.Start(urlFiori);
        }
    }
}
