using System;
using System.IO;
using System.Text;
 

namespace TemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            callGenerateApi("c:\\temp\\");

        }
        static void callGenerateApi(string directory)
        {
        
            callGeneratorController(directory,"user", "users", true);
            callGeneratorController(directory, "tenant", "tenants", true);
            callGeneratorController(directory, "todo", "todos", true);
            callGeneratorController(directory, "order", "orders", true);
            callGeneratorController(directory, "profile", "profiles", true);

            callGeneratorController(directory, "list", "lists", false);
            callGeneratorController(directory, "language", "languages", false);
            callGeneratorController(directory, "item", "items", false);
            callGeneratorController(directory, "ruleBook", "ruleBooks", false);

            callGeneratorExtension(directory, "user", "users", true);
            callGeneratorExtension(directory, "tenant", "tenants", true);
            callGeneratorExtension(directory, "todo", "todos", true);
            callGeneratorExtension(directory, "order", "orders", true);
            callGeneratorExtension(directory, "profile", "profiles", true);

            callGeneratorExtension(directory, "list", "lists", false);
            callGeneratorExtension(directory, "language", "languages", false);
            callGeneratorExtension(directory, "item", "items", false);
            callGeneratorExtension(directory, "ruleBook", "ruleBooks", false);
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
    }
}
