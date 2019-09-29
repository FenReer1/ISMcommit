using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void Button1_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            int day;
            day = Convert.ToInt32(dayt.Text);
             switch (day)
                {
                    case 1:
                        dat.Text = ("Понедельник");
                        break;
                    case 2:
                        dat.Text = ("Вторник");
                        break;
                    case 3:
                        dat.Text = ("Среда");
                        break;
                    case 4:
                        dat.Text = ("Четверг");
                        break;
                    case 5:
                        dat.Text = ("Пятница");
                        break;
                    case 6:
                        dat.Text = ("Суббота");
                        break;
                    case 7:
                        dat.Text = ("Воскресенье");
                        break;
                    default:
                        dat.Text = ("Ошибка");
                        break;
                }
        }

        private void Day_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            int mont;
            mont = Convert.ToInt32(month.Text);
            switch (mont)
            {
                case 1:
                    montht.Text=("Январь");
                    break;
                case 2:
                    montht.Text=("Февраль");
                    break;
                case 3:
                    montht.Text=("Март");
                    break;
                case 4:
                    montht.Text=("Апрель");
                    break;
                case 5:
                    montht.Text=("Май");
                    break;
                case 6:
                    montht.Text=("Июнь");
                    break;
                case 7:
                    montht.Text=("Июль");
                    break;
                case 8:
                    montht.Text=("Август");
                    break;
                case 9:
                    montht.Text=("Сентябрь");
                    break;
                case 10:
                    montht.Text=("Октябрь");
                    break;
                case 11:
                    montht.Text=("Ноябрь");
                    break;
                case 12:
                    montht.Text=("Декабрь");
                    break;
                default:
                    montht.Text = ("Ошибка");
                    break;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            double x,y;
            x = Convert.ToDouble(month.Text);
            y = Convert.ToDouble(yt.Text);
            switch (dia.Text)
            {
            
                    case "+":
                        double sum;
                        sum = x + y;
                        ytex.Text = Convert.ToString(sum);
                break;
                    case "*":
                        double mno;
                        mno = x * y;
                        ytex.Text = Convert.ToString(mno);
                break;
                    case "-":
                        double min;
                        min = x - y;
                        ytex.Text = Convert.ToString(min);
                break;
                    case "/":
                        double dil;
                        dil = x / y;
                        ytex.Text = Convert.ToString(dil);
                break;
                    default:
                        ytex.Text = ("Ошибка");
                break;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
