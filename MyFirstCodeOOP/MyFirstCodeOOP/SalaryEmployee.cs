using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class SalaryEmployee : Employee
    {
        #region Properties
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            //El base es la herencia que traigo de la clase padre, que para este caso se trata de una clase abstracta
            return $"{base.ToString()} \n\t" +
                $"Value to Pay; {GetValueToPay():C2}";
        }
        #endregion
    }
}