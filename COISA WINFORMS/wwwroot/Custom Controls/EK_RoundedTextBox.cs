using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COISA_WINFORMS.wwwroot.Custom_Controls
{
    public class EK_RoundedTextBox:Panel
    {

     

        public EK_RoundedTextBox()
        {
            this.Height = 100;
            this.BackColor = Color.FromArgb(142, 144, 145);
            
        }


        private GraphicsPath GetPath(Rectangle rectangle)
        {
            
            Rectangle leftarc = new Rectangle(rectangle.X, rectangle.Y, rectangle.Height, rectangle.Height);
            Rectangle Righttarc = new Rectangle(rectangle.Width- rectangle.Height, rectangle.Y, rectangle.Height, rectangle.Height);
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftarc, 90, 180);
            path.AddArc(Righttarc,270,180);
            
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
          
            Rectangle r = this.ClientRectangle;
            GraphicsPath graphicsPath = GetPath(r);
            this.Region = new Region(graphicsPath);
           e.Graphics.DrawPath(new Pen(this.Parent.BackColor,3), graphicsPath);

        }

    }
}
