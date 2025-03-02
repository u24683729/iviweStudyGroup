using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iviweStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudyGroup()
        {
            List<Models.Student> people = new List<Models.Student>();
            people.Add(new Models.Student { Std_ID = 24683729, Std_Name = "Iviwe", Std_Surname = "Vikwa", Std_Email = "u24683729@tuks.co.za" });
            people.Add(new Models.Student { Std_ID = 23784718, Std_Name = "Thina", Std_Surname = "Magqira", Std_Email = "u23784718@tuks.co.za" });
            people.Add(new Models.Student { Std_ID = 24979962, Std_Name = "Sivuyisiwe", Std_Surname = "Ngalo", Std_Email = "u24979962@tuks.co.za" });
            people.Add(new Models.Student { Std_ID = 23641925, Std_Name = "Nkhensani", Std_Surname = "Notigo", Std_Email = "u23641925@tuks.co.za" });
            people.Add(new Models.Student { Std_ID = 24885062, Std_Name = "Tumisho", Std_Surname = "Matlala", Std_Email = "u24885062@tuks.co.za" });
            return View(people);
        }

    }

}