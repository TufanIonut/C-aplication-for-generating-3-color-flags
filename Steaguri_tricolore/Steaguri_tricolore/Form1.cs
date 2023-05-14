using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steaguri_tricolore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static bool verificare(int[] x, int nivel)
        {
            for (int i = 0; i < nivel; i++)
            {
                if (x[nivel] == x[i])
                {
                    return false;
                }
            }
            return true;
        }
        public List<Color> culoriSelectate = new List<Color>();
        public int punct = 0;
        private void btn_start_Click(object sender, EventArgs e)
        {
            List<Color> culoriUtilizate = new List<Color>();
            culoriUtilizate.Add(Color.Blue);
            culoriUtilizate.Add(Color.Red);
            culoriUtilizate.Add(Color.Black);
            culoriUtilizate.Add(Color.White);
            culoriUtilizate.Add(Color.Green);
            culoriUtilizate.Add(Color.Yellow);
            int[] x = new int[3];
            int nivel = 0;
            x[nivel] = 0;
            while (nivel > -1)
            {
                bool gasit = false;
                while (!gasit && x[nivel] < 6)
                {
                    x[nivel]++;
                    gasit = verificare(x, nivel);
                }
                if (gasit)
                {
                    if (nivel == 2)
                    {
                        foreach (var item in x)
                        {
                            culoriSelectate.Add(culoriUtilizate[item - 1]);
                        }
                        
                    }
                    else
                    {
                        nivel++;
                        x[nivel] = 0;
                    }
                }
                else
                {
                    nivel--;
                }
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            culoare1.BackColor = culoriSelectate[punct];
            culoare2.BackColor = culoriSelectate[punct + 1];
            culoare3.BackColor = culoriSelectate[punct + 2];
            punct++;
        }
    }
}

