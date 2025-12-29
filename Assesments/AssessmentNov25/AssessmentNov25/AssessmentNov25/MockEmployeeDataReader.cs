using AssessmentNov25;

namespace EmployeeServices
{
    public interface IEmployeeDataReader
    {
        EmployeeRecord GetEmployeeRecors(int employeeid);
    }

    public class MockEmployeeDataReader : IEmployeeDataReader
    {
        public EmployeeRecord GetEmployeeRecors(int employeeid)
        {
            if (employeeid == 101)
            {
                return new EmployeeRecord
                {
                    Id = 101,
                    Name = "Logesh",
                    Role = "Developer",
                    IsVetern = false
                };
            }




            if (employeeid == 102)
            {
                return new EmployeeRecord
                {
                    Id = 102,
                    Name = "Prathees",
                    Role = "Hr",
                    IsVetern = true
                };
            }





            if (employeeid == 103)
            {
                return new EmployeeRecord
                {
                    Id = 103,
                    Name = "Waseef",
                    Role = "Developer",
                    IsVetern = false
                };
            }





            return new EmployeeRecord
            {
                Id = employeeid,
                Name = "Unknown",
                Role = "Unknown",
                IsVetern = false
            };
        }
    }
}
