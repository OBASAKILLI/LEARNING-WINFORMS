using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISA_WINFORMS.wwwroot.Custom_Controls
{
    public class EK_AvaterImage:PictureBox
    {
        public EK_AvaterImage()
        {
            this.Size = new Size(50,50);
            this.SizeMode=PictureBoxSizeMode.StretchImage;
           // this.Padding=new Padding(5,5,5,5);

        }
      private   GraphicsPath GetGraphicspath(Rectangle rectangle)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(rectangle);
            path.CloseFigure();
            return path;

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = GetGraphicspath(this.ClientRectangle);
            this.Region = new Region(path);
          
            pe.Graphics.DrawPath(new Pen(this.BackColor, 2), path);
        }
    }
}
