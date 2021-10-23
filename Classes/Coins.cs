using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicRemakeGP43D.Classes
{
    public class Coins
    {
        int srcX = 0;

        public Transform transform;
        

        public Coins(PointF pos, Size size)
        {
            transform = new Transform(pos, size);
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(GameController.spritesheet, new Rectangle(new Point((int)transform.position.X, (int)transform.position.Y), new Size(transform.size.Width, transform.size.Height)), srcX, 16, 93, 81, GraphicsUnit.Pixel);
        }
    }
}
