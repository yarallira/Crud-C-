using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_C_Sharp
{
    public partial class AddFuncionário : Form
    {
        public AddFuncionário()
        {
            InitializeComponent();

            txtPesquisarNome.Enabled = true;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereço.Enabled = false;
            txtNúmero.Enabled = false;
            txtBairro.Enabled = false;
            txtRG.Enabled = false;
            txtCPF.Enabled = false;
           
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=YaraProgramadora;Data Source=DESKTOP-46D3CA8\SQLEXPRESS";
      
        private string strSql = string.Empty;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            txtPesquisarNome.Enabled = false;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereço.Enabled = true;
            txtNúmero.Enabled = true;
            txtBairro.Enabled = true;
            txtRG.Enabled = true;
            txtCPF.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into tbl_pessoas (ch_nome,ch_telefone,ch_celular," +
                "ch_email,ch_endereco,ch_numero,ch_bairro,ch_rg,ch_cpf) " +
                "values(@Nome,@Telefone,@Celular,@Email,@Endereço,@Numero,@Bairro,@RG,@CPF)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereço", SqlDbType.VarChar).Value = txtEndereço.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNúmero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtRG.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtCPF.Text;

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            txtPesquisarNome.Enabled = true;

            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNúmero.Clear();
            txtBairro.Clear();
            txtRG.Clear();
            txtCPF.Clear();

            txtPesquisarNome.Enabled = true;
            txtNome.Enabled = false;
            txtTelefone.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereço.Enabled = false;
            txtNúmero.Enabled = false;
            txtBairro.Enabled = false;
            txtRG.Enabled = false;
            txtCPF.Enabled = false;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            strSql = "Select * from tbl_pessoas " +
               "where ch_nome = @Pesquisa ";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Pesquisa", SqlDbType.VarChar).Value = txtPesquisarNome.Text;          

            try
            { 
                if ( txtPesquisarNome.Text == string.Empty)
                {
                    MessageBox.Show("Você não digitou um nome.");
                }


                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("Este nome não esta cadastrado");
                }

                dr.Read();

                txtId.Text = Convert.ToString(dr["nm_id"]);
                txtNome.Text = Convert.ToString(dr["ch_nome"]);
                txtTelefone.Text = Convert.ToString(dr["ch_telefone"]);
                txtCelular.Text = Convert.ToString(dr["ch_celular"]);
                txtEmail.Text = Convert.ToString(dr["ch_email"]);
                txtEndereço.Text = Convert.ToString(dr["ch_endereco"]);
                txtNúmero.Text = Convert.ToString(dr["ch_numero"]);
                txtBairro.Text = Convert.ToString(dr["ch_bairro"]);
                txtRG.Text = Convert.ToString(dr["ch_rg"]);
                txtCPF.Text = Convert.ToString(dr["ch_cpf"]);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }

            if (txtPesquisarNome.Text != string.Empty)
            {
                txtPesquisarNome.Enabled = true;
                txtNome.Enabled = true;
                txtTelefone.Enabled = true;
                txtCelular.Enabled = true;
                txtEmail.Enabled = true;
                txtEndereço.Enabled = true;
                txtNúmero.Enabled = true;
                txtBairro.Enabled = true;
                txtRG.Enabled = true;
                txtCPF.Enabled = true;
            }

            txtPesquisarNome.Clear();        

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            strSql = "UPDATE tbl_pessoas SET ch_nome = @Nome , ch_telefone = @Telefone, ch_celular = @Celular," +
                "ch_email = @Email, ch_endereco = @Endereço, ch_numero = @Numero, ch_bairro = @Bairro," +
                "ch_rg = @RG, ch_cpf =@CPF WHERE nm_id = @Id";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = txtId.Text;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txtCelular.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txtEmail.Text;
            comando.Parameters.Add("@Endereço", SqlDbType.VarChar).Value = txtEndereço.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txtNúmero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txtBairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txtRG.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txtCPF.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Alterado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNúmero.Clear();
            txtBairro.Clear();
            txtRG.Clear();
            txtCPF.Clear();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM tbl_pessoas WHERE nm_id = @Id";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.VarChar).Value = txtId.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Exclusão de cadastro feita com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereço.Clear();
            txtNúmero.Clear();
            txtBairro.Clear();
            txtRG.Clear();
            txtCPF.Clear();
        }


    }
}
