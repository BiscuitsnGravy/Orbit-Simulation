/*
    Jason Trost
    Computer Science 322
    Homework 3
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trost_HW3
{
    public partial class Form1 : Form
    {
        // structs for planets and gravity centers to help store information
        struct GravityCenter
        {
            public int x;
            public int y;
            public int radius;
        }
        struct Planet
        {
            public float x;
            public float y;
            public int gravitationalRadius;
            public float angle;
            public const int width = 10;
            public const int height = 10;
            public int nearest_X;
            public int nearest_Y;
        }
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }
        // lists to store information
        List<GravityCenter> gravityCenters = new List<GravityCenter> ( );
        List<Planet> planetList = new List<Planet>();

        // creation function that generates planets or gravity centers, only operates if one of the radio buttons is selected
        private void PlanetScreen_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = PlanetScreen.CreateGraphics(); ;
            int w = Convert.ToInt32(Change_Radius.Value);
            // create a gravity center
            if (CenterOfGravity.Checked == true)
            {
                GravityCenter gravityCenter = new GravityCenter { };
                gravityCenter.x = (e.X-5);
                gravityCenter.y = (e.Y-5);
                gravityCenter.radius = w;
                gravityCenters.Add (gravityCenter); // adds the center of black circle to list of gravity centers

                g.FillEllipse (Brushes.LightGray, e.X-w, e.Y-w, w*2, w*2); // Draws gray and black circles
                g.FillEllipse(Brushes.Black, e.X-5, e.Y-5, 10, 10); // Since static no need to add them to time interval
            }
            // create a planet
            if (CreateAPlanet.Checked == true)
            {
                Planet planet = new Planet { };
                planet.x = e.X - 5;
                planet.y = e.Y - 5;
                foreach (GravityCenter gravity in gravityCenters)
                {
                    if (gravity.x != planet.x || gravity.y != planet.y){ // if statement needed so program doesnt try to divide by zero and make the program crash
                        if (Math.Sqrt(Math.Pow((planet.x - gravity.x), 2) + Math.Pow((planet.y - gravity.y), 2)) < gravity.radius)
                        {
                            planet.nearest_X = gravity.x;
                            planet.nearest_Y = gravity.y;
                            planet.gravitationalRadius = Convert.ToInt32(Math.Sqrt(Math.Pow((planet.x - gravity.x), 2) + Math.Pow((planet.y - gravity.y), 2)));
                            if (planet.x < gravity.x)
                                planet.angle = (float)(Math.Atan((planet.y - gravity.y) / (planet.x - gravity.x)) - Math.PI); // exception needed if planets is clicked ontop of a gravity center
                            else
                                planet.angle = (float)Math.Atan((planet.y - gravity.y) / (planet.x - gravity.x));
                            planetList.Add(planet);
                            g.FillEllipse(Brushes.HotPink, planet.x, planet.y, 10, 10);
                            break;
                        }// if planet x,y within radius of gravity circle set gravity circle x,y to planet
                    planetList.Add(planet);
                    g.FillEllipse(Brushes.HotPink, planet.x, planet.y, 10, 10);
                    }
                }
            }
        }
        // paint function for every tick of timer to move planets
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = PlanetScreen.CreateGraphics();
            for (int i = 0; i < planetList.Count; i++)
            {
                if (planetList[i].gravitationalRadius > 0)
                {
                    float xNew = planetList[i].nearest_X + planetList[i].gravitationalRadius * (float)Math.Cos(planetList[i].angle + .02);
                    float yNew = planetList[i].nearest_Y + planetList[i].gravitationalRadius * (float)Math.Sin(planetList[i].angle + .02);
                    g.FillEllipse(Brushes.LightGray, planetList[i].x, planetList[i].y, 10, 10);
                    planetList[i] = new Planet
                    {// reconstructs planet with new location/angle
                        x = xNew,
                        y = yNew,
                        gravitationalRadius = planetList[i].gravitationalRadius,
                        angle = (float)(planetList[i].angle + .02),
                        nearest_X = planetList[i].nearest_X,
                        nearest_Y = planetList[i].nearest_Y
                    };
                    g.FillEllipse(Brushes.HotPink, planetList[i].x, planetList[i].y, 10, 10);
                }
            }
        }
    }
}
