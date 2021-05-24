using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Task_Scheduler
{
   public class GradientPanel : Panel
    {
        public Color TopColor { set; get; }
        public Color BottomColor { set; get; }
        public float Angel { set; get; }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.TopColor, this.BottomColor, this.Angel);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);

        }
    }
}  
