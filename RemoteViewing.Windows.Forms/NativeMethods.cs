using System;
using System.Runtime.InteropServices;

namespace RemoteViewing.Windows.Forms
{
    internal static class NativeMethods
    {
        [DllImport("user32", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateIconIndirect(ref ICONINFO piconinfo);
    }

    internal struct ICONINFO
    {
        public bool fIcon;
        public uint xHotspot;
        public uint yHotspot;
        public IntPtr hbmMask;
        public IntPtr hbmColor;
    }
}
