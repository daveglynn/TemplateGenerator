using System;
using System.IO;
using System.Text;
 

namespace TemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            callGenerateApi();

        }
        static void callGenerateApi( )
        {

            callGeneratorController("user", "users", true);
            callGeneratorController("tenant", "tenants", true);
            callGeneratorController("todo", "todos", true);
            callGeneratorController("order", "orders", true);
            callGeneratorController("profile", "profiles", true);

            callGeneratorController("list", "lists", false);
            callGeneratorController("language", "languages", false);
            callGeneratorController("item", "items", false);
            callGeneratorController("ruleBook", "ruleBooks", false);

            callGeneratorExtension("user", "users", true);
            callGeneratorExtension("tenant", "tenants", true);
            callGeneratorExtension("todo", "todos", true);
            callGeneratorExtension("order", "orders", true);
            callGeneratorExtension("profile", "profiles", true);

            callGeneratorExtension("list", "lists", false);
            callGeneratorExtension("language", "languages", false);
            callGeneratorExtension("item", "items", false);
            callGeneratorExtension("ruleBook", "ruleBooks", false);
        }

        static void callGeneratorController(string singleName, string pluralName, bool tenantRequired) 
        {
            string path = @"c:\temp\" + singleName + ".controller.js";
            var controller = new Controller("TemplateGenerator",singleName, pluralName, false);
            var result = controller.TransformText();
            File.WriteAllText(path, result);
        }
         static void callGeneratorExtension(string singleName, string pluralName, bool tenantRequired)
        {
            string path = @"c:\temp\" + singleName + ".extension.js";
            var extension = new Extension("TemplateGenerator", singleName, pluralName, false);
            var result =   extension.TransformText();
            File.WriteAllText(path, result);
       }
    }
}
