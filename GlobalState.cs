namespace mentorbridge
{
    public static class GlobalState
    {
        public static string LoggedInUsername { get; set; } = string.Empty;
        public static string LoggedInRole { get; set; } = string.Empty;
        public static int LoggedInUserID { get; set; }
        public static int ProfileID { get; set; }
        public static string LoggedInField { get; set; } = string.Empty;
        public static Mentor MatchedMentor { get; set; } 
    }  
}