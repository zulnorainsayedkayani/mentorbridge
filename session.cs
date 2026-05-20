namespace mentorbridge
{
    public class Session
    {
        public int SessionID { get; set; }
        public int StudentID { get; set; }
        public int MentorID { get; set; }
        public string Status { get; set; } = string.Empty;
        public string RequestDate { get; set; } = string.Empty;
    }
}
