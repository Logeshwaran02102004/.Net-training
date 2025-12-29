using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingDay17
{
    public interface Mydb
    {
        string[] ShowData();
    }

    internal class Sqldata : Mydb
    {
        public string[] ShowData()
        {
            return new string[] { "india", "canada", "uk" };
        }
    }

    internal class oracledata : Mydb
    {
        public string[] ShowData()
        {
            return new string[] { "CKS", "RCB", "SRH" };
        }
    }


    internal class mysqldata : Mydb
    {
        public string[] ShowData()
        {
            return new string[] { "red", "blue", "green" };
        }
    }


    class factory
    {
        public static Mydb GetInstance(int i)
        {
            if (i == 1)
                return new Sqldata();

            if (i == 2)
                return new oracledata();

            return new mysqldata();
        }
    }


}
