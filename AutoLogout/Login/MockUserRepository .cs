using System.Security.Cryptography;
using System.Text;

namespace AutoLogout.Login
{
    public interface IUserRepository
    {
        bool TryLogin(string userId, string password, out string 権限コード);
    }

    public class MockUserRepository : IUserRepository
    {
        private class UserInfo
        {
            public string UserId { get; set; } = string.Empty;
            public string PasswordHash { get; set; } = string.Empty;
            public string 権限コード { get; set; } = string.Empty;
        }

        const string PasswordSalt = "ABC123"; // パスワードのソルト（固定値として使用）

        // テスト用の固定データ（UserId, Salt, SHA256(Salt + Password), 権限コード）
        private readonly List<UserInfo> _users = new()
        {
            new UserInfo
            {
                UserId = "admin",
                PasswordHash = ComputeHash(PasswordSalt, "password"),
                権限コード = "A"
            },
            new UserInfo
            {
                UserId = "user",
                PasswordHash = ComputeHash(PasswordSalt, "test"),
                権限コード = "U"
            }
        };

        public bool TryLogin(string userId, string password, out string 権限コード)
        {
            権限コード = string.Empty;

            var user = _users.FirstOrDefault(u => u.UserId == userId);
            if (user == null) return false;

            string inputHash = ComputeHash(PasswordSalt, password);
            if (inputHash != user.PasswordHash) return false;

            権限コード = user.権限コード;
            return true;
        }

        private static string ComputeHash(string salt, string password)
        {
            var bytes = Encoding.UTF8.GetBytes(salt + password);
            var hash = SHA256.HashData(bytes);
            return Convert.ToHexStringLower(hash);
        }
    }

}
