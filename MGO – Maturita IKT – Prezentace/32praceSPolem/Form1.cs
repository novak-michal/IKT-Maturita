using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praceSPolem
{
    public partial class oknoProgramu : Form
    {
        public oknoProgramu()
        {
            InitializeComponent();
        }
        int[] našePole = new int[101];

        //vypíše obsah pole do textboxu vpravo
        private void VypišPole()
        {
            poleObsahPole.Text = null;
            foreach (int číslo in našePole)
                poleObsahPole.Text += číslo + Environment.NewLine;
        }
        
        private void QuickSort(int levý, int pravý)
        {
            if (levý < pravý)
            {
                int pomocná;
                int hranice = levý;
                //první prvek je pivot
                int pivot = levý;
                //projdeme pole, prvky větší než pivot přesuneme k sobě
                for (int i = levý + 1; i <= pravý; i++)
                    if (našePole[i] < našePole[pivot])
                    {
                        hranice++;
                        //přesun prvků
                        pomocná = našePole[hranice];
                        našePole[hranice] = našePole[i];
                        našePole[i] = pomocná;
                    }
                //posun pivotu mezi malé a velké
                pomocná = našePole[hranice];
                našePole[hranice] = našePole[pivot];
                našePole[pivot] = pomocná;
                //zavolat quicksort na části rozděleného pole
                QuickSort(levý, hranice - 1);
                QuickSort(hranice + 1, pravý);
            } 
            }
        

        private void tlačítkoNaplňPole_Click(object sender, EventArgs e)
        {
            int start=Convert.ToInt32(poleStartovacíČíslo.Text);
            for (int i = 0; i < našePole.Length; i++)
            {
                našePole[i] = i + start;
            }
            VypišPole();
        }

        private void tlačítkoVypišPole_Click(object sender, EventArgs e)
        {
            VypišPole();
        }

        private void tlačítkoHledejČíslo_Click(object sender, EventArgs e)
        {
            int hledanéČíslo = Convert.ToInt32(poleHledanéČíslo.Text);
            for (int i =0;i<našePole.Length;i++)
            {
                if (našePole[i] == hledanéČíslo)
                {
                    MessageBox.Show("Číslo " + hledanéČíslo + " se v poli nachází na pozici: " + i, "Zpráva o hledání");
                    return;
                }
            }
            MessageBox.Show("Číslo " + hledanéČíslo + " se v poli nenachází.", "Zpráva o hledání");
        }

        private void tlačítkoNaplňNáhodně_Click(object sender, EventArgs e)
        {
            Random náhoda =new Random();
            int minimum = Convert.ToInt32(poleČíslaOd.Text);
            int maximum = Convert.ToInt32(poleČíslaDo.Text);
            for (int i = 0; i < našePole.Length; i++)
            {
                našePole[i] = náhoda.Next(minimum, maximum + 1);
            }
            VypišPole();
        }

        private void tlačítkoProhoď_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(polePozice1.Text);
            int j = Convert.ToInt32(polePozice2.Text);
            int pomocná = našePole[i];
            našePole[i] = našePole[j];
            našePole[j] = pomocná;
            VypišPole();
        }

        private void tlačítkoSeřaďBubblesort_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            for (j=našePole.Length-1;j>0;j--)
                for (i=0;i<j;i++)
                    if(našePole[i]>našePole[i+1])
                    {
                        int pomocná = našePole[i];
                        našePole[i] = našePole[i+1];
                        našePole[i+1] = pomocná;
                    }
            VypišPole();
        }

        private void tlačítkoSeřaďQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort(0, našePole.Length - 1);
            VypišPole();
        }
    }
}
