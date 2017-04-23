namespace Coventry_University_Learning_Styles.Models
{
    public class ResultsBreakdown
    {
        public ResultsBreakdown() { }

        public string ResultBreakdown(bool Kineasthetic, bool Aural, bool ReadWrite, bool Visual)
        {
            string BreakdownRecommendation = "";

            if (Kineasthetic == true && Aural == true && ReadWrite == true && Visual == true)
            {
                BreakdownRecommendation = "The class all are identically split between learning styles. \nTherefore to effectively target every student you would need to give each style equal time. This will mean that every student will be reached within their preferred method.";
            }
            else if (Kineasthetic == true)
            {
                BreakdownRecommendation = "The class favours a strong preference towards a kineasthetic style. \nTherefore targeting this style will reach the most students. \nTo target this preference you may wish to get them to try a few tasks. This could involve giving them a demonstration but getting them to follow each step at the same time. This way they will memorize the actions as they are DOING them.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>examples of principles</li>
                    <li>give real-life examples</li>
                    <li>applications</li>
                    <li>hands-on approaches</li>
                    <li>trial and error</li>
                    <li>exhibits, samples, photographs</li>
                    <li>solutions to problems, previous exam papers</li>
                  </ul>";
            }
            else if (Aural == true)
            {
                BreakdownRecommendation = "The class favours a strong preference towards a Aural style. \nTherefore targeting this style will reach the most students. \nTo target this preference you may wish to involve more speaking in your class. This will mean your lectures will have been more effective. So the students may already have a good understanding of the topic, so targeting another style may be more effective.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>discussions and tutorials</li>
                    <li>get students to discuss topics with others</li>
                    <li>explain new ideas to other people</li>
                    <li>get them to use a tape recorder</li>
                    <li>remember interesting examples, stories, jokes…</li>
                    <li>get the students to describe the overheads, pictures and other visuals to somebody who was not there</li>
                    <li>tell the students to leave spaces in your notes for later recall and ‘filling’</li>
                  </ul>";
            }
            else if (ReadWrite == true)
            {
                BreakdownRecommendation = "The class favours a strong preference towards a Read/Write style. \nTherefore targeting this style will reach the most students. \nTo target this preference you may wish to write text on the screen as you teach or provide the students with documents to read. Alternatively you could recommend that they read a certain article or textbook whilst you teach other methods.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>lists</li>
                    <li>headings</li>
                    <li>dictionaries</li>
                    <li>glossaries</li>
                    <li>definitions</li>
                    <li>handouts</li>
                    <li>textbooks</li>
                  </ul>";
            }
            else if (Visual == true)
            {
                BreakdownRecommendation = "The class favours a strong preference towards a Visual style. \nTherefore targeting this style will reach the most students. \nTo target this preference you may wish to involve more diagrams/graphs or any visual representation of the topic being taught. So if it is a new programming concept a diagram show how that concept is layed i.e. layers, flow of data.\n\n You should use some or all of the following:" + 

                @"<ul>
                    <li>gestures and picturesque language</li>
                    <li>pictures, videos, posters, slides </li>
                    <li>flowcharts</li>
                    <li>underlining, different colours, highlighters</li>
                    <li>textbooks with diagrams and pictures</li>
                    <li>graphs </li>
                    <li>symbols and white          space </li>
                  </ul>";
            }
            else if (Visual == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Visual and Kinesthetic. \nTherefore to effectively target every student you would need to target both styles. Visual and Kineasthetic are slightly similar in that they both prefer not to read or listen. To target this class you could give diagrams/graphs of a new topic, whilst giving all the students steps to DO and Follow.";
            }
            else if (Visual == true && Aural == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Visual and Aural. \nTherefore to effectively target every student you would need to target both styles. Visual and Aural are slightly different from each in that one shows students prefer to see and the others prefer to listen. To target this class you could give diagrams/graphs of a new topic, whilst discussing these which would capture both style perfectly.";
            }
            else if (Visual == true && ReadWrite == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Visual and Read/Write. \nTherefore to effectively target every student you would need to target both styles. Visual and Read/Write are slightly different in that one shows students prefer to see a visual representation and the other prefers to read about it. To target this class you could give diagrams/graphs of a new topic, whilst giving all the students something to also read about, this way they can pick which one they prefer.";
            }
            else if (Aural == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Aural and Kinesthetic. \nTherefore to effectively target every student you would need to target both styles. Aural and Kineasthetic are slightly similar in that they both prefer not to read. To target this class you could give tasks to carry out whilst explaining how it works, this will give the kinesthetic learners something to DO and Aural learners the chance to listen.";
            }
            else if (Aural == true && ReadWrite == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Aural and ReadWrite. \nTherefore to effectively target every student you would need to target both styles. Aural and ReadWrite are different as one student would prefer to listen to the new topic explained, whereas the other students would prefer to read about the new topic. To target this class you could give out a document with the topic explained and also talk to the class at the same time to reach both styles.";
            }
            else if (ReadWrite == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "The class shows a preference to 2 different styles, Read/Write and Kinesthetic. \nTherefore to effectively target every student you would need to target both styles. Read/Write and Kineasthetic are different as one style prefers to read and the other prefers to DO tasks to learn. To target this class you could give textsheets or articles to read on the new topic, whilst giving all the students steps to DO and Follow.";
            }

            return BreakdownRecommendation;
        }

        public string SurveyResultBreakdown(bool Kineasthetic, bool Aural, bool ReadWrite, bool Visual)
        {
            string BreakdownRecommendation = "";

            if (Kineasthetic == true && Aural == true && ReadWrite == true && Visual == true)
            {
                BreakdownRecommendation = "Your learning style is a perfect balance between all the different styles. This means that you learn best in any manner. You will be able to learn by reading text, seeing things visually and actually doing things physically.";
            }
            else if (Kineasthetic == true)
            {
                BreakdownRecommendation = "Your learning style is more prominent to a kineasthetic style. This means you learn best by doing things. For example, you learn programming best by testing code and doing tasks.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>examples of principles</li>
                    <li>use real-life examples</li>
                    <li>applications</li>
                    <li>hands-on approaches</li>
                    <li>trial and error</li>
                    <li>exhibits, samples, photographs</li>
                    <li>solutions to problems, previous exam papers</li>
                  </ul>";
            }
            else if (Aural == true)
            {
                BreakdownRecommendation = "Your learning style is more prominent to a aural style. This means you learn best by listening to new topics. For example, you learn best by listening to a lecturer read.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>discussions and tutorials</li>
                    <li>discuss topics with others</li>
                    <li>explain new ideas to other people</li>
                    <li>use a tape recorder</li>
                    <li>remember interesting examples, stories, jokes…</li>
                    <li>describe the overheads, pictures and other visuals to somebody who was not there</li>
                    <li>leave spaces in your notes for later recall and ‘filling’</li>
                  </ul>";
            }
            else if (ReadWrite == true)
            {
                BreakdownRecommendation = "Your learning style is more prominent to a read/write style. This means you learn best by reading or writing down text. For example, you learn best by reading articles or textbooks to understand new topics.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>lists</li>
                    <li>headings</li>
                    <li>dictionaries</li>
                    <li>glossaries</li>
                    <li>definitions</li>
                    <li>handouts</li>
                    <li>textbooks</li>
                  </ul>";
            }
            else if (Visual == true)
            {
                BreakdownRecommendation = "Your learning style is more prominent to a visual style. This means you learn best by seeing things visually. For example, you learn best by viewing examples in the format of graphs and charts.\n\n You should use some or all of the following:" +

                @"<ul>
                    <li>gestures and picturesque language</li>
                    <li>pictures, videos, posters, slides </li>
                    <li>flowcharts</li>
                    <li>underlining, different colours, highlighters</li>
                    <li>textbooks with diagrams and pictures</li>
                    <li>graphs </li>
                    <li>symbols and white          space </li>
                  </ul>";
            }
            else if (Visual == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Visual and Kinesthetic. Therefore to learn a new topic effectively you could target both styles. Visual and Kineasthetic are slightly similar in that they both show you prefer not to read or listen. To learn effectively you would prefer to see an example visually like a graph or chart, or you could actually do some tasks to learn a new topic.";
            }
            else if (Visual == true && Aural == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Visual and Aural. Therefore to learn a new topic effectively you could target both styles. Visual and Aural are slightly different from each in that one shows you prefer to see something visually or you prefer to listen. To target these styles of learning you could view diagrams/graphs of a new topic, or listen about or discuss the new topic which would capture both style perfectly.";
            }
            else if (Visual == true && ReadWrite == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Visual and Read/Write. Therefore to learn a new topic effectively you could target both styles. Visual and Read/Write are slightly different in that one shows you prefer to see a visual representation and the other shows you prefers to read about it. To target these learning styles you could view diagrams/graphs of a new topic, or you could get something to also read about on the new topic, this way you can learn effectively.";
            }
            else if (Aural == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Aural and Kinesthetic. Therefore to learn a new topic effectively you could target both styles. Aural and Kineasthetic are slightly similar in that it shows you prefer not to read. To target these learning styles you could find a video to listen to a new topic, or you could do some tasks on the new topic. It is also possible to do both at the same time which would prove to be really effective in your style of learning.";
            }
            else if (Aural == true && ReadWrite == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Aural and ReadWrite. Therefore to learn a new topic effectively you could target both styles. Aural and ReadWrite are different as one shows you would prefer to listen to the new topic explained, whereas the other shows you would prefer to read about the new topic. To target these learning styles you could read a document with the topic explained and also listen to someone talk at the same time to reach both styles.";
            }
            else if (ReadWrite == true && Kineasthetic == true)
            {
                BreakdownRecommendation = "Your learning style shows a preference to 2 different styles, Read/Write and Kinesthetic. Therefore to learn a new topic effectively you could target both styles. Read/Write and Kineasthetic are different as one shows you prefers to read and the other shows you prefers to DO tasks to learn. To target these learning styles you could find articles/books to read on the new topic, or do some tasks which will help you understand the new topic.";
            }

            return BreakdownRecommendation;
        }
    }
}