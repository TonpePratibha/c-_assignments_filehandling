using System.ComponentModel.DataAnnotations;
using System.Globalization;
using CsvHelper;
using File_handling;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        //simple text file handling

        //string path = "D:\\bridgelabz_assignments\\practiceProjects\\File handling\\File handling\\doc.txt";

        //bool result = File.Exists(path);
        //if (result)
        //{
        //    Console.WriteLine("file exists");
        //   //Console.WriteLine( File.ReadAllText(path));
        //   // File.Delete(path);

        //}
        //else
        //{
        //    Console.WriteLine("file is not exists");
        //}











        //    // Check if the file exists before attempting to delete it
        //    if (File.Exists(path))
        //    {
        //        try
        //        {
        //            // Attempt to delete the file
        //            File.Delete(path);
        //            Console.WriteLine("File deleted successfully.");
        //        }
        //        catch (Exception ex)
        //        {
        //            // Catch any errors and display the message
        //            Console.WriteLine("Error deleting the file: " + ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("File does not exist.");
        //    }



        //csv file handling


        var records = new List<Employee> {
       new Employee{Id=1,Name="abc",Email="abc@gmail.com" },
       new Employee{Id=2,Name="xyz",Email="xyz@gmail.com" },
       new Employee{Id=3,Name="def",Email="def@gmail.com" }
        };

        //writing in csv file
        //string path = "D:\\bridgelabz_assignments\\practiceProjects\\File handling\\File handling\\DemoCsv.csv";
        //File.Create(path);
        //using (var writter = new StreamWriter(path)) 
        //using (var csvinput = new CsvWriter(writter, CultureInfo.InvariantCulture)) { 

        //csvinput.WriteRecords(records);
        //}

        // reading from csv file
        //using (var reader = new StreamReader(path)) 
        //using (var csvoutput = new CsvReader(reader, CultureInfo.InvariantCulture))
        //{

        //    var recordData = csvoutput.GetRecords<Employee>();
        //    foreach (var record in recordData)
        //    {

        //        Console.WriteLine($"id: {record.Id},Nmae: {record.Name} email:{record.Email}");
        //    }

        //}

        //json file writing


        //write data in json file
        string path = "D:\\bridgelabz_assignments\\practiceProjects\\File handling\\File handling\\DemoJson.json";
           // File.Create(path);
        //string jsonInput=JsonConvert.SerializeObject(records,Formatting.Indented);
        //File.WriteAllText(path,jsonInput);
        //Console.WriteLine("data addedd to json");



        //read data from json file

        string readjson=File.ReadAllText(path);
        var deserializeddata=JsonConvert.DeserializeObject<List<Employee>>(readjson);
        foreach (var record in deserializeddata) {
            Console.WriteLine($"id: {record.Id},Nmae: {record.Name} email:{record.Email}");
        }
        }
    }

