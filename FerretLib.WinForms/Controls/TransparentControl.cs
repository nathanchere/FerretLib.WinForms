using System.Windows.Forms;

namespace FerretLib.WinForms.Controls
{
    private class TransparentControl : Control
    {
        protected override void OnPaintBackground(PaintEventArgs pevent) { }
        protected override void OnPaint(PaintEventArgs e) { }
    }
}