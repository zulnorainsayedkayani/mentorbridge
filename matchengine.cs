using System.Collections.Generic;

namespace mentorbridge
{
    public class MatchEngine
    {
        public static List<Mentor> FindMatchingMentors(
            string studentField)
        {
            List<Mentor> allMentors =
                DatabaseHelper.GetAllMentors();

            List<Mentor> matchedMentors =
                new List<Mentor>();

            foreach (Mentor m in allMentors)
            {
                if (m.Expertise.ToLower()
                    .Contains(studentField.ToLower()))
                {
                    matchedMentors.Add(m);
                }
            }

            return matchedMentors;
        }
    }
}