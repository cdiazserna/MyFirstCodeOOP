using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP.Helper
{
    public class EmployeeHelper
    {
        #region Fields

        private Employee _salaryEmployee;
        private Employee _commissionEmployee;
        private Employee _contractorEmployee;
        private Employee _baseCommissionEmployee;

        #endregion

        #region Methods

        public EmployeeHelper(Employee salaryEmployee, Employee commissionEmployee, Employee contractorEmployee, Employee baseCommissionEmployee)
        {
            _salaryEmployee = salaryEmployee;
            _commissionEmployee = commissionEmployee;
            _contractorEmployee = contractorEmployee;
            _baseCommissionEmployee = baseCommissionEmployee;
        }

        public decimal GetPayrollFromActiveEmployees()
        {
            ICollection<Employee> employees = new List<Employee>()
                {
                    _salaryEmployee,
                    _commissionEmployee,
                    _contractorEmployee,
                    _baseCommissionEmployee,
                };

            decimal payroll = 0;

            foreach (Employee employee in employees)
            {
                if (employee.IsActive == true)
                {
                    Console.WriteLine("");
                    Console.WriteLine(employee);
                    Console.WriteLine("");
                    payroll += employee.GetValueToPay();
                }
            }

            return payroll;
        }

        #endregion
    }
}
