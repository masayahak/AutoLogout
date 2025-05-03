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
            return _repository.TryLogin(userId, password, out 権限コード);
        }
    }
}
