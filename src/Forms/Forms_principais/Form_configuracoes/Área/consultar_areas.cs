using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms.Forms_principais.Form_configuracoes.Área
{
    public partial class consultar_areas : Form
    {
        DB db = new DB();
        

       
        
        public consultar_areas()
        {
            InitializeComponent();
            

        }
        //limpa os campos
        public void cleanTextBox()
        {
            txtid.Text = "";
            txtarea.Text = "";
        }
       //vê se os campos estao vazios
        public Boolean checkTextBoxesValues()
        {
            if (txtarea.Text.Equals("") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Prcura se já existe uma área
        public Boolean checkArea()
        {
            DB db = new DB();

            String nome = txtarea.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM area WHERE nome_area = @nome", db.getConnection());

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Se a tabela estiver vazia ele desativa a dataGridView
        public void check()
        {
 
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM area", db.getConnection());

           

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                dtareas.Enabled = false;
            }
            else
            {
                dtareas.Enabled = true;
                dataview();
            }
        }


        //Mostra os Dados Na DataGridView
        public void dataview()
        {
            string selectQuery = "SELECT * FROM area";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dtareas.DataSource = table;
        }


        //Passa os campos da tabela para os campos correspondentes
        public void dtareas_MouseClick(object sender, MouseEventArgs e)
        {

            txtid.Text = dtareas.CurrentRow.Cells[0].Value.ToString();
            txtarea.Text = dtareas.CurrentRow.Cells[1].Value.ToString();
        }

        
        //Insere os dados Na Base de dados
        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO area(nome_area) VALUES('" + txtarea.Text + "')";
            using (MySqlCommand cmd = new MySqlCommand(insertQuery, db.connection))
            { 
                if (checkTextBoxesValues())
                {
                if (checkArea())
                {
                    MessageBox.Show("Já existe esta Área, escolha outra");
                }
                else
                {
                        try
                        {
                            db.openConnection();

                            
                            cmd.ExecuteNonQuery();
                            check();
                            dataview();
                            db.closeConnection();
                            cleanTextBox();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro:" + erro.Message);
                        }
                        finally
                        {
                            db.closeConnection();
                        }
                    }
                }
                else
                {
                MessageBox.Show("Preencha os campos");
                }
            }
        }

        private void consultar_areas_Load(object sender, EventArgs e)
        {
            check();
        }
        //Edita os Dados já presentes na tabela
        private void btneditar_Click(object sender, EventArgs e)
        {
            
            if ( checkTextBoxesValues())
            {
                if (checkArea())
                {
                    MessageBox.Show("Já existe esta Área, escolha outra");
                }
                else
                {
                    string updateQuery = "UPDATE area SET nome_area = '" + txtarea.Text + "' WHERE idarea =" + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
                    {
                        try
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            cleanTextBox();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Erro:" + erro.Message);
                        }
                        finally
                        {
                            db.closeConnection();
                        }
                    }

                        
                }

                
                
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
            
                
        }
        //Elimina os Dados Da Tabela
        private void btnremover_Click(object sender, EventArgs e)
        {
            if (checkTextBoxesValues())
            {
                if (checkIdArea())
                {
                    MessageBox.Show("Esta Área contém subáreas\n Elimine primeiro as Subáreas");
                }
                else
                {
                    try
                    {
                        string deleteQuery = "DELETE FROM area WHERE idarea = " + int.Parse(txtid.Text);
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
                            check();
                            cleanTextBox();
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro:" + erro.Message);
                    }
                    finally
                    {
                        db.closeConnection();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }
        //Ve se existe a Area
        public Boolean checkIdArea()
        {
            DB db = new DB();

            String nome = txtid.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM subarea WHERE area_idarea = @nome", db.getConnection());

            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // permite ao utlizador procurar
        public void search(string search)
        {
            DB db = new DB();
            {
                string pesquisarQuery = "SELECT * FROM area WHERE nome_area LIKE '%" + search + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, db.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
               dtareas.DataSource = table;
            }

        }

        private void txtconsultararea_TextChanged(object sender, EventArgs e)
        {
            search(txtconsultararea.Text);
        }
    }
}
