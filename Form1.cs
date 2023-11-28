using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;

namespace WindowsFormsAppTagdij
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Clear();
            sb.Server = "localhost";
            sb.UserID="root";
            sb.Password = "";
            sb.Database = "tagdij";
            connection = new MySqlConnection(sb.ConnectionString);
            command = connection.CreateCommand();
            tagok_betoltese();
        }

        private void tagok_betoltese()
        {
            listBoxTagok.Items.Clear();
            try
            {
                if(connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText="SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1 order by nev;";
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tag beolvasottTag = new Tag(reader.GetInt32("azon"), reader.GetString("nev"), reader.GetInt32("szulev"), reader.GetInt32("irszam"), reader.GetString("orsz"));
                        listBoxTagok.Items.Add(beolvasottTag);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void listBoxTagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTagok.SelectedIndex<0)
            {
                return;
            }
            else
            {
                Tag kivalasztottTag = (Tag)listBoxTagok.SelectedItem;
                textBoxNev.Text=kivalasztottTag.nev;
                textBoxAzon.Text=kivalasztottTag.azon.ToString();
                textBoxOrsz.Text=kivalasztottTag.orsz;
                numericUpDownIrszam.Value=kivalasztottTag.irszam;
                numericUpDownSzulev.Value=kivalasztottTag.szulev;
            }
        }

        private void buttonLetrehozas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
            else
            {
                string nev = textBoxNev.Text;
                decimal szulev = numericUpDownSzulev.Value;
                decimal irszam = numericUpDownIrszam.Value;
                string orsz = textBoxOrsz.Text;
                command.Parameters.Clear();
                command.CommandText="INSERT INTO `ugyfel`(`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (NULL, @nev, @szulev, @irszam, @orsz)";
                
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@szulev", szulev);
                command.Parameters.AddWithValue("@irszam", irszam);
                command.Parameters.AddWithValue("@orsz", orsz);
                try
                {
                    if (connection.State!=ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres rögzítés!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                textBoxNev.Text="";
                numericUpDownSzulev.Value=numericUpDownSzulev.Minimum;
                numericUpDownIrszam.Value=numericUpDownIrszam.Minimum;
                textBoxOrsz.Text="H";
                tagok_betoltese();
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
            else
            {
                string azon = textBoxAzon.Text.ToString();
                string nev = textBoxNev.Text;
                decimal szulev = numericUpDownSzulev.Value;
                decimal irszam = numericUpDownIrszam.Value;
                string orsz = textBoxOrsz.Text;
                command.CommandText = "SET FOREIGN_KEY_CHECKS=OFF;" +
                    "DELETE FROM `ugyfel` WHERE azon=@azon;";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@azon", azon);
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@szulev", szulev);
                command.Parameters.AddWithValue("@irszam", irszam);
                command.Parameters.AddWithValue("@orsz", orsz);
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres törlés!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                textBoxNev.Text = "";
                numericUpDownSzulev.Value = numericUpDownSzulev.Minimum;
                numericUpDownIrszam.Value = numericUpDownIrszam.Minimum;
                textBoxOrsz.Text = "H";
                tagok_betoltese();
            }
        }

        private void buttonModositas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Nincs név");
                return;
            }
            else
            {
                string nev = textBoxNev.Text;
                decimal szulev = numericUpDownSzulev.Value;
                decimal irszam = numericUpDownIrszam.Value;
                string orsz = textBoxOrsz.Text;
                string azon = textBoxAzon.Text.ToString();
                command.CommandText = "UPDATE `ugyfel` SET `nev`='@nev',`szulev`='@szulev',`irszam`='@irszam',`orsz`='@orsz' WHERE azon=@azon";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@azon", azon);
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@szulev", szulev);
                command.Parameters.AddWithValue("@irszam", irszam);
                command.Parameters.AddWithValue("@orsz", orsz);
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.ExecuteNonQuery();
                    MessageBox.Show("Sikeres módosítás!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                textBoxNev.Text = "";
                numericUpDownSzulev.Value = numericUpDownSzulev.Minimum;
                numericUpDownIrszam.Value = numericUpDownIrszam.Minimum;
                textBoxOrsz.Text = "H";
                tagok_betoltese();
            }
        }
    }
}
