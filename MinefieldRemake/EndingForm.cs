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
    public partial class EndingForm : Form
    {
        #region GLOBAL VARIABLES
        string EndingText, FacePath;
        #endregion

        public EndingForm(string endingText,string facePath)
        {
            InitializeComponent();
            EndingText = endingText;
            FacePath = facePath;
        }

        //If user click face
        private void ClickFace(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //When user closes current form, close game
        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Load Ending Screen
        private void LoadScreen(object sender, EventArgs e)
        {
            Face.Image = Image.FromFile(FacePath);
            EndingLbl.Text = EndingText;
        }
    }
}
