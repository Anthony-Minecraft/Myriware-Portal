namespace Myriware_Portal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Inbox = new System.Windows.Forms.TabPage();
            this.button_FetchMail = new System.Windows.Forms.Button();
            this.tabPage_ViewMessage = new System.Windows.Forms.TabPage();
            this.info01 = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.info02 = new System.Windows.Forms.Label();
            this.info03 = new System.Windows.Forms.Label();
            this.button_Validation = new System.Windows.Forms.Button();
            this.richTextBox_Logger = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel_MailHolder = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_ViewMessage = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Inbox.SuspendLayout();
            this.tabPage_ViewMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Inbox);
            this.tabControl1.Controls.Add(this.tabPage_ViewMessage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Inbox
            // 
            this.tabPage_Inbox.Controls.Add(this.tableLayoutPanel_MailHolder);
            this.tabPage_Inbox.Controls.Add(this.button_FetchMail);
            this.tabPage_Inbox.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Inbox.Name = "tabPage_Inbox";
            this.tabPage_Inbox.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Inbox.Size = new System.Drawing.Size(606, 400);
            this.tabPage_Inbox.TabIndex = 0;
            this.tabPage_Inbox.Text = "Inbox";
            this.tabPage_Inbox.UseVisualStyleBackColor = true;
            // 
            // button_FetchMail
            // 
            this.button_FetchMail.Location = new System.Drawing.Point(7, 7);
            this.button_FetchMail.Name = "button_FetchMail";
            this.button_FetchMail.Size = new System.Drawing.Size(593, 23);
            this.button_FetchMail.TabIndex = 0;
            this.button_FetchMail.Text = "Fetch Mail";
            this.button_FetchMail.UseVisualStyleBackColor = true;
            this.button_FetchMail.Click += new System.EventHandler(this.button_FetchMail_Click);
            // 
            // tabPage_ViewMessage
            // 
            this.tabPage_ViewMessage.Controls.Add(this.richTextBox_ViewMessage);
            this.tabPage_ViewMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ViewMessage.Name = "tabPage_ViewMessage";
            this.tabPage_ViewMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ViewMessage.Size = new System.Drawing.Size(606, 400);
            this.tabPage_ViewMessage.TabIndex = 1;
            this.tabPage_ViewMessage.Text = "View Message";
            this.tabPage_ViewMessage.UseVisualStyleBackColor = true;
            // 
            // info01
            // 
            this.info01.Location = new System.Drawing.Point(632, 34);
            this.info01.Name = "info01";
            this.info01.ReadOnly = true;
            this.info01.Size = new System.Drawing.Size(156, 20);
            this.info01.TabIndex = 1;
            this.info01.Text = "Myriware Access Portal";
            this.info01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(688, 61);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(688, 87);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '#';
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // info02
            // 
            this.info02.AutoSize = true;
            this.info02.Location = new System.Drawing.Point(632, 61);
            this.info02.Name = "info02";
            this.info02.Size = new System.Drawing.Size(55, 13);
            this.info02.TabIndex = 4;
            this.info02.Text = "Username";
            // 
            // info03
            // 
            this.info03.AutoSize = true;
            this.info03.Location = new System.Drawing.Point(635, 87);
            this.info03.Name = "info03";
            this.info03.Size = new System.Drawing.Size(53, 13);
            this.info03.TabIndex = 5;
            this.info03.Text = "Password";
            // 
            // button_Validation
            // 
            this.button_Validation.Location = new System.Drawing.Point(633, 113);
            this.button_Validation.Name = "button_Validation";
            this.button_Validation.Size = new System.Drawing.Size(155, 23);
            this.button_Validation.TabIndex = 6;
            this.button_Validation.Text = "Validate";
            this.button_Validation.UseVisualStyleBackColor = true;
            this.button_Validation.Click += new System.EventHandler(this.button_Validation_ClickAsync);
            // 
            // richTextBox_Logger
            // 
            this.richTextBox_Logger.Location = new System.Drawing.Point(635, 143);
            this.richTextBox_Logger.Name = "richTextBox_Logger";
            this.richTextBox_Logger.ReadOnly = true;
            this.richTextBox_Logger.Size = new System.Drawing.Size(153, 291);
            this.richTextBox_Logger.TabIndex = 7;
            this.richTextBox_Logger.Text = "DeBug Box";
            this.richTextBox_Logger.TextChanged += new System.EventHandler(this.richTextBox_Logger_TextChanged);
            // 
            // tableLayoutPanel_MailHolder
            // 
            this.tableLayoutPanel_MailHolder.ColumnCount = 1;
            this.tableLayoutPanel_MailHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_MailHolder.Location = new System.Drawing.Point(7, 37);
            this.tableLayoutPanel_MailHolder.Name = "tableLayoutPanel_MailHolder";
            this.tableLayoutPanel_MailHolder.RowCount = 20;
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel_MailHolder.Size = new System.Drawing.Size(593, 357);
            this.tableLayoutPanel_MailHolder.TabIndex = 1;
            // 
            // richTextBox_ViewMessage
            // 
            this.richTextBox_ViewMessage.Location = new System.Drawing.Point(7, 7);
            this.richTextBox_ViewMessage.Name = "richTextBox_ViewMessage";
            this.richTextBox_ViewMessage.ReadOnly = true;
            this.richTextBox_ViewMessage.Size = new System.Drawing.Size(593, 387);
            this.richTextBox_ViewMessage.TabIndex = 0;
            this.richTextBox_ViewMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_Logger);
            this.Controls.Add(this.button_Validation);
            this.Controls.Add(this.info03);
            this.Controls.Add(this.info02);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.info01);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Myriware Portal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Inbox.ResumeLayout(false);
            this.tabPage_ViewMessage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Inbox;
        private System.Windows.Forms.TabPage tabPage_ViewMessage;
        private System.Windows.Forms.TextBox info01;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label info02;
        private System.Windows.Forms.Label info03;
        private System.Windows.Forms.Button button_Validation;
        private System.Windows.Forms.RichTextBox richTextBox_Logger;
        private System.Windows.Forms.Button button_FetchMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_MailHolder;
        private System.Windows.Forms.RichTextBox richTextBox_ViewMessage;
    }
}

