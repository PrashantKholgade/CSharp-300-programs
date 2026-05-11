// Program 258: Template Method Pattern
// Category: Advanced

using System;
abstract class DataProcessor{
    public void Process(){ReadData();ProcessData();WriteOutput();}
    protected abstract void ReadData();
    protected abstract void ProcessData();
    protected virtual void WriteOutput()=>Console.WriteLine("Writing output...");
}
class CSVProcessor:DataProcessor{protected override void ReadData()=>Console.WriteLine("Reading CSV...");protected override void ProcessData()=>Console.WriteLine("Processing CSV data...");}
class JSONProcessor:DataProcessor{protected override void ReadData()=>Console.WriteLine("Reading JSON...");protected override void ProcessData()=>Console.WriteLine("Processing JSON data...");protected override void WriteOutput()=>Console.WriteLine("Writing JSON output...");}
class Program{static void Main(){new CSVProcessor().Process();Console.WriteLine("---");new JSONProcessor().Process();}}
