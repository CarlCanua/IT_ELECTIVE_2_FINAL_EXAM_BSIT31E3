using System.Diagnostics;
using System.Reflection;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31E3.Controllers
{
    // BASE CONTROLLER FOR THE 31E3 PORTFOLIO.
    //
    // Add each student's portfolio controller in this same Controllers folder.
    // Each student controller should use [Classmate("Student Name")].
    // The Home page will automatically discover those controllers.
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var classmates = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(Controller).IsAssignableFrom(t) && !t.IsAbstract)
                .Select(t => new
                {
                    Type = t,
                    Attribute = t.GetCustomAttribute<ClassmateAttribute>()
                })
                .Where(x => x.Attribute != null)
                .OrderBy(x => x.Attribute!.Name)
                .Select(x => new ClassmateListItem
                {
                    Name = x.Attribute!.Name,
                    ControllerName = x.Type.Name.Replace("Controller", "")
                })
                .ToList();

            return View(classmates);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
