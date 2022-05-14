namespace WindowsFormsApplication1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.CarriageListInfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CarriagesInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.TrainsList = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.NumberTrainNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberCarriageNumeric = new System.Windows.Forms.NumericUpDown();
            this.TrainInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberPlaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.BasketTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberTrainNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberCarriageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPlaceNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CarriageListInfo
            // 
            this.CarriageListInfo.Location = new System.Drawing.Point(894, 47);
            this.CarriageListInfo.Name = "CarriageListInfo";
            this.CarriageListInfo.ReadOnly = true;
            this.CarriageListInfo.Size = new System.Drawing.Size(330, 428);
            this.CarriageListInfo.TabIndex = 0;
            this.CarriageListInfo.Text = "";
            this.CarriageListInfo.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(894, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать места";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowPlaceInCarriages_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1063, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Показать свободные места";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ShowFreePlaceButton_Click);
            // 
            // CarriagesInfoTextBox
            // 
            this.CarriagesInfoTextBox.Location = new System.Drawing.Point(558, 288);
            this.CarriagesInfoTextBox.Name = "CarriagesInfoTextBox";
            this.CarriagesInfoTextBox.ReadOnly = true;
            this.CarriagesInfoTextBox.Size = new System.Drawing.Size(330, 187);
            this.CarriagesInfoTextBox.TabIndex = 3;
            this.CarriagesInfoTextBox.Text = "";
            // 
            // TrainsList
            // 
            this.TrainsList.Location = new System.Drawing.Point(152, 47);
            this.TrainsList.Name = "TrainsList";
            this.TrainsList.ReadOnly = true;
            this.TrainsList.Size = new System.Drawing.Size(400, 428);
            this.TrainsList.TabIndex = 4;
            this.TrainsList.Text = "";
            this.TrainsList.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(152, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Показать поезда";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ShowAllTrain_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(558, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(330, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "Показать вагоны";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ShowCarriagesButton_Click);
            // 
            // NumberTrainNumeric
            // 
            this.NumberTrainNumeric.Location = new System.Drawing.Point(26, 53);
            this.NumberTrainNumeric.Name = "NumberTrainNumeric";
            this.NumberTrainNumeric.Size = new System.Drawing.Size(120, 20);
            this.NumberTrainNumeric.TabIndex = 7;
            this.NumberTrainNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер поезда";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер вагона";
            // 
            // NumberCarriageNumeric
            // 
            this.NumberCarriageNumeric.Location = new System.Drawing.Point(26, 108);
            this.NumberCarriageNumeric.Name = "NumberCarriageNumeric";
            this.NumberCarriageNumeric.Size = new System.Drawing.Size(120, 20);
            this.NumberCarriageNumeric.TabIndex = 9;
            // 
            // TrainInfoTextBox
            // 
            this.TrainInfoTextBox.Location = new System.Drawing.Point(558, 47);
            this.TrainInfoTextBox.Name = "TrainInfoTextBox";
            this.TrainInfoTextBox.ReadOnly = true;
            this.TrainInfoTextBox.Size = new System.Drawing.Size(330, 206);
            this.TrainInfoTextBox.TabIndex = 11;
            this.TrainInfoTextBox.Text = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(558, 21);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(330, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Показать поезд";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ShowTrain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Место";
            // 
            // NumberPlaceNumeric
            // 
            this.NumberPlaceNumeric.Location = new System.Drawing.Point(26, 159);
            this.NumberPlaceNumeric.Name = "NumberPlaceNumeric";
            this.NumberPlaceNumeric.Size = new System.Drawing.Size(120, 20);
            this.NumberPlaceNumeric.TabIndex = 13;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(26, 185);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 52);
            this.button6.TabIndex = 15;
            this.button6.Text = "Добавить в корзину";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.AddTicketButton);
            // 
            // BasketTextBox
            // 
            this.BasketTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BasketTextBox.Location = new System.Drawing.Point(152, 501);
            this.BasketTextBox.Name = "BasketTextBox";
            this.BasketTextBox.ReadOnly = true;
            this.BasketTextBox.Size = new System.Drawing.Size(400, 160);
            this.BasketTextBox.TabIndex = 16;
            this.BasketTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(152, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ваша коризна";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button7.Location = new System.Drawing.Point(556, 501);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 46);
            this.button7.TabIndex = 18;
            this.button7.Text = "Перейти к покупке";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1238, 673);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BasketTextBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberPlaceNumeric);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.TrainInfoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberCarriageNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTrainNumeric);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TrainsList);
            this.Controls.Add(this.CarriagesInfoTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarriageListInfo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberTrainNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberCarriageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPlaceNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CarriageListInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox CarriagesInfoTextBox;
        private System.Windows.Forms.RichTextBox TrainsList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown NumberTrainNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumberCarriageNumeric;
        private System.Windows.Forms.RichTextBox TrainInfoTextBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberPlaceNumeric;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox BasketTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
    }
}