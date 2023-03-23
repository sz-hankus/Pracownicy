
namespace Pracownicy
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.SalaryPicker = new System.Windows.Forms.NumericUpDown();
            this.JobTitleLabel = new System.Windows.Forms.Label();
            this.JobTitlePicker = new System.Windows.Forms.ComboBox();
            this.ContractTypeLabel = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(344, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(444, 420);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.ContractTypeLabel);
            this.panel1.Controls.Add(this.JobTitlePicker);
            this.panel1.Controls.Add(this.JobTitleLabel);
            this.panel1.Controls.Add(this.SalaryPicker);
            this.panel1.Controls.Add(this.SalaryLabel);
            this.panel1.Controls.Add(this.BirthDatePicker);
            this.panel1.Controls.Add(this.BirthDateLabel);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.SurnameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 379);
            this.panel1.TabIndex = 1;
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.CustomFormat = "dd/MM/yyyy";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDatePicker.Location = new System.Drawing.Point(115, 90);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(96, 20);
            this.BirthDatePicker.TabIndex = 5;
            this.BirthDatePicker.Value = new System.DateTime(2023, 3, 22, 22, 24, 53, 187);
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(13, 96);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(79, 13);
            this.BirthDateLabel.TabIndex = 4;
            this.BirthDateLabel.Text = "Data urodzenia";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(115, 53);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(130, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(115, 21);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(130, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(13, 56);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(53, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Nazwisko";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(26, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Imie";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(13, 134);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.SalaryLabel.TabIndex = 6;
            this.SalaryLabel.Text = "Pensja";
            // 
            // SalaryPicker
            // 
            this.SalaryPicker.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SalaryPicker.Location = new System.Drawing.Point(115, 132);
            this.SalaryPicker.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.SalaryPicker.Name = "SalaryPicker";
            this.SalaryPicker.Size = new System.Drawing.Size(96, 20);
            this.SalaryPicker.TabIndex = 7;
            // 
            // JobTitleLabel
            // 
            this.JobTitleLabel.AutoSize = true;
            this.JobTitleLabel.Location = new System.Drawing.Point(13, 175);
            this.JobTitleLabel.Name = "JobTitleLabel";
            this.JobTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.JobTitleLabel.TabIndex = 8;
            this.JobTitleLabel.Text = "Stanowisko";
            // 
            // JobTitlePicker
            // 
            this.JobTitlePicker.FormattingEnabled = true;
            this.JobTitlePicker.Location = new System.Drawing.Point(115, 172);
            this.JobTitlePicker.Name = "JobTitlePicker";
            this.JobTitlePicker.Size = new System.Drawing.Size(130, 21);
            this.JobTitlePicker.TabIndex = 9;
            this.JobTitlePicker.Items.AddRange(new object[]
            {
                JobTitles.DESIGNER,
                JobTitles.PROGRAMMMER,
                JobTitles.MANAGER
            }) ;
            // 
            // ContractTypeLabel
            // 
            this.ContractTypeLabel.AutoSize = true;
            this.ContractTypeLabel.Location = new System.Drawing.Point(13, 224);
            this.ContractTypeLabel.Name = "ContractTypeLabel";
            this.ContractTypeLabel.Size = new System.Drawing.Size(76, 13);
            this.ContractTypeLabel.TabIndex = 10;
            this.ContractTypeLabel.Text = "Rodzaj umowy";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(115, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 247);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(115, 270);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(79, 336);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(147, 30);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown SalaryPicker;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.ComboBox JobTitlePicker;
        private System.Windows.Forms.Label JobTitleLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label ContractTypeLabel;
    }
}

