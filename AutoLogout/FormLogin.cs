using AutoLogout.Controls;

namespace AutoLogout
{
    public partial class FormLogin : BaseForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ButtonÉçÉOÉCÉì_Click(object sender, EventArgs e)
        {

            var formMenu = new FormMenu();
            formMenu.FormClosed += (_, _) => this.Close();
            formMenu.Show();

            this.Hide();
        }

        private void ButtonèIóπ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
