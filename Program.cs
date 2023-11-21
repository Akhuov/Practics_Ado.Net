using Practics__001_Ado.Net;
using System.Configuration;


//var r = new Config();
//r.SafeToConfigConnectionString();


string? strOfCon = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
Console.WriteLine(strOfCon);