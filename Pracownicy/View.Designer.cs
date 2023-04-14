
using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class View
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
            this.components = new System.ComponentModel.Container();
            this.employeesListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.contractTypeLabel = new System.Windows.Forms.Label();
            this.jobTitlePicker = new System.Windows.Forms.ComboBox();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.salaryPicker = new System.Windows.Forms.NumericUpDown();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.inputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.writeButton = new System.Windows.Forms.Button();
            this.outputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.addButtonErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesListBox
            // 
            this.employeesListBox.FormattingEnabled = true;
            this.employeesListBox.Location = new System.Drawing.Point(344, 13);
            this.employeesListBox.Name = "employeesListBox";
            this.employeesListBox.Size = new System.Drawing.Size(444, 420);
            this.employeesListBox.TabIndex = 0;
            this.employeesListBox.Click += new System.EventHandler(this.EmployeesListBox_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.contractTypeLabel);
            this.panel1.Controls.Add(this.jobTitlePicker);
            this.panel1.Controls.Add(this.jobTitleLabel);
            this.panel1.Controls.Add(this.salaryPicker);
            this.panel1.Controls.Add(this.salaryLabel);
            this.panel1.Controls.Add(this.birthDatePicker);
            this.panel1.Controls.Add(this.birthDateLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 379);
            this.panel1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(79, 336);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 30);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(114, 224);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 247);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(115, 270);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton_Click);
            // 
            // contractTypeLabel
            // 
            this.contractTypeLabel.AutoSize = true;
            this.contractTypeLabel.Location = new System.Drawing.Point(13, 224);
            this.contractTypeLabel.Name = "contractTypeLabel";
            this.contractTypeLabel.Size = new System.Drawing.Size(76, 13);
            this.contractTypeLabel.TabIndex = 10;
            this.contractTypeLabel.Text = "Rodzaj umowy";
            // 
            // jobTitlePicker
            // 
            this.jobTitlePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitlePicker.FormattingEnabled = true;
            this.jobTitlePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.jobTitlePicker.Location = new System.Drawing.Point(115, 172);
            this.jobTitlePicker.Name = "jobTitlePicker";
            this.jobTitlePicker.Size = new System.Drawing.Size(130, 21);
            this.jobTitlePicker.TabIndex = 9;
            this.jobTitlePicker.SelectionChangeCommitted += new System.EventHandler(this.JobTitlePicker_SelectionChangeCommitted);
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Location = new System.Drawing.Point(13, 175);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(62, 13);
            this.jobTitleLabel.TabIndex = 8;
            this.jobTitleLabel.Text = "Stanowisko";
            // 
            // salaryPicker
            // 
            this.salaryPicker.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryPicker.Location = new System.Drawing.Point(115, 132);
            this.salaryPicker.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.salaryPicker.Name = "salaryPicker";
            this.salaryPicker.Size = new System.Drawing.Size(96, 20);
            this.salaryPicker.TabIndex = 7;
            this.salaryPicker.ValueChanged += new System.EventHandler(this.SalaryPicker_ValueChanged);
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(13, 134);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 6;
            this.salaryLabel.Text = "Pensja";
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.CustomFormat = "dd/MM/yyyy";
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDatePicker.Location = new System.Drawing.Point(115, 90);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(96, 20);
            this.birthDatePicker.TabIndex = 5;
            this.birthDatePicker.Value = new System.DateTime(2023, 4, 13, 23, 24, 26, 0);
            this.birthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(13, 96);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(79, 13);
            this.birthDateLabel.TabIndex = 4;
            this.birthDateLabel.Text = "Data urodzenia";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(115, 53);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(130, 20);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 21);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(13, 56);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Imie";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(61, 417);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Wczytaj plik";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(196, 417);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(100, 23);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Zapisz do pliku";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // addButtonErrorProvider
            // 
            this.addButtonErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.addButtonErrorProvider.ContainerControl = this;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.employeesListBox);
            this.Name = "View";
            this.Text = "Pracownicy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        private void MyInitialize()
        {
            //this.birthDatePicker.Value = DateTime.Now;
            // Init items in job title picker
            String[] titlesStrings = new JobTitlesMethods().getAllStrings();
            this.jobTitlePicker.Items.AddRange(titlesStrings);
            this.jobTitlePicker.SelectedItem = titlesStrings[0];

            // Init radio buttons
            String[] contractStrings = new ContractTypesMethods().getAllStrings();
            this.radioButton1.Text = contractStrings[0];
            this.radioButton2.Text = contractStrings[1];
            this.radioButton3.Text = contractStrings[2];
        }

        #endregion

        private System.Windows.Forms.ListBox employeesListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown salaryPicker;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.ComboBox jobTitlePicker;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label contractTypeLabel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog inputFileDialog;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.SaveFileDialog outputFileDialog;
        private ErrorProvider addButtonErrorProvider;
    }
}

