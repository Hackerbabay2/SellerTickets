using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Button loginButton;
        private Button siginUpTumbler;
        private TextBox passwordTextbox;
        private TextBox loginTextBox;
        private Label PasswordLabel;
        private Label LoginLabel;
        private Label SiginUpLoginLabel;
        private Label SiginUpPasswordLabel;
        private Label MainSiginUpLabel;
        private TextBox SiginUpLoginTextBox;
        private TextBox SiginUpPasswordTextBox;
        private Button SiginUpButton;
        private Button LoginTumbler;
        private Label MainLoginLabel;
        private DataBase _dataBase = new DataBase();

        public Form1()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginButton = new System.Windows.Forms.Button();
            this.siginUpTumbler = new System.Windows.Forms.Button();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.MainLoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SiginUpLoginLabel = new System.Windows.Forms.Label();
            this.SiginUpPasswordLabel = new System.Windows.Forms.Label();
            this.MainSiginUpLabel = new System.Windows.Forms.Label();
            this.SiginUpLoginTextBox = new System.Windows.Forms.TextBox();
            this.SiginUpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SiginUpButton = new System.Windows.Forms.Button();
            this.LoginTumbler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.IndianRed;
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(567, 239);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(92, 37);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // siginUpTumbler
            // 
            this.siginUpTumbler.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.siginUpTumbler.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siginUpTumbler.Location = new System.Drawing.Point(1057, 26);
            this.siginUpTumbler.Name = "siginUpTumbler";
            this.siginUpTumbler.Size = new System.Drawing.Size(138, 47);
            this.siginUpTumbler.TabIndex = 1;
            this.siginUpTumbler.Text = "Регистация";
            this.siginUpTumbler.UseVisualStyleBackColor = false;
            this.siginUpTumbler.Click += new System.EventHandler(this.button2_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(539, 213);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(156, 22);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(539, 187);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(156, 22);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // MainLoginLabel
            // 
            this.MainLoginLabel.AutoSize = true;
            this.MainLoginLabel.BackColor = System.Drawing.Color.Orange;
            this.MainLoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLoginLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLoginLabel.Location = new System.Drawing.Point(567, 134);
            this.MainLoginLabel.Name = "MainLoginLabel";
            this.MainLoginLabel.Size = new System.Drawing.Size(116, 53);
            this.MainLoginLabel.TabIndex = 4;
            this.MainLoginLabel.Text = "Вход";
            this.MainLoginLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Orange;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(482, 220);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 17);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Orange;
            this.LoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(488, 192);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(54, 19);
            this.LoginLabel.TabIndex = 6;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.Click += new System.EventHandler(this.LoginLabel_Click);
            // 
            // SiginUpLoginLabel
            // 
            this.SiginUpLoginLabel.AutoSize = true;
            this.SiginUpLoginLabel.BackColor = System.Drawing.Color.Orange;
            this.SiginUpLoginLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SiginUpLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiginUpLoginLabel.Location = new System.Drawing.Point(481, 192);
            this.SiginUpLoginLabel.Name = "SiginUpLoginLabel";
            this.SiginUpLoginLabel.Size = new System.Drawing.Size(54, 19);
            this.SiginUpLoginLabel.TabIndex = 12;
            this.SiginUpLoginLabel.Text = "Логин";
            this.SiginUpLoginLabel.Visible = false;
            this.SiginUpLoginLabel.Click += new System.EventHandler(this.SiginUpLoginLabel_Click);
            // 
            // SiginUpPasswordLabel
            // 
            this.SiginUpPasswordLabel.AutoSize = true;
            this.SiginUpPasswordLabel.BackColor = System.Drawing.Color.Orange;
            this.SiginUpPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiginUpPasswordLabel.Location = new System.Drawing.Point(475, 220);
            this.SiginUpPasswordLabel.Name = "SiginUpPasswordLabel";
            this.SiginUpPasswordLabel.Size = new System.Drawing.Size(63, 17);
            this.SiginUpPasswordLabel.TabIndex = 11;
            this.SiginUpPasswordLabel.Text = "Пароль";
            this.SiginUpPasswordLabel.Visible = false;
            this.SiginUpPasswordLabel.Click += new System.EventHandler(this.SiginUpPasswordLabel_Click);
            // 
            // MainSiginUpLabel
            // 
            this.MainSiginUpLabel.AutoSize = true;
            this.MainSiginUpLabel.BackColor = System.Drawing.Color.Orange;
            this.MainSiginUpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainSiginUpLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainSiginUpLabel.Location = new System.Drawing.Point(501, 134);
            this.MainSiginUpLabel.Name = "MainSiginUpLabel";
            this.MainSiginUpLabel.Size = new System.Drawing.Size(279, 53);
            this.MainSiginUpLabel.TabIndex = 10;
            this.MainSiginUpLabel.Text = "Регистрация";
            this.MainSiginUpLabel.Visible = false;
            this.MainSiginUpLabel.Click += new System.EventHandler(this.MainSiginUpLabel_Click);
            // 
            // SiginUpLoginTextBox
            // 
            this.SiginUpLoginTextBox.Location = new System.Drawing.Point(532, 187);
            this.SiginUpLoginTextBox.Name = "SiginUpLoginTextBox";
            this.SiginUpLoginTextBox.Size = new System.Drawing.Size(156, 22);
            this.SiginUpLoginTextBox.TabIndex = 9;
            this.SiginUpLoginTextBox.Visible = false;
            this.SiginUpLoginTextBox.TextChanged += new System.EventHandler(this.SiginUpLoginTextBox_TextChanged);
            // 
            // SiginUpPasswordTextBox
            // 
            this.SiginUpPasswordTextBox.Location = new System.Drawing.Point(532, 213);
            this.SiginUpPasswordTextBox.Name = "SiginUpPasswordTextBox";
            this.SiginUpPasswordTextBox.Size = new System.Drawing.Size(156, 22);
            this.SiginUpPasswordTextBox.TabIndex = 8;
            this.SiginUpPasswordTextBox.Visible = false;
            this.SiginUpPasswordTextBox.TextChanged += new System.EventHandler(this.SiginUpPasswordTextBox_TextChanged);
            // 
            // SiginUpButton
            // 
            this.SiginUpButton.BackColor = System.Drawing.Color.IndianRed;
            this.SiginUpButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SiginUpButton.Location = new System.Drawing.Point(518, 282);
            this.SiginUpButton.Name = "SiginUpButton";
            this.SiginUpButton.Size = new System.Drawing.Size(201, 37);
            this.SiginUpButton.TabIndex = 7;
            this.SiginUpButton.Text = "Зарегистрироваться";
            this.SiginUpButton.UseVisualStyleBackColor = false;
            this.SiginUpButton.Visible = false;
            this.SiginUpButton.Click += new System.EventHandler(this.SiginUpButton_Click);
            // 
            // LoginTumbler
            // 
            this.LoginTumbler.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.LoginTumbler.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTumbler.Location = new System.Drawing.Point(1057, 79);
            this.LoginTumbler.Name = "LoginTumbler";
            this.LoginTumbler.Size = new System.Drawing.Size(138, 47);
            this.LoginTumbler.TabIndex = 13;
            this.LoginTumbler.Text = "Вход";
            this.LoginTumbler.UseVisualStyleBackColor = false;
            this.LoginTumbler.Visible = false;
            this.LoginTumbler.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 607);
            this.Controls.Add(this.LoginTumbler);
            this.Controls.Add(this.SiginUpLoginLabel);
            this.Controls.Add(this.SiginUpPasswordLabel);
            this.Controls.Add(this.MainSiginUpLabel);
            this.Controls.Add(this.SiginUpLoginTextBox);
            this.Controls.Add(this.SiginUpPasswordTextBox);
            this.Controls.Add(this.SiginUpButton);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.MainLoginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.siginUpTumbler);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ChangeLoginVisible(bool visible)
        {
            MainLoginLabel.Visible = visible;
            PasswordLabel.Visible = visible;
            LoginLabel.Visible = visible;
            passwordTextbox.Visible = visible;
            loginTextBox.Visible = visible;
            loginButton.Visible = visible;
            siginUpTumbler.Visible = visible;
        }

        public void ChangeSiginUpVisible(bool visible)
        {
            MainSiginUpLabel.Visible = visible;
            SiginUpLoginLabel.Visible = visible;
            SiginUpPasswordLabel.Visible = visible;
            SiginUpLoginTextBox.Visible = visible;
            SiginUpPasswordTextBox.Visible = visible;
            SiginUpButton.Visible = visible;
            LoginTumbler.Visible = visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (loginTextBox.Text != "" && passwordTextbox.Text != "")
            {
                if (loginTextBox.Text.Length < 34 && passwordTextbox.Text.Length < 34)
                {
                    if (_dataBase.FindUser(loginTextBox.Text,passwordTextbox.Text))
                    {
                        Form5 choiseRoute = new Form5();
                        choiseRoute.Show();
                        Hide();
                    }
                    else
                        MessageBox.Show("Пользователь не найден или введен не правильно логин и пароль");
                }
                else
                    MessageBox.Show("Слишком много символов в логине или пароле");
            }
            else
                MessageBox.Show("Введите данные во все поля");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeSiginUpVisible(true);
            ChangeLoginVisible(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeLoginVisible(true);
            ChangeSiginUpVisible(false);
        }

        private void SiginUpButton_Click(object sender, EventArgs e)
        {
            if (SiginUpLoginTextBox.Text != "" && SiginUpPasswordTextBox.Text != "")
            {
                if (SiginUpLoginTextBox.Text.Length < 34 && SiginUpPasswordTextBox.Text.Length < 34)
                {
                    if (_dataBase.CheckLoginInStock(SiginUpLoginTextBox.Text))
                        MessageBox.Show("Пользователь с таким логином уже есть!");
                    else
                    {
                        _dataBase.AddUser(SiginUpLoginTextBox.Text, SiginUpPasswordTextBox.Text);
                        Form2 AllNameForm = new Form2();
                        AllNameForm.Show();
                        Hide();
                    }
                }
                else
                    MessageBox.Show("Слишком много символов в логине или пароле");
            }
            else
                MessageBox.Show("Введите данные во все поля");
        }

        private void MainSiginUpLabel_Click(object sender, EventArgs e)
        {

        }

        private void SiginUpLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiginUpPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SiginUpLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void SiginUpPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
