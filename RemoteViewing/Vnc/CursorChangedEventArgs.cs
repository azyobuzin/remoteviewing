using System;

namespace RemoteViewing.Vnc
{
    public class CursorChangedEventArgs : EventArgs
    {
        public int HotspotX { get; }

        public int HotspotY { get; }

        public int Width { get; }

        public int Height { get; }

        public byte[] Pixels { get; }

        public byte[] Bitmask { get; }

        public CursorChangedEventArgs(int hotspotX, int hotspotY, int width, int height, byte[] pixels, byte[] bitmask)
        {
            this.HotspotX = hotspotX;
            this.HotspotY = hotspotY;
            this.Width = width;
            this.Height = height;
            this.Pixels = pixels;
            this.Bitmask = bitmask;
        }
    }
}
