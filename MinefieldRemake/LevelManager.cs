using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinefieldRemake
{
    class LevelManager : IGame
    {
        #region PROPS
        public string GameState { get; set; }
        private int GamePoint { get; set; }
        private int RowCount { get; set; }
        private int ColumnCount { get; set; }
        private int RefX { get; set; }
        private int RefY { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        #endregion

        #region GLOBAL VARIABLES
        Panel[,] boxes;
        Form screen;
        Mine mine;
        #endregion

        //Constructor
        public LevelManager(Form instance)
        {
            this.screen = instance;
            this.Width = 45;
            this.Height = 45;
            this.RefX = 12;
            this.RefY = 12;
            GameState = "playing";
            GamePoint = 0;
            RowCount = 14;
            ColumnCount = 6;
            boxes = new Panel[ColumnCount,RowCount];
            mine = new Mine();
        }

        //Load Level
        public void Load()
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    boxes[i, j] = new Panel();
                    boxes[i, j].Location = new Point(RefX, RefY);
                    boxes[i, j].Size = new Size(Width, Height);
                    boxes[i, j].BackColor = Color.White;
                    boxes[i, j].Cursor = Cursors.Hand;
                    boxes[i, j].BackColor = Color.Gray;
                    boxes[i, j].BorderStyle = BorderStyle.FixedSingle;
                    boxes[i, j].Tag = "init";
                    boxes[i, j].MouseClick += new MouseEventHandler(Click);
                    screen.Controls.Add(boxes[i, j]);
                    RefX += Width + 10;
                }
                RefY += Height + 10;
                RefX = 12;
            }
            mine.Load(boxes);
        }

        //Click Handler
        private void Click(object sender, MouseEventArgs e)
        {
            Panel currentBox = (Panel)sender;
            if (GameState == "playing")
            {
                //Left Mouse Click
                if (e.Button == MouseButtons.Left)
                {
                    if ((string)currentBox.Tag == "init")
                    {
                        currentBox.Tag = "box";
                        currentBox.BackColor = Color.Green;
                        currentBox.Enabled = false;
                        mine.Load(boxes);
                        AddPoint();
                    }
                    if ((string)currentBox.Tag=="mine")
                    {
                        GameState = "lost";
                        isGameOver();
                        return;
                    }
                    if (GamePoint==(ColumnCount*RowCount)-1)
                    {
                        GameState = "win";
                        isGameOver();
                        return;
                    }
                }
            }
        }

        //Check If Game is over
        private void isGameOver()
        {
            if (GameState == "lost")
            {
                //TODO
                MessageBox.Show("You Lose!");
            }
            else if (GameState == "win")
            {
                //TODO
                MessageBox.Show("You Win!");
            }
        }

        //Add Point
        private void AddPoint()
        {
            GamePoint ++;
        }
    }
}
