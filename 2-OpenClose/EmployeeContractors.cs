namespace OpenClose
{
    public class EmployeeContractors : Employee
    {
       
        public EmployeeContractors(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;           
            return salary;
        }
    }
}