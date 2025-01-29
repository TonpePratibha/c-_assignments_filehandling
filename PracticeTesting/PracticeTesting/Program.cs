using System.ComponentModel.DataAnnotations;
using System.IO.Pipes;
using PracticeTesting;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

        var dataannotation = new RegexandDataannotation
        {
            Name = "abc",
            Age = 22,
            Email = "email@gmail.com"
        };

        var validationResults = new List<ValidationResult>();
        var context = new ValidationContext(dataannotation);
        bool valid = Validator.TryValidateObject(dataannotation, context, validationResults, true);
        if (valid)
        {
            Console.WriteLine("person detail is valid");
        }
        else
        {
            Console.WriteLine("error messages");
            foreach (var error in validationResults)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }


        ///reges mobile validation
        ///
        string[] str = {"9925612824",
          "8238783138", "02812451830"};
        foreach (string s in str) {
            Console.WriteLine("{0} {1} a valid mobile number" , s , isvalidnumber(s) ?"is":"is not");
        }
        Console.ReadLine();
    }

    public static bool isvalidnumber(string number) {

        string strregex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

        Regex r = new Regex(strregex);

        if(r.IsMatch(number))
            return true;
        else
            return false;   

    }
}