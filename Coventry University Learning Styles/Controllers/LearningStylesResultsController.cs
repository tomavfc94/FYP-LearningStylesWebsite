using System.Web.Mvc;
using Coventry_University_Learning_Styles.Models;
using System.Data.Entity;
using System.Collections.Generic;

namespace Coventry_University_Learning_Styles.Controllers
{
    public class LearningStylesResultsController : Controller
    {
        private covunilsdbEntities db = new covunilsdbEntities();

        public ActionResult Results(UserSession UserSession)   
        {
            if (ModelState.IsValid)
            {
                IndividualSession CurrentSession = new IndividualSession();

                CurrentSession.ClassCodeID = UserSession.ClassCodeID;

                CurrentSession.AgeID = 1;
                CurrentSession.EthinicityID = 1;
                CurrentSession.GenderID = 1;
                
                //Calculate All The Check Boxes
                AddResults(UserSession);

                //Create A New Instance Of The Results
                UserSessionResults UserResults = new UserSessionResults();

                //Total Of All Learning Styles For The Percentages
                int Total = (UserSession.AuralCount + UserSession.KineastheticCount + UserSession.ReadWriteCount + UserSession.VisualCount);

                UserResults.AuralPercent = ((decimal)UserSession.AuralCount / Total) * 100;
                UserResults.ReadWritePercent = ((decimal)UserSession.ReadWriteCount / Total) * 100;
                UserResults.KineastheticPercent = ((decimal)UserSession.KineastheticCount / Total) * 100;
                UserResults.VisualPercent = ((decimal)UserSession.VisualCount / Total) * 100;

                decimal CurrentHighestPercent = 0;

                CurrentHighestPercent = UserResults.AuralPercent;

                //set Aural to true as this is the first value
                bool Aural = true;
                bool Kinesthetic = false;
                bool ReadWrite = false;
                bool Visual = false;

                if (UserResults.KineastheticPercent > CurrentHighestPercent)
                {
                    Kinesthetic = true;
                    Aural = false;
                    ReadWrite = false;
                    Visual = false;
                    CurrentHighestPercent = UserResults.KineastheticPercent;
                }

                if (UserResults.ReadWritePercent > CurrentHighestPercent)
                {
                    ReadWrite = true;
                    Aural = false;
                    Kinesthetic = false;
                    Visual = false;
                    CurrentHighestPercent = UserResults.ReadWritePercent;
                }

                if (UserResults.VisualPercent > CurrentHighestPercent)
                {
                    Visual = true;
                    Aural = false;
                    ReadWrite = false;
                    Kinesthetic = false;
                    CurrentHighestPercent = UserResults.VisualPercent;
                }

                if (UserResults.AuralPercent == CurrentHighestPercent)
                {
                    Aural = true;
                }

                if (UserResults.KineastheticPercent == CurrentHighestPercent)
                {
                    Kinesthetic = true;
                }

                if (UserResults.ReadWritePercent == CurrentHighestPercent)
                {
                    ReadWrite = true;
                }

                if (UserResults.VisualPercent == CurrentHighestPercent)
                {
                    Visual = true;
                }

                ResultsBreakdown Breakdown = new ResultsBreakdown();

                UserResults.BestLearningStyle = Breakdown.SurveyResultBreakdown(Kinesthetic, Aural, ReadWrite, Visual);

                db.Entry(CurrentSession).State = EntityState.Added;
                db.SaveChanges();

                //Set The ID after it has been added to the database
                UserResults.IndividualSessionID = CurrentSession.ID;

                return View(UserResults);
            }

            return RedirectToAction("Survey", "LearningStylesSurvey", UserSession);
        }

        public ActionResult Finish(UserSessionResults UserResults)  
        {
            if (ModelState.IsValid)
            {
                SessionResult SessionResult = new SessionResult();

                SessionResult.IndividualSessionID = (int)UserResults.IndividualSessionID;
                SessionResult.AuralPercent = UserResults.AuralPercent;
                SessionResult.KineastheticPercent = UserResults.KineastheticPercent;
                SessionResult.ReadWritePercent = UserResults.ReadWritePercent;
                SessionResult.VisualPercent = UserResults.VisualPercent;
                SessionResult.Results = UserResults.BestLearningStyle;

                db.Entry(SessionResult).State = EntityState.Added;
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home", new { });
        }

        public ActionResult DrawLearningStylesBarChart(decimal TotalAuralPercentage, decimal TotalKineastheticPercentage, decimal TotalReadWritePercentage, decimal TotalVisualPercentage)
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

        public void AddResults(UserSession UserSession)
        {
            //Add Aural
            if (UserSession.Q1_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q2_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q3_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q4_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q5_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q6_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q7_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q8_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q9_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q10_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q11_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q12_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q13_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q14_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q15_Aural)
                UserSession.AuralCount += 1;
            if (UserSession.Q16_Aural)
                UserSession.AuralCount += 1;

            //Add Kineasthetic
            if (UserSession.Q1_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q2_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q3_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q4_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q5_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q6_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q7_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q8_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q9_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q10_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q11_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q12_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q13_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q14_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q15_Kineasthetic)
                UserSession.KineastheticCount += 1;
            if (UserSession.Q16_Kineasthetic)
                UserSession.KineastheticCount += 1;

            //Add ReadWrite
            if (UserSession.Q1_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q2_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q3_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q4_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q5_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q6_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q7_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q8_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q9_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q10_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q11_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q12_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q13_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q14_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q15_ReadWrite)
                UserSession.ReadWriteCount += 1;
            if (UserSession.Q16_ReadWrite)
                UserSession.ReadWriteCount += 1;

            //Add Visual
            if (UserSession.Q1_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q2_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q3_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q4_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q5_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q6_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q7_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q8_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q9_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q10_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q11_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q12_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q13_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q14_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q15_Visual)
                UserSession.VisualCount += 1;
            if (UserSession.Q16_Visual)
                UserSession.VisualCount += 1;
        }
    }
}