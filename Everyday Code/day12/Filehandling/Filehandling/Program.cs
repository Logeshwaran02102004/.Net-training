using FileHandlingDemo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is for garbage collection 
            GarbageCollectorDemo gcDemo = new GarbageCollectorDemo();
            gcDemo.RunGarbageCollectorDemo();

            // this is used to read the file text
            /*
            string filepath = "C:\\Users\\logeshwaranv\\Desktop\\Infinite.nettraining\\Csharp\\day12\\day11training.txt";

            using (StreamReader reader = new StreamReader(filepath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine("updated file content");
                Console.WriteLine(content);

            }*/


            /*

            // specify the directory which we want to manupulate
            string sourcedir = @"C:\Users\logeshwaranv\Desktop\Infinite.nettraining\Csharp\day12\SampleSource";
            string targetdir = @"C:\Users\logeshwaranv\Desktop\Infinite.nettraining\Csharp\day12\SampleDestination";
            DirectoryInfo sdi = new DirectoryInfo(sourcedir);
            DirectoryInfo tdi = new DirectoryInfo(targetdir);

            if (!tdi.Exists)
            {
                tdi.Create();
            }

            //coping new filw into each directory 
            foreach (FileInfo fi in sdi.GetFiles())
            {
                fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);
                Console.WriteLine(@"coping {0}\{1}", tdi.FullName, fi.Name);
            }


            //copying each sub dorectories and its files
            foreach(DirectoryInfo sourcesubdir in sdi.GetDirectories())
            {
                DirectoryInfo targetSubdir = tdi.CreateSubdirectory(sourcesubdir.Name);
                
                //copying each file into it's new directory 
                foreach(FileInfo fi in sourcesubdir.GetFiles())
                {
                    fi.CopyTo(Path.Combine(targetSubdir.ToString(), fi.Name), true);
                    Console.WriteLine(@"coping {0}\{1}",targetSubdir.FullName, fi.Name);
                }

            }*/


            Console.ReadLine();

        }
    
    }
}
