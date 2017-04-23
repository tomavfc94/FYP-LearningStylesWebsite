namespace Coventry_University_Learning_Styles.Models
{
    public class UserSessionResults
    {
        public UserSessionResults() { }

        public int? IndividualSessionID { get; set; }
        public string Result { get; set; }
        public string BestLearningStyle { get; set; }
        public decimal CurrentHighestPercent { get; set; }
        public decimal VisualPercent { get; set; }
        public decimal AuralPercent { get; set; }
        public decimal ReadWritePercent { get; set; }
        public decimal KineastheticPercent { get; set; }
        public bool SatisfiedYes { get; set; }
        public bool SatisfiedNo { get; set; }
        public string ReasonNotSatisfied { get; set; } 
    }
}