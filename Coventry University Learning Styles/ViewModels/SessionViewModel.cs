using System.Collections.Generic;
using System.Web.Mvc;

namespace Coventry_University_Learning_Styles.Models
{
    public class UserSession
    {
        public UserSession() { }

        public int? IndividualSessionID { get; set; }
        public int GenderID { get; set; }
        public int AgeID { get; set; }
        public int EthnicityID { get; set; }
        public int ClassCodeID { get; set; }
        public int AuralCount { get; set; }
        public int KineastheticCount { get; set; }
        public int ReadWriteCount { get; set; } 
        public int VisualCount { get; set; }

        public SelectList ClassCodes;

        //Question 1        
        public bool Q1_Aural { get; set; }
        public bool Q1_Kineasthetic { get; set; }
        public bool Q1_ReadWrite { get; set; }
        public bool Q1_Visual { get; set; }

        //Question 2
        public bool Q2_Aural { get; set; }
        public bool Q2_Kineasthetic { get; set; }
        public bool Q2_ReadWrite { get; set; }
        public bool Q2_Visual { get; set; }


        //Question 3
        public bool Q3_Aural { get; set; }
        public bool Q3_Kineasthetic { get; set; }
        public bool Q3_ReadWrite { get; set; }
        public bool Q3_Visual { get; set; }


        //Question 4
        public bool Q4_Aural { get; set; }
        public bool Q4_Kineasthetic { get; set; }
        public bool Q4_ReadWrite { get; set; }
        public bool Q4_Visual { get; set; }


        //Question 5
        public bool Q5_Aural { get; set; }
        public bool Q5_Kineasthetic { get; set; }
        public bool Q5_ReadWrite { get; set; }
        public bool Q5_Visual { get; set; }


        //Question 6
        public bool Q6_Aural { get; set; }
        public bool Q6_Kineasthetic { get; set; }
        public bool Q6_ReadWrite { get; set; }
        public bool Q6_Visual { get; set; }


        //Question 7
        public bool Q7_Aural { get; set; }
        public bool Q7_Kineasthetic { get; set; }
        public bool Q7_ReadWrite { get; set; }
        public bool Q7_Visual { get; set; }


        //Question 8
        public bool Q8_Aural { get; set; }
        public bool Q8_Kineasthetic { get; set; }
        public bool Q8_ReadWrite { get; set; }
        public bool Q8_Visual { get; set; }


        //Question 9
        public bool Q9_Aural { get; set; }
        public bool Q9_Kineasthetic { get; set; }
        public bool Q9_ReadWrite { get; set; }
        public bool Q9_Visual { get; set; }


        //Question 10
        public bool Q10_Aural { get; set; }
        public bool Q10_Kineasthetic { get; set; }
        public bool Q10_ReadWrite { get; set; }
        public bool Q10_Visual { get; set; }


        //Question 11
        public bool Q11_Aural { get; set; }
        public bool Q11_Kineasthetic { get; set; }
        public bool Q11_ReadWrite { get; set; }
        public bool Q11_Visual { get; set; }


        //Question 12
        public bool Q12_Aural { get; set; }
        public bool Q12_Kineasthetic { get; set; }
        public bool Q12_ReadWrite { get; set; }
        public bool Q12_Visual { get; set; }


        //Question 13
        public bool Q13_Aural { get; set; }
        public bool Q13_Kineasthetic { get; set; }
        public bool Q13_ReadWrite { get; set; }
        public bool Q13_Visual { get; set; }


        //Question 14
        public bool Q14_Aural { get; set; }
        public bool Q14_Kineasthetic { get; set; }
        public bool Q14_ReadWrite { get; set; }
        public bool Q14_Visual { get; set; }


        //Question 15
        public bool Q15_Aural { get; set; }
        public bool Q15_Kineasthetic { get; set; }
        public bool Q15_ReadWrite { get; set; }
        public bool Q15_Visual { get; set; }


        //Question 16
        public bool Q16_Aural { get; set; }
        public bool Q16_Kineasthetic { get; set; }
        public bool Q16_ReadWrite { get; set; }
        public bool Q16_Visual { get; set; }
    }
}