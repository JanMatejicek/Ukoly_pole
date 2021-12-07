using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Úkol_pole_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox_before.Items.Clear();
            listBox_after.Items.Clear();
            textBox.Clear();
            try
            {
                if (radioButton_sestupne.Checked == true || radioButton_vzestupne.Checked == true) {
                    int N = int.Parse(textBox.Text);
                    int[] array = new int[N];
                    for (int i = 0; i < N; i++) {
                        array[i] = random.Next(1, 50);
                        listBox_before.Items.Add(array[i]);
                    }
                    Array.Sort(array);
                    if (radioButton_vzestupne.Checked == true) { foreach (int cislo in array) { listBox_after.Items.Add(cislo); } }
                    if (radioButton_sestupne.Checked == true){
                        array = array.Reverse().ToArray();
                        foreach (int cislo in array) { listBox_after.Items.Add(cislo); }
                    }
                }
                else { MessageBox.Show("Zadej setřídění pole"); }
            }
            catch { MessageBox.Show("Zadej prosím číslo!!"); }
        }
    }
}
