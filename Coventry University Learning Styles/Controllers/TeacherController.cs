using Coventry_University_Learning_Styles.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Coventry_University_Learning_Styles.Controllers
{ 
    public class TeacherController : Controller
    {
        private covunilsdbEntities db = new covunilsdbEntities();

        public ActionResult Results(int ClassCodeID)
        {
            ClassResultsViewModel ClassResults = new ClassResultsViewModel();
            List<SessionResult> SessionResults = db.SessionResults.Where(s => s.IndividualSession.ClassCodeID == ClassCodeID).ToList();

            int TotalAuralCount = (int)SessionResults.Sum(s => s.AuralPercent);
            int TotalKineastheticCount = (int)SessionResults.Sum(s => s.KineastheticPercent);
            int TotalReadWriteCount = (int)SessionResults.Sum(s => s.ReadWritePercent);
            int TotalVisualCount = (int)SessionResults.Sum(s => s.VisualPercent);
            
            //Total Of All Learning Styles For The Percentages
            int Total = (TotalAuralCount + TotalKineastheticCount + TotalReadWriteCount + TotalVisualCount);

            if (Total != 0)
            {
                decimal TotalAuralPercentage = ((decimal)TotalAuralCount / Total) * 100;
                decimal TotalKineastheticPercentage = ((decimal)TotalKineastheticCount / Total) * 100;
                decimal TotalReadWritePercentage = ((decimal)TotalReadWriteCount / Total) * 100;
                decimal TotalVisualPercentage = ((decimal)TotalVisualCount / Total) * 100;

                ClassResults.TotalAuralPercentage = TotalAuralPercentage;
                ClassResults.TotalKineastheticPercentage = TotalKineastheticPercentage;
                ClassResults.TotalReadWritePercentage = TotalReadWritePercentage;
                ClassResults.TotalVisualPercentage = TotalVisualPercentage;

                decimal CurrentHighestPercent = 0;

                CurrentHighestPercent = TotalAuralPercentage;

                //set Aural to true as this is the first value
                bool Aural = true;
                bool Kinesthetic = false;
                bool ReadWrite = false;
                bool Visual = false;

                if (TotalKineastheticPercentage > CurrentHighestPercent)
                {
                    Kinesthetic = true;
                    Aural = false;
                    ReadWrite = false;
                    Visual = false;
                    CurrentHighestPercent = TotalKineastheticPercentage;
                }

                if (TotalReadWritePercentage > CurrentHighestPercent)
                {
                    ReadWrite = true;
                    Aural = false;
                    Kinesthetic = false;
                    Visual = false;
                    CurrentHighestPercent = TotalReadWritePercentage;
                }

                if (TotalVisualPercentage > CurrentHighestPercent)
                {
                    Visual = true;
                    Aural = false;
                    ReadWrite = false;
                    Kinesthetic = false;
                    CurrentHighestPercent = TotalVisualPercentage;
                }

                if (TotalAuralPercentage == CurrentHighestPercent)
                {
                    Aural = true;
                }

                if (TotalKineastheticPercentage == CurrentHighestPercent)
                {
                    Kinesthetic = true;
                }

                if (TotalReadWritePercentage == CurrentHighestPercent)
                {
                    ReadWrite = true;
                }

                if (TotalVisualPercentage == CurrentHighestPercent)
                {
                    Visual = true;
                }

                ResultsBreakdown Breakdown = new ResultsBreakdown();

                ClassResults.ClassResult += Breakdown.ResultBreakdown(Kinesthetic, Aural, ReadWrite, Visual);

                ClassResults.Students = db.Students.Where(s => s.ClassCodeID == 1).ToList();

                return View(ClassResults);
            }

            return View();
        }

        public ActionResult DrawLearningStylesBarChart (decimal TotalAuralPercentage, decimal TotalKineastheticPercentage, decimal TotalReadWritePercentage, decimal TotalVisualPercentage)
        {
            IEnumerable<decimal> LearningStylePercentages = new[] { TotalAuralPercentage, TotalKineastheticPercentage, TotalReadWritePercentage, TotalVisualPercentage };

            return PartialView("LearningStylesBarChart", LearningStylePercentages);
        }

        public ActionResult DrawLearningStylesLineChart(decimal TotalAuralPercentage, decimal TotalKineastheticPercentage, decimal TotalReadWritePercentage, decimal TotalVisualPercentage)
        {
            IEnumerable<decimal> LearningStylePercentages = new[] { TotalAuralPercentage, TotalKineastheticPercentage, TotalReadWritePercentage, TotalVisualPercentage };

            return PartialView("LearningStylesLineChart", LearningStylePercentages);
        }

        public ActionResult DrawLearningStylesPieChart(decimal TotalAuralPercentage, decimal TotalKineastheticPercentage, decimal TotalReadWritePercentage, decimal TotalVisualPercentage)
        {
            IEnumerable<decimal> LearningStylePercentages = new[] { TotalAuralPercentage, TotalKineastheticPercentage, TotalReadWritePercentage, TotalVisualPercentage };

            return PartialView("LearningStylesPieChart", LearningStylePercentages);
        }

        public ActionResult OpenStudentProfile(int StudentID)
        {
            Student Student = db.Students.Find(StudentID);

            List<LearningDifficulty> LearningDifficulties = new List<LearningDifficulty>();

            List<int> LearningDifficultiesIDs = db.StudentLearningDifficulties.Where(l => l.StudentID == StudentID).Select(l => l.LearningDifficultyID).ToList();

            foreach (int LearningDifficulty in LearningDifficultiesIDs)
            {
                LearningDifficulty Difficulty = db.LearningDifficulties.Find(LearningDifficulty);
                LearningDifficulties.Add(Difficulty);
            }

            StudentProfileViewModel StudentProfile = new StudentProfileViewModel();

            StudentProfile.Student = Student;
            StudentProfile.LearningDifficulties = LearningDifficulties;

            return View("OpenStudentProfile", StudentProfile);
        }

        public ActionResult Home(int? ClassCodeID)
        {
            if (ClassCodeID != null)
            {
                return RedirectToAction("Results", new { ClassCodeID = ClassCodeID });
            }

            TeacherHomeViewModel TeacherHome = new TeacherHomeViewModel();

            TeacherHome.ClassCodes = new SelectList(db.ClassCodes.ToList(), "ID", "Code");

            return View(TeacherHome);
        }
    }
}