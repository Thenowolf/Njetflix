using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        UzivatelBO uzivatel;
        public Login()
        {
            InitializeComponent();
            // Collection<BusinessLayer.DTO.FilmDTO> filmDTO = BusinessLayer.DTO.FilmDTO.SelectAll();
            //dataGridView1.DataSource = filmDTO;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            uzivatel = UzivatelHandler.Login(textBox1.Text, textBox2.Text);
            if (uzivatel.id != null && uzivatel.spravce == true )
            {
                label1.Text = "Přihlášení v pořádku";
                Edit edit = new Edit();
                edit.ShowDialog();
                this.Hide();
            }
            else label1.Text = "Neplatné přihlášení";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
