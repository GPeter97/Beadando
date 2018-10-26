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

namespace beadandosokpntnulla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mentes.Click += (sender, e) => { Mentes(); };
            betoltes.Click += (sender, e) => { Megnyitas(); };
        }

        private void radioButtonN_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Mentes()
        {
            string tartalom = listBox1.Items.ToString();
            string tartalom1 = listBox1.SelectedItem.ToString();
            string tartalom2 = textBoxN.Text;
            string tartalom3 = textBoxD.Text;
            string tartalom4 = radioButtonF.Text;
            string tartalom5 = radioButtonN.Text;
 
            saveFileDialog1.FileName = "";
            var eredmeny = saveFileDialog1.ShowDialog(this);

            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog1.FileName;
               
                string hobbik = "";

                foreach (string hobbi in listBox1.Items)
                {
                    hobbik = hobbik + hobbi + Environment.NewLine;
                }
                hobbik = Environment.NewLine + hobbik;
                if (radioButtonF.Checked == true)
                {
                    File.WriteAllText(fileNev, "Név: " + tartalom2 + "\nNem: Férfi\nSzületési Dátum: " + tartalom3 + "\nKedvenc hobbi: " + tartalom1 + "\n" + hobbik);
                }
                else
                {
                    File.WriteAllText(fileNev, "Név: " + tartalom2 + "\nNem: Nő\nSzületési Dátum: " + tartalom3 + "\nKedvenc hobbi: " + tartalom1 + "\n" + hobbik);

                }


                MessageBox.Show("Sikeres mentés");
            }
        }
        private void Megnyitas()
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                
                MessageBox.Show(File.ReadAllText(openFileDialog1.FileName));
            }

        }
        
        private void hozzadas_Click_1(object sender, EventArgs e)
        {
            if (textBoxH.Text != null)
            {
                string[] Hobbik = System.Text.RegularExpressions.Regex.Split(textBoxH.Text, "\r\n");
                listBox1.Items.AddRange(Hobbik);
                textBoxH.Clear();
            }
        }
    }
}
