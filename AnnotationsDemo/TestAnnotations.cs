using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AnnotationsDemo
{
    class TestAnnotations
    {
        public static void Display()
        {
            Console.WriteLine("Emplyoee Class Validation");
            Console.WriteLine("-------------------------");

            Employee objEmployee = new Employee();
            objEmployee.Name = "Mayur Kalekar";
            objEmployee.Age = "18";
            objEmployee.PhoneNumber = "8888888888";
            objEmployee.Email = "mayurKalekar250@gmail.com";

            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name:{0}", Totalresult.MemberNames.First(),Environment.NewLine);
                    Console.WriteLine("Error Mesage :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age: " + objEmployee.Age + "\n" + "Phonenumber: " + objEmployee.PhoneNumber + "\n" + "Email: " + objEmployee.Email);
            }
            Console.WriteLine("\n Press any key to exit");
            Console.ReadKey();

        }
    }
}
