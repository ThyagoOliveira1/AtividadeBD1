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

namespace AtividadeEAD03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdcCidade_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "brasil";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";

            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();
                MessageBox.Show("Conexão Aberta!");

                MySqlCommand cmd = realizaConexacoBD.CreateCommand();
                cmd.CommandText = "INSERT INTO cidade (NomeCidade)" + "VALUES('" + txtbNomeCidade.Text + "')";
                cmd.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com Sucesso!");
                atualizarGrid();
                txtbNomeCidade.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "brasil";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";

            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();
                MySqlCommand cmd = realizaConexacoBD.CreateCommand();
                cmd.CommandText = "SELECT * from cidade";
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0);
                    row.Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows.Add(row);
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }
    }
}
