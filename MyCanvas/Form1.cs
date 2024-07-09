using System.Drawing;
using System.Windows.Forms;

namespace MyCanvas
{
    public partial class Form1 : Form
    {
        Bitmap Bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool IsDrawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Board_PB_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsDrawing == true)
            {
                IsDrawing = false;
            }
            else
            {
                IsDrawing |= true;
            }
        }

        private void Board_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing == true)
            {
                Graphics graphics = Graphics.FromImage(Bitmap);
                graphics.DrawRectangle(pen, e.X, e.Y, 3, 1);
                Board_PB.Image = Bitmap;
            }
        }
    }
}
