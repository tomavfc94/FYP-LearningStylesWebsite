using System.Collections.Generic;

namespace Coventry_University_Learning_Styles.Models
{
    public class StudentProfileViewModel 
    {
        public StudentProfileViewModel() { }

        public Student Student { get; set; } 
        public List<LearningDifficulty> LearningDifficulties { get; set; }
    }
}