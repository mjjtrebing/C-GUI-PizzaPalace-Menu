/*Pizza palace
 *Author: Matt Trebing
 * 2/7/19
 * HW1 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1PizzaPalace
{
    public partial class pizzaPalace : Form
    {
        public pizzaPalace()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //is called and provides the total order with tip and tax calculated
        private void orderCalc()
        {
            double holder;
            double tax;
            holder = double.Parse(order.Text.Substring(1));
            tax = holder * 0.06;
            holder += tax;
            holder += double.Parse(tipBox.Text.Substring(1));
            total.Text = holder.ToString("C");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (chicken.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (chicken.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (mushroom.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (mushroom.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (pineapple.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (pineapple.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void pizzaPalace_Load(object sender, EventArgs e)
        {

        }

        private void smallRadio_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (smallRadio.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder += 7.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if(smallRadio.Checked == false)//if check changes
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 7.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void mediumRadio_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (mediumRadio.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 9.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (mediumRadio.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 9.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void largeRadio_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (largeRadio.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 12.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (largeRadio.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 12.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void Pep_CheckedChanged(object sender, EventArgs e)
        {
                double holder;
                if (Pep.Checked == true)
                {
                    holder = double.Parse(order.Text.Substring(1));
                    holder = holder + 1.00;
                    order.Text = holder.ToString("C");
                     orderCalc();
                }
                else if (Pep.Checked == false)//subrats the money when the other radio button is selected
                {
                    holder = double.Parse(order.Text.Substring(1));
                    holder -= 1.00;
                    order.Text = holder.ToString("C");
                     orderCalc();
                }
        }

        private void bacon_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (bacon.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (bacon.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void pepper_CheckedChanged(object sender, EventArgs e)
        {
            double holder;
            if (pepper.Checked == true)
            {
                holder = double.Parse(order.Text.Substring(1));
                holder = holder + 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
            else if (pepper.Checked == false)//subrats the money when the other radio button is selected
            {
                holder = double.Parse(order.Text.Substring(1));
                holder -= 1.00;
                order.Text = holder.ToString("C");
                orderCalc();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            tipBox.Text = "$2.00";
            order.Text = "$0.00";
            total.Text = "$0.00";

        }
    }
}
