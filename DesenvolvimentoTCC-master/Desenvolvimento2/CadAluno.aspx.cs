using System;
using Model;
using Dados;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Instrumentation;

//STRING DE CONEXÃO

namespace Desenvolvimento2
{
    public partial class CadAluno1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarPaises();
                CarregarCursos();
                CarregarSexo();
                CarregarStatus();
                CarregarTipo();
            }
        }

            protected void btn_salvar_Click(object sender, EventArgs e)
            {
            Aluno aluno = new Aluno()
            {
                    Ra = txt_RA.Text,
                    Curso = ddlCursos.Text,
                    Data_de_ingresso = Convert.ToDateTime(txtDataIngressao.Text),
                    Nome_completo = txtNomeCompleto.Text,
                    Rg = txtRG.Text,
                    Cpf = txtcpf.Text,
                    Telefone_fixo = txtTelefone.Text,
                    Telefone_celular = txtCelular.Text,
                    Nacionalidade = ddlPaises.Text,
                    Nome_pai = txt_nome_pai.Text,
                    Nome_mae = txt_nome_mae.Text,
                    End_cep = txtCEP.Text,
                    End_complemento = txt_complemento.Text,
                    End_bairro = txt_bairro.Text,
                    End_cidade = txt_cidade.Text,
                    Tipo_logradouro = txt_tipo_logradouro.Text,
                    End_rua = txtEnd.Text,
                    Telefone_emergencial = txt_tel_emerg.Text,
                    Data_nascimento = Convert.ToDateTime(txtDTNascimento.Text),
                    Email = txtEmail.Text,
                    Sexo_id = ddlSexo.Text,
                    Status_id = ddlStatus.Text,
                    Tipo_id = ddlTipo.Text,
                    Dt_inclusao = Convert.ToDateTime(txt_dt_inclusao.Text),
                    Data_alteracao = Convert.ToDateTime(txt_dt_alteracao.Text),
                };

                AlunoDB alunoDB = new AlunoDB();
                bool status = alunoDB.Salvar(aluno);

            if (status)
                {
                  Response.Write("<script>alert('Registro Inserido com Sucesso!');</script>");
                  LimparComponentes();
            }
                else
                {
                Response.Write("<script>alert('Erro ao tentar inserir!');</script>");
            }
            }

        private void LimparComponentes()
        {
            txt_RA.Text = String.Empty;
            txtDataIngressao.Text = String.Empty;
            txtNomeCompleto.Text = String.Empty;
            txtRG.Text = String.Empty;
            txtcpf.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtCelular.Text = String.Empty;
            ddlPaises.Text = String.Empty;
            txt_nome_pai.Text = String.Empty;
            txt_nome_mae.Text = String.Empty;
            txtCEP.Text = String.Empty;
            txt_complemento.Text = String.Empty;
            txt_bairro.Text = String.Empty;
            txt_cidade.Text = String.Empty;
            txt_tipo_logradouro.Text = String.Empty;
            txtEnd.Text = String.Empty;
            txt_tel_emerg.Text = String.Empty;
            txtDTNascimento.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txt_dt_inclusao.Text = String.Empty;
            txt_dt_alteracao.Text = String.Empty;
        }


        private void CarregarPaises()
        {
            PaisDB paisDB = new PaisDB();
            ddlPaises.DataSource = paisDB.ConsultarList();
            ddlPaises.DataValueField = "Id";
            ddlPaises.DataValueField = "Nome";
            ddlPaises.DataBind();
        }

        private void CarregarCursos()
        {
            CursoDB cursoDB = new CursoDB();
            ddlCursos.DataSource = cursoDB.ConsultarList();
            ddlCursos.DataValueField = "Id";
            ddlCursos.DataValueField = "Nome";
            ddlCursos.DataBind();        
        }

        private void CarregarSexo()
        {
            SexoDB sexoDB = new SexoDB();
            ddlSexo.DataSource = sexoDB.ConsultarList();
            ddlSexo.DataValueField = "Id";
            ddlSexo.DataValueField = "Nome";
            ddlSexo.DataBind();
        }

        private void CarregarStatus()
        {
            StatusDB statusDB = new StatusDB();
            ddlStatus.DataSource = statusDB.ConsultarList();
            ddlStatus.DataValueField = "Id";
            ddlStatus.DataValueField = "Nome";
            ddlStatus.DataBind();
        }

        private void CarregarTipo()
        {
            TipoDB tipoDB = new TipoDB();
            ddlTipo.DataSource = tipoDB.ConsultarList();
            ddlTipo.DataValueField = "Id";
            ddlTipo.DataValueField = "Nome";
            ddlTipo.DataBind();
        }
    }
  }