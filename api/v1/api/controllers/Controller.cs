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
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class Controller : ControllerBase
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
            this.Write("\r\n/******************************************************************************" +
                    "************************\r\n \r\n ");
            
            #line 18 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(getCopyright()));
            
            #line default
            #line hidden
            this.Write(@"

******************************************************************************************************/

/******************************************************************************************************
 controller layer
******************************************************************************************************/
""use strict"";
var db = require('../.././db.js');
var _ = require('underscore');
var constants = require('../.././shared/constant.shared');
var helpers = require('../.././shared/helpers.shared');
var common = require('./extensions/common.extension');
var extension = require('./extensions/");
            
            #line 31 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".extension\');\r\nvar controller = \"user\";\r\nvar Sequelize = require(\'sequelize\');\r\n");
            
            #line 34 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
 if (_singleName == "user")  { 
            
            #line default
            #line hidden
            this.Write(" \r\n/*****************************************************************************" +
                    "*************************\r\n Login \r\n********************************************" +
                    "**********************************************************/\r\nmodule.exports.user" +
                    "sLogin = function(req, res) {\r\n    var body = _.pick(req.body, \'email\', \'passwor" +
                    "d\');\r\n    var userInstance;\r\n\r\n    db.user.authenticate(body).then(function(user" +
                    ") {\r\n        var token = user.generateToken(\'authentication\');\r\n        userInst" +
                    "ance = user;\r\n        return db.token.create({\r\n            token: token\r\n      " +
                    "  });\r\n    }).then(function(tokenInstance) {\r\n        // could not read header i" +
                    "n angular client so I jused used the response to send back the token\r\n        //" +
                    "res.header(\'Auth\', tokenInstance.get(\'token\')).json(userInstance.toPublicJSON())" +
                    ";\r\n        res.status(200).json({\r\n            message: \'Signin Successful\',\r\n  " +
                    "          token: tokenInstance.get(\'token\'),\r\n            user: userInstance.toP" +
                    "ublicJSON()\r\n        }) \r\n    }).catch(function() {\r\n        res.status(400).jso" +
                    "n({\"err\": {\"name\": \"authorisation\", \"message\": \"Signin UnSuccessful\"  }}   );\r\n " +
                    "   });\r\n};\r\n\r\n/*****************************************************************" +
                    "*************************************\r\n Logout \r\n*******************************" +
                    "***********************************************************************/\r\nmodule" +
                    ".exports.usersLogout = function(req, res) {\r\n    req.token.destroy().then(functi" +
                    "on() {\r\n        res.status(204).send();\r\n    }).catch(function(err) {\r\n        r" +
                    "es.status(500).json(err);\r\n    });\r\n};\r\n");
            
            #line 71 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n/*****************************************************************************" +
                    "*************************\r\n Insert a Record \r\n**********************************" +
                    "********************************************************************/\r\nmodule.ex" +
                    "ports.");
            
            #line 75 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write("Post = function(req, res) {\r\n\r\n    // pick appropiate fields");
            
            #line 77 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
if (_tenantRequired == true){
            
            #line default
            #line hidden
            this.Write(" and set tenant  ");
            
            #line 77 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n    var body = extension.setPost(req, \'C\');\r\n               \r\n    db.");
            
            #line 80 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".create(body).then(function(");
            
            #line 80 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n        res.json(");
            
            #line 81 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(@".toPublicJSON())
    }).catch(Sequelize.ValidationError, function(err) {
         res.status(422).send(err.errors);
    }).catch(function(err) {
        res.status(400).json(err);
    });
};

/******************************************************************************************************
 Get All Records 
******************************************************************************************************/
module.exports.");
            
            #line 92 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write("GetAll = function(req, res) {\r\n\r\n    // builds clause \r\n    var where = {};\r\n    " +
                    "where = common.setClauseAll(req, where);\r\n    where = extension.setClauseQuery(r" +
                    "eq.query, where);\r\n\t");
            
            #line 98 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
if (_tenantRequired == true){
            
            #line default
            #line hidden
            this.Write("where = common.setClauseTenantId(req, where);");
            
            #line 98 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\r\n    var attributes = common.setAttributes();\r\n\r\n    db.");
            
            #line 102 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".findAll({\r\n        attributes: attributes,\r\n        where: where\r\n    }).then(fu" +
                    "nction(");
            
            #line 105 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write(") {\r\n        res.json(");
            
            #line 106 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write(@");
    }, function(err) {
        res.status(500).json(err);
    })
};

/******************************************************************************************************
 Get a Record by Id
******************************************************************************************************/
module.exports.");
            
            #line 115 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write("GetById = function(req, res) {\r\n\r\n    // builds clause\r\n    var where = {};\r\n    " +
                    "where = common.setClauseId(req, where);\r\n\t");
            
            #line 120 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
if (_tenantRequired == true){
            
            #line default
            #line hidden
            this.Write("where = common.setClauseTenantId(req, where);");
            
            #line 120 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" \r\n\r\n    var attributes = common.setAttributes();\r\n\r\n    //find and return the re" +
                    "cords \r\n    db.");
            
            #line 125 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".findOne({\r\n        attributes: attributes,\r\n        where: where\r\n    }).then(fu" +
                    "nction(");
            
            #line 128 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n        if (!!");
            
            #line 129 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n            res.json(");
            
            #line 130 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".toPublicJSON());\r\n        } else {\r\n            res.status(404).json({\"err\": {\"n" +
                    "ame\": \"");
            
            #line 132 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(@""", ""message"": ""An error occurred retrieving the record""  }});
        }
    }, function(err) {
        res.status(500).json(err);
    })
};

/******************************************************************************************************
 Update a Record 
******************************************************************************************************/
module.exports.");
            
            #line 142 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write(@"Put = function(req, res) {

    // pick appropiate fields 
    var body = extension.setPost(req, 'U');

    // set the attributes to update
    var attributes = extension.prepareForUpdate(body);

    // builds clause
    var where = {};
    where = common.setClauseId(req, where);
    ");
            
            #line 153 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
if (_tenantRequired == true){
            
            #line default
            #line hidden
            this.Write("where = common.setClauseTenantId(req, where);");
            
            #line 153 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n    // find record on database, update record and return to client\r\n    db.");
            
            #line 156 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".findOne({\r\n        where: where\r\n    }).then(function(");
            
            #line 158 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n        if (");
            
            #line 159 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n            ");
            
            #line 160 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".update(attributes).then(function(");
            
            #line 160 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(") {\r\n                res.json(");
            
            #line 161 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".toPublicJSON());\r\n            }, function(err) {\r\n                res.status(400" +
                    ").json(err);\r\n            });\r\n        } else {\r\n             res.status(404).js" +
                    "on({\"err\": {\"name\": \"");
            
            #line 166 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(@""", ""message"": ""An error occurred retrieving the record""}});
        }
    }, function(err) {
        res.status(500).json(err);
    });
};

/******************************************************************************************************
 Delete a Record 
******************************************************************************************************/
module.exports.");
            
            #line 176 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_pluralName));
            
            #line default
            #line hidden
            this.Write("Delete = function(req, res) {\r\n\r\n    // builds clause\r\n    var where = {};\r\n    w" +
                    "here = common.setClauseId(req, where);\r\n    ");
            
            #line 181 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
if (_tenantRequired == true){
            
            #line default
            #line hidden
            this.Write("where = common.setClauseTenantId(req, where);");
            
            #line 181 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n    // delete record on database\r\n    db.");
            
            #line 184 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write(".destroy({\r\n        where: where\r\n    }).then(function(rowsDeleted) {\r\n        if" +
                    " (rowsDeleted === 0) {\r\n            res.status(404).json({ \"err\": { \"name\": \"");
            
            #line 188 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\api\v1\api\controllers\Controller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_singleName));
            
            #line default
            #line hidden
            this.Write("\", \"message\": \"An error occurred retrieving the record\"}});\r\n        } else {\r\n  " +
                    "          res.status(204).send();\r\n        }\r\n    }, function(err) {\r\n        re" +
                    "s.status(500).json(err);\r\n    });\r\n};");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\TemplateGenerator\shared\helper.ttinclude"

 


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
        
        #line 34 "C:\SkyDrive\Lenovo\Olympus\Products\d2d\system\generator\v1\TemplateGenerator\shared\helper.ttinclude"
 
IEnumerable<string> GetColumnDetails()  
{ 

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Houses22;Database=d2d;");
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

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Houses22;Database=d2d;");
            conn.Open();

            // Define a query
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM " + tableName, conn);

             
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

public bool allowFields(string columnName,bool includeTenant, bool includeId, bool includeBy  )  
{
  if ((columnName == "updatedAt") ||
      (columnName == "createdAt") ||
      (columnName == "password_hash") ||
      (columnName == "salt")  ||
	  ((columnName == "tenantId") && (includeTenant == false)) ||
	  ((columnName == "updatedBy") && (includeBy == false)) ||
	  ((columnName == "createdBy") && (includeBy == false)) ||
	  ((columnName == "id") && (includeId == false))  )
  {
    return false;
  }
	return true;
}
 
public bool allowType(string whatType,string columnName,string columnType,bool includeTenant, bool includeId, bool includeBy  )  
{
   if (whatType == columnType)   
   {
	 if (((columnName == "tenantId") && (includeTenant == false)) ||
	    ((columnName == "updatedBy") && (includeBy == false)) ||
	    ((columnName == "createdBy") && (includeBy == false)) ||
	    ((columnName == "id") && (includeId == false))  ) {
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
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
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
    public class ControllerBase
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
