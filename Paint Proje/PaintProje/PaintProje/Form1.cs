namespace PaintProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;

        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,1);
        Pen erase = new Pen(Color.White,10);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();
            if (paint)
            {
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sx = x - cx;
            sy = y - cy;

            
        }

        private void btn_kalem_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_silgi_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        int index;
        int x, y, sx, sy, cx, cy;


    }
}