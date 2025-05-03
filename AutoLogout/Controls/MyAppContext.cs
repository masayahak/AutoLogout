namespace AutoLogout.Controls
{
    public class MyAppContext : ApplicationContext
    {
        private readonly FormLogin _loginForm;

        public MyAppContext(FormLogin loginForm)
        {
            _loginForm = loginForm;
            _loginForm.Show();
        }

        public void ShowLoginAndCloseOthers()
        {
            _loginForm.Show();

            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                if (f != _loginForm)
                    f.Close();
            }
        }
    }

}