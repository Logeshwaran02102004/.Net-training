using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9training
{
    internal class Exceptionhandling2
    {
        public static void MethodDivide()
    {
        try
        {
            int x, y, z;
            Console.WriteLine("Entert the numbers : ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = x / y;
            Console.WriteLine($"Result: {z}");
        }
        catch (DivideByZeroException exe1)
        {
            throw new Exception($"exception caught in method divide by zero {exe1.Message}\n sourse:{exe1.Source}");
            throw exe1;
        }
        catch (Exception ex) {
            throw new Exception(ex.Message);
        }
        finally
        {
            Console.WriteLine("End of the program");
        }

    }
   
        public static void Main(string[] args)
        {
            try
            {
                MethodDivide();
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception in main :{ex.Message}");
            }

        }
    }
}
