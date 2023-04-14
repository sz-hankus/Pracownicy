using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    public class Presenter
    {
        private readonly View _view;
        private readonly Model _model;

        private String _chosenName = "";
        private String _chosenSurname = "";
        private DateTime _chosenBrithDate = DateTime.Now;
        private int _chosenSalary = 0;
        private JobTitles _chosenTitle = JobTitles.DESIGNER;
        private ContractTypes _chosenContractType = ContractTypes.PERMANENT_EMPLOYMENT;

        private List<Employee> _currentEmployees;

        // Events for the View to subscribe to
        public Action<List<Employee>> employeesListUpdated;
        public Action<String> errorSet;
        public Action errorUnset;

        public Presenter(View view, Model model)
        {
            this._view = view;
            view.presenter = this;
            SubscribeToViewEvents();

            this._model = model;
        }

        private void SubscribeToViewEvents()
        {
            this._view.nameChanged += OnNameChange;
            this._view.surnameChanged += OnSurnameChange;
            this._view.birthDateChanged += OnBirthDateChange;
            this._view.salaryChanged += OnSalaryChange;
            this._view.jobTitleChanged += OnJobTitleChange;
            this._view.addButtonClicked += OnAddClicked;
            this._view.loadButtonClicked += OnLoadClicked;
            this._view.writeButtonClicked += OnWriteClicked;
            this._view.contractTypeChanged += OnContractTypeChange;
        }

        private void OnNameChange(String name)
        {
            this._chosenName = name;
        }

        private void OnSurnameChange(String surname)
        {
            this._chosenSurname = surname;
        }

        private void OnBirthDateChange(DateTime birthDate)
        {
            this._chosenBrithDate = birthDate; 
        }

        private void OnSalaryChange(int salary)
        {
            this._chosenSalary = salary;
        }

        private void OnJobTitleChange(JobTitles title)
        {
            this._chosenTitle = title;
        }

        private void OnAddClicked()
        {
            Employee newEmployee = new Employee(_chosenName, 
                                                _chosenSurname,
                                                _chosenBrithDate,
                                                _chosenSalary,
                                                _chosenTitle,
                                                _chosenContractType);
            if (!this._model.isEmployeeValid(newEmployee))
            {
                this.errorSet.Invoke("Niepoprawne dane. Imię i nazwisko muszą składać się ze znaków alfabetycznych.");
                return; 
            }

            this._model.AddEmployee(newEmployee);
            this._currentEmployees = this._model.GetEmployees();
            // invoke events handled by the view
            this.employeesListUpdated.Invoke(this._currentEmployees);
            this.errorUnset.Invoke();
        }

        private void OnLoadClicked(String path)
        {
            this._model.LoadFromFile(path);
            this._currentEmployees = this._model.GetEmployees();

            this.employeesListUpdated.Invoke(this._currentEmployees);
        }

        private void OnWriteClicked(String path)
        {
            this._model.WriteContentsToFile(path);
        }

        private void OnContractTypeChange(ContractTypes type)
        {
            this._chosenContractType = type;
        }
    }
}
