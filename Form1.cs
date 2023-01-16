namespace lab3
{
    public partial class Form1 : Form
    {
        public struct coord
        {
            public double x;
            public double y;
            public double z;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {        
            if (Logic.ErrorValue(x1,y1,z1,x2,y2,z2))
            {
                coord a = new coord { x = double.Parse(x1.Text), y = double.Parse(y1.Text), z = double.Parse(z1.Text) };
                coord b = new coord { x = double.Parse(x2.Text), y = double.Parse(y2.Text), z = double.Parse(z2.Text) };

                MessageBox.Show($"����������� �������� ����� ������\n c = {Logic.SumVect(a, b)}");
            }
            else 
            {
                MessageBox.Show("����������� ������� ���������� ��������");
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Logic.ErrorValue(x1, y1, z1, x2, y2, z2))
            {
                coord a = new coord { x = double.Parse(x1.Text), y = double.Parse(y1.Text), z = double.Parse(z1.Text) };
                coord b = new coord { x = double.Parse(x2.Text), y = double.Parse(y2.Text), z = double.Parse(z2.Text) };

                MessageBox.Show($"����������� �������� ����� ������\n c = {Logic.MinusVect(a, b)}");
            }
            else
            {
                MessageBox.Show("����������� ������� ���������� ��������");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Logic.ErrorValue(x1, y1, z1, x2, y2, z2))
            {
                coord a = new coord { x = double.Parse(x1.Text), y = double.Parse(y1.Text), z = double.Parse(z1.Text) };
                coord b = new coord { x = double.Parse(x2.Text), y = double.Parse(y2.Text), z = double.Parse(z2.Text) };


                MessageBox.Show($"����������� ���������� ������������ ����� = {Logic.ScalProd(a, b):#.##}");
            }
            else
            {
                MessageBox.Show("����������� ������� ���������� ��������");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Logic.ErrorValue(x1, y1, z1, x2, y2, z2))
            {
                coord a = new coord { x = double.Parse(x1.Text), y = double.Parse(y1.Text), z = double.Parse(z1.Text) };
                coord b = new coord { x = double.Parse(x2.Text), y = double.Parse(y2.Text), z = double.Parse(z2.Text) };


                MessageBox.Show($"����������� ����������� ������������ ����� ������\n � = {Logic.VectProd(a, b)}");
            }
            else
            {
                MessageBox.Show("����������� ������� ���������� ��������");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Logic.ErrorValue(x1, y1, z1, x2, y2, z2))
            {
                coord a = new coord { x = double.Parse(x1.Text), y = double.Parse(y1.Text), z = double.Parse(z1.Text) };
                coord b = new coord { x = double.Parse(x2.Text), y = double.Parse(y2.Text), z = double.Parse(z2.Text) };


                MessageBox.Show($"����� ������� � = {Logic.LengtVect(a):#.##}");
                MessageBox.Show($"����� ������� b = {Logic.LengtVect(b):#.##}");
            }
            else
            {
                MessageBox.Show("����������� ������� ���������� ��������");
            }
        }
    }
}