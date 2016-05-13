using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_sim
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int m = 0;
        private String s;
        private int tick = 0;

        private int temp = 0;

        private int[] proc;
        private int[] tabY;

        private int[] memor;
        private int[] tabX;

        private System.Random x = new Random();

        private void generator_Click(object sender, EventArgs e)
        {
        

                s = numbers.Text;
                this.m = Convert.ToInt16(s);

                proc = new int[this.m];//proces
                tabY = new int[this.m];

                memor = new int[this.m];//pamiec
                tabX = new int[this.m];

                for (int i = 0; i < this.m; i++)
                {
                    proc[i] = x.Next(5, 20);
                }

                for (int i = 0; i < this.m; i++)
                {
                    memor[i] = x.Next(15, 30);
                }
            
            if (this.first.Checked)
            {
                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        if (proc[j] <= memor[i] && proc[j] != 0)
                        {
                            memor[i] -= proc[j];
                            tabX[i] = memor[i];
                            tabY[j] = proc[j];


                            proc[j] = 0;

                        }


                    }
                }

                timer.Enabled = true;
                timer.Start();
            }


            else if (this.best.Checked)
            {

                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.m - 1; j++)
                    {
                        if (memor[j] > memor[j + 1])
                        {
                            temp = memor[i];
                            memor[i] = memor[j];
                            memor[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        if (proc[j] <= memor[i] && proc[j] != 0)
                        {
                            memor[i] -= proc[j];
                            tabX[i] = memor[i];
                            tabY[j] = proc[j];


                            proc[j] = 0;

                        }


                    }
                }

                timer.Enabled = true;
                timer.Start();

            }


            else if (this.worst.Checked)
            {

                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        if (memor[i] < memor[j])
                        {
                            temp = memor[i];
                            memor[i] = memor[j];
                            memor[j] = temp;

                        }
                    }
                }

                for (int i = 0; i < this.m; i++)
                {
                    for (int j = 0; j < this.m; j++)
                    {
                        if (proc[j] <= memor[i] && proc[j] != 0)
                        {
                            memor[i] -= proc[j];
                            tabX[i] = memor[i];
                            tabY[j] = proc[j];


                            proc[j] = 0;

                        }


                    }
                }
                timer.Enabled = true;
                timer.Start();

            }


           



        }

        private void timer_Tick(object sender, EventArgs e)
        {

            this.chart.Series["Series"].Points.AddXY(tabX[this.tick], tabY[this.tick]);
            this.tick++;

            if (this.tick == this.m)
            {
                this.tick = 0;
                timer.Stop();
            }
        }
    }
}
