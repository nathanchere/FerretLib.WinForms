using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FerretLib.WinForms
{

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

    //public class ResourceFont
    //{
    //    [DllImport("gdi32.dll")]
    //    private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

    //    private PrivateFontCollection _font;

    //    public ResourceFont(byte[] rawFont)
    //    {
    //        _font = new PrivateFontCollection();
    //        using (var stream = new MemoryStream(rawFont))
    //        {
    //            var pinnedArray = GCHandle.Alloc(rawFont, GCHandleType.Normal);
    //            var pointer = pinnedArray.AddrOfPinnedObject();
    //            _font.AddMemoryFont(pointer, (int)stream.Length);
    //            uint dummy = 0;
    //            AddFontMemResourceEx((IntPtr)pointer, (uint)stream.Length, IntPtr.Zero, ref dummy);
    //            pinnedArray.Free();
    //        }
    //    }

    //    public Font GetFont(float ems)
    //    {
    //        if (_font == null || _font.Families.Length == 0) throw new InvalidDataException("No font data loaded");
    //        return new Font(_font.Families[0], ems);
    //    }
    //}


}
