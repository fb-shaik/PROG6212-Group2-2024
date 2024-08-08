using System.Reflection;

namespace Reflection_Console_App_G2
{
    //Reflection is a powerful feature in .Net that allows for
    //developers to inspect & manipulate the meta-data of the 
    //assemblies at runtime
    class Program
    {
        static string path = "C:\\Users\\User\\source\\repos\\VehicleManagement\\bin\\Debug\\net8.0\\VehicleManagement.dll";
        static void Main(string[] args)
        {
            //load the assembly from the specified path using the Loadfile method
            Assembly assembly = Assembly.LoadFile(path);

            //Types: Classes, interfaces, enums, structures & delegates that hold metadata
            //This can be used to generate objects / interact with members

            Type[] types = assembly.GetTypes();
            foreach (Type t in types) 
            {
                Console.WriteLine("");
                Console.WriteLine("TYPE: " + t.FullName);

                MethodInfo[] methods = t.GetMethods();

                foreach (MethodInfo m in methods) 
                {
                    Console.WriteLine("---------Method: " + m.Name);

                    ParameterInfo[] parameters = m.GetParameters();
                    foreach (ParameterInfo p in parameters) 
                    {
                        Console.WriteLine("---------Parameter: " + p.Name + ", Type " + p.ParameterType);

                    }
                }

                
            }

             


        }
    }
}
