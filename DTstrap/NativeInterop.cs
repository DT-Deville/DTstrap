using System.Runtime.InteropServices;

namespace DTstrap
{
    /// <summary>
    /// Manual P/Invoke declarations replacing CsWin32 source generator.
    /// </summary>
    internal static class NativeInterop
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SHObjectProperties(IntPtr hwnd, uint shopType, string pszObjectName, string pszPropertyPage);

        // Window style constants
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_TOOLWINDOW = 0x00000080;

        // SHOP_TYPE constants
        public const uint SHOP_FILEPATH = 0x2;
    }
}
