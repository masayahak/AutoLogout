using System.Net;
using System.Net.Sockets;

namespace AutoLogout.Login
{
    public static class CurrentUser
    {
        // ------------------------------------------------
        // プロパティ
        // ------------------------------------------------
        public static string ユーザーID { get; set; } = string.Empty;
        public static string 権限コード { get; set; } = string.Empty;
        public static DateTime ログイン日時 { get; set; }
        public static string IPアドレス { get; set; } = string.Empty;

        // ------------------------------------------------
        // メソッド
        // ------------------------------------------------
        public static void Login(string id, string code)
        {
            ユーザーID = id;
            権限コード = code;
            ログイン日時 = DateTime.Now;
            IPアドレス = GetLocalIPAddress();
        }

        public static void Logout()
        {
            ユーザーID = string.Empty;
            権限コード = string.Empty;
            ログイン日時 = default;
            IPアドレス = string.Empty;
        }

        private static string GetLocalIPAddress()
        {
            try
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        return ip.ToString();
                }
            }
            catch
            {
                // ログイン履歴に記録できなくてもログイン処理には影響させない
            }
            return "不明";
        }
    }
}
