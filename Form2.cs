using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form2 : Form
    {
        //Puan say
        int Count = 0;
        Form1 F1;
        //buton dizisi tanımla
        Button[,] NewButton = new Button[5,5];
        public Form2(Form1 frm)
        {
            InitializeComponent();
            // Lock form
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.F1 = frm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //form2 ayarları
            this.Location = Properties.Settings.Default.Location;
            this.Size = Properties.Settings.Default.Size;
            axWindowsMediaPlayer1.URL = @"C:\Users\user\Desktop\Ahmet General Documents\C#\MayınTarlası\undertale-megalovania (online-audio-converter.com).wav";
            //point sınıfı tanımla
            Point NewPoint = new Point();
            //İsimleri eşle
            label2.Text = F1.textBox2.Text;
            //Dinamik Buton Üret
            for (int i = 0; i < NewButton.GetLength(0); i++)
            {
                for (int j = 0; j < NewButton.GetLength(1); j++)
                {
                    //buton sınıfını çağır
                    NewButton[i, j] = new Button();
                    //buton size ayarla
                    NewButton[i, j].Height = 50;
                    NewButton[i, j].Width = 50;
                    //buton x ve y değerlerini ayarla
                    NewPoint.X = 100 + i * 50;
                    NewPoint.Y = 100 + j * 50;
                    //buton x ve y değerlerini ata
                    NewButton[i, j].Location = NewPoint;
                    //butona isim ver
                    NewButton[i, j].Text = i.ToString() + j.ToString();
                    NewButton[i, j].BackColor = Color.Green;
                    //butonu forma ekle
                    this.Controls.Add(NewButton[i, j]);
                    //*****************************************************
                    //butonları ürettikten sonra
                    NewButton[i,j].Click+= new System.EventHandler(this.Tıkla);
                }
            }
        }
        private void Tıkla(object sender, EventArgs e)
        {
            //butonları ilişkile
            Button Yeni = (Button)sender;
            //random sınıfını çağır
            Random R = new Random();
            int x, y;
            x = R.Next(0, 5);
            y = R.Next(0, 5);
            //herhangi bir butonu mayın yap
            NewButton[x, y].Name = "Mayın";
            //tıklanan butonları kırmızı yap
            Yeni.BackColor = Color.Red;
            //tıklanan butonları kapat
            Yeni.Enabled = false;
            //puan saydır
            Count+=5;
            if (Yeni.Name=="Mayın")
            {
                label4.Text = Count.ToString();
                MessageBox.Show($"Oyun Bitti");
                for (int i = 0; i < NewButton.GetLength(0); i++)
                {
                    for (int j = 0; j < NewButton.GetLength(1); j++)
                    {
                        NewButton[i, j].Enabled = false;
                    }
                }
            }
        }               

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }       //baştan başlat




    }
}
