using Timer = System.Windows.Forms.Timer;

namespace AutoLogout.Controls
{
    public class BaseForm : Form
    {

        // 自動ログアウトまでの時間（分）
        private readonly TimeSpan Timeout =
#if DEBUG
            TimeSpan.FromMinutes(1); // デバッグ: 1分
#else
            TimeSpan.FromMinutes(30); // リリース: 30分
#endif

        // 自動ログアウトのチェック間隔
        private readonly int CheckIntervalMilliseconds =
#if DEBUG
            1000; // デバッグ: 1秒
#else
            10 * 1000; // リリース: 10秒
#endif

        private readonly Timer _inactivityTimer = new();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 未操作タイマーを開始
            StartInactivityTimer();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            // フォームがフォーカスを取得したら、未操作タイマーをリセット
            UserActivityTracker.Update(); 
        }

        private void StartInactivityTimer()
        {
            _inactivityTimer.Interval = CheckIntervalMilliseconds;
            _inactivityTimer.Tick += (_, _) => CheckTimeout();
            _inactivityTimer.Start();
        }

        private void CheckTimeout()
        {
            if (!UserActivityTracker.IsInactive(Timeout)) 
                return;

            _inactivityTimer.Stop();
            if (!IsHandleCreated) 
                return;

            BeginInvoke(() =>
            {
                Program.AppContextInstance!.ShowLoginAndCloseOthers();
            });
        }
    }
}
