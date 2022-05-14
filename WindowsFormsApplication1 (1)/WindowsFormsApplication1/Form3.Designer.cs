namespace WindowsFormsApplication1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.EmailAdress = new System.Windows.Forms.TextBox();
            this.Alert = new System.Windows.Forms.Label();
            this.PhoneNumberAlert = new System.Windows.Forms.Label();
            this.EmailAdressAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер телеона и почту для связи с вами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(290, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(363, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Почта:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(434, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перейти на выбор поезда";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(434, 193);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(216, 20);
            this.PhoneNumber.TabIndex = 4;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // EmailAdress
            // 
            this.EmailAdress.Location = new System.Drawing.Point(434, 237);
            this.EmailAdress.Name = "EmailAdress";
            this.EmailAdress.Size = new System.Drawing.Size(216, 20);
            this.EmailAdress.TabIndex = 5;
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.BackColor = System.Drawing.Color.Cornsilk;
            this.Alert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alert.Location = new System.Drawing.Point(434, 272);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(154, 20);
            this.Alert.TabIndex = 6;
            this.Alert.Text = "Введите контакты";
            this.Alert.Visible = false;
            // 
            // PhoneNumberAlert
            // 
            this.PhoneNumberAlert.AutoSize = true;
            this.PhoneNumberAlert.BackColor = System.Drawing.Color.Cornsilk;
            this.PhoneNumberAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhoneNumberAlert.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberAlert.Location = new System.Drawing.Point(656, 196);
            this.PhoneNumberAlert.Name = "PhoneNumberAlert";
            this.PhoneNumberAlert.Size = new System.Drawing.Size(133, 20);
            this.PhoneNumberAlert.TabIndex = 7;
            this.PhoneNumberAlert.Text = "Привышен лимит";
            this.PhoneNumberAlert.Visible = false;
            // 
            // EmailAdressAlert
            // 
            this.EmailAdressAlert.AutoSize = true;
            this.EmailAdressAlert.BackColor = System.Drawing.Color.Cornsilk;
            this.EmailAdressAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmailAdressAlert.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailAdressAlert.Location = new System.Drawing.Point(656, 240);
            this.EmailAdressAlert.Name = "EmailAdressAlert";
            this.EmailAdressAlert.Size = new System.Drawing.Size(133, 20);
            this.EmailAdressAlert.TabIndex = 8;
            this.EmailAdressAlert.Text = "Привышен лимит";
            this.EmailAdressAlert.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 606);
            this.Controls.Add(this.EmailAdressAlert);
            this.Controls.Add(this.PhoneNumberAlert);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.EmailAdress);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox EmailAdress;
        private System.Windows.Forms.Label Alert;
        private System.Windows.Forms.Label PhoneNumberAlert;
        private System.Windows.Forms.Label EmailAdressAlert;
    }
}