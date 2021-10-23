using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SonicRemakeGP43D.Classes
{
    public static class GameController
    {

        public static SoundPlayer audio = new SoundPlayer(SonicRemakeGP43D.Properties.Resources.theme);
        public static MainMenu mainMenu  = new MainMenu();

        public static Image spritesheet;
        public static List<Road> roads;
        public static List<CrabEnemy> crabs;
        public static List<Coins> coins;
        public static List<BomberEnemy> bombers;


        public static int dangerSpawn = 10;
        public static int countDangerSpawn = 0;


        public static void Init()
        {

            roads = new List<Road>();
            bombers = new List<BomberEnemy>();
            crabs = new List<CrabEnemy>();
            coins = new List<Coins>();
            spritesheet = Properties.Resources.sprite;
            GenerateRoad();
            PlayMusic();
           
        }

        public static void MoveMap()
        {
            for(int i = 0; i < roads.Count; i++)
            {
                roads[i].transform.position.X -= 4;
                if (roads[i].transform.position.X + roads[i].transform.size.Width < 0)
                {
                    roads.RemoveAt(i);
                    GetNewRoad();
                }
            }
            for (int i = 0; i < crabs.Count; i++)
            {
                crabs[i].transform.position.X -= 4;
                if (crabs[i].transform.position.X + crabs[i].transform.size.Width < 0)
                {
                    crabs.RemoveAt(i);
                }
            }
            for (int i = 0; i < bombers.Count; i++)
            {
                bombers[i].transform.position.X -= 4;
                if (bombers[i].transform.position.X + bombers[i].transform.size.Width < 0)
                {
                    bombers.RemoveAt(i);
                }
            }

            for (int i = 0; i < coins.Count; i++)
            {
                coins[i].transform.position.X -= 4;
                if (coins[i].transform.position.X + coins[i].transform.size.Width < 0)
                {
                    coins.RemoveAt(i);
                }
            }
        }

        public static void GetNewRoad()
        {
            Road road = new Road(new PointF(0 + 100 * 9, 200), new Size(100, 17));
            roads.Add(road);
            countDangerSpawn++;

            if (countDangerSpawn >= dangerSpawn)
            {
                Random r = new Random();
                dangerSpawn = r.Next(5, 9);
                countDangerSpawn = 0;
                int obj = r.Next(0, 3);
                switch (obj)
                {
                    case 0:
                        CrabEnemy cactus = new CrabEnemy(new PointF(0 + 100 * 9, 150), new Size(50, 50));
                        crabs.Add(cactus);
                        break;
                    case 1:
                        BomberEnemy bird = new BomberEnemy(new PointF(0 + 100 * 9, 110), new Size(50, 50));
                        bombers.Add(bird);
                        break;
                    case 2:
                        Coins coin = new Coins(new PointF(0 + 100 * 9, 150), new Size(60, 50));
                        coins.Add(coin);
                        break;
                }
            }
        }
        public static void GenerateRoad()
        {
            for(int i = 0; i < 10; i++)
            {
                Road road = new Road(new PointF(0 + 100 * i, 200), new Size(100, 17));
                roads.Add(road);
                countDangerSpawn++;
            }
        }

        public static void DrawObjets(Graphics g)
        {
            for(int i = 0; i < roads.Count; i++)
            {
                roads[i].DrawSprite(g);
            }
            for (int i = 0; i < crabs.Count; i++)
            {
                crabs[i].DrawSprite(g);
            }
            for (int i = 0; i < bombers.Count; i++)
            {
                bombers[i].DrawSprite(g);
            }
            for (int i = 0; i < coins.Count; i++)
            {
                coins[i].DrawSprite(g);
            }

        }

        public static void PlayMusic()
        {
            audio.Play();
        }

        public static void StopMusic() {

            audio.Stop();
        }

     
    }
}
