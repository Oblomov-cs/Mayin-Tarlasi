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
        int refX, refY, guessCount;
        #endregion

        //Constructor
        public Mine()
        {
            rnd = new Random();
            guessCount = 84;
        }

        //Load Mine
        public void Load(Panel[,] boxes)
        {
            for (int i = 0; i < guessCount; i++)
            {
                RowNumber = rnd.Next(0, 6);
                ColumnNumber = rnd.Next(0, 14);
                if ((string)boxes[RowNumber,ColumnNumber].Tag=="init")
                {
                    boxes[RowNumber, ColumnNumber].Tag = "mine";
                    Delete(boxes);
                    refX = RowNumber;
                    refY = ColumnNumber;
                    guessCount -= 1;
                    break;
                }
            }
        }

        //Delete Older Mine
        private void Delete(Panel[,] boxes)
        {
            boxes[refX, refY].Tag = "init";
        }
    }
}
