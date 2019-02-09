using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static int Euclidean(int a, int b)
        {
            if(a%b == 0)
                return b;
            return Euclidean(b, a % b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calcButtonEvn(object sender, EventArgs e)
        {
            int f1numer, f1deno;
            int f2numer, f2deno;
            int temp; 
            if (!(Int32.TryParse(F1_numer.Text, out f1numer) && Int32.TryParse(F2_numer.Text, out f2numer)))
            {
                MessageBox.Show("숫자를 제대로 입력하세요.");
                return;
            }
            if (!(Int32.TryParse(F1_deno.Text, out f1deno) && Int32.TryParse(F2_deno.Text, out f2deno)))
            {
                MessageBox.Show("숫자를 제대로 입력하세요.");
                return;
            }
            switch (oper.Text)
            {
                case "+":
                    temp = f1deno;
                    f1numer *= f2deno;
                    f2numer *= f1deno;
                    f1deno *= f2deno;
                    f2deno *= temp;
                    r_numer.Text = (f1numer + f2numer).ToString();
                    r_deno.Text = f1deno.ToString();
                    break;
                case "-":
                    temp = f1deno;
                    f1numer *= f2deno;
                    f2numer *= f1deno;
                    f1deno *= f2deno;
                    f2deno *= temp;
                    r_numer.Text = (f1numer - f2numer).ToString();
                    r_deno.Text = f1deno.ToString();
                    break;
                case "*":
                    r_numer.Text = (f1numer * f2numer).ToString();
                    r_deno.Text = (f1deno * f2deno).ToString();
                    break;
                case "/":
                    Swap(ref f2numer, ref f2deno);
                    r_numer.Text = (f1numer * f2numer).ToString();
                    r_deno.Text = (f1deno * f2deno).ToString();
                    break;
                default:
                    MessageBox.Show("연산자를 제대로 정해주세요.");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { oper.Text = setOper.Text; }

        // 기약분수로 전환
        private void ConvBtn_Click(object sender, EventArgs e)
        {
            int numer, deno;
            if(Int32.TryParse(F1_numer.Text,out numer) && Int32.TryParse(F1_deno.Text,out deno))
            {
                int div = Euclidean(numer, deno);
                F1_numer.Text = (numer / div).ToString();
                F1_deno.Text = (deno / div).ToString();
            }
            if (Int32.TryParse(F2_numer.Text, out numer) && Int32.TryParse(F2_deno.Text, out deno))
            {
                int div = Euclidean(numer, deno);
                F2_numer.Text = (numer / div).ToString();
                F2_deno.Text = (deno / div).ToString();
            }
            if (Int32.TryParse(r_numer.Text, out numer) && Int32.TryParse(r_deno.Text, out deno))
            {
                int div = Euclidean(numer, deno);
                r_numer.Text = (numer / div).ToString();
                r_deno.Text = (deno / div).ToString();
            }
        }
    }
}
