using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FerretLib.WinForms
{

    /// <summary>
    /// WARNING: Do not use. PrivateFontCollection is a useless piece of shit with a fatal AccessViolationException bug which
    /// has been reported repeatedly since at least 2003 and still not fixed. Love your work Microsoft.
    /// </summary>

    public class ResourceFont : IDisposable
    {
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private PrivateFontCollection _font;

        private IntPtr _fontPointer;
        private GCHandle _handle;

        public ResourceFont(byte[] rawFont)
        {
            _font = new PrivateFontCollection();
            using (var stream = new MemoryStream(rawFont))
            {
                _handle = GCHandle.Alloc(rawFont, GCHandleType.Pinned);
                _fontPointer = _handle.AddrOfPinnedObject();
                _font.AddMemoryFont(_fontPointer, (int)stream.Length);
                uint dummy = 0;
                AddFontMemResourceEx(_fontPointer, (uint)stream.Length, IntPtr.Zero, ref dummy);                
            }
        }

        public Font GetFont(float ems)
        {
            if (_font == null || _font.Families.Length == 0) throw new InvalidDataException("No font data loaded");
            return new Font(_font.Families[0], ems);
        }

        public void Dispose()
        {
            if(_handle != null) _handle.Free();
            if (_font != null) _font.Dispose();
        }
    }
}
