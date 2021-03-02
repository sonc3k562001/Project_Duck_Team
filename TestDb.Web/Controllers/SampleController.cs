using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Xml;
using System.Reflection;

namespace TestDb.Web.Controllers
{
    public class SampleController : Controller
    {
	string menuFilename = "menuitems.xml";

        public SampleController()
        {

        }

        public ActionResult Page(string id)
        {
            return View(@"\SampleViews\" + id + ".cshtml");
        }

        public JsonResult MenuItems()
        {
            var listMenuItems = new List<object>();
            string pathDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var menuFilePath = Path.Combine(pathDir, menuFilename);
            using (StreamReader sr = new StreamReader(menuFilePath))
            {
                using (XmlReader reader = XmlReader.Create(sr))
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "menuitem"))
                        {
                            listMenuItems.Add(new { Title = reader.GetAttribute("title"), Route = reader.GetAttribute("route") });
                        }
                    }
                    reader.Close();
                }
                sr.Close();
            }
            return Json(listMenuItems.ToList());
        }

    }
}