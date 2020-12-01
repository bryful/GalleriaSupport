using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace FindFolder
{
	class Program
	{
		static string  header = "Content-type: text/html\n\n";

		static string [] targetDirs = new string[]{
		@" \\192.168.10.88\sv04\pool\sec\comic\00",
		@" \\192.168.10.88\sv04\pool\sec\comic\10",
		@" \\192.168.10.88\sv04\pool\sec\comic\20",
		@" \\192.168.10.88\sv04\pool\sec\comic\30",
		@" \\192.168.10.88\sv04\pool\sec\comic\40",
		@" \\192.168.10.88\sv04\pool\sec\comic\99"
		};

		static void FindFolderName(ref List<DirectoryInfo> lst, string TargetName)
		{

			foreach(string s in targetDirs)
			{
				DirectoryInfo d1 = new DirectoryInfo(s);
				if (d1.Exists == false) continue;
				DirectoryInfo[] d2 = d1.GetDirectories("*" + TargetName + "*");
				if (d2.Length>0)
				{
					foreach(DirectoryInfo d3 in d2)
					{
						lst.Add(d3);
					}
				}

			}
		}
		static void Main(string[] args)
		{
			

			string REQUEST_METHOD  = System.Environment.GetEnvironmentVariable("REQUEST_METHOD");
			bool IsGET = (REQUEST_METHOD == "GET");
			bool IsPOST = (REQUEST_METHOD == "POST");

			string getStr = "";

			if(IsGET)
			{
				getStr = Environment.GetEnvironmentVariable("QUERY_STRING");

			}
			else if(IsPOST)
			{
				int CL = int.Parse(System.Environment.GetEnvironmentVariable("CONTENT_LENGTH"));
				if (CL > 0)
				{
					Stream inputStream = Console.OpenStandardInput();
					byte[] bytes = new byte[CL];
					int outputLength = inputStream.Read(bytes, 0, CL);
					char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
					getStr = new string(chars);
				}

			}
			else
			{

			}
			string tname = "";
			string dirList = "";

			if (getStr != "")
			{

				getStr = HttpUtility.UrlDecode(getStr);

				string tn = "";
				string[] prms = new string[0];
				try
				{
					prms = getStr.Split('=');
				}
				catch
				{

				}
				if (prms.Length>=2)
				{
					if(prms[0]== "folder")
					{
						tn = prms[1];
					}
				}
				tname = tn;
				if (tn != "")
				{
					List<DirectoryInfo> lst = new List<DirectoryInfo>();
					FindFolderName(ref lst, tn);

					if (lst.Count > 0)
					{
						foreach (DirectoryInfo d in lst)
						{
							dirList += "<li>" + d.Parent.Name+"/"+ d.Name + "</li>\r\n";
						}
					}
					else
					{
						dirList += "<li>none</li>\r\n";
					}
				}


			}
			dirList = "<ul>\r\n" + dirList + "</ul>\r\n";

			FileInfo fi = new FileInfo(".\\body.html");

			string html = "$FolderPath";
			if (fi.Exists == true)
			{
				html = File.ReadAllText(fi.FullName, Encoding.GetEncoding("utf-8"));
			}
			html = html.Replace("$FolderPath", dirList);
			html = html.Replace("$TargetName", tname);

			Console.OutputEncoding = new UTF8Encoding();
			Console.WriteLine(header);
			Console.WriteLine(html);
		}
	}
}
