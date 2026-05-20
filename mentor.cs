namespace mentorbridge
{
    public class Mentor
    {
        public int MentorID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string Expertise { get; set; } = string.Empty;
        public int Experience { get; set; }
        public string Availability { get; set; } = string.Empty;
        public int MaxStudents { get; set; }
        public double AverageRating { get; set; }
    }
}