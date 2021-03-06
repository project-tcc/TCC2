﻿using Dados;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desenvolvimento2
{
    public partial class CadAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarPaises();
                CarregarSexo();
                CarregarStatus();
                CarregarTipo();
            }
        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor()
            {
                Nome_completo = txt_nome_completo.Text,
                Rg = txt_rg.Text,
                Cpf = txt_CPF.Text,
                Telefone_fixo = txt_telefone_fixo.Text,
                Telefone_celular = txt_telefone_celular.Text,
                Telefone_emergencial = txt_telefone_emergencial.Text,
                Nacionalidade_id = ddlPaises.Text,
                End_cep = txtCEP.Text,
                End_complemento = txt_complemento.Text,
                End_bairro = txt_bairro.Text,
                End_cidade = txt_cidade.Text,
                Tipo_logradouro = txt_tipo_logradouro.Text,
                End_rua = txtRua.Text,
                Numresidencia = txtNumResidencia.Text,
                Formacao = txt_formacao.Text,
                Codigo_acesso = txt_codigo_acesso.Text,
                Senha_acesso = Convert.ToInt32(txt_senha_acesso.Text),
                Dt_inclusao = Convert.ToDateTime(txt_dt_inclusao.Text),
                Dt_alteracao = Convert.ToDateTime(txt_dt_alteracao.Text),
                Status_id = ddlStatus.Text,
                Sexo_id = ddlSexo.Text,
                Tipo_id = ddlTipo.Text,
                Dt_admissao = Convert.ToDateTime(txt_data_admissao.Text),

            };

            ProfessorDB professorDB = new ProfessorDB();
            bool status = professorDB.Salvar(professor);

            if (status)
            {
                Response.Write("<script>alert('Registro Inserido com Sucesso!');</script>");
                LimparComponentes();
            }
            else
            {
                Response.Write("<script>alert('ERRO AO TENTAR INSERIR OS DADOS!');</script>");
            }

        }

        private void LimparComponentes()
        {
            txt_nome_completo.Text = String.Empty;
            txt_rg.Text = String.Empty;
            txt_CPF.Text = String.Empty;
            txt_telefone_fixo.Text = String.Empty;
            txt_telefone_celular.Text = String.Empty;
            txt_telefone_emergencial.Text = String.Empty;
            txtCEP.Text = String.Empty;
            txt_complemento.Text = String.Empty;
            txt_bairro.Text = String.Empty;
            txt_cidade.Text = String.Empty;
            txt_tipo_logradouro.Text = String.Empty;
            txtRua.Text = String.Empty;
            txtNumResidencia.Text = String.Empty;
            txt_formacao.Text = String.Empty;
            txt_codigo_acesso.Text = String.Empty; 
            txt_senha_acesso.Text = String.Empty;
            txt_dt_inclusao.Text = String.Empty;
            txt_dt_alteracao.Text = String.Empty;
            txt_data_admissao.Text = String.Empty;
        }

        private void CarregarPaises()
        {
            PaisDB paisDB = new PaisDB();
            ddlPaises.DataSource = paisDB.ConsultarList();
            ddlPaises.DataValueField = "Id";
            ddlPaises.DataValueField = "Nome";
            ddlPaises.DataBind();
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
 