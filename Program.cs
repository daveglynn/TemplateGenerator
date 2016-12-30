using System;
using System.IO;
using System.Text;
 

namespace TemplateGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
             
          //callGenerateApi("C:\\temp\\backend\\");
          //callGenerateClient("C:\\temp\\frontend\\");

          callGenerateApi("C:\\SkyDrive\\Lenovo\\Olympus\\Products\\d2d\\system\\api\\v1\\api\\");
          //callGenerateClient("C:\\SkyDrive\\Lenovo\\Olympus\\Products\\d2d\\system\\d2d-client-sq303-bs4\\v1\\src\\app\\d2dapp\\");

        }

        static void callGenerateApi(string directory)
        {
        
            callGeneratorController(directory + "controllers\\","user", "users", true, false);
            callGeneratorController(directory + "controllers\\", "tenant", "tenants", false, false);
            callGeneratorController(directory + "controllers\\", "todo", "todos", true, false);
            callGeneratorController(directory + "controllers\\", "order", "orders", true, false);
            callGeneratorController(directory + "controllers\\", "profile", "profiles", true, true);
            callGeneratorController(directory + "controllers\\", "list", "lists", false, false);
            callGeneratorController(directory + "controllers\\", "language", "languages", false, true);
            callGeneratorController(directory + "controllers\\", "item", "items", false, true);
            callGeneratorController(directory + "controllers\\", "ruleBook", "ruleBooks", false, false);

            callGeneratorExtension(directory + "controllers\\extensions\\", "user", "users", true, false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "tenant", "tenants", false, false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "todo", "todos", true, false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "order", "orders", true, false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "profile", "profiles", true, true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "list", "lists", false, false);
            callGeneratorExtension(directory + "controllers\\extensions\\", "language", "languages", false, true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "item", "items", false, true);
            callGeneratorExtension(directory + "controllers\\extensions\\", "ruleBook", "ruleBooks", false, false);

            callGeneratorRouter(directory + "routes\\", "item", "items", false);
            callGeneratorRouter(directory + "routes\\", "language", "languages", false);
            callGeneratorRouter(directory + "routes\\", "list", "lists", false);
            callGeneratorRouter(directory + "routes\\", "order", "orders", false);
            callGeneratorRouter(directory + "routes\\", "profile", "profiles", false);
            callGeneratorRouter(directory + "routes\\", "ruleBook", "ruleBooks", false);
            callGeneratorRouter(directory + "routes\\", "tenant", "tenants", false);
            callGeneratorRouter(directory + "routes\\", "todo", "todos", false);
            callGeneratorRouter(directory + "routes\\", "user", "users", false);

        }

        static void callGenerateClient(string directory)
        {

            callGeneratorService(directory + "security\\users\\", "user", "users", false);
            callGeneratorService(directory + "security\\tenants\\", "tenant", "tenants", false);
            callGeneratorService(directory + "master\\profiles\\", "profile", "profiles", false);
            callGeneratorService(directory + "master\\languages\\", "language", "languages", false);
            callGeneratorService(directory + "master\\lists\\", "list", "lists", false);
            callGeneratorService(directory + "master\\items\\", "item", "items", false);
            callGeneratorService(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

            callGeneratorConstructor(directory + "security\\users\\", "user", "users", false);
            callGeneratorConstructor(directory + "security\\tenants\\", "tenant", "tenants", false);
            callGeneratorConstructor(directory + "master\\profiles\\", "profile", "profiles", false);
            callGeneratorConstructor(directory + "master\\languages\\", "language", "languages", false);
            callGeneratorConstructor(directory + "master\\lists\\", "list", "lists", false);
            callGeneratorConstructor(directory + "master\\items\\", "item", "items", false);
            callGeneratorConstructor(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

         //     callGeneratorRouting(directory + "security\\users\\", "user", "users", false);
         //   callGeneratorRouting(directory + "security\\tenants\\", "tenant", "tenants", false);
         //   callGeneratorRouting(directory + "master\\profiles\\", "profile", "profiles", false);
         //   callGeneratorRouting(directory + "master\\languages\\", "language", "languages", false);
         //   callGeneratorRouting(directory + "master\\lists\\", "list", "lists", false);
         //   callGeneratorRouting(directory + "master\\items\\", "item", "items", false);
         //   callGeneratorRouting(directory + "master\\rulebooks\\", "ruleBook", "ruleBooks", false);

            //callGeneratorService(directory + "todos\\", "todo", "todos", false);
            // callGeneratorService(directory + "order\\", "order", "orders", true);
            //  callGeneratorService(directory + "list\\", "list", "lists", false);
            //  callGeneratorService(directory + "item\\", "item", "items", false);
            // callGeneratorService(directory + "ruleBook\\", "ruleBook", "ruleBooks", false);

        }

        static void callGeneratorController(string directory, string singleName, string pluralName, bool tenantRequired, bool codetable) 
        {
            string path = @directory + singleName + ".controller.js";
            var controller = new Controller("TemplateGenerator",singleName, pluralName, tenantRequired, codetable);
            var result = controller.TransformText();
            File.WriteAllText(path, result);
        }
         static void callGeneratorExtension(string directory, string singleName, string pluralName, bool tenantRequired, bool codetable)
        {
            string path = @directory + singleName + ".extension.js";
            var extension = new Extension("TemplateGenerator", singleName, pluralName, tenantRequired, codetable);
            var result =   extension.TransformText();
            File.WriteAllText(path, result);
        
        }
        static void callGeneratorRouter(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".router.js";
            var Router = new Router("TemplateGenerator", singleName, pluralName, false);
            var result = Router.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorService(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".service.ts";
            var service = new Service("TemplateGenerator", singleName, pluralName, false);
            var result = service.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorConstructor(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + singleName + ".ts";
            var constructor = new Constructor("TemplateGenerator", singleName, pluralName, false);
            var result = constructor.TransformText();
            File.WriteAllText(path, result);
        }
        static void callGeneratorRouting(string directory, string singleName, string pluralName, bool tenantRequired)
        {
            string path = @directory + pluralName + ".routing.ts";
            var routing = new Routing("TemplateGenerator", singleName, pluralName, false);
            var result = routing.TransformText();
            File.WriteAllText(path, result);
        }

    }
}
