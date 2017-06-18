using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwelveMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            show_picture();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            show_picture();
        }

        private void show_picture()
        {
            string month;
            month = monthCalendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile("picture/" + month + ".jpg");
            }
            catch (Exception e)
            {
                MessageBox.Show("Папка с картинками не найдена","Ошибка");
                this.Close();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = !monthCalendar.Visible;
        }

    }
}
