using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinefieldRemake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region GLOBAL VARIABLES
        LevelManager level;
        #endregion

        //Load Game Screen
        private void LoadScreen(object sender, EventArgs e)
        {
            level = new LevelManager(this);
            level.Load();
        }
    }
}
