using Coventry_University_Learning_Styles.Models;
using System.Linq;
using System.Web.Mvc;

namespace Coventry_University_Learning_Styles.Controllers
{
    public class LearningStylesSurveyController : Controller
    {
        private covunilsdbEntities db = new covunilsdbEntities(); 

        public ActionResult Survey()
        {
            UserSession Session = new UserSession();

            Session.ClassCodes = new SelectList(db.ClassCodes.ToList(), "ID", "Code");

            return View(Session);
        } 
    }
}