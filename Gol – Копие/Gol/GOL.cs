using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gol
{
    public partial class GOL : Form
    {
        //1 = blue | 2 = red | 3 = yellow| 4 = green
        //Current generation array keeping the current values of the cells
        public int[,] CurrentGen = new int[,] { {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,2,0,2,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,3,3,3,0,0,0,0,0,0,0,0,0,0,2,2,0,2,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0},
                                         {0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0},
                                         {0,0,0,0,0,0,0,4,1,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,4,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                         {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},};
        
        private int[,] NextGen = new int[30,30];  //Value/dimensions to an array are needed, requires size

        int maxX = 30;
        int maxY = 30;
        int cellSize = 20;
        int blueNeighbors;
        int redNeighbors;
        int yellowNeighbors;
        int greenNeighbors;
        int count = 1;

        Graphics g;
        Pen pen = new Pen(Color.Black);
        Brush green = new SolidBrush(Color.Green);
        Brush blue = new SolidBrush(Color.Blue);
        Brush red = new SolidBrush(Color.Red);
        Brush yellow = new SolidBrush(Color.Yellow);

        //Graphics, initializing the board
        public GOL()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //method drawing the grid of the board
        private void drawGrid()
        {
            for (int i = 0; i <= maxX; i++)//horizontal lines
            {
                g.DrawLine(pen, 0, i * cellSize, maxX * cellSize, i * cellSize);
            }

            for (int j = 0; j <= maxY; j++)//vertical lines
            {
                g.DrawLine(pen, j * cellSize, 0, j * cellSize, maxY * cellSize);
            }
        }

        private void fillGrid()
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    if (CurrentGen[i, j] == 1)
                    {
                        g.FillRectangle(blue, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                    if (CurrentGen[i, j] == 2)
                    {
                        g.FillRectangle(red, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                    if (CurrentGen[i, j] == 3)
                    {
                        g.FillRectangle(yellow, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                    if (CurrentGen[i, j] == 4)
                    {
                        g.FillRectangle(green, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                }
            }
        }

        public int blueCounter(int x,int y)
        {
            int bcount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (x + i < 0 || x + i >= maxX)   // Out of bounds
                        continue;
                    if (y + j < 0 || y + j >= maxY)   // Out of bounds
                        continue;
                    if (x + i == x && y + j == y)       // Same Cell
                        continue;
                    if (CurrentGen[x + i, y + j] == 1) 
                        bcount+= CurrentGen[x + i, y + j];
                }
            }

            return bcount;
        }
        public int redCounter(int x, int y)
        {
            int rcount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (x + i < 0 || x + i >= maxX)   // Out of bounds
                        continue;
                    if (y + j < 0 || y + j >= maxY)   // Out of bounds
                        continue;
                    if (x + i == x && y + j == y)       // Same Cell
                        continue;
                    if (CurrentGen[x + i, y + j] == 2) 
                        rcount+= CurrentGen[x + i, y + j]/2;
                }
            }
                    return rcount;
        }
        public int yellowCounter(int x, int y)
        {
            int ycount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (x + i < 0 || x + i >= maxX)   // Out of bounds
                        continue;
                    if (y + j < 0 || y + j >= maxY)   // Out of bounds
                        continue;
                    if (x + i == x && y + j == y)       // Same Cell
                        continue;
                    if (CurrentGen[x + i, y + j] == 3) 
                        ycount += CurrentGen[x + i, y + j]/3;
                }
            }
                    return ycount;
        }
        public int greenCounter(int x, int y)
        {
            int gcount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (x + i < 0 || x + i >= maxX)   // Out of bounds
                        continue;
                    if (y + j < 0 || y + j >= maxY)   // Out of bounds
                        continue;
                    if (x + i == x && y + j == y)       // Same Cell
                        continue;
                    if (CurrentGen[x + i, y + j] == 4) 
                        gcount += CurrentGen[x + i, y + j]/4;
                }
            }
                    return gcount;
        }

        //transfer from one generation to another, changing arrays
        private void transferGeneration()
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    CurrentGen[i, j] = NextGen[i, j];
                }
            }
        }

        public void blueSpawn()
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    blueNeighbors = blueCounter(i, j);
                    redNeighbors = redCounter(i, j);
                    yellowNeighbors = yellowCounter(i, j);
                    greenNeighbors = greenCounter(i, j);

                    if (CurrentGen[i, j] == 1 && blueNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 1 && blueNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && blueNeighbors >= 3)
                        NextGen[i, j] = 1;

                    else if (CurrentGen[i, j] == 1 && redNeighbors >= 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 1 && yellowNeighbors >= 3)
                        NextGen[i, j] = 4;

                    else if (CurrentGen[i, j] == 2 && redNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 2 && redNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && redNeighbors >= 3)
                        NextGen[i, j] = 2;

                    else if (CurrentGen[i, j] == 3 && yellowNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 3 && yellowNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && yellowNeighbors >= 3 && yellowNeighbors > blueNeighbors && yellowNeighbors > redNeighbors)
                        NextGen[i, j] = 3;

                    else if (CurrentGen[i, j] == 3 && blueNeighbors >= 3)
                        NextGen[i, j] = 4;

                    else if (CurrentGen[i, j] == 3 && redNeighbors > 4)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 4 && greenNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 4 && greenNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && greenNeighbors >= 3)
                        NextGen[i, j] = 4;

                    else if (CurrentGen[i, j] == 4 && blueNeighbors >= 3)
                        NextGen[i, j] = 1;

                    else if (CurrentGen[i, j] == 4 && yellowNeighbors >= 3)
                        NextGen[i, j] = 3;

                    else if (CurrentGen[i, j] == 4 && redNeighbors >= 3)
                        NextGen[i, j] = 2;

                    else
                        NextGen[i, j] = CurrentGen[i, j];
                }
            }

            transferGeneration();
        }

        /*public void redSpawn() 
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    blueNeighbors = blueCounter(i, j);
                    redNeighbors = redCounter(i, j);
                    yellowNeighbors = yellowCounter(i, j);
                    greenNeighbors = greenCounter(i, j);

                    if (CurrentGen[i, j] == 2 && redNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 2 && redNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && redNeighbors >= 3)
                        NextGen[i, j] = 2;

                    else
                        NextGen[i, j] = CurrentGen[i, j];
                }
            }

            transferGeneration();
        }

        public void yellowSpawn() 
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    blueNeighbors = blueCounter(i, j);
                    redNeighbors = redCounter(i, j);
                    yellowNeighbors = yellowCounter(i, j);
                    greenNeighbors = greenCounter(i, j);

                    if (CurrentGen[i, j] == 3 && yellowNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 3 && yellowNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && yellowNeighbors >= 3 && yellowNeighbors>blueNeighbors && yellowNeighbors>redNeighbors)
                        NextGen[i, j] = 3;

                    else if (CurrentGen[i, j] == 3 && blueNeighbors >= 3)
                        NextGen[i, j] = 4;

                    else if (CurrentGen[i, j] == 3 && redNeighbors > 4)
                        NextGen[i, j] = 0;

                    else
                        NextGen[i, j] = CurrentGen[i, j];
                }
            }

            transferGeneration();
        }

        public void greenSpawn() 
        {
            for (int i = 0; i < maxX; i++)
            {
                for (int j = 0; j < maxY; j++)
                {
                    blueNeighbors = blueCounter(i, j);
                    redNeighbors = redCounter(i, j);
                    yellowNeighbors = yellowCounter(i, j);
                    greenNeighbors = greenCounter(i, j);

                    if (CurrentGen[i, j] == 4 && greenNeighbors < 2)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 4 && greenNeighbors > 3)
                        NextGen[i, j] = 0;

                    else if (CurrentGen[i, j] == 0 && greenNeighbors >= 3)
                        NextGen[i, j] = 4;

                    else if (CurrentGen[i, j] == 4 && blueNeighbors >= 3)
                        NextGen[i, j] = 1;

                    else if (CurrentGen[i, j] == 4 && yellowNeighbors >= 3)
                        NextGen[i, j] = 3;

                    else if (CurrentGen[i, j] == 4 && redNeighbors >= 3)
                        NextGen[i, j] = 2;

                    else
                        NextGen[i, j] = CurrentGen[i, j];
                }
            }

            transferGeneration();
        }*/

        public void allSpawn()
        {
            blueSpawn();
            //redSpawn();
            //yellowSpawn();
            //greenSpawn();
            count++;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            tm_update.Stop();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            tm_update.Start();
        }

        //Timer that renders the board each second
        private void tm_update_Tick(object sender, EventArgs e)
        {
            panel1.Refresh();
            label1.Text = count.ToString("Generation: "+count);
            allSpawn();
            drawGrid();
            fillGrid();
        }
    }
}
