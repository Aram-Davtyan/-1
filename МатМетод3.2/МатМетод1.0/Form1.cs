using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МатМетод1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyClose()
        {
            if (MessageBox.Show("Закрыть приложение?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                == DialogResult.Yes)
                Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           /* double[,] a1 = {
                              {7,-1,1,0,1,3},
                              {14,1,1,1,1,2},
                              {8,1,5,-1,1,-4}
                            };
           */
               double[,] a1  = new double[3, 6];
               a1[0, 0] = (double)A10.Value;   a1[0, 1] = (double)A11.Value;   a1[0, 2] = (double)A12.Value;   a1[0, 3] = (double)A13.Value;   a1[0, 4] = (double)A14.Value;   a1[0, 5] = (double)A15.Value;

               a1[1, 0] = (double)A20.Value;   a1[1, 1] = (double)A21.Value;   a1[1, 2] = (double)A22.Value;   a1[1, 3] = (double)A23.Value;   a1[1, 4] = (double)A24.Value;   a1[1, 5] = (double)A25.Value;

               a1[2, 0] = (double)A30.Value;   a1[2, 1] = (double)A31.Value;   a1[2, 2] = (double)A32.Value;   a1[2, 3] = (double)A33.Value;   a1[2, 4] = (double)A34.Value;   a1[2, 5] = (double)A35.Value;
            

            double[,] a = new double[3, 9];
            int[] baz = { 6, 7, 8 };

            //double[] CB = { 0, 5, 5, 4, 2, 0, -1, -1, -1 };
            double[] CB = new double[9];
            CB[0] = 0; CB[1] = (double)C11.Value; CB[2] = (double)C12.Value; CB[3] = (double)C13.Value; CB[4] = (double)C14.Value; CB[5] = (double)C15.Value; ; CB[6] = -1; CB[7] = -1; CB[8] = -1;



            // double[] CBB = { 0, -1, -3, -2, 0, 2 };
            double[] CBB = new double[6];
            CBB[0] = 0; CBB[1] = (double)C21.Value; CBB[2] = (double)C22.Value; CBB[3] = (double)C23.Value; CBB[4] = (double)C24.Value; CBB[5] = (double)C25.Value;

            double[] Cb = { -1, -1, -1 };
            double[] Cbb = new double[3];
            double[] Dj = new double[9];
            double[] Djj = new double[9];

            double OpEl;



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = a1[i, j];
                }
            }


            int f;
            for (int i = 0; i < 3; i++)
            {
                f = 0;
                for (int j = 6; j < 9; j++)
                {
                    if (i == f)
                        a[i, j] = 1;
                    else
                        a[i, j] = 0;


                    if (i == f)
                        a[i, j] = 1;
                    else
                        a[i, j] = 0;


                    if (i == f)
                        a[i, j] = 1;
                    else
                        a[i, j] = 0;

                    f++;
                }
            }


            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");



            for (int i = 0; i < 9; i++)
            {
                double sum1 = 0;
                double sum2 = 0;

                if (baz[0] == 6 || baz[0] == 7 || baz[0] == 8)
                {
                    sum2 += Cb[0] * a[0, i];
                }
                else
                {
                    sum1 += Cb[0] * a[0, i];
                }


                if (baz[1] == 6 || baz[1] == 7 || baz[1] == 8)
                {
                    sum2 += Cb[1] * a[1, i];
                }
                else
                {
                    sum1 += Cb[1] * a[1, i];
                }


                if (baz[2] == 6 || baz[2] == 7 || baz[2] == 8)
                {
                    sum2 += Cb[2] * a[2, i];
                }
                else
                {
                    sum1 += Cb[2] * a[2, i];
                }

                if (i >= 6)
                    sum2 -= CB[i];
                else
                    sum1 -= CB[i];

                Dj[i] = sum1;
                Djj[i] = sum2;

            }




            for (int j = 0; j < 9; j++)
            {
                Console.Write(Dj[j] + " ");
            }

            Console.WriteLine(" ");

            for (int j = 0; j < 9; j++)
            {
                Console.Write(Djj[j] + " ");
            }
            Console.WriteLine(" ");


            bool flag = true;
            while (flag)
            {
                double[] q = new double[3];
                double minDjj;
                int minJ, minI;

                minDjj = Djj[1];
                minJ = 1;
                for (int i = 1; i < 9; i++)
                {
                    if (Djj[i] < minDjj)
                    {
                        minDjj = Djj[i];
                        minJ = i;
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(minDjj + " ");
                Console.WriteLine(minJ + " ");



                for (int i = 0; i < 3; i++)
                {
                    q[i] = a[i, 0] / a[i, minJ];
                }

                double minStolb;
                minStolb = 999999999999;
                minI = -1;
                for (int i = 0; i < 3; i++)
                {
                    if (q[i] < minStolb && a[i, minJ] > 0)
                    {
                        minStolb = q[i];
                        minI = i;
                    }

                }


                Console.WriteLine(" ");
                Console.WriteLine(minStolb + " ");
                Console.WriteLine(minI + " ");




                OpEl = a[minI, minJ];


                Console.WriteLine(" ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(baz[i] + " ");
                }
                Console.WriteLine(" ");



                for (int i = 0; i < 9; i++)
                {
                    a[minI, i] /= OpEl;
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");



                double[,] ax = new double[3, 9];
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 9; j++)
                    {

                        ax[i, j] = a[i, j];
                    }
                }


                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 9; j++)
                    {
                        if (i == minI)
                            continue;

                        a[i, j] = ax[i, j] - ax[minI, j] * ax[i, minJ];
                    }
                }

                baz[minI] = minJ;
                Cb[minI] = CB[minJ];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(baz[i] + " ");
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(Cb[i] + " ");
                }

                Console.WriteLine(" ");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(a[i, j] + "                ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");




                for (int i = 0; i < 9; i++)
                {
                    double sum1 = 0;
                    double sum2 = 0;

                    if (baz[0] == 6 || baz[0] == 7 || baz[0] == 8)
                    {
                        sum2 += Cb[0] * a[0, i];
                    }
                    else
                    {
                        sum1 += Cb[0] * a[0, i];
                    }


                    if (baz[1] == 6 || baz[1] == 7 || baz[1] == 8)
                    {
                        sum2 += Cb[1] * a[1, i];
                    }
                    else
                    {
                        sum1 += Cb[1] * a[1, i];
                    }


                    if (baz[2] == 6 || baz[2] == 7 || baz[2] == 8)
                    {
                        sum2 += Cb[2] * a[2, i];
                    }
                    else
                    {
                        sum1 += Cb[2] * a[2, i];
                    }

                    if (i >= 6)
                        sum2 -= CB[i];
                    else
                        sum1 -= CB[i];

                    Dj[i] = sum1;
                    Djj[i] = sum2;

                }



                for (int j = 0; j < 9; j++)
                {
                    Console.Write(Dj[j] + " ");
                }

                Console.WriteLine(" ");

                for (int j = 0; j < 9; j++)
                {
                    Console.Write(Djj[j] + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                double sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    sum += baz[i];
                }
                if (sum <= 12)
                    flag = false;

            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    a1[i, j] = a[i, j];
                }
            }


            Console.WriteLine(" ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(a1[i, j] + "                ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");


            flag = true;
            while (flag)
            {
                double[] q = new double[3];
                double minDj;
                int minJ, minI;

                minDj = Dj[1];
                minJ = 1;
                for (int i = 1; i < 6; i++)
                {
                    if (Dj[i] < minDj)
                    {
                        minDj = Dj[i];
                        minJ = i;
                    }
                }
                Console.WriteLine(" ");
                Console.WriteLine(minDj + " ");
                Console.WriteLine(minJ + " ");



                for (int i = 0; i < 3; i++)
                {
                    
                    q[i] = a1[i, 0] / a1[i, minJ];
                }

                double minStolb;
                minStolb = 999999999999;
                minI = -1;
                for (int i = 0; i < 3; i++)
                {
                    if (q[i] < minStolb && a1[i, minJ] > 0)
                    {
                        minStolb = q[i];
                        minI = i;
                    }

                }


                Console.WriteLine(" ");
                Console.WriteLine(minStolb + " ");
                Console.WriteLine(minI + " ");




                OpEl = a[minI, minJ];


                Console.WriteLine(" ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(baz[i] + " ");
                }
                Console.WriteLine(" ");



                for (int i = 0; i < 6; i++)
                {
                    a1[minI, i] /= OpEl;
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");



                double[,] ax = new double[3, 6];
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {

                        ax[i, j] = a1[i, j];
                    }
                }


                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        if (i == minI)
                            continue;

                        a1[i, j] = ax[i, j] - ax[minI, j] * ax[i, minJ];
                    }
                }

                baz[minI] = minJ;
                Cb[minI] = CB[minJ];

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(baz[i] + " ");
                }
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(Cb[i] + " ");
                }

                Console.WriteLine(" ");

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(a1[i, j] + "                ");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");




                for (int i = 0; i < 6; i++)
                {
                    double sum1 = 0;



                    sum1 += Cb[0] * a1[0, i];

                    sum1 += Cb[1] * a1[1, i];

                    sum1 += Cb[2] * a1[2, i];

                    sum1 -= CB[i];

                    Dj[i] = sum1;


                }



                for (int j = 0; j < 6; j++)
                {
                    Console.Write(Dj[j] + " ");
                }

                Console.WriteLine(" ");

                for (int j = 0; j < 6; j++)
                {
                    Console.Write(Djj[j] + " ");
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                int kol = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (Dj[i] < 0)
                        kol++;
                }
                if (kol == 0)
                    flag = false;


            }

            for (int i = 0; i < 3; i++)
            {

                Cbb[i] = CBB[baz[i]];

            }


            for (int i = 0; i < 6; i++)
            {

                double sum2 = 0;



                sum2 += Cbb[0] * a1[0, i];

                sum2 += Cbb[1] * a1[1, i];

                sum2 += Cbb[2] * a1[2, i];

                sum2 -= CBB[i];

                Djj[i] = sum2;


            }
            Console.WriteLine(" ");

            for (int j = 0; j < 6; j++)
            {
                Console.Write(Dj[j] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine(" ");

            for (int j = 0; j < 6; j++)
            {
                Console.Write(Djj[j] + " ");
            }
            Console.WriteLine(" ");

            ////СКЛЕЙКА

            double[,] a2 = new double[3, 5];
            double[] b = new double[3];
            double[,] dd = new double[2, 5];
            double[,] cc = new double[2, 5];
            bool[] bazis = new bool[5];
            double[] cbaz = new double[3];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = a1[i, j + 1];

            for (int i = 0; i < 3; i++)
                b[i] = a1[i, 0];

            for (int i = 0; i < 5; i++)
                cc[0, i] = CB[i + 1];

            for (int i = 0; i < 5; i++)
                cc[1, i] = CBB[i + 1];

            for (int j = 0; j < 5; j++)
                dd[0, j] = Dj[j + 1];

            for (int j = 0; j < 5; j++)
                dd[1, j] = Djj[j + 1];


            for (int i = 0; i < 3; i++)
                cbaz[i] = Cb[i];



            double[,] al = new double[3, 5];
            double[] bl = new double[3];
            double[,] ddl = new double[2, 5];
            double[,] ccl = new double[2, 5];
            int[] bazl = new int[3];
            double[] cbazl = new double[3];
            int pol = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    al[i, j] = a1[i, j + 1];

            for (int i = 0; i < 3; i++)
                bl[i] = a1[i, 0];

            for (int i = 0; i < 5; i++)
                ccl[0, i] = CB[i + 1];

            for (int i = 0; i < 5; i++)
                ccl[1, i] = CBB[i + 1];

            for (int j = 0; j < 5; j++)
                ddl[0, j] = Dj[j + 1];

            for (int j = 0; j < 5; j++)
                ddl[1, j] = Djj[j + 1];

            for (int i = 0; i < 3; i++)
            {
                bazl[i] = baz[i];
                cbazl[i] = Cb[i];
            }

            pol = 0;
            for (int i = 0; i < 5; i++)
                if (ddl[1, i] > 0 && ddl[1, i] != 0)
                    pol++;
            double lbn = 0, lbv = 0, chp1 = 0, chp2 = 0, cho1 = 0, cho2 = 0;
            bool ln = false, lv = false;
            double[] lb = new double[5];

            for (int i = 0; i < 5; i++)
                if (dd[1, i] != 0)
                    lb[i] = -dd[0, i] / dd[1, i];
                else
                    lb[i] = 0;


            if (pol == 2)
                lv = true;
            if (pol == 0)
                ln = true;
            for (int i = 0; i < 5; i++)
                if (ddl[1, i] > 0)
                    chp1 = -ddl[0, i] / ddl[1, i];
                else if (ddl[1, i] < 0)
                    cho1 = -ddl[0, i] / ddl[1, i];
            for (int i = 4; i >= 0; i--)
                if (ddl[1, i] > 0)
                    chp2 = -ddl[0, i] / ddl[1, i];
                else if (ddl[1, i] < 0)
                    cho2 = -ddl[0, i] / ddl[1, i];

            for (int i = 0; i < 5; i++)
            {
                if (ddl[1, i] > 0)
                    if (chp1 > chp2)
                        lbn = chp1;
                    else
                        lbn = chp2;
                if (ddl[1, i] < 0)
                    if (cho1 < cho2)
                        lbv = cho1;
                    else
                        lbv = cho2;
            }

            double[] x = new double[5];

            Console.WriteLine(" ");

            double f1 = 0, f2 = 0;
            if (lv)
            {
                Console.WriteLine("Отрезок:  [ " + lbn + "; +oo )");
                Console.WriteLine("l* -> +oo");

                label7.Text = "Отрезок:  [ " + lbn + "; +oo )";
                label8.Text = "l* -> +oo";
            }
            else if (ln)
            {
                Console.WriteLine("Отрезок: (-oo ; " + lbv + " ]");
                Console.WriteLine("l* -> -oo");

                label7.Text = "Отрезок: (-oo ; " + lbv + " ]";
                label8.Text = "l* -> -oo";
            }

            else
            {
                Console.WriteLine(" ");

                Console.WriteLine("Отрезок: [ " + lbv + " ; " + lbv + " ]");
                label7.Text = "Отрезок: [ " + lbv + " ; " + lbv + " ]";
                for (int i = 0; i < 5; i++)
                    x[i] = 0;
                for (int i = 0; i < 3; i++)
                    x[baz[i] - 1] = b[i];
                Console.Write("x* = (");
                label8.Text = "x* = (";
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(x[i] + " ");
                    label8.Text = label8.Text + x[i] + " ";
                }
                Console.Write(")");
                label8.Text = label12.Text + ")";
                for (int i = 0; i < 3; i++)
                {
                    f1 += cc[0, baz[i] - 1] * b[i];
                    f2 += cc[1, baz[i] - 1] * b[i];
                }
                Console.WriteLine("f* = " + f1 + " + (" + f2 + "lb)");
                label9.Text = "f* = " + f1 + " + (" + f2 + "lb)";
            }
            Console.WriteLine(" ");
            while (pol != 0) //////////////////////////////// БЫЛО = 0
            {
                lbv = lbn;
                lbn = 0;
                double min = lbv;
                int n = 0;
                for (int i = 4; i >= 0; i--)
                    if (-dd[0, i] / dd[1, i] == min && dd[1, i] != 0)
                        n = i;
                double max = 0;
                for (int i = 2; i >= 0; i--)
                    if (b[i] / a[i, n] > max)
                        max = b[i] / a[i, n];
                for (int i = 0; i < 3; i++)
                    if (b[i] / a[i, n] < max && a[i, n] > 0)
                        max = b[i] / a[i, n];
                int m = 0;
                for (int i = 2; i >= 0; i--)
                    if (b[i] / a[i, n] == max)
                        m = i;
                baz[m] = n + 1;
                b[m] /= a[m, n];
                for (int i = 0; i < 5; i++)
                    if (i != n)
                        a[m, i] /= a[m, n];
                
                for (int i = 0; i < 5; i++)
                    if (i == n)
                        a[m, i] /= a[m, n];
                for (int i = 0; i < 3; i++)
                {
                    if (i != m)
                        b[i] = b[i] - b[m] * a[i, n];
                    for (int j = 0; j < 5; j++)
                        if (i != m && j != n)
                            a[i, j] = a[i, j] - a[m, j] * a[i, n];
                    for (int j = 0; j < 5; j++)
                        if (i != m && j == n)
                            a[i, j] = a[i, j] - a[m, j] * a[i, n];
                }
                for (int i = 0; i < 3; i++)
                    cbaz[i] = cc[0, baz[i] - 1];
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 5; j++)
                        dd[i, j] = 0;
                //
                for (int i = 0; i < 5; i++)
                {
                    dd[0, i] = cc[0, baz[0] - 1] * a[0, i] + cc[0, baz[1] - 1] * a[1, i] + cc[0, baz[2] - 1] * a[2, i] - cc[0, i];
                    dd[1, i] = cc[1, baz[0] - 1] * a[0, i] + cc[1, baz[1] - 1] * a[1, i] + cc[1, baz[2] - 1] * a[2, i] - cc[1, i];
                }
                pol = 0;///////////////////////////////////////// БЫЛО = 1
                for (int i = 0; i < 5; i++)
                    if (dd[1, i] > 0)
                        pol++;
                for (int i = 0; i < 5; i++)
                    if (dd[1, i] != 0)
                        lb[i] = -dd[0, i] / dd[1, i];
                    else
                        lb[i] = 0;
                ln = false;
                if (pol == 0)
                    ln = true;
                for (int i = 0; i < 5; i++)
                    if (lbv > lb[i] && dd[1, i] != 0)
                        lbn = lb[i];
                Console.WriteLine(" ");
                if (ln)
                {
                    Console.WriteLine("Отрезок: (-oo ; " + lbv + " ]");
                    Console.WriteLine("l* -> -oo");

                    label10.Text = "Отрезок: (-oo ; " + lbv + " ]";
                    label11.Text = "l* -> -oo";
                }


                else
                {
                    Console.WriteLine("Отрезок: [ " + lbn + " ; " + lbv + " ]");
                    label10.Text = "Отрезок: [ " + lbn + " ; " + lbv + " ]";
                    for (int i = 0; i < 5; i++)
                        x[i] = 0;
                    for (int i = 0; i < 3; i++)
                        x[baz[i] - 1] = b[i];
                    Console.Write("x* = (" + " ");
                    label11.Text = "x* = (" + " ";
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(x[i] + " ");
                        label11.Text = label11.Text+x[i] + " ";
                    }
                    Console.WriteLine(")");
                    label11.Text = label11.Text + ")";
                    f1 = 0; f2 = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        f1 += cc[0, baz[i] - 1] * b[i];
                        f2 += cc[1, baz[i] - 1] * b[i];
                    }
                    Console.WriteLine("f* = " + f1 + " + (" + f2 + "lb)");
                    label12.Text = "f* = " + f1 + " + (" + f2 + "lb)";
                }
            }
            /////////////////////

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = al[i, j];
            for (int i = 0; i < 3; i++)
                b[i] = bl[i];
            for (int i = 0; i < 5; i++)
                cc[0, i] = ccl[0, i];
            for (int i = 0; i < 5; i++)
                cc[1, i] = ccl[1, i];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 5; j++)
                    dd[i, j] = ddl[i, j];
            for (int i = 0; i < 3; i++)
            {
                baz[i] = bazl[i];
                cbaz[i] = cbazl[i];
            }
            for (int i = 0; i < 5; i++)
                if (dd[1, i] != 0)
                    lb[i] = -dd[0, i] / dd[1, i];
                else
                    lb[i] = 0;
            pol = 0;
            for (int i = 0; i < 5; i++)
                if (ddl[1, i] > 0 && ddl[1, i] != 0)
                    pol++;
            ln = false; lv = false;
            if (pol == 2)
                lv = true;
            if (pol == 0)
                ln = true;
            for (int i = 0; i < 5; i++)
                if (ddl[1, i] > 0)
                    chp1 = -ddl[0, i] / ddl[1, i];
                else if (ddl[1, i] < 0)
                    cho1 = -ddl[0, i] / ddl[1, i];
            for (int i = 4; i >= 0; i--)
                if (ddl[1, i] > 0)
                    chp2 = -ddl[0, i] / ddl[1, i];
                else if (ddl[1, i] < 0)
                    cho2 = -ddl[0, i] / ddl[1, i];
            for (int i = 0; i < 5; i++)
            {
                if (ddl[1, i] > 0)
                    if (chp1 > chp2)
                        lbn = chp1;
                    else
                        lbn = chp2;
                if (ddl[1, i] < 0)
                    if (cho1 < cho2)
                        lbv = cho1;
                    else
                        lbv = cho2;
            }

            ///////////////////////////////
            while (pol != 2)
            {
                lbn = lbv;
                lbv = 0;
                double min = lbn;
                int n = 0;
                for (int i = 4; i >= 0; i--)
                    if (-dd[0, i] / dd[1, i] == min)
                        n = i;
                double max = 0;
                for (int i = 2; i >= 0; i--)
                    if (b[i] / a[i, n] > max)
                        max = b[i] / a[i, n];
                for (int i = 0; i < 3; i++)
                    if (b[i] / a[i, n] < max && a[i, n] > 0)
                        max = b[i] / a[i, n];
                int m = 0;
                for (int i = 2; i >= 0; i--)
                    if (b[i] / a[i, n] == max)
                        m = i;
                baz[m] = n + 1;
                b[m] /= a[m, n];
                for (int i = 0; i < 5; i++)
                    if (i != n)
                        a[m, i] /= a[m, n];
                for (int i = 0; i < 5; i++)
                    if (i == n)
                        a[m, i] /= a[m, n];
                for (int i = 0; i < 3; i++)
                {
                    if (i != m)
                        b[i] = b[i] - b[m] * a[i, n];
                    for (int j = 0; j < 5; j++)
                        if (i != m && j != n)
                            a[i, j] = a[i, j] - a[m, j] * a[i, n];
                    for (int j = 0; j < 5; j++)
                        if (i != m && j == n)
                            a[i, j] = a[i, j] - a[m, j] * a[i, n];
                }
                for (int j = 0; j < 5; j++)
                {
                    double sk = 0;
                    for (int i = 0; i < 3; i++)
                        sk += a[i, j];
                    for (int i = 0; i < 3; i++)
                        if (sk == 1 && (a[i, j] == 1 || a[i, j] == 0))
                            bazis[j] = true;
                        else
                            bazis[j] = false;
                }

               


               // int kb = 0;
                //
                 // for (int i = 0; i < 5; i++)
                  //   kb += bazis[i];
                for (int i = 0; i < 3; i++)
                    cbaz[i] = cc[0, baz[i] - 1];
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 5; j++)
                        dd[i, j] = 0;
                for (int i = 0; i < 5; i++)
                {
                    dd[0, i] = cc[0, baz[0] - 1] * a[0, i] + cc[0, baz[1] - 1] * a[1, i] + cc[0, baz[2] - 1] * a[2, i] - cc[0, i];
                    dd[1, i] = cc[1, baz[0] - 1] * a[0, i] + cc[1, baz[1] - 1] * a[1, i] + cc[1, baz[2] - 1] * a[2, i] - cc[1, i];
                }
                pol = 0;
                for (int i = 0; i < 5; i++)
                    if (dd[1, i] > 0)
                        pol++;
                for (int i = 0; i < 5; i++)
                    if (dd[1, i] != 0)
                        lb[i] = -dd[0, i] / dd[1, i];
                    else
                        lb[i] = 0;
                lv = false;
                if (pol == 2)
                    lv = true;
                for (int i = 0; i < 5; i++)
                    if (lbn < lb[i] && dd[1, i] != 0)
                        lbv = lb[i];
                Console.WriteLine();



                if (lv)
                {
                    Console.WriteLine("Отрезок: [ " + lbn + " ; +oo )");
                    Console.WriteLine("l* -> +oo");


                    label13.Text = "Отрезок: [ " + lbn + " ; +oo )";
                    label14.Text = "l* -> +oo";
                }
                else
                {
                    Console.WriteLine("Отрезок: [ " + lbn + " ; " + lbv + " ]");
                    label13.Text = "Отрезок: [ " + lbn + " ; " + lbv + " ]";
                    for (int i = 0; i < 5; i++)
                        x[i] = 0;
                    for (int i = 0; i < 3; i++)
                        x[baz[i] - 1] = b[i];
                    Console.Write("x* = (");
                    label14.Text = "x* = (";
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write(" " + x[i]);
                        label14.Text = label14.Text+" " + x[i];
                    }
                    Console.WriteLine(")");
                    label14.Text = label14.Text + ")";
                    f1 = 0; f2 = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        f1 += cc[0, baz[i] - 1] * b[i];
                        f2 += cc[1, baz[i] - 1] * b[i];
                    }
                    Console.WriteLine("f* = " + f1 + " + (" + f2 + ")");
                    label15.Text = "f* = " + f1 + " + (" + f2 + ")";
                }
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyClose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyClose();
        }

       
        
        
        
        
        
        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {

        }

        private void очиститьПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A10.Value = 0; A11.Value = 0; A12.Value = 0; A13.Value = 0; A14.Value = 0; A15.Value = 0;
            A20.Value = 0; A21.Value = 0; A22.Value = 0; A23.Value = 0; A24.Value = 0; A25.Value = 0;
            A30.Value = 0; A31.Value = 0; A32.Value = 0; A33.Value = 0; A34.Value = 0; A35.Value = 0;


            C11.Value = 0; C12.Value = 0; C13.Value = 0; C14.Value = 0; C15.Value = 0;
            C21.Value = 0; C22.Value = 0; C23.Value = 0; C24.Value = 0; C25.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOprogramme formOprogramme = new FormOprogramme();
            formOprogramme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A10.Value = 0;     A11.Value = 0;     A12.Value = 0;     A13.Value = 0;      A14.Value = 0;     A15.Value = 0;
            A20.Value = 0;     A21.Value = 0;     A22.Value = 0;     A23.Value = 0;      A24.Value = 0;     A25.Value = 0;
            A30.Value = 0;     A31.Value = 0;     A32.Value = 0;     A33.Value = 0;      A34.Value = 0;     A35.Value = 0;


            C11.Value = 0;     C12.Value = 0;      C13.Value = 0;     C14.Value = 0;      C15.Value = 0;
            C21.Value = 0;     C22.Value = 0;      C23.Value = 0;     C24.Value = 0;      C25.Value = 0;


            label7.Text = " "; label8.Text = " "; label9.Text = " "; label10.Text = " ";
            label11.Text = " "; label12.Text = " "; label13.Text = " "; label14.Text = " "; label15.Text = " ";
        }

        private void шаблон1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A10.Value = 6; A11.Value = 0; A12.Value = 1; A13.Value = -3; A14.Value = 2; A15.Value = 0;
            A20.Value = 17; A21.Value = -1; A22.Value = 0; A23.Value = 2; A24.Value = 3; A25.Value = 1;
            A30.Value = 18; A31.Value = 0; A32.Value = 0; A33.Value = 3; A34.Value = 2; A35.Value = 1;


            C11.Value = 2; C12.Value = 1; C13.Value = -1; C14.Value = 3; C15.Value = 0;
            C21.Value = 3; C22.Value = -2; C23.Value = 1; C24.Value = 4; C25.Value = -4;
        }

        private void шаблон2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A10.Value = 7; A11.Value = -1; A12.Value = 1; A13.Value = 0; A14.Value = 1; A15.Value = 3;
            A20.Value = 14; A21.Value = 1; A22.Value = 1; A23.Value = 1; A24.Value = 1; A25.Value = 2;
            A30.Value = 8; A31.Value = 1; A32.Value = 5; A33.Value = -1; A34.Value = 1; A35.Value =-4;


            C11.Value = 5; C12.Value = 5; C13.Value = 4; C14.Value = 2; C15.Value = 0;
            C21.Value = -1; C22.Value = -3; C23.Value = -2; C24.Value = 0; C25.Value = 2;
        }
    }
  }

