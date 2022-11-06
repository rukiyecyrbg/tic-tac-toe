using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public char secimtipi = 'X';
        public Form1()
        {
            InitializeComponent();

            //pictureBox1.Load("./img/o.jfif");
            //pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Image != null) return;

            if (secimtipi == 'X')
            {
                pb.Load("./img/X.jfif");
                pb.Invalidate();
                pb.Tag = secimtipi;
                secimtipi = 'o';
            }
            else
            {
                pb.Load("./img/o.jfif");
                pb.Invalidate();
                pb.Tag = secimtipi;
                secimtipi = 'X';
            }
			kontrol();
            //if (pb.Name == "pictureBox1")
            //{
            //    if (Convert.ToString(pb.Tag) == Convert.ToString(pictureBox2.Tag) && Convert.ToString(pictureBox3.Tag))
            //    {
            //        MessageBox.Show("kazandınız");
            //    }
            //}

        }
        public void kontrol()
        {
			MessageBox.Show(pictureBox1.Tag.ToString());
            if (pictureBox1.Tag.ToString() == "x" && pictureBox2.Tag.ToString() == "x" && pictureBox3.Tag.ToString() == "x")
			{
				MessageBox.Show("X KAZANDI");
			}
			
			//if (bt4.Text == "X" && bt5.Text == "X" && bt6.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt7.Text == "X" && bt8.Text == "X" && bt9.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt1.Text == "X" && bt4.Text == "X" && bt7.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt2.Text == "X" && bt5.Text == "X" && bt8.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt3.Text == "X" && bt6.Text == "X" && bt9.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt1.Text == "X" && bt5.Text == "X" && bt9.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt3.Text == "X" && bt5.Text == "X" && bt7.Text == "X")
			//{
			//	MessageBox.Show("X KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt1.Text == "O" && bt2.Text == "O" && bt3.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt4.Text == "O" && bt5.Text == "O" && bt6.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt7.Text == "O" && bt8.Text == "O" && bt9.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt1.Text == "O" && bt4.Text == "O" && bt7.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt2.Text == "O" && bt5.Text == "O" && bt8.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt3.Text == "O" && bt6.Text == "O" && bt9.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt1.Text == "O" && bt5.Text == "O" && bt9.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//if (bt3.Text == "O" && bt5.Text == "O" && bt7.Text == "O")
			//{
			//	MessageBox.Show("O KAZANDI");
			//	yeniOyun();
			//}
			
			//else if (bt1.Text != "" && bt2.Text != "" && bt3.Text != "" && bt4.Text != "" && bt5.Text != "" && bt6.Text != "" && bt7.Text != "" && bt8.Text != "" && bt9.Text != "")
			//{
			//	MessageBox.Show("KAZANAN YOK");
			//	yeniOyun();
			//}
        }
    }
}
