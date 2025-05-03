using AutoLogout.Controls;

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
    }
}
