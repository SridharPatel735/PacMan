using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
/// <summary>
/// Sridhar Patel
/// December 2019
/// Creating a small version of pacman
/// </summary>

namespace PacMan
{
    public partial class Form1 : Form
    {
        //Draw tools creation
        Graphics g;
        Pen pathPen = new Pen(Color.Blue, 10);
        SolidBrush pacBrush = new SolidBrush(Color.Yellow);
        Font titleFont = new Font("Arial", 16, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();

            //Graphics declaration
            g = this.CreateGraphics();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            //Clearing the screen and clearing the outputLabel
            g.Clear(Color.Black);

            //All of the frames
            OpenMouth(-60, 20);
            CloseMouth(20, 40);
            OpenMouth(40, 60);
            CloseMouth(60, 80);
            OpenMouth(80, 100);
            CloseMouth(100, 120);
            OpenMouth(120, 140);
            CloseMouth(140, 160);
            OpenMouth(160, 180);
            CloseMouth(180, 200);
            OpenMouth(200, 220);
            CloseMouth(220, 240);
            OpenMouth(240, 255);
            CloseMouth2(75, 95);
            OpenMouth2(95, 115);
            CloseMouth2(115, 135);
            OpenMouth2(135, 155);
            CloseMouth2(155, 175);
            OpenMouth2(175, 195);
            CloseMouth2(195, 215);
            OpenMouth2(215, 235);
            CloseMouth2(235, 255);
            OpenMouth2(255, 275);
            CloseMouth2(275, 295);
            g.DrawString("Congratulation", titleFont, pacBrush, 20, 200);
        }
        public void OpenMouth(int x, int y)
        {
            //Loop for the open mouth when Pac Man is going to the side
            for (int i = x; i <= y; i = i + 10)
            {
                g.Clear(Color.Black);
                g.DrawLine(pathPen, 0, 60, 325, 60);
                g.DrawLine(pathPen, 0, 140, 245, 140);
                g.DrawLine(pathPen, 320, 55, 320, this.Height);
                g.DrawLine(pathPen, 240, 135, 240, this.Height);
                g.FillPie(pacBrush, i, 75, 50, 50, 30, 300);
                Thread.Sleep(50);
            }
        }
        public void CloseMouth(int x, int y)
        {
            //Loop for the close mouth when Pac Man is going to the side
            for (int i = x; i <= y; i = i + 10)
            {
                g.Clear(Color.Black);
                g.DrawLine(pathPen, 0, 60, 325, 60);
                g.DrawLine(pathPen, 0, 140, 245, 140);
                g.DrawLine(pathPen, 320, 55, 320, this.Height);
                g.DrawLine(pathPen, 240, 135, 240, this.Height);
                g.FillPie(pacBrush, i, 75, 50, 50, 30, 360);
                Thread.Sleep(50);
            }
        }
        public void OpenMouth2(int x, int y)
        {
            //Loop for the open mouth when Pac Man is going down
            for (int i = x; i <= y; i = i + 10)
            {
                g.Clear(Color.Black);
                g.DrawLine(pathPen, 0, 60, 325, 60);
                g.DrawLine(pathPen, 0, 140, 245, 140);
                g.DrawLine(pathPen, 320, 55, 320, this.Height);
                g.DrawLine(pathPen, 240, 135, 240, this.Height);
                g.FillPie(pacBrush, 255, i, 50, 50, 120, 300);
                Thread.Sleep(50);
            }
        }
        public void CloseMouth2(int x, int y)
        {
            //Loop for the close mouth when Pac Man is going down
            for (int i = x; i <= y; i = i + 10)
            {
                g.Clear(Color.Black);
                g.DrawLine(pathPen, 0, 60, 325, 60);
                g.DrawLine(pathPen, 0, 140, 245, 140);
                g.DrawLine(pathPen, 320, 55, 320, this.Height);
                g.DrawLine(pathPen, 240, 135, 240, this.Height);
                g.FillPie(pacBrush, 255, i, 50, 50, 30, 360);
                Thread.Sleep(50);
            }
        }
    }
}
