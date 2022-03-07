using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace stagiaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<stagiaire> L = new List<stagiaire>();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("code", "code");
            dataGridView1.Columns.Add("nom", "nom");
            dataGridView1.Columns.Add("age", "age");
            dataGridView1.Columns.Add("filiere", "filiere");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Code = int.Parse(textBox1.Text);
            string Nom = textBox2.Text;
            int Age = int.Parse(textBox5.Text);
            string Filiere = textBox3.Text;
            stagiaire s = new stagiaire(Code, Nom, Age, Filiere);

            foreach (stagiaire l in L)
            {
                if (textBox1.Text == l.Filiere)
                {
                    dataGridView1.Rows.Add(l.Code, l.Nom, l.Age, l.Filiere);

                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string y = "fichier";
            FileStream f = File.Open(y, FileMode.Open);
            XmlSerializer p = new XmlSerializer(typeof(List<stagiaire>));
            List<stagiaire> lis = (List<stagiaire>)p.Deserialize(f);
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("vous voullez vraiment quitter le programme ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.No)
            {
                MessageBox.Show("vous avez annuler de quitter le programme ", "information");
            }

            else if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
