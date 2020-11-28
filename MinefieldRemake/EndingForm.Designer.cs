
namespace MinefieldRemake
{
    partial class EndingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndingForm));
            this.Face = new System.Windows.Forms.PictureBox();
            this.EndingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Face)).BeginInit();
            this.SuspendLayout();
            // 
            // Face
            // 
            this.Face.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Face.Image = ((System.Drawing.Image)(resources.GetObject("Face.Image")));
            this.Face.Location = new System.Drawing.Point(74, 34);
            this.Face.Name = "Face";
            this.Face.Size = new System.Drawing.Size(32, 32);
            this.Face.TabIndex = 0;
            this.Face.TabStop = false;
            this.Face.Click += new System.EventHandler(this.ClickFace);
            // 
            // EndingLbl
            // 
            this.EndingLbl.AutoSize = true;
            this.EndingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EndingLbl.Location = new System.Drawing.Point(52, 108);
            this.EndingLbl.Name = "EndingLbl";
            this.EndingLbl.Size = new System.Drawing.Size(69, 16);
            this.EndingLbl.TabIndex = 1;
            this.EndingLbl.Text = "You Win!";
            this.EndingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.EndingLbl);
            this.Controls.Add(this.Face);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Field";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseGame);
            this.Load += new System.EventHandler(this.LoadScreen);
            ((System.ComponentModel.ISupportInitialize)(this.Face)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Face;
        private System.Windows.Forms.Label EndingLbl;
    }
}