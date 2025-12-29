using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay17
{
    internal abstract class DataExporter
    {
        public void Export()
        {
            ConnectToSource();
            FetchData();
            FormatData();
            SaveToFile();
        }
        protected abstract void ConnectToSource();
        protected abstract void FetchData();
        protected abstract void FormatData();
        protected abstract void SaveToFile();
    }
    class CsvExporter : DataExporter
    {
        protected override void ConnectToSource()
        {
            Console.WriteLine("Connecting to data source for CSV");
        }
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for CSV");
        }
        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as CSV");
        }
        protected override void SaveToFile()
        {
            Console.WriteLine("Saving CSV file");
        }
    }
    class JsonExporter : DataExporter
    {
        protected override void ConnectToSource()
        {
            Console.WriteLine("Connecting to data source for JSON");
        }
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for JSON");
        }
        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as JSON");
        }
        protected override void SaveToFile()
        {
            Console.WriteLine("Saving JSON file");
        }
    }
    class XmlExporter : DataExporter
    {
        protected override void ConnectToSource()
        {
            Console.WriteLine("Connecting to data source for XML");
        }
        protected override void FetchData()
        {
            Console.WriteLine("Fetching data for XML");
        }
        protected override void FormatData()
        {
            Console.WriteLine("Formatting data as XML");
        }

        protected override void SaveToFile()
        {
            Console.WriteLine("Saving XML file");
        }
    }
}
