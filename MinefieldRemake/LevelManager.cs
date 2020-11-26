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
<<<<<<< HEAD
<<<<<<< HEAD
=======
        private int RefI { get; set; }
        private int RefJ { get; set; }
>>>>>>> test
=======
        private int RefI { get; set; }
        private int RefJ { get; set; }
>>>>>>> test
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
<<<<<<< HEAD
<<<<<<< HEAD
            //TODO
=======
>>>>>>> test
=======
>>>>>>> test
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    boxes[i, j] = new Panel();
                    boxes[i, j].Location = new Point(RefX, RefY);
                    boxes[i, j].Size = new Size(Width, Height);
                    boxes[i, j].BackColor = Color.White;
                    boxes[i, j].Cursor = Cursors.Hand;
<<<<<<< HEAD
<<<<<<< HEAD
                    boxes[i, j].Tag = "box";
                    screen.Controls.Add(boxes[i, j]);
=======
                    boxes[i, j].BackColor = Color.Green;
                    screen.Controls.Add(boxes[i, j]);
                    boxes[i, j].Click += new System.EventHandler(Click);
>>>>>>> test
=======
                    boxes[i, j].BackColor = Color.Green;
                    screen.Controls.Add(boxes[i, j]);
                    boxes[i, j].Click += new System.EventHandler(Click);
>>>>>>> test
                    RefX += Width + 10;
                }
                RefY += Height + 10;
                RefX = 12;
            }
            mine.Load(boxes);
        }

        //When user does mouse rigth click, add flag
        public void AddFlag()
        {
            //TODO
        }

<<<<<<< HEAD
<<<<<<< HEAD
        //Update Game
        public void Update()
        {
            //TODO
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    boxes[i, j].Click += new System.EventHandler(Click);
                }
            }
        }

        //Click 
        public void Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    if ((string)boxes[i,j].Tag=="mine")
                    {
                        MessageBox.Show("Got You");
                        GameState = "done";
                        break;
                    }
                }
            }
        }
=======
=======
>>>>>>> test
        //Click 
        public void Click(object sender, EventArgs e)
        {
            //TODO
            Panel currentBox = (Panel)sender;
            if ((string)currentBox.Tag=="mine")
            {
                //TODO
                MessageBox.Show("Over!");
            }
        }

<<<<<<< HEAD
>>>>>>> test
=======
>>>>>>> test
    }
}
