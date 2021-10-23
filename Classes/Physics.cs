using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicRemakeGP43D.Classes
{
    public class Physics
    {

        public Transform transform;


        public int coins;

        float gravity;
        float a;

        public bool isJumping;
        public bool isCrouching;
        Player player = new Player();

     
        public Physics(PointF position, Size size)
        {

            transform = new Transform(position, size);
            gravity = 0;
            a = 0.4f;
            isJumping = false;
            isCrouching = false;

        }

        public void ApplyPhysics()
        {
            CalculatePhysics();
        }

        public void CalculatePhysics()
        {
            if(transform.position.Y<150 || isJumping)
            {
                transform.position.Y += gravity;
                gravity += a;
            }
            if (transform.position.Y > 150)
                isJumping = false;
        }

        public bool Collide()
        {
            for(int i = 0; i < GameController.crabs.Count; i++)
            {
                var crab = GameController.crabs[i];
                PointF delta = new PointF();
                delta.X = (transform.position.X + transform.size.Width / 2) - (crab.transform.position.X + crab.transform.size.Width / 2);
                delta.Y = (transform.position.Y + transform.size.Height / 2) - (crab.transform.position.Y + crab.transform.size.Height / 2);
                if (Math.Abs(delta.X) <= transform.size.Width / 2 + crab.transform.size.Width / 2)
                {
                    if (Math.Abs(delta.Y) <= transform.size.Height / 2 + crab.transform.size.Height / 2)
                    {
                        return true;
                    }
                }
            }
            for (int i = 0; i < GameController.bombers.Count; i++)
            {
                var bomber = GameController.bombers[i];
                PointF delta = new PointF();
                delta.X = (transform.position.X + transform.size.Width / 2) - (bomber.transform.position.X + bomber.transform.size.Width / 2);
                delta.Y = (transform.position.Y + transform.size.Height / 2) - (bomber.transform.position.Y + bomber.transform.size.Height / 2);
                if (Math.Abs(delta.X) <= transform.size.Width / 2 + bomber.transform.size.Width / 2)
                {
                    if (Math.Abs(delta.Y) <= transform.size.Height / 2 + bomber.transform.size.Height / 2)
                    {
                        return true;
                    }
                }
            }

            for (int i = 0; i < GameController.coins.Count; i++)
            {
                var coin = GameController.coins[i];
                PointF delta = new PointF();
                delta.X = (transform.position.X + transform.size.Width / 2) - (coin.transform.position.X + coin.transform.size.Width / 2);
                delta.Y = (transform.position.Y + transform.size.Height / 2) - (coin.transform.position.Y + coin.transform.size.Height / 2);

                if (Math.Abs(delta.X) <= transform.size.Width / 2 + coin.transform.size.Width / 2)
                {

                    if (Math.Abs(delta.Y) <= transform.size.Height / 2 + coin.transform.size.Height / 2)
                    {

                        return false;
                    }                    
                }
            }
            return false;
        }

        public void AddForce()
        {
            if (!isJumping)
            {
                isJumping = true;
                gravity = -10;
            }
        }
    }
}
