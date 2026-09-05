namespace KrishiSetuPro.Helpers
{
    /// <summary>
    /// Simple static holder for the currently logged-in user.
    /// Set on successful login, cleared on logout.
    /// </summary>
    public static class Session
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string UserType { get; set; } // "Farmer" / "Buyer" / "Admin"
        public static string FullName { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            UserType = null;
            FullName = null;
        }
    }
}
