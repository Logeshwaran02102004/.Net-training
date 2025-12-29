using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLinq
{
    internal class Program
    {
        List<Movies> li = new List<Movies>()
    {
        new Movies(){ MovieId=100, MovieName="Bahubali", Actor="Prabhas",
         Actress="Tamanna", YOR=2015 },
        new Movies(){ MovieId=200, MovieName="Bahubali2", Actor="Prabhas",
         Actress="Anushka", YOR=2017 },
        new Movies(){ MovieId=300, MovieName="Robot", Actor="Rajini",
         Actress="Aish", YOR=2010 },
        new Movies(){ MovieId=400, MovieName="3 idiots", Actor="Amir",
         Actress="kareena", YOR=2009 },
        new Movies(){ MovieId=500, MovieName="Saaho", Actor="Prabhas",
         Actress="shraddha", YOR=2019 },
    };


        public void Actorname()
        {
            var res = from t in li
                      where t.Actor==("Prabhas")
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.MovieId} {item.MovieName}");
            }
        }

        public void Moviesin2019()
        {
            var res = from t in li
                      where t.YOR == 2019
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($" {item.MovieName}");
            }
        }

        public void prabhasanushka()
        {
            var res = from t in li
                      where t.Actor==("Prabhas") && t.Actress ==("Anushka")
                      select t;

            foreach(var item in res)
            {
                Console.WriteLine($"{item.MovieName}");
            }
        }

        public void Actres()//actress acted with the brabhas
        {
            var res = from t in li
                      where t.Actor == ("Prabhas")
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.Actress}");
            }
        }

        public void displaymovies()//displaying the movies between 2010-2018
        {
            var res = from t in li
                      where t.YOR >= 2010 && t.YOR <= 2018
                      select t;
            //Avar res = li.Where(t => t.YOR >= 2010 && t.YOR <= 2018);

            foreach ( var item in res)
            {
                Console.WriteLine($"{item.YOR} {item.MovieName}");
            }
        }

        public void sortyear()
        {
            var res =  from t in li
                       orderby t.YOR descending
                       select t;

            foreach( var item in res)
            {
                Console.WriteLine($"movie id : {item.MovieId}Movie Name :{item.MovieName} actress : {item.Actress}year : {item.YOR}");
            }

        }

        public void characdisplay()
        {
            var res = from t in li
                      where t.MovieName.Length >= 5
                      select t;

            foreach(var item in res)
            {
                Console.WriteLine($"{item.MovieName}");
            }
        }

        public void disactoractress()//printing the values of actor and actress according to year
        {
            var res = from t in li
                      where t.YOR==2009 || t.YOR==2017 || t.YOR==2019
                      select t;

            foreach(var item in res)
            {
                Console.WriteLine($"{item.Actress} | {item.Actor}");
            }
        }


        public void startbendi()
        {
            var res = from m in li 
                      where m.MovieName.StartsWith("B") && m.MovieName.EndsWith("i") 
                      select m;
            foreach (var item in res)
                Console.WriteLine($"{item.MovieName}");
        }


        public void disactress()
        {
            var res = from m in li 
                      where m.Actor != "Rajini" orderby m.Actress descending 
                      select m.Actress;
            foreach (var actress in res)
                Console.WriteLine(actress);

        }


        public void format()
        {
            var res = from m in li  
                      select $"{m.MovieId}  {m.MovieName}  {m.Actor}  {m.Actress}  {m.YOR}";
            foreach (var record in res)
                Console.WriteLine(record);
        }


        
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.Actorname();
            //program.Moviesin2019();
            //program.prabhasanushka();\
            //program.Actres();
            //program.displaymovies();
            //program.sortyear();
            //program.characdisplay();
            //program.disactoractress();
            //program.startbendi();
            //program.disactress();
            //program.format();


            // lambda expressions
            Lambda lambda = new Lambda();
            lambda.secondlargestprice();
            lambda.topthreehighest();


        }
    }
}
