using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinefieldRemake
{
    class Mine
    {
        #region PROPS
        private int RowNumber { get; set; }
        private int ColumnNumber { get; set; }
        #endregion

        #region GLOBAL VARIABLES
        Random rnd;
        #endregion

        //Constructor
        public Mine()
        {
            rnd = new Random();
            RowNumber = rnd.Next(0, 6);
            ColumnNumber = rnd.Next(0, 14);
        }


        //Load Mine
        public void Load(Panel[,] boxes)
        {
            boxes[RowNumber,ColumnNumber].Tag = "mine";
            boxes[RowNumber, ColumnNumber].BackColor = Color.Blue;
        }
    }
}
