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

namespace PSI18H_M16_Projeto_2218088_RodrigoBarata.Forms
{
    public partial class Formacao : Form
    {
        DB db = new DB();
        public Formacao()
        {
            InitializeComponent();
            
        }
        public void checkCombox()
        {
            

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM area", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Não tem nenhuma Área\n Tem de inserir Primeiro a Área");
                dt.Enabled = false;
                cbxarea.Enabled = false;
                cbxsub.Enabled = false;
                cbxcurso.Enabled = false;
            }
            else
            {
                string selectarea = "SELECT * FROM area ORDER BY nome_area ASC;";
                
                using (MySqlCommand mysqlcommand = new MySqlCommand(selectarea, db.connection))
                {
                    MySqlDataReader myReader;
                    try
                    {
                        db.openConnection();
                        myReader = mysqlcommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        cbxarea.DisplayMember = "nome_area";
                        cbxarea.ValueMember = "idarea";
                        cbxarea.DataSource = dt;
                        
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
        public void checkComboxSub()
        {


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM subarea WHERE area_idarea = " + cbxarea.SelectedValue, db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Não tem nenhuma Subárea\n Tem de inserir Primeiro a Subárea");
                dt.Enabled = false;
                
                cbxsub.Enabled = false;
                cbxcurso.Enabled = false;
                cbxsub.Text = "";
                cbxcurso.Text = "";
            }
            else
            {
                string selectQuery = "SELECT * FROM subarea WHERE area_idarea = " + cbxarea.SelectedValue;
                using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
                {
                    MySqlDataReader myReader;
                    try
                    {
                        db.openConnection();
                        myReader = mysqlcommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        cbxsub.DisplayMember = "nome_subarea";
                        cbxsub.ValueMember = "idsubarea";
                        cbxsub.DataSource = dt;
                        checkComboxCurso();
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
        public void checkComboxCurso()
        {


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM curso WHERE subarea_idsubarea = " + cbxsub.SelectedValue, db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Não tem nenhum Curso\n Tem de inserir Primeiro o Curso");
                dt.Enabled = false;

                
                cbxcurso.Enabled = false;
                cbxcurso.Text = "";
            }
            else
            {
                string selectQuery = "SELECT * FROM curso WHERE subarea_idsubarea = " + cbxsub.SelectedValue;
                 using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
                 {
                     MySqlDataReader myReader;
                     try
                     {
                         db.openConnection();
                         myReader = mysqlcommand.ExecuteReader();
                         DataTable dt = new DataTable();
                         dt.Load(myReader);
                         cbxcurso.DisplayMember = "nome_curso";
                         cbxcurso.ValueMember = "idcursos";
                         cbxcurso.DataSource = dt;
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
        public void checkComboxFormador()
        {


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM formador ", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Não tem nenhum Formador");
                dt.Enabled = false;


                cbxformador.Enabled = false;
                cbxformador.Text = "";
            }
            else
            {
                string selectQuery = "SELECT * FROM formador ";
                using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
                {
                    MySqlDataReader myReader;
                    try
                    {
                        db.openConnection();
                        myReader = mysqlcommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        cbxformador.DisplayMember = "nome";
                        cbxformador.ValueMember = "idformador";

                        cbxformador.DataSource = dt;
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
        public void checkComboxCliente()
        {


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM cliente ", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Não tem nenhum Cliente");
                dt.Enabled = false;


                cbxcliente.Enabled = false;
                cbxcliente.Text = "";
            }
            else
            {
                string selectQuery = "SELECT * FROM cliente ";
                using (MySqlCommand mysqlcommand = new MySqlCommand(selectQuery, db.connection))
                {
                    MySqlDataReader myReader;
                    try
                    {
                        db.openConnection();
                        myReader = mysqlcommand.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(myReader);
                        cbxcliente.DisplayMember = "nome";
                        cbxcliente.ValueMember = "idcliente";
                        cbxcliente.DataSource = dt;
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
        public Boolean checkTextBoxesValues()
        {
            if(cbxarea.Text.Equals("") || cbxsub.Text.Equals("") || cbxcurso.Text.Equals("") || cbxformador.Text.Equals("") || cbxcliente.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void dataview()
        {
            string selectQuery = "select F.idformacao, F.data_de_inicio,F.data_final , F2.nome, cli.nome, C1.nome_curso, Su.nome_subarea, A1.nome_area FROM  formacao F  join formador F2 on F.formador_idformador=F2.idformador join cliente cli on F.cliente_idcliente=cli.idcliente join curso C1 on F.curso_idcursos=C1.idcursos join subarea Su on C1.subarea_idsubarea=Su.idsubarea join area A1 on Su.area_idarea=A1.idarea";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, db.connection);
            adapter.Fill(table);
            dt.DataSource = table;
                     
            MySqlCommand command = new MySqlCommand(selectQuery, db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                
                dt.Enabled = false;


                cbxcliente.Enabled = false;
               
            }



        }

        private void cbxarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkComboxSub();
        }

        private void Formacao_Load(object sender, EventArgs e)
        {
            checkCombox();
            checkComboxFormador();
            checkComboxCliente();
            dataview();
        }

        private void cbxsub_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkComboxCurso();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            string insertquery = "INSERT INTO formacao (data_de_inicio, data_final, formador_idformador, cliente_idcliente, curso_subarea_area_idarea, curso_subarea_idsubarea, curso_idcursos ) VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7)";
            using (MySqlCommand cmd = new MySqlCommand(insertquery, db.connection))
            {
                if (checkTextBoxesValues())
                {
                    
                    
                        try
                        {
                            db.openConnection();

                            cmd.Parameters.AddWithValue("@param1", DateTime.Parse(DTPinicio.Text).ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@param2", DateTime.Parse(DTPFim.Text).ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@param3", cbxformador.SelectedValue);
                            cmd.Parameters.AddWithValue("@param4", cbxcliente.SelectedValue);
                            cmd.Parameters.AddWithValue("@param5", cbxarea.SelectedValue);
                            cmd.Parameters.AddWithValue("@param6", cbxsub.SelectedValue);
                            cmd.Parameters.AddWithValue("@param7", cbxcurso.SelectedValue);
                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
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
                else
                {
                    MessageBox.Show("Preencha todos os campos");
                }
            }
        }

        private void dt_MouseClick(object sender, MouseEventArgs e)
        {
            txtid.Text = dt.CurrentRow.Cells[0].Value.ToString();
            DTPinicio.Text = dt.CurrentRow.Cells[1].Value.ToString();
            DTPFim.Text = dt.CurrentRow.Cells[2].Value.ToString();
            cbxformador.Text = dt.CurrentRow.Cells[3].Value.ToString();
            cbxcurso.Text = dt.CurrentRow.Cells[4].Value.ToString();
            cbxsub.Text = dt.CurrentRow.Cells[5].Value.ToString();
            cbxarea.Text = dt.CurrentRow.Cells[6].Value.ToString();
            cbxcliente.Text = dt.CurrentRow.Cells[7].Value.ToString();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (checkTextBoxesValues())
            {
               
               
                    try
                    {
                        string updateQuery = "UPDATE `formacao` SET `data_de_inicio`='" + DateTime.Parse(DTPinicio.Text).ToString("yyyy-MM-dd") + "',`data_final`='" + DateTime.Parse(DTPFim.Text).ToString("yyyy-MM-dd") + "',`formador_idformador`='" + cbxformador.Text + "',`curso_idcursos`='" +cbxcurso.Text + "',`curso_subarea_idsubarea`='" + cbxsub.Text + "',`curso_subarea_area_idarea`='" + cbxarea.Text + "',`cliente_idcliente`='" + cbxcliente.Text + "' WHERE idformacao =" + int.Parse(txtid.Text);
                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, db.connection))
                        {
                            db.openConnection();


                            cmd.ExecuteNonQuery();
                            dataview();
                            db.closeConnection();
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
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (checkTextBoxesValues())
            {

                try
                {
                    string deleteQuery = "DELETE FROM formacao WHERE idformacao = " + int.Parse(txtid.Text);
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, db.connection))
                    {
                        db.openConnection();


                        cmd.ExecuteNonQuery();
                        dataview();
                        db.closeConnection();
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
            else
            {
                MessageBox.Show("Preencha os campos");
            }
        }
        public void search(string search)
        {
            DB db = new DB();
            {
                string pesquisarQuery = "SELECT * FROM formacao WHERE nome LIKE '%" + search + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(pesquisarQuery, db.getConnection());
                DataTable table = new DataTable();
                adapter.Fill(table);
                dt.DataSource = table;
            }

        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            search(txtconsultar.Text);
        }
    }
}
