//using System.Text.Json.JsonSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myriware_Portal
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private class UserDataType
        {
            public string UUID { get; set; }
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string MidName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
        }
        private class MailMessage
        {
            public string FROM { get; set; }
            public string USERNAME { get; set; }
            public string TITLE { get; set; }
        }
        private UserDataType UserData = null;
        private void LogEvent(string e)
        {
            richTextBox_Logger.Text += "\n" + e;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Validation_ClickAsync(object sender, EventArgs e)
        {
            _ = Username_validationAsync();
        }
        private async Task Username_validationAsync()
        {
            //Try and fetch the data, using POST to requested URL
            var values = new Dictionary<string, string>
            {
                { "username", textBox_Username.Text },
                { "password", textBox_Password.Text }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://myriware.anthonysmith18.repl.co/validation.php", content);

            //var responseString = await response.Content.ReadAsStringAsync();
            var responseString = await response.Content.ReadAsStringAsync();
            LogEvent(responseString);
            if (responseString == "Invalid")
            {
                return;
            }
            UserDataType data = JsonSerializer.Deserialize<UserDataType>(responseString);

            UserData = data;

            _ = Fetch_Mail_Async();
        }

        private Boolean LoggedIn()
        {
            if (UserData == null)
            {
                LogEvent("You are not logged in!");
                return false;
            } 
            else
            {
                return true;
            }
        }

        private void button_FetchMail_Click(object sender, EventArgs e)
        {
            if (!LoggedIn()) { return; }
            _ = Fetch_Mail_Async();
        }

        private async Task Fetch_Mail_Async()
        {
            tableLayoutPanel_MailHolder.Controls.Clear();
            LogEvent("Trying to use UUID <" + UserData.UUID + "> to access mail");
            var responseString = await client.GetStringAsync("https://myriware.anthonysmith18.repl.co/public/myrimail/fetch_mail.php?filter=none&uuid=" + UserData.UUID);
            LogEvent(responseString);
            var data = JsonSerializer.Deserialize<IList<MailMessage>>(responseString);
            foreach (MailMessage message in data)
            {
                TableLayoutPanel collector = new TableLayoutPanel();
                collector.ColumnCount = 3;
                Label title = new Label();
                title.Text = message.TITLE;
                Label from = new Label();
                from.Text = message.FROM;
                from.AutoSize = true;
                Button viewer = new Button();
                viewer.Text = "Read";
                viewer.Height = 19;
                viewer.AutoSize = true;
                viewer.Click += delegate { _ = openMessageAsync(message.TITLE, message.FROM); };

                collector.Controls.Add(title);
                collector.Controls.Add(from);
                collector.Controls.Add(viewer);
                tableLayoutPanel_MailHolder.Controls.Add(collector);
            }
        }

        private async Task openMessageAsync(string title, string from)
        {
            LogEvent("Trying to use UUID <" + title + ", " + from + "> to open mail");
            string url = "https://myriware.anthonysmith18.repl.co/public/myrimail/get_mail_content.php?title=" + title + "&uuid=" + from;
            LogEvent(url);
            var responseString = await client.GetStringAsync(url);
            LogEvent(responseString);
            richTextBox_ViewMessage.Text = responseString;
            tabControl1.SelectTab(1);
        }

        private void richTextBox_Logger_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
