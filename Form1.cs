using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ex9_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Today;
            pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\" + DateTime.Today.Month + "月.png");
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            switch (monthCalendar1.SelectionStart.Month)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\1月.png");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\2月.png");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\3月.png");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\4月.png");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\5月.png");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\6月.png");
                    break;
                case 7:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\7月.png");
                    break;
                case 8:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\8月.png");
                    break;
                case 9:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\9月.png");
                    break;
                case 10:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\10月.png");
                    break;
                case 11:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\11月.png");
                    break;
                case 12:
                    pictureBox1.Image = Image.FromFile(@"D:\cat32tw\Desktop\Ex9_1\images\12月.png");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            monthCalendar1.AddBoldedDate(monthCalendar1.SelectionStart.Date);
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(monthCalendar1.SelectionStart.Date);
            monthCalendar1.UpdateBoldedDates();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveBoldedDate(monthCalendar1.SelectionStart.Date);
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
