using AutoLogout.Controls;
using AutoLogout.Login;

namespace AutoLogout
{
    public partial class FormMenu : BaseForm
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Button業務１_Click(object sender, EventArgs e)
        {
            var form業務１ = new Form業務１();
            form業務１.Show();
        }

        private void Button終了_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            Labelログイン者.Text = $"ログイン者: {CurrentUser.ユーザーID} ( {CurrentUser.IPアドレス} )  権限: {CurrentUser.権限コード} ";
        }
    }
}
