using System;
using System.IO;
using System.Text;
 

namespace TemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            //callGenerateApi("C:\\SkyDrive\\Lenovo\\Olympus\\Products\\d2d\\system\\api_code\\v1\\api\\");

           // callGenerateApi("C:\\temp\\");

            callGenerateClient("C:\\temp\\");

        }

        static void callGenerateApi(string directory)
        {
        
            callGeneratorController(directory + "controllers\\","user", "users", false);
            callGeneratorController(directory + "controllers\\", "tenant", "tenants", false);
            callGeneratorController(directory + "controllers\\", "todo", "todos", true);
            callGeneratorController(directory + "controllers\\", "order", "orders", true);
            callGeneratorController(directory + "controllers\\", "profile", "profiles", true);
            callGeneratorController(directory + "controllers\\", "list", "lists", false);
            callGeneratorController(directory + "controllers\\", "language", "languages", false);
            callGeneratorController(directory + "controllers\\", "item", "items", false);
            callGeneratorController(directory + "controllers\\", "ruleBook", "ruleBooks", false);

            callGeneratorExtension(directory + "controllers\\extensions\\", "user", "users", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "tenant", "tenants", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "todo", "todos", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "order", "orders", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "profile", "profiles", true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "list", "lists", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "language", "languages", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "item", "items", false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "ruleBook", "ruleBooks", false);

        }

        static void callGenerateClient(string directory)
        {

            callGeneratorService(directory + "user\\", "user", "users", false);
            callGeneratorService(directory + "profile\\", "profile", "profiles", true);
            // callGeneratorService(directory + "tenant\\", "tenant", "tenants", false);
            // callGeneratorService(directory + "todo\\", "todo", "todos", true);
            // callGeneratorService(directory + "order\\", "order", "orders", true);
            //  callGeneratorService(directory + "list\\", "list", "lists", false);
            //  callGeneratorService(directory + "language\\", "language", "languages", false);
            //  callGeneratorService(directory + "item\\", "item", "items", false);
            // callGeneratorService(directory + "ruleBook\\", "ruleBook", "ruleBooks", false);

        }

        static void callGeneratorController(string directory, string singleName, string pluralName, bool tenantRequired) 
        {
            string path = @directory + singleName + ".controller.js";
            var controller = new Controller("TemplateGenerator",singleName, pluralName, false);
            var result = controller.TransformText();
            File.WriteAllText(path, result);
        }
         static void callGeneratorExtension(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".extension.js";
            var extension = new Extension("TemplateGenerator", singleName, pluralName, false);
            var result =   extension.TransformText();
            File.WriteAllText(path, result);
        
        }

        static void callGeneratorService(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".service.js";
            var service = new Service("TemplateGenerator", singleName, pluralName, false);
            var result = service.TransformText();
            File.WriteAllText(path, result);
        }

    }
}
