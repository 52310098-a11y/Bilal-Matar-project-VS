namespace Bilal_Matar_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txt_regEmail = new TextBox();
            btn_up = new Button();
            groupBox1 = new GroupBox();
            cb_reg = new CheckBox();
            ll_register = new LinkLabel();
            txt_regPassword = new TextBox();
            txt_name = new TextBox();
            label2 = new Label();
            txt_regName = new Label();
            btn_regCancel = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            loginToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            Login_page = new TabPage();
            groupBox2 = new GroupBox();
            cb_log = new CheckBox();
            ll_login = new LinkLabel();
            txt_logPassword = new TextBox();
            txt_logEmail = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_cancel = new Button();
            btn_in = new Button();
            Register_page = new TabPage();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            Login_page.SuspendLayout();
            groupBox2.SuspendLayout();
            Register_page.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 73);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txt_regEmail
            // 
            txt_regEmail.Location = new Point(113, 70);
            txt_regEmail.Name = "txt_regEmail";
            txt_regEmail.Size = new Size(234, 27);
            txt_regEmail.TabIndex = 1;
            // 
            // btn_up
            // 
            btn_up.Location = new Point(113, 195);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(110, 29);
            btn_up.TabIndex = 2;
            btn_up.Text = "Sign-Up";
            btn_up.UseVisualStyleBackColor = true;
            btn_up.Click += btn_up_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_reg);
            groupBox1.Controls.Add(ll_register);
            groupBox1.Controls.Add(txt_regPassword);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(txt_regEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_regName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btn_regCancel);
            groupBox1.Controls.Add(btn_up);
            groupBox1.Location = new Point(31, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 280);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cb_reg
            // 
            cb_reg.AutoSize = true;
            cb_reg.Location = new Point(113, 155);
            cb_reg.Name = "cb_reg";
            cb_reg.Size = new Size(132, 24);
            cb_reg.TabIndex = 4;
            cb_reg.Text = "Show Password";
            cb_reg.UseVisualStyleBackColor = true;
            cb_reg.CheckedChanged += cb_reg_CheckedChanged;
            // 
            // ll_register
            // 
            ll_register.AutoSize = true;
            ll_register.Location = new Point(113, 242);
            ll_register.Name = "ll_register";
            ll_register.Size = new Size(232, 20);
            ll_register.TabIndex = 3;
            ll_register.TabStop = true;
            ll_register.Text = "Already registered? Click to Login";
            ll_register.LinkClicked += ll_register_LinkClicked;
            // 
            // txt_regPassword
            // 
            txt_regPassword.Location = new Point(113, 111);
            txt_regPassword.Name = "txt_regPassword";
            txt_regPassword.PasswordChar = '*';
            txt_regPassword.Size = new Size(234, 27);
            txt_regPassword.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(113, 26);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(234, 27);
            txt_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 114);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txt_regName
            // 
            txt_regName.AutoSize = true;
            txt_regName.Location = new Point(22, 29);
            txt_regName.Name = "txt_regName";
            txt_regName.Size = new Size(49, 20);
            txt_regName.TabIndex = 0;
            txt_regName.Text = "Name";
            // 
            // btn_regCancel
            // 
            btn_regCancel.Location = new Point(237, 195);
            btn_regCancel.Name = "btn_regCancel";
            btn_regCancel.Size = new Size(110, 29);
            btn_regCancel.TabIndex = 2;
            btn_regCancel.Text = "Cancel";
            btn_regCancel.UseVisualStyleBackColor = true;
            btn_regCancel.Click += btn_regCancel_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(116, 28);
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(115, 24);
            loginToolStripMenuItem.Text = "Login";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Login_page);
            tabControl1.Controls.Add(Register_page);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(442, 391);
            tabControl1.TabIndex = 5;
            // 
            // Login_page
            // 
            Login_page.Controls.Add(groupBox2);
            Login_page.Location = new Point(4, 29);
            Login_page.Name = "Login_page";
            Login_page.Padding = new Padding(3);
            Login_page.Size = new Size(434, 358);
            Login_page.TabIndex = 0;
            Login_page.Text = "Login";
            Login_page.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cb_log);
            groupBox2.Controls.Add(ll_login);
            groupBox2.Controls.Add(txt_logPassword);
            groupBox2.Controls.Add(txt_logEmail);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btn_cancel);
            groupBox2.Controls.Add(btn_in);
            groupBox2.Location = new Point(32, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 245);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox1";
            // 
            // cb_log
            // 
            cb_log.AutoSize = true;
            cb_log.Location = new Point(111, 123);
            cb_log.Name = "cb_log";
            cb_log.Size = new Size(132, 24);
            cb_log.TabIndex = 4;
            cb_log.Text = "Show Password";
            cb_log.UseVisualStyleBackColor = true;
            cb_log.CheckedChanged += cb_log_CheckedChanged;
            // 
            // ll_login
            // 
            ll_login.AutoSize = true;
            ll_login.Location = new Point(111, 210);
            ll_login.Name = "ll_login";
            ll_login.Size = new Size(199, 20);
            ll_login.TabIndex = 3;
            ll_login.TabStop = true;
            ll_login.Text = "No account? Click to register";
            ll_login.LinkClicked += ll_login_LinkClicked;
            // 
            // txt_logPassword
            // 
            txt_logPassword.Location = new Point(111, 79);
            txt_logPassword.Name = "txt_logPassword";
            txt_logPassword.PasswordChar = '*';
            txt_logPassword.Size = new Size(234, 27);
            txt_logPassword.TabIndex = 1;
            // 
            // txt_logEmail
            // 
            txt_logEmail.Location = new Point(111, 38);
            txt_logEmail.Name = "txt_logEmail";
            txt_logEmail.Size = new Size(234, 27);
            txt_logEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 41);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 0;
            label4.Text = "Email";
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(235, 163);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(110, 29);
            btn_cancel.TabIndex = 2;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_regCancel_Click;
            // 
            // btn_in
            // 
            btn_in.Location = new Point(111, 163);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(110, 29);
            btn_in.TabIndex = 2;
            btn_in.Text = "Login";
            btn_in.UseVisualStyleBackColor = true;
            btn_in.Click += btn_in_Click;
            // 
            // Register_page
            // 
            Register_page.Controls.Add(groupBox1);
            Register_page.Location = new Point(4, 29);
            Register_page.Name = "Register_page";
            Register_page.Padding = new Padding(3);
            Register_page.Size = new Size(434, 358);
            Register_page.TabIndex = 1;
            Register_page.Text = "Register";
            Register_page.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 415);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Login_page.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            Register_page.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txt_regEmail;
        private Button btn_up;
        private GroupBox groupBox1;
        private TextBox txt_regPassword;
        private Label label2;
        private Button btn_regCancel;
        private CheckBox cb_reg;
        private LinkLabel ll_register;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage Login_page;
        private TabPage Register_page;
        private TextBox txt_name;
        private Label txt_regName;
        private GroupBox groupBox2;
        private CheckBox cb_log;
        private LinkLabel ll_login;
        private TextBox txt_logPassword;
        private TextBox txt_logEmail;
        private Label label3;
        private Label label4;
        private Button btn_cancel;
        private Button btn_in;
    }
}
