using AutoLogout.Controls;
using AutoLogout.Login;
using System;
using System.Net;

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

            // ログイン成功
            CurrentUser.ユーザーID = userId;
            CurrentUser.権限コード = 権限コード!;
            CurrentUser.ログイン日時 = DateTime.Now;
            CurrentUser.IPアドレス = Dns.GetHostAddresses(Dns.GetHostName())
                                        .FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)?
                                        .ToString() ?? "不明";

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
