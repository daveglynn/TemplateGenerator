﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TemplateGenerator
{
    using System.Linq;
    using System.Text;
    using Npgsql;
    using System.Data;
    using System.Globalization;
    using System.Collections.Generic;
    using System.IO;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class Router : RouterBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("  ");
            this.Write("\r\n/******************************************************************************" +
                    "************************\r\n \r\n ");
            
            #line 19 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(getCopyright()));
            
            #line default
            #line hidden
            this.Write(@"

******************************************************************************************************/

/******************************************************************************************************
 router
******************************************************************************************************/
""use strict"";
var express = require('express'), app = express();
var router = express.Router();
var _ = require('underscore');
var db = require('../.././db.js');
var middleware = require('../.././middleware.js')(db);
var ctrl");
            
            #line 32 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(" = require(\'../controllers/");
            
            #line 32 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".controller.js\');\r\n\r\nrouter\r\n    .route(\'/\')\r\n    .post(");
            
            #line 36 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 if ( (_singleName != "user") ) {
            
            #line default
            #line hidden
            this.Write(" middleware.requireAuthentication, middleware.requireAuthorisation,");
            
            #line 36 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
}
            
            #line default
            #line hidden
            this.Write(" ctrl");
            
            #line 36 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".add");
            
            #line 36 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(");\r\nrouter\r\n    .route(\'/all\')\r\n    .get(middleware.requireAuthentication, middle" +
                    "ware.requireAuthorisation, ctrl");
            
            #line 39 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".get");
            
            #line 39 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_pluralName)));
            
            #line default
            #line hidden
            this.Write("All);\r\nrouter\r\n    .route(\'/:id(\\\\d+)/\')\r\n    .get(middleware.requireAuthenticati" +
                    "on, middleware.requireAuthorisation, ctrl");
            
            #line 42 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".get");
            
            #line 42 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write("ById);\r\nrouter\r\n    .route(\'/:id(\\\\d+)/\')\r\n    .put(middleware.requireAuthenticat" +
                    "ion, middleware.requireAuthorisation, ctrl");
            
            #line 45 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".update");
            
            #line 45 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(");\r\nrouter\r\n    .route(\'/:id(\\\\d+)/\')\r\n    .delete(middleware.requireAuthenticati" +
                    "on, middleware.requireAuthorisation, ctrl");
            
            #line 48 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".delete");
            
            #line 48 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t");
            
            #line 50 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 foreach(DataRow row in GetColumnRow(_singleName)) 
	{ var BaseColumnName = row[(int)ColumnInfo.BaseColumnName].ToString();
	if(getIDfields(BaseColumnName,false,false)){
            
            #line default
            #line hidden
            this.Write("\r\nrouter\r\n    .route(\'/");
            
            #line 55 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(removeId(BaseColumnName)));
            
            #line default
            #line hidden
            this.Write("/:");
            
            #line 55 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BaseColumnName));
            
            #line default
            #line hidden
            this.Write("(\\\\d+)/\')\r\n    .get(middleware.requireAuthentication, middleware.requireAuthorisa" +
                    "tion, ctrl");
            
            #line 56 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".get");
            
            #line 56 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_pluralName)));
            
            #line default
            #line hidden
            this.Write("By");
            
            #line 56 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(BaseColumnName)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 57 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
}}
            
            #line default
            #line hidden
            
            #line 58 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
if (_codetable == true){
            
            #line default
            #line hidden
            
            #line 59 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
if (_singleName != "item"){
            
            #line default
            #line hidden
            this.Write("router\r\n    .route(\'/dropdown\')\r\n\t.get(middleware.requireAuthentication, middlewa" +
                    "re.requireAuthorisation, ctrl");
            
            #line 62 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".get");
            
            #line 62 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_pluralName)));
            
            #line default
            #line hidden
            this.Write("Dropdown);\r\n");
            
            #line 63 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n");
            
            #line 64 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
if (_singleName == "item"){
            
            #line default
            #line hidden
            this.Write("router\r\n    .route(\'/list/:listId(\\\\d+)/dropdown/\')\r\n\t.get(middleware.requireAuth" +
                    "entication, middleware.requireAuthorisation, ctrl");
            
            #line 67 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_singleName)));
            
            #line default
            #line hidden
            this.Write(".get");
            
            #line 67 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstUpper(_pluralName)));
            
            #line default
            #line hidden
            this.Write("Dropdown);\r\n");
            
            #line 68 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 } 
            
            #line default
            #line hidden
            
            #line 69 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n");
            
            #line 70 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 var _nongenerated = ""; 
            
            #line default
            #line hidden
            
            #line 71 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
 if ( (_singleName == "user") ) { 
    string path = System.IO.Directory.GetParent(Environment.CurrentDirectory).FullName.Replace("\\bin","") +"\\api_code\\v1\\api\\routes\\nongenerated\\"+ _singleName +".router.js";
     if (File.Exists(path)) {
	  _nongenerated = File.ReadAllText(path); 
	 }
 	}

            
            #line default
            #line hidden
            
            #line 78 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\Router.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_nongenerated));
            
            #line default
            #line hidden
            this.Write("\r\nmodule.exports = router");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\..\..\..\..\shared\helper.ttinclude"

 

public string  ruleBookFields = " include: [{model: db.ruleBook, attributes: ['id', 'active','name','processflags']}]";
public string  userAttributesList = "'id','firstName','lastName','email'";
public string  ruleBookAttributesList = "id', 'active', 'name', 'processflags'";
public string codeTableAttributesList = "'id', 'active', 'parentListId', 'name', 'code', 'ruleBookId'";

public enum ColumnInfo
{
	AllowDBNull = 0,
	BaseCatalogName =  1,
	BaseColumnName = 2,
	BaseSchemaName = 3,
	BaseTableName = 4,
	ColumnName = 5,
	ColumnOrdinal = 6,
	ColumnSize = 7,
	DataType = 8,
	IsUnique = 9,
	IsKey = 10,
	IsAliased = 11,
	IsExpression = 12,
	IsIdentity = 13,
	IsAutoIncrement = 14,
	IsRowVersion = 15,
	IsHidden = 16,
	IsLong = 17,
	IsReadOnly = 18,
	NumericPrecision = 19,
	NumericScale = 20,
	ProviderSpecificDataType = 21,
	ProviderType = 22 
}


        
        #line default
        #line hidden
        
        #line 38 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\templategenerator\v1\api_code\v1\api\routes\..\..\..\..\shared\helper.ttinclude"
 
IEnumerable<string> GetColumnDetails()  
{ 

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Houses22;Database=d2d_v1;");
            conn.Open();

            // Define a query
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM users", conn);

             
            using (var reader = command.ExecuteReader(CommandBehavior.SchemaOnly))
            {
			 DataTable schemaTable = reader.GetSchemaTable();

                foreach (DataRow row in schemaTable.Rows)
                {

                    foreach (DataColumn col in schemaTable.Columns)
                    yield return col.ColumnName as string; ;
 
                }

		} 
} 
 
 


IEnumerable<DataRow> GetColumnRow(string tableName  )  
{ 
			//tableName = tableName.ToString().ToLower();
			
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Houses22;Database=d2d_v1;");
            conn.Open();

			StringBuilder sb = new StringBuilder();
 
		    sb.Append(" SELECT * FROM ");
			sb.Append("\"");
			sb.Append(tableName);
			sb.Append("\"");

	       // Define a query
            NpgsqlCommand command = new NpgsqlCommand(sb.ToString(), conn);

             
            using (var reader = command.ExecuteReader(CommandBehavior.SchemaOnly))
            {
			 DataTable schemaTable = reader.GetSchemaTable();

                foreach (DataRow row in schemaTable.Rows)
                {

					yield return row as DataRow; ;
                    //foreach (DataColumn col in schemaTable.Columns)
                    //yield return row as DataRow; ;
 
                }

		} 
		 conn.Close();
} 

public bool allowFields(string columnName,bool includeTenant, bool includeId, bool includeBy ,bool includeAt )  
{
  if (
      (columnName == "password_hash") ||
      (columnName == "salt")  ||
	  ((columnName == "tenantId") && (includeTenant == false)) ||
	  ((columnName == "updatedBy") && (includeBy == false)) ||
	  ((columnName == "createdBy") && (includeBy == false)) ||
	  ((columnName == "updatedAt") && (includeAt == false)) ||
	  ((columnName == "createdAt") && (includeAt == false)) ||
	  ((columnName == "id") && (includeId == false))  )
  {
    return false;
  }
	return true;
}
 
public bool allowType(string whatType,string columnName,string columnType,bool includeTenant, bool includeId, bool includeBy, bool includeAt  )  
{
   if (whatType == columnType)   
   {
	 if (((columnName == "tenantId") && (includeTenant == false)) ||
	    ((columnName == "updatedBy") && (includeBy == false)) ||
	    ((columnName == "createdBy") && (includeBy == false)) ||
	    ((columnName == "updatedAt") && (includeAt == false)) ||
	    ((columnName == "createdAt") && (includeAt == false)) ||
	    ((columnName == "id") && (includeId == true))  ) {
	       return false;
	    } else {
		return true;
	  }
   }  
 
   return false;
  
}							

public bool getIDfields(string columnName,bool includeTenant, bool includeId    )  
{
   if (getLastChars(columnName,2) == "Id")   
   {
	 if (((columnName == "tenantId") && (includeTenant == false)) ||
	    ((columnName == "id") && (includeId == false))  ) {
	       return false;
	    } else {
		return true;
	  }
   }  
 
   return false;
  
}	


public bool isCodeTable(string columnName )  
{
   if (getLastChars(columnName,2) == "Id")   
   {
		return true;
	}else {
		return false;
	  }
}	 

public bool getIDfieldsForInclude(string columnName,bool includeTenant, bool includeId    )  
{
   if (getLastChars(columnName,2) == "Id")   
   {
	 if (((columnName == "tenantId") && (includeTenant == false)) ||
	    ( (columnName == "parentListId")) ||
	    ((columnName == "id") && (includeId == false))  ) {
	       return false;
	    } else {
		return true;
	  }
   }  
 
   return false;
  
}	 
public string getLastChars( string source,  int tail_length) 
{
    {
       if(tail_length >= source.Length)
          return source;
       return source.Substring(source.Length - tail_length);
    }
}

public string firstUpper(string str)
{
    if (String.IsNullOrEmpty(str)) return str;
    if (str.Length == 1) return str.ToUpper();
    return str.Remove(1).ToUpper() + str.Substring(1);
}

public string removeId(string str)
{
    return str.Remove(str.Length - 2);
}

public string getCsharpType(string str,bool convertDateToString)
{
    if ( str == "System.Int32") return "number";
    if ( str == "System.String") return "string";
    if ( str == "System.Boolean") return "boolean";
    if (( str == "System.DateTime") && (convertDateToString == true)) return "string";
    if (( str == "System.DateTime") && (convertDateToString == false)) return "Date";
 
	return str;
}
 
public string getCopyright()
{


	var copyRight = "";
    copyRight = "Copyright 2016 Olympus Consultancy Limited - All Rights Reserved "; 
    copyRight =  copyRight + Environment.NewLine + " " + "You may NOT use, copy, distribute or modify this code unless you have written " ; 
    copyRight =  copyRight + Environment.NewLine + " " + "consent from the author which may be obtained from emailing dave@ocl.ie " ; 
	return copyRight;
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class RouterBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
