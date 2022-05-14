namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.Label();
            this.SecondNameAlert = new System.Windows.Forms.Label();
            this.FirstNameAlert = new System.Windows.Forms.Label();
            this.LastNameAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите свои данные";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(411, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(444, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Имя:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(403, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(495, 168);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(100, 20);
            this.SecondName.TabIndex = 4;
            this.SecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondName_KeyPress);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(495, 208);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 5;
            this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_KeyPress);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(495, 247);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 6;
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(495, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alert
            // 
            this.Alert.AutoSize = true;
            this.Alert.BackColor = System.Drawing.Color.Cornsilk;
            this.Alert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Alert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alert.Location = new System.Drawing.Point(495, 277);
            this.Alert.Name = "Alert";
            this.Alert.Size = new System.Drawing.Size(113, 19);
            this.Alert.TabIndex = 8;
            this.Alert.Text = "Введите данные";
            this.Alert.Visible = false;
            // 
            // SecondNameAlert
            // 
            this.SecondNameAlert.AutoSize = true;
            this.SecondNameAlert.BackColor = System.Drawing.Color.Cornsilk;
            this.SecondNameAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondNameAlert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameAlert.Location = new System.Drawing.Point(601, 171);
            this.SecondNameAlert.Name = "SecondNameAlert";
            this.SecondNameAlert.Size = new System.Drawing.Size(182, 19);
            this.SecondNameAlert.TabIndex = 9;
            this.SecondNameAlert.Text = "Привышен лимит символов";
            this.SecondNameAlert.Visible = false;
            // 
            // FirstNameAlert
            // 
            this.FirstNameAlert.AutoSize = true;
            this.FirstNameAlert.BackColor = System.Drawing.Color.Cornsilk;
            this.FirstNameAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstNameAlert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameAlert.Location = new System.Drawing.Point(601, 211);
            this.FirstNameAlert.Name = "FirstNameAlert";
            this.FirstNameAlert.Size = new System.Drawing.Size(182, 19);
            this.FirstNameAlert.TabIndex = 10;
            this.FirstNameAlert.Text = "Привышен лимит символов";
            this.FirstNameAlert.Visible = false;
            // 
            // LastNameAlert
            // 
            this.LastNameAlert.AutoSize = true;
            this.LastNameAlert.BackColor = System.Drawing.Color.Cornsilk;
            this.LastNameAlert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LastNameAlert.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameAlert.Location = new System.Drawing.Point(601, 250);
            this.LastNameAlert.Name = "LastNameAlert";
            this.LastNameAlert.Size = new System.Drawing.Size(182, 19);
            this.LastNameAlert.TabIndex = 11;
            this.LastNameAlert.Text = "Привышен лимит символов";
            this.LastNameAlert.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 545);
            this.Controls.Add(this.LastNameAlert);
            this.Controls.Add(this.FirstNameAlert);
            this.Controls.Add(this.SecondNameAlert);
            this.Controls.Add(this.Alert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecondName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Alert;
        private System.Windows.Forms.Label SecondNameAlert;
        private System.Windows.Forms.Label FirstNameAlert;
        private System.Windows.Forms.Label LastNameAlert;
    }
}