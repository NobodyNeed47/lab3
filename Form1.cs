namespace lab3
{
    public partial class Form1 : Form
    {
        public struct coord
        {
            public float x;
            public float y;
            public float z;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coord a = new coord { x = float.Parse(x1.Text), y = float.Parse(y1.Text), z = float.Parse(z1.Text) };
            coord b = new coord { x = float.Parse(x2.Text), y = float.Parse(y2.Text), z = float.Parse(z2.Text) };
            MessageBox.Show($"Результатом сложения будет вектор\n c = {Logic.SumVect(a, b)}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coord a = new coord { x = float.Parse(x1.Text), y = float.Parse(y1.Text), z = float.Parse(z1.Text) };
            coord b = new coord { x = float.Parse(x2.Text), y = float.Parse(y2.Text), z = float.Parse(z2.Text) };
            MessageBox.Show($"Результатом разности будет вектор\n c = {Logic.MinusVect(a, b)}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coord a = new coord { x = float.Parse(x1.Text), y = float.Parse(y1.Text), z = float.Parse(z1.Text) };
            coord b = new coord { x = float.Parse(x2.Text), y = float.Parse(y2.Text), z = float.Parse(z2.Text) };
            MessageBox.Show($"Результатом скалярного произведения будет = {Logic.ScalProd(a,b):#.##}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coord a = new coord { x = float.Parse(x1.Text), y = float.Parse(y1.Text), z = float.Parse(z1.Text) };
            coord b = new coord { x = float.Parse(x2.Text), y = float.Parse(y2.Text), z = float.Parse(z2.Text) };
            MessageBox.Show($"Результатом вектороного произведения будет вектор\n с = {Logic.VectProd(a,b)}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coord a = new coord { x = float.Parse(x1.Text), y = float.Parse(y1.Text), z = float.Parse(z1.Text) };
            coord b = new coord { x = float.Parse(x2.Text), y = float.Parse(y2.Text), z = float.Parse(z2.Text) };

            MessageBox.Show($"Длина вектора а = {Logic.LengtVect(a):#.##}");
            MessageBox.Show($"Длина вектора b = {Logic.LengtVect(b):#.##}");
        }
    }
}