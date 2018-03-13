using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int d;
            int m;
            int y;

            if (!(int.TryParse(day.Text,out d) && int.TryParse(month.Text, out m) && int.TryParse(year.Text, out y)))
            {
                throw new Exception("invalid data");   
            }

            if(0 < m && m < 12)
            {
                // Day in Month
                int DayInMonth = getNumberOfDays(m, y);

                if(0 < d && d < DayInMonth)
                {
                    if (d == 1)
                    {
                        m--;
                        if (m == 0)
                        {
                            m = 12;
                            y--;
                        }
                        DayInMonth = getNumberOfDays(m, y);
                        dRes.Text = DayInMonth.ToString();
                    }
                    else
                    {

                        dRes.Text = (d - 1).ToString();
                    }

                    yRes.Text = y.ToString();
                    mRes.Text = m.ToString();
                }
                else
                {
                    throw new Exception("invalid data");
                }
                
            }
            else
            {
                throw new Exception("invalid data");
            }
        }

        public static int getNumberOfDays(int m, int y)
        {
            int leap = (1 - (y % 4 + 2) % (y % 4 + 1)) * ((y % 100 + 2) % (y % 100 + 1)) + (1 - (y % 400 + 2) % (y % 400 + 1));

            return 28 + ((m + (m / 8)) % 2) + 2 % m + ((1 + leap) / m) + (1 / m) - (leap / m);
        }
    }
}
