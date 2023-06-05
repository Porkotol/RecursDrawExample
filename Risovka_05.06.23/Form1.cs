namespace Risovka_05._06._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MyDraw(Graphics g, int N , int x, int y)
        {
            if (N == 0)
                return;
            else
                {
                g.DrawRectangle(new Pen(Brushes.Blue, 2), 0, 0, x, y);
                x += 50;
                y += 50;
                N--;
                MyDraw(g, N, x, y);
                }
           
        }
        private void Form1_Paint (object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            MyDraw(g, 7, 50, 50);
        }
    }
}