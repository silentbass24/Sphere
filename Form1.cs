using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PaoloCiolaProvaFinale
{
    public partial class Form1 : Form
    {
        //instance of a new type sphere object
        Sfera sf = new Sfera();
        public Form1()
        {
            InitializeComponent();
        }
        //Exit button
        private void btnEsci_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //button calcola
        private void btnCalcola_Click(object sender, EventArgs e)
        {
            //method called based on the type of input: radius, Area or Volume

            try
            {
                //input Radius
                if (radioBtnRaggio.Checked) 
                {
                    sf.Raggio = Convert.ToDouble(txtRaggio.Text);

                    txtArea.Text = Math.Round(sf.Area(), 2).ToString();

                    txtVolume.Text = Math.Round(sf.VolumeSfera(), 2).ToString();
                //input Area    
                }else if(radioBtnArea.Checked) 
                {
                    sf.Superficie = Convert.ToDouble(txtArea.Text);

                    txtRaggio.Text = Math.Round(sf.SuptoRaggio(), 2).ToString();

                    txtVolume.Text = Math.Round(sf.SuptoVol(), 2).ToString();
                //input Volume
                }else if(radioBtnVolume.Checked) //valore noto volume
                {
                    sf.Volume = Convert.ToDouble(txtVolume.Text);

                    txtRaggio.Text = Math.Round(sf.VoltoRaggio(), 2).ToString();

                    txtArea.Text = Math.Round(sf.VoltoSup(), 2).ToString();
                }
                           
            }catch(Exception excp)
            {
                MessageBox.Show("Inserire correttamente il valore del campo che deve essere maggiore di zero" + excp);
            }
        }
        //button Save on file txt
        private void btnSalvaSuFile_Click(object sender, EventArgs e)
        {
            StreamWriter swobj;
            string percorso;
            if(radioBtnRaggio.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    percorso = saveFileDialog1.FileName;
                    swobj = File.CreateText(percorso);
                    swobj.Write(sf.StampaSferaRaggio());
                    swobj.Close();
                    MessageBox.Show("Scrittura file terminata");
                }
            }else if (radioBtnArea.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    percorso = saveFileDialog1.FileName;
                    swobj = File.CreateText(percorso);
                    swobj.Write(sf.StampaSferaArea());
                    swobj.Close();
                    MessageBox.Show("Scrittura file terminata");
                }
            }
            else if (radioBtnVolume.Checked)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    percorso = saveFileDialog1.FileName;
                    swobj = File.CreateText(percorso);
                    swobj.Write(sf.StampaSferaVolume());
                    swobj.Close();
                    MessageBox.Show("Scrittura file terminata");
                }
            }


        }
        //button Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtRaggio.Clear();
            txtVolume.Clear();
        }
    }
}
