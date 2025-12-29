using EmployeeServices;

namespace PayrollSystem
{
    public class PayrollProcessor
    {
        private static readonly Dictionary<int, decimal> BaseSalaries = new()
        {
            [101] = 70000m,
            [102] = 150000m,
            [103] = 35000m
        };





        private readonly IEmployeeDataReader _employeeReader;

        public PayrollProcessor(IEmployeeDataReader employeeReader)
        {
            _employeeReader = employeeReader;
        }




        public decimal CalculateTotalCompesation(int employeeId)
        {
            var emp = _employeeReader.GetEmployeeRecors(employeeId);

            BaseSalaries.TryGetValue(employeeId, out decimal baseSalary);

            decimal bonus = emp switch
            {
                { Role: "Manager", IsVetern: true } => 10000m,
                { Role: "Manager", IsVetern: false } => 5000m,
                { Role: "Developer" } => 2000m,
                { Role: "Intern" } => 500m,
                _ => 0m
            };




            return baseSalary + bonus;
        }
    }
}
