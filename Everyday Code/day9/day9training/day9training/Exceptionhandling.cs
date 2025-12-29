using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{
    internal class Exceptionhandling
    {
        public static void Main(string[] args)
        {
            try
            {
                int x, y, z;
                Console.WriteLine("Enter the numbers :");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = x / y;
                Console.WriteLine($"Result : {z}");
            }
            catch (DivideByZeroException exe)
            {
                throw new Exception($"exeception occured while divide by 0{exe.Message}\n sourse:{exe.Source}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                Console.WriteLine("End of the program");
            }
        }
    }
}
