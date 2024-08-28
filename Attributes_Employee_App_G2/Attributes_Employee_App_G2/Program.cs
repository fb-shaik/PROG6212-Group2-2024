using System.ComponentModel.DataAnnotations;

namespace Attributes_Employee_App_G2
{
   class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the Employee class
            Employee emp = new Employee();

            //lets test out the attributes created in the Employee class
            emp.Id = "2334523434451";
            emp.FName = "Joe";
            emp.SName = "Blog";
            emp.Email = "joe.blog@gmail.com";
            emp.Phone = "1234567890";
            emp.Salary = 10000;

            //method check
            Console.WriteLine(emp.getValues());

            Console.WriteLine(emp.updatedGetValues());


            //ValidationResult: Class that represents the result of a validation request
            //List<ValidationResult>: initialized empty list that will store any validdation errors/results
            List<ValidationResult> validationResults = new List<ValidationResult>();
            
            //Provides context in which the validation is done. Info about the object passed
            ValidationContext context = new ValidationContext(emp);

            //Stores the results of the validation (true: object passes all validation checks)
            bool validCheck = Validator.TryValidateObject(emp, context, validationResults,true);
            //Validator.TryValidateObject: method that validates an object based on its data annotation attributes
            //emp:The object to validate
            //context:provides the necessary context for validation
            //validationResults:List to hold any validation results (errors) found
            //true:Indicates whether to validate all properties of the object. Setting true makes sure all are validated


            if (!validCheck) {
                    foreach (ValidationResult validationResult in validationResults) 
                    {
                        Console.WriteLine(validationResult.ErrorMessage);
                    }
                }
                else 
                {
                    Console.WriteLine("No errors");
                }
            Console.ReadLine();
            }
        
        }
    }

