using System.Net;

namespace AutoLogout.Login
{
    public class LoginService
    {
        private readonly IUserRepository _repository;

        public LoginService(IUserRepository repository)
        {
            _repository = repository;
        }

        public bool TryLogin(string userId, string password, out string? 権限コード)
        {
            if (!_repository.TryLogin(userId, password, out 権限コード))
                return false;

            // ログイン成功
            CurrentUser.ユーザーID = userId;
            CurrentUser.権限コード = 権限コード!;
            CurrentUser.ログイン日時 = DateTime.Now;
            CurrentUser.IPアドレス = Dns.GetHostAddresses(Dns.GetHostName())
                                        .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                                        .ToString() ?? "不明";

            return true;
        }

    }
}
