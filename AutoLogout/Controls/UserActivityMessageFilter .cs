namespace AutoLogout.Controls
{

    // ユーザーの操作を監視するフィルタ
    // 監視対象は
    //  キーボードのキー押下、マウスの左ボタン、右ボタン、ホイールのクリック
    // （負荷軽減のためあえてマウスの移動は検知しない）
    public class UserActivityMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            const int WM_LBUTTONDOWN = 0x0201;
            const int WM_RBUTTONDOWN = 0x0204;
            const int WM_MBUTTONDOWN = 0x0207;

            switch (m.Msg)
            {
                case WM_KEYDOWN:
                case WM_LBUTTONDOWN:
                case WM_RBUTTONDOWN:
                case WM_MBUTTONDOWN:
                    UserActivityTracker.Update();
                    break;
            }

            return false; // 他の処理も続けて行う
        }
    }
}
