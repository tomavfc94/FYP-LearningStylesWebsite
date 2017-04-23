using System.Web.Mvc;

namespace Coventry_University_Learning_Styles.Models
{
    public class TeacherHomeViewModel
    {
        public TeacherHomeViewModel() { }

        public int ClassCodeID { get; set; }
        public SelectList ClassCodes;
    }
}