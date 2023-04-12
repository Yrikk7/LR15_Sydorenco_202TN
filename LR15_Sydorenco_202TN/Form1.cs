using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR15_Sydorenco_202TN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tntOK.Text = "OK";
            btnOK.Text = "OK";
            titOK.Text = "OK";
            blnOK.Text = "OK";
            tetOK.Text = "OK";
            gogOK.Text = "OK";
            lolOK.Text = "OK";
            minys.Text = "";
            plus.Text = "";
            modyl.Text = "";
            tftResult.Text = "";
            lolResult.Text = "";
            tutResult.Text = "";
            ldlResult.Text = "";
            titResult.Text = "";
            tetResult.Text = "";
            arithmetic.Text = "";
            geometric.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtA.Text);
            double result = (2 * (1 / Math.Tan(x * 3)) - (Math.Log10(Math.Cos(x)) / Math.Log10(1 + Math.Pow(x, 2))));
            ldlResult.Text = result.ToString();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtA.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;

        }

        private void tntOK_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(txtB.Text);
            double z = Convert.ToDouble(txtC.Text);
            double res = ((Math.Pow(y, 3) + Math.Pow(z, 3)) / 2);
            double rel = Math.Pow(y * z, 0.5);
            arithmetic.Text = res.ToString();
            geometric.Text = rel.ToString();
        }

        private void titOK_Click(object sender, EventArgs e)
        {
             string m = txtM.Text;
             string n = txtN.Text;
            if(n.Contains(m))
            {
                titResult.Text = "true";
            }
            else
            {
                titResult.Text ="false";
            }
        }

        private void tetOK_Click(object sender, EventArgs e)
        {
            double X1 = Convert.ToDouble(x1.Text);
            double Y1 = Convert.ToDouble(y1.Text);
            double X2 = Convert.ToDouble(x2.Text);
            double Y2 = Convert.ToDouble(y2.Text);
            double X3 = Convert.ToDouble(x3.Text);
            double Y3 = Convert.ToDouble(y3.Text);
            double X4 = Convert.ToDouble(x4.Text);
            double Y4 = Convert.ToDouble(y4.Text);
            double fug = X1 - X3;
            double hug = X2 - X4;
            if (Y1==Y2 && fug==hug && Y3==Y4)
                {
                   tetResult.Text = "a triangle is obtained";
                }
                else
                {
                   tetResult.Text = "triangle does not work";
                }
        }

        private void blnOK_Click(object sender, EventArgs e)
        {            
            int str = Convert.ToInt32(NN.Text);
            int[] ar = str.ToString().ToCharArray().Select(x => x - '0').ToArray();
            int minArray = ar[0];
            int yuuy = 0;
            for (int i = 1; i < ar.Length; i++ )
            {
                if (ar[i] < minArray)
                {
                    minArray = ar[i];
                }
            }
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == minArray)
                {
                     yuuy++;  
                }
            }
            tftResult.Text = minArray.ToString();
            tutResult.Text = yuuy.ToString();
        }

        private void gogOK_Click(object sender, EventArgs e)
        {
            int ret = Convert.ToInt32(masiv.Text);
            int[] af = ret.ToString().ToCharArray().Select(x => x - '0').ToArray();
            int[] array = new int[] { };
            int[] aryr = new int[] { };
             for (int i = 1; i < af.Length; i++)
            {
                if (af[i] < 0)
                {
                    af[i] = array[i];
                }
                if (af[i] > 0)
                {
                    af[i] = aryr[i];
                }
            }
            int rray = array[0]* array[1];
            int ety = 0;
            for (int i = 2; i < array.Length; i++)
            {
                  ety = array[i] * rray;
            }
            minys.Text = ety.ToString();
            int iou = aryr[0] * aryr[1];
            int wow = 0;
            for (int i = 2; i < aryr.Length; i++)
            {
                 wow = aryr[i] * iou;
            }
            plus.Text = wow.ToString();
        }

        private void masiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (masiv.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    gogOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void NN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (NN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    blnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtB.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    tntOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtC.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    tntOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtM.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    titOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (txtN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    titOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void lolOK_Click(object sender, EventArgs e)
        {
            /*string[] teor = lol1.Text;*/        }
    }
}
