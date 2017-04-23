
using System.Collections.Generic;

namespace Coventry_University_Learning_Styles.Models
{
    public class ClassResultsViewModel
    {
        public ClassResultsViewModel() { }

        public string ClassResult { get; set; }
        public decimal TotalAuralPercentage { get; set; }
        public decimal TotalKineastheticPercentage { get; set; }
        public decimal TotalReadWritePercentage { get; set; }
        public decimal TotalVisualPercentage { get; set; }
        public List<Student> Students { get; set; }
        public bool Satisfied { get; set; }
        public bool NotSatisfied { get; set; }
        public string Reason { get; set; }
    }
}