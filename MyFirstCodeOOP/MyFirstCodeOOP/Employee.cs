using System;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            //return String.Format("" +
            //    "ID: {0}, " +
            //    "First Name: {1}, " +
            //    "Last Name: {2}, " +
            //    "BirthDate: {3}, " +
            //    "HiringDate: {4}, " +
            //    "Is Active? {5}",
            //    Id,
            //    FirstName,
            //    LastName,
            //    BirthDate,
            //    HiringDate,
            //    IsActive);

            return $"EMPLOYEE \n\t " +
                $"ID: {Id} \n\t " +
                $"First Name: {FirstName} \n\t " +
                $"Last Name: {LastName} \n\t " +
                $"Birth Date: {BirthDate} \n\t " +
                $"Hiring Date {HiringDate} \n\t " +
                $"Is Active? {IsActive}";
        }
        #endregion
    }
}
