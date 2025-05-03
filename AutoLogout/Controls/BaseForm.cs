using Timer = System.Windows.Forms.Timer;

namespace AutoLogout.Controls
{
    public class BaseForm : Form
    {
        private const int CheckIntervalMilliseconds = 10 * 1000; // 10秒
        private const int AutoLogoutMinutes = 1;                 // 1分
        private static readonly TimeSpan Timeout = TimeSpan.FromMinutes(AutoLogoutMinutes);

        private readonly Timer _inactivityTimer = new();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HookUserActivity(this);
            StartInactivityTimer();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            UserActivityTracker.Update();
        }

        private void HookUserActivity(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.MouseDown += OnMouseDown;
                ctrl.KeyDown += OnKeyDown;

                if (ctrl.HasChildren)
                    HookUserActivity(ctrl);
            }

            MouseDown += OnMouseDown;
            KeyDown += OnKeyDown;
        }

        private void OnMouseDown(object? sender, MouseEventArgs e) => UserActivityTracker.Update();
        private void OnKeyDown(object? sender, KeyEventArgs e) => UserActivityTracker.Update();

        private void StartInactivityTimer()
        {
            _inactivityTimer.Interval = CheckIntervalMilliseconds;
            _inactivityTimer.Tick += (_, _) =>
            {
                if (UserActivityTracker.IsInactive(Timeout))
                {
                    _inactivityTimer.Stop();
                    BeginInvoke(() => Program.AppContextInstance!.ShowLoginAndCloseOthers());
                }
            };
            _inactivityTimer.Start();
        }
    }
}
