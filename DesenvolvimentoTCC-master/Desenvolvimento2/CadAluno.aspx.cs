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
        // dá para usar na pagina toda sem precisar ficar criando
        //banco_tccEntities context = new banco_tccEntities();

        AlunoDB context = new AlunoDB();
        PaisDB contexts = new PaisDB();
        /// <summary>
        /// string de conexão
  

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            //{
            //    CarregarPaises();
            //    CarregarCursos();
            //    CarregarSexo();
            //    CarregarStatus();
            //    CarregarTipo();
            //}
            //CarregarTabela();
            //    //Carrega o Drop Down referente aos paises
            //    ddlPaises = DropGenerico(ddlPaises, 1);
            //    ddlCursos = DropGenerico(ddlCursos, 2);
            //    ddlSexo = DropGenerico(ddlSexo, 3);
            //    ddlStatus = DropGenerico(ddlStatus, 4);
            //    ddlTipo = DropGenerico(ddlTipo, 5);
        }

            protected void btn_salvar_Click(object sender, EventArgs e)
            {
                Aluno aluno = new Aluno()
                {
                    ra = int.Parse(txt_RA.Text),
                    //curso = Convert.ToInt64(ddlCursos.Text),
                    curso = ddlCursos.Text,
                    data_de_ingresso = Convert.ToDateTime(txtDataIngressao.Text),
                    nome_completo = txtNomeCompleto.Text,
                    rg = Convert.ToInt32(txtRG.Text),
                    cpf = Convert.ToInt32(txtcpf.Text),
                    telefone_fixo = txtTelefone.Text,
                    telefone_celular = txtCelular.Text,
                    nacionalidade = Convert.ToInt32(ddlPaises.Text),
                    nome_pai = txt_nome_pai.Text,
                    nome_mae = txt_nome_mae.Text,
                    end_cep = txtCEP.Text,
                    end_complemento = txt_complemento.Text,
                    end_bairro = txt_bairro.Text,
                    end_cidade = txt_cidade.Text,
                    tipo_logradouro = txt_tipo_logradouro.Text,
                    end_rua = txtEnd.Text,
                    telefone_emergencial = txt_tel_emergencia.Text,
                    data_nascimento = Convert.ToDateTime(txtDTNascimento.Text),
                    email = txtEmail.Text,
                    sexo_id = Convert.ToInt32(ddlSexo.Text),
                    status_id = Convert.ToInt32(ddlStatus.Text),
                    tipo_id = Convert.ToInt32(ddlTipo.Text),
                    dt_inclusao = Convert.ToDateTime(txt_dt_inclusao.Text),
                    data_alteracao = Convert.ToDateTime(txt_dt_alteracao.Text),
                };

                AlunoDB alunoDB = new AlunoDB();
                bool status = alunoDB.Salvar(aluno);


                if (status)
                {
                    lblMSG.Text = "Registro Inserido!";
                    LimparComponentes();

                }
                else
                {
                    lblMSG.Text = "Erro ao inserir registro";

                }
            }

            private void LimparComponentes()
            {
            txt_RA.Text = String.Empty;
            ddlCursos.Text = String.Empty;
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
            txt_tel_emergencia.Text = String.Empty;
            txtDTNascimento.Text = String.Empty;
            txtEmail.Text = String.Empty;
            ddlSexo.Text = String.Empty;
            ddlStatus.Text = String.Empty;
            ddlTipo.Text = String.Empty;
            txt_dt_inclusao.Text = String.Empty;
            txt_dt_alteracao.Text = String.Empty;
            }


        //private void CarregarPaises()
        //{
        //    PaisDB paisDB = new PaisDB();
        //    ddlPaises.DataSource = paisDB.ConsultarTudo();
        //    ddlPaises.DataBind();
        //}


        
        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e)
            {

            }



        }
    } 