namespace Project___Review_RBT
{
    public partial class Form1 : Form
    {
        private RedBlackTree rbt;
        private Point startPosition = new Point(0, 0);
        private Point targetPosition;
        public Form1()
        {
            InitializeComponent();
            rbt = new RedBlackTree();
            for(int i=0; i<80;i++)
            {
                textBox1.Text = i.ToString();
                add_button_Click(this, new EventArgs());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(add_button.Location.X + 200, add_button.Location.Y);
            panel1.Width = panel1.Width * 2 + 500;
            panel1.Height = panel1.Height * 2 + 200;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            textBox1.Clear();
            if (rbt.Insert(s) == 0)
            {
                MessageBox.Show("Giá trị đã tồn tại trong cây");
                return;
            }
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rbt.root != null)
            {
                DrawTree(e.Graphics, rbt.root, panel1.Width / 2, 30, 384);
            }
        }
        public void DrawTree(Graphics g, RedBlackNode node, int x, int y, int offset)
        {
            if (node != null)
            {
                if (node.Left != null)
                {
                    DrawTree(g, node.Left, x - offset, y + 160, offset / 2);
                    Point start = new Point(x, y + 44);
                    Point end = new Point(x - offset, y + 160);
                    Pen p = new Pen(Color.Black, 2);
                    g.DrawLine(p, start, end);
                }
                // Đo kích thước chuỗi để tính kích thước hình tròn
                Font font = new Font("Times New Roman", 8);
                SizeF stringSize = g.MeasureString(node.FormattedValue, font); // Sử dụng giá trị đã định dạng

                // Đặt kích thước hình tròn dựa trên kích thước chuỗi
                int padding = 6; // Khoảng cách giữa chuỗi và viền hình tròn
                int circleDiameter = (int)(stringSize.Width + padding); // Đường kính hình tròn 

                // Vẽ hình tròn cho nút
                Brush brush = node.Color == NodeColor.Red ? Brushes.Red : Brushes.Black; // Kiểm tra màu sắc
                g.FillEllipse(brush, x - circleDiameter / 2, y, circleDiameter, circleDiameter); // Vẽ hình tròn với kích thước tính toán

                // Vẽ giá trị của nút (chữ nằm giữa hình tròn)
                float textX = x - stringSize.Width / 2;
                float textY = y + (circleDiameter - stringSize.Height) / 2; // Căn giữa dọc
                g.DrawString(node.FormattedValue, font, Brushes.White, textX, textY); // Vẽ chữ giữa hình tròn

                if (node.Right != null)
                {
                    DrawTree(g, node.Right, x + offset, y + 160, offset / 2);
                    Point start = new Point(x, y + 44);
                    Point end = new Point(x + offset, y + 160);
                    Pen p = new Pen(Color.Black, 2);
                    g.DrawLine(p, start, end);
                }
            }
        }
    }
}
