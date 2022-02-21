using HyggeLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HyggeWS
{
    /// <summary>
    /// Summary description for HyggeService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HyggeService : System.Web.Services.WebService
    {
        [WebMethod]
        public string FetchPoem(string fileName) //Method to fetch file content using fileName from user (Eclipse --> WS)
        {
            if (fileName == null)                //Null check
            {
                return "Error: File was not found";
            }

            string path = @"C:\poems\" + fileName;  //Creating a path string to be used later to find the correct file

            try
            {
                string text = File.ReadAllText(path);   //Put content of a file in string using the path created above
                return text;        //Return the file content
            }
            catch (FileNotFoundException ex)    //Catching FileNotFoundException in case File.ReadAllText throws it
            {
                return "Error: No file with file name " + fileName; //If the file was not found, return error message
            }
        }
    }



}

