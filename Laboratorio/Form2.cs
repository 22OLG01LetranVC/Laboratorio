using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class Form2 : Form
    {

        string nombre, grado, seccion, telefono, matricula, cicloAcademico,
            correoElectronico, direccion, fechaNacimiento, tutorAsignado, promedioActual;

        //Este string sirve para que nos reconozca nuestras variables

        public Form2()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 v1 = new Form1();
            v1.Show();
            this.Hide();
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 v2 = new Form3();
            v2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
        //Esto sirve para que cada textBox se vacie y podamos poner nuevos datos

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            grado = textBox2.Text;
            seccion = textBox3.Text;
            telefono = textBox4.Text;
            matricula = textBox5.Text;
            cicloAcademico = textBox6.Text;
            correoElectronico = textBox7.Text;
            direccion = textBox8.Text;
            fechaNacimiento = textBox9.Text;
            tutorAsignado = textBox10.Text;
            promedioActual = textBox11.Text;

            //Sirve para que se identique cada columna con cada textBox al que se le ingresen textos

            dataGridView1.Rows.Add(nombre, grado, seccion, telefono, matricula,
                cicloAcademico, correoElectronico, direccion,
                fechaNacimiento, tutorAsignado, promedioActual);

            //Agregar las columnas y que funcione

            LimpiarCampos(); //Nuestro limpiar campos para vaciar las filas
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;
                dataGridView1.CurrentRow.Cells[4].Value = textBox5.Text;
                dataGridView1.CurrentRow.Cells[5].Value = textBox6.Text;
                dataGridView1.CurrentRow.Cells[6].Value = textBox7.Text;
                dataGridView1.CurrentRow.Cells[7].Value = textBox8.Text;
                dataGridView1.CurrentRow.Cells[8].Value = textBox9.Text;
                dataGridView1.CurrentRow.Cells[9].Value = textBox10.Text;
                dataGridView1.CurrentRow.Cells[10].Value = textBox11.Text;
                //Esto sirve para verificar si hay alguan fila seleccionada en el DataGridView
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                LimpiarCampos();
                //Esto para eliminar toda la fila sin que quede texto en ella
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                //Sirve para verificar si hay algun dato ahi para seleccionar, borrar o editar
            }
        }
    }
}

