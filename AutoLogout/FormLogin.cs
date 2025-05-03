using AutoLogout.Controls;
using AutoLogout.Login;

namespace AutoLogout
{
    public partial class FormLogin : BaseForm
    {
        private readonly LoginService _loginService = new(new MockUserRepository());

        public FormLogin()
        {
            InitializeComponent();
        }

        private void Buttonログイン_Click(object sender, EventArgs e)
        {
            // ユーザーIDとパスワードを取得
            string userId = TextBoxユーザーID.Text.Trim();
            string password = TextBoxパスワード.Text.Trim();

            // ログイン情報検証
            if (!_loginService.TryLogin(userId, password, out var 権限コード))
            {
                MessageBox.Show("ユーザーIDまたはパスワードが間違っています", "ログイン失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 画面遷移
            var formMenu = new FormMenu();
            formMenu.FormClosed += (_, _) => this.Close();
            formMenu.Show();

            this.Hide();
        }

        private void Button終了_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
