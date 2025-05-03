namespace AutoLogout.Controls
{
    public static class UserActivityTracker
    {
        public static DateTime LastActionTime { get; private set; } = DateTime.Now;

        public static void Update()
        {
            LastActionTime = DateTime.Now;
        }

        public static bool IsInactive(TimeSpan timeout)
        {
            return DateTime.Now - LastActionTime > timeout;
        }
    }
}
