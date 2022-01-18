using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Edit : Form
    {
        Collection<FilmBO> filmy = FilmHandler.SelectAll();
        UcinkujiciBO ucinkujici = new UcinkujiciBO();
        public Edit()
        {
            InitializeComponent();
            dataGridView1.DataSource = filmy;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmHandler.UpdateInfo(FilmBO.ChangeInfo(nazevText.Text, Convert.ToInt32(rokText.Text), zanrText.Text, popisText.Text, zamekCheck.Checked, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)));
            /*int count = 0;
            foreach (char c in nazevText.Text)
            {
                if (c == ',') count++;
            }
            String[] jmena = new string[count+1];
            String[] prijmeni = new string[count+1];
            String zanr;
            String text = "Déžo lakatoš";
            for (int i = 0; i <= count; i++)
            {
                if (i != count)
                {
                    jmena += "'";
                    jmena += textBox1.Text.Split(",")[i].Split(" ")[0];
                    jmena += "', ";
                    prijmeni += "'";
                    prijmeni += textBox1.Text.Split(",")[i].Split(" ")[1];
                    prijmeni += "', ";
                }
                else
                {
                    jmena += "'";
                    jmena += textBox1.Text.Split(",")[i].Split(" ")[0];
                    jmena += "'";
                    prijmeni += "'";
                    prijmeni += textBox1.Text.Split(",")[i].Split(" ")[1];
                    prijmeni += "'";
                }
            }

            for (int i = 0; i <= count; i++)
            {
                    jmena[i] = text.Split(",")[i].Split(" ")[0];
                    prijmeni[i] = nazevText.Text.Split(",")[i].Split(" ")[1];
            }
            zanr = rokText.Text; */


            // filmy = FilmHandler.SelectDetailed(jmena, prijmeni, zanr);
            // dataGridView1.DataSource = filmy;
            if (herciText.Text != "")
            {
                for (int i = 0; i < FilmBO.ConvertNames(herciText.Text).Length; i++)
                {
                    //UcinkujiciBO ucinkujici = new UcinkujiciBO();
                    if (UcinkujiciHandler.Select(FilmBO.ConvertNames(herciText.Text)[i], FilmBO.ConvertSurnames(herciText.Text)[i]).id == 0)
                    {
                        label2.Visible = true;
                        ucinkujici = new UcinkujiciBO { jmeno = FilmBO.ConvertNames(herciText.Text)[i], prijmeni = FilmBO.ConvertSurnames(herciText.Text)[i], role = "herec" };
                        label2.Text = "Zadaný účinkující " + ucinkujici.jmeno + " " + ucinkujici.prijmeni + " neexistuje, bude proto vytvořen.";
                        UcinkujiciHandler.Insert(ucinkujici);
                        ucinkujici = UcinkujiciHandler.Select(ucinkujici.jmeno, ucinkujici.prijmeni);
                        UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                    }
                    else
                    {
                        ucinkujici = UcinkujiciHandler.Select(FilmBO.ConvertNames(herciText.Text)[i], FilmBO.ConvertSurnames(herciText.Text)[i]);
                        UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                    }
                }
            }
            if(reziserText.Text != "")
            {
                if (UcinkujiciHandler.Select(FilmBO.ConvertNames(reziserText.Text)[0], FilmBO.ConvertSurnames(reziser.Text)[0]).id == 0)
                {
                    label2.Visible = true;
                    ucinkujici = new UcinkujiciBO { jmeno = FilmBO.ConvertNames(reziserText.Text)[0], prijmeni = FilmBO.ConvertSurnames(reziserText.Text)[0], role = "reziser" };
                    label2.Text = "Zadaný režisér " + ucinkujici.jmeno + " " + ucinkujici.prijmeni + " neexistuje, bude proto vytvořen.";
                    UcinkujiciHandler.Insert(ucinkujici);
                    ucinkujici = UcinkujiciHandler.Select(ucinkujici.jmeno, ucinkujici.prijmeni);
                    UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                }
                else
                {
                    ucinkujici = UcinkujiciHandler.Select(FilmBO.ConvertNames(reziserText.Text)[0], FilmBO.ConvertSurnames(reziserText.Text)[0]);
                    UcinkujiciHandler.InsertDependency(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), ucinkujici.id);
                }
                //filmy = FilmHandler.SelectAll();
                //dataGridView1.DataSource = filmy;

            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource = filmy;
            DataGridViewRow row = dataGridView1.SelectedRows[0];*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = dataGridView1.SelectedRows[0];
            //int id = Convert.ToInt32(row.Cells[0].Value);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            FilmBO film = FilmHandler.SelectID(id);
            nazevText.Text = film.nazev;
            rokText.Text = film.rok.ToString();
            popisText.Text = film.popis;
            zanrText.Text = film.zanr;
            zamekCheck.Checked = film.zamek;
            ucinkujciView.DataSource = film.ucinkujici;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*dataGridView1.DataSource = filmy;
            DataGridViewRow row = new DataGridViewRow();
            //DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells[0].Value);
            FilmBO film = FilmHandler.SelectID(id);
            nazevText.Text = film.nazev;
            rokText.Text = film.rok.ToString();
            popisText.Text = film.popis;
            zanrText.Text = film.zanr;
            zamekCheck.Checked = film.zamek;*/
            
        }
    }
}
