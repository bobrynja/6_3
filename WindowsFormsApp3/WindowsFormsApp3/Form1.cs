using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int buf;
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            if (n <= 0 || m <= 0) MessageBox.Show("Размер массива не может быть отрицательным или равным 0");
            else
            {
                int[,] arr = new int[n, m];
                //Заполнение массива
                string[] a = textBox3.Text.Split('\n');
                for (int i = 0; i < n; i++)
                {
                    string[] b = a[i].Split(' ');
                    b = a[i].Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = Convert.ToInt32(b[j]);
                    }
                }
                int st_1 = 0;
                int st_2 = 0;
                if (m % 2 == 0)
                {
                    st_1 = m / 2 - 1;
                    st_2 = m / 2;
                }
                else
                {
                    st_1 = 0;
                    st_2 = m / 2;
                }
                for (int i = 0; i < n; i++)
                {
                    buf = arr[i, st_1];
                    arr[i, st_1] = arr[i, st_2];
                    arr[i, st_2] = buf;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        textBox4.Text += (arr[i, j] + "  ");
                    }
                    textBox4.Text += Environment.NewLine;
                }
                 }
                }
                catch { MessageBox.Show("Некорректный ввод данных!!!"); }
                }
            
        
    }
}
