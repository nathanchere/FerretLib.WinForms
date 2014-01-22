using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FerretLib.WinForms
{
    public class ResourceFont
    {
        private PrivateFontCollection _font;

        public ResourceFont(byte[] rawFont)
        {
            System.IntPtr data = new IntPtr();
            try
            {
                _font = new PrivateFontCollection();
                using (var stream = new MemoryStream(rawFont)) {
                    data = Marshal.AllocCoTaskMem((int)stream.Length);
                    Marshal.Copy(rawFont, 0, data, (int)stream.Length);
                    _font.AddMemoryFont(data, (int)stream.Length);
                }                
            }
            finally
            {
                Marshal.FreeCoTaskMem(data);
            }
        }

        public Font GetFont(float ems)
        {
            if (_font == null || _font.Families.Length == 0) throw new InvalidDataException("No font data loaded");
            return new Font(_font.Families[0], ems);
        }
    }
}
