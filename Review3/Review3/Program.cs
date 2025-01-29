using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


using Review3;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    
    public static void Emailvalidator(string email)
    {

       

        string emailregex = @"^[a-zA-Z0-9_.]+@[a-zA-Z0-9]+\.[a-zA-z0-9]";
;

        Regex regex = new Regex(emailregex);

        if (regex.IsMatch(email)) {
            Console.WriteLine("valid email");
        }
        else
        {
            Console.WriteLine("invalid email");
        }
    }

    public static void PasswordChecker(string password) {


        
        string passRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[$%^&*!]).{8,}$";

        Regex regex = new Regex(passRegex);
        if (regex.IsMatch(password))
        {
            Console.WriteLine("valid Password");
        }
        else {

            Console.WriteLine("invalid password");
        }
    }
    public static void MobilenumberValidator(string phone)
    {

        string phoneregex = @"^(\+91-\d{10})$";


        Regex regex = new Regex(phoneregex);
        if (regex.IsMatch(phone))
        {
            Console.WriteLine("valid number");
        }
        else
        {

            Console.WriteLine("invalid phone number");
        }

    }
        public static void DivisionException() {

        try
        {
            Console.WriteLine("enter num1");
        
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("enter num2");
        int num2 = int.Parse(Console.ReadLine());
        
            int division = num1 / num2;
            Console.WriteLine(division);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("error occured due to dvision by zero");
        }

        catch (FormatException ) {
            Console.WriteLine("provide valid input");
        }
              
        }

    public static void AgeValidation() { 
    Console.WriteLine("enter age");
        int age=int.Parse(Console.ReadLine());
        try
        {
            if (age < 0 || age > 150)
            {
                throw new InvalidAgeException("enetr age betwen 0 to 150");
            }
            else
            {
                Console.WriteLine("valid age");
            }
        }
        catch (InvalidAgeException e) {
            Console.WriteLine(e.Message);
        }
    }
    public static void BankingValidation() {

        int balance = 500;
        Console.WriteLine("enter withdrawal amount");
        int withdrawamount=int.Parse(Console.ReadLine());
        try
        {
            if (withdrawamount > balance)
            {
                throw new InsufficientFundsException("insufficient balance in account");
            }
        }
        catch (InsufficientFundsException e) {
            Console.WriteLine(e.Message);
        }
    }

    public static void StockException()
    {
        int stock = 5;
        Console.WriteLine("enter quantity of product");
        int qty=int.Parse(Console.ReadLine());
        try {
            if (qty > stock) {
                throw new ProductoutofstockException("ennetred quantity is greater than stock");
            }
        }
        catch (ProductoutofstockException e)
        {
            Console.WriteLine(e.Message);

        }
    }

    public static (T,T) Swapnum<T>( T a, T b)
    {
        return (b, a);
       
    }



    private static void Main(string[] args)
    {
        Console.WriteLine("enter email");
        string email = Console.ReadLine();
        Emailvalidator(email);

        Console.WriteLine("enter password");
        string pass = Console.ReadLine();
        PasswordChecker(pass);

        Console.WriteLine("enter phone number");
        string phone = Console.ReadLine();
        MobilenumberValidator(phone);

        DivisionException();

        AgeValidation();

        BankingValidation();


        ///generics swapping
        ///

        int x = 7;
        int y = 9;
       (x,y)= Swapnum<int>( x, y);
        Console.WriteLine("after swapping"+x+ y);


        float f1= 1.2f;
        float f2 = 3.5f;
        (f1,f2)=Swapnum<float>(f1, f2);
        Console.WriteLine("after swapping" + f1+ f2);




        //Create a lambda expression that checks whether a number is even or odd.
        Console.WriteLine("enter num");
        int num = int.Parse(Console.ReadLine());
        string result=(num%2==0)?"even":"odd";
        Console.WriteLine(result);

        //Use a lambda expression to compare two strings based on their lengths.
        string str1 = "abc";
        string str2 = "bhgd";
        string result1 = (str1.Length == str2.Length) ? "string are equal" : (str1.Length > str2.Length ? "str1 is greater length" : "str2 length is greater");
        Console.WriteLine(result1);



        /*Given a list of integers, use a lambda expression to:
        Multiply each number by 2.
Remove numbers less than 10.*/



        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

        List<int> list2 = list.Select(x => x * 2).ToList();

        foreach (var i in list2)
        {
            Console.WriteLine(i);
        }

        var list3 = list2.Where(x => x > 10);

        foreach (var i in list3) { 
        Console.WriteLine(i);
        }


        //Write a lambda expression to find the maximum of two numbers.
        int a = 3;
        int b = 5;
        int max = a > b ? a : b;
        Console.WriteLine(max);


}}