using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pracownicy
{
    public partial class View : Form
    {
        public Presenter presenter;

        public Action<String> nameChanged;
        public Action<String> surnameChanged;
        public Action<DateTime> birthDateChanged;
        public Action<int> salaryChanged;
        public Action<JobTitles> jobTitleChanged;
        public Action<ContractTypes> contractTypeChanged;
        public Action addButtonClicked;

        
        public Action<String> loadButtonClicked;
        public Action<String> writeButtonClicked;

        public View()
        {
            InitializeComponent();
            MyInitialize();
        }

        public void SubscribeToPresenterEvents()
        {
            this.presenter.employeesListUpdated += this.OnUpdateEmployeesList;
            this.presenter.errorSet += this.OnErrorSet;
            this.presenter.errorUnset += this.OnErrorUnset;
        }

        private void OnUpdateEmployeesList(List<Employee> employees)
        {
            this.employeesListBox.Items.Clear();
            this.employeesListBox.Items.AddRange(employees.ToArray());
        }

        private void OnErrorSet(String message)
        {
            this.addButtonErrorProvider.SetError(this.addButton, message);
        }

        private void OnErrorUnset()
        {
            this.addButtonErrorProvider.Clear();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;   
            this.nameChanged.Invoke(tb.Text);
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            this.surnameChanged.Invoke(tb.Text);
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            this.birthDateChanged.Invoke(dtp.Value);
        }

        private void SalaryPicker_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;
            this.salaryChanged.Invoke((int)nud.Value);
        }

        private void JobTitlePicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            String selected = cmb.SelectedItem as String;
            JobTitles title = new JobTitlesMethods().fromString(selected);

            this.jobTitleChanged.Invoke(title);
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            ContractTypes type = new ContractTypesMethods().fromString(rb.Text);
            if (rb.Checked)
            {
                this.contractTypeChanged.Invoke(type);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.addButtonClicked.Invoke();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.inputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = inputFileDialog.FileName;
                this.loadButtonClicked.Invoke(path);
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = this.outputFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = outputFileDialog.FileName;
                this.writeButtonClicked.Invoke(path);
            }
        }

        private void EmployeesListBox_Click(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            Employee selected = lb.SelectedItem as Employee;
            if (selected == null)
                return;
            
            this.nameTextBox.Text = selected.Name;
            this.surnameTextBox.Text = selected.Surname;
            this.birthDatePicker.Value = selected.BirthDate;
            this.salaryPicker.Value = selected.Salary;
            this.jobTitlePicker.SelectedItem = new JobTitlesMethods().getString(selected.Title);
            
            String contract = new ContractTypesMethods().getString(selected.ContractType);
            
            foreach (RadioButton rBtn in this.panel1.Controls.OfType<RadioButton>())
                if (rBtn.Text == contract)
                    rBtn.Select();
            
        }

    }
}
