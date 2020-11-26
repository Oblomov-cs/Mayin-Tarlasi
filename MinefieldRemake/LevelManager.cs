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
        private string GameState { get; set; }
        private int GamePoint { get; set; }
        private int RowCount { get; set; }
        private int ColumnCount { get; set; }
        private int RefX { get; set; }
        private int RefY { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }
        #endregion

        #region GLOBAL VARIABLES
        Panel[,] addedPanels;
        Form screen;
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
            addedPanels = new Panel[ColumnCount,RowCount];
        }


        //Load Level
        public void Load()
        {
            //TODO
            for (int i = 0; i < ColumnCount; i++)
            {
                for (int j = 0; j < RowCount; j++)
                {
                    addedPanels[i, j] = new Panel();
                    addedPanels[i, j].Location = new Point(RefX, RefY);
                    addedPanels[i, j].Size = new Size(Width, Height);
                    addedPanels[i, j].BackColor = Color.White;
                    addedPanels[i, j].Cursor = Cursors.Hand;
                    screen.Controls.Add(addedPanels[i, j]);
                    RefX += Width + 10;
                }
                RefY += Height + 10;
                RefX = 12;
            }
        }

        public void Click()
        {
            //TODO
        }

        public void AddFlag()
        {
            //TODO
        }

        public void Update()
        {
            //TODO
        }
    }
}
