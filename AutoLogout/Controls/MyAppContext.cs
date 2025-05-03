namespace AutoLogout.Controls
{
    public class MyAppContext : ApplicationContext
    {
        public MyAppContext(FormLogin loginForm)
        {
            loginForm.Show();
        }

        public void ShowLoginAndCloseOthers()
        {
            // ログインフォームは常にNEWする
            var loginForm = new FormLogin();
            loginForm.Show();

            foreach (Form f in Application.OpenForms.Cast<Form>().ToList())
            {
                // 過去のログインフォームがあっても、NEWしたインスタンス以外は閉じる
                if (f != loginForm)
                    f.Close();
            }
        }
    }

}