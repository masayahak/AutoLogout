using AutoLogout.Controls;

namespace AutoLogout
{
    internal static class Program
    {
        public static Controls.MyAppContext? AppContextInstance { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ユーザーアクティビティを監視するフィルタを追加
            Application.AddMessageFilter(new UserActivityMessageFilter());

            var loginForm = new FormLogin();
            AppContextInstance = new MyAppContext(loginForm);
            Application.Run(AppContextInstance);
        }
    }
}