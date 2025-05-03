using AutoLogout.Controls;

namespace AutoLogout
{
    public partial class FormLogin : BaseForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonƒƒOƒCƒ“_Click(object sender, EventArgs e)
        {

            var formMenu = new FormMenu();
            formMenu.FormClosed += (_, _) => this.Close();
            formMenu.Show();

            this.Hide();
        }

    }
}
