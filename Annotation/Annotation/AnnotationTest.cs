using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Annotation
{
    class AnnotationTest
    {
        public static void Display()
        {
            Employee obj = new Employee();
            obj.Name = Console.ReadLine();
            obj.Age = Convert.ToInt32 (Console.ReadLine());
            obj.PhoneNumber = Console.ReadLine();
            obj.Email = Console.ReadLine();
            Console.WriteLine("\n##################\n");
            ValidationContext context = new ValidationContext(obj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(obj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name: {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name :" + obj.Name + "\n" + "Age : " + obj.Age + "\n" + "PhoneNumber : " + obj.PhoneNumber + "Email : " + obj.Email);
            }
        }
    }
}
