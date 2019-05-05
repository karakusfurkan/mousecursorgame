using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YG35426_DengeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            //Cursor --> İmleç
            //Cursor.Position = new Point(150, 150);

            //Cursor.Position = lblStart.Location;

            //label location'ı formun içerisindeki label'ın sola ve yukarı olan uzaklıklarından oluşur.
            //Ancak cursor location'ı formun değil tüm ekranın içerisinde sola ve yukarı olan uzaklıklardan oluşur.
            //int x = this.Location.X + lblStart.Location.X + 10;
            //int y = this.Location.Y + lblStart.Location.Y + 30;

            //Cursor.Position = new Point(x, y);

            //this.PointToScreen() ekrandaki noktayı bul
            Cursor.Position = this.PointToScreen(lblStart.Location);
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler ! Oyunu kazandınız :)");
        }
    }
}
