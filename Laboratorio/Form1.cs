using System.Windows.Forms;

namespace Laboratorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "Oscar" && textBox2.Text == "1234")
                {
                    Form2 v1 = new Form2();
                    v1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }

            //El If y Else de esta parte estan para ver si cumple esta funcion, si lo cumple deja entrar y si no 
        }

        private void ventana2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 v1 = new Form2();
            v1.Show();
            this.Hide();
        }

        private void ventana3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 v2 = new Form3();
            v2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
