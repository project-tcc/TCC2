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
        //Desenvolvimento_TCCEntities2 context = new Desenvolvimento_TCCEntities2();

        protected void Page_Load(object sender, EventArgs e)
        {
            //ddlPaises = DropGenerico(ddlPaises, 1);
            //ddlTitulo = DropGenerico(ddlTitulo, 2);
            //ddlSexo = DropGenerico(ddlSexo, 3);
            //ddlStatus = DropGenerico(ddlStatus, 4);
            //ddlTipos = DropGenerico(ddlTipos, 5);

        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {
            //professor_tb Professor = new professor_tb()
            //{
            //    nome_completo = txt_nome_completo.Text,
            //    rg = Convert.ToInt32(txt_rg.Text),
            //    cpf = Convert.ToInt32(txt_CPF.Text),
            //    telefone_fixo = txt_telefone_fixo.Text,
            //    telefone_celular = txt_telefone_celular.Text,
            //    telefone_emergencial = txt_telefone_emergencial.Text,
            //    nacionalidade_id = Convert.ToInt32(ddlPaises.Text),
            //    end_cep = txtCEP.Text,
            //    end_complemento = txt_complemento.Text,
            //    end_bairro = txt_bairro.Text,
            //    end_cidade = txt_cidade.Text,
            //    tipo_logradouro = txt_tipo_logradouro.Text,
            //    end_rua = txtRua.Text,
            //    numresidencia = Convert.ToInt32(txtNumResidencia.Text),
            //    codigo_acesso = txt_codigo_acesso.Text,
            //    senha_acesso = Convert.ToInt32(txt_senha_acesso.Text),
            //    data_cadastro = Convert.ToDateTime(txt_data_cadastro.Text),
            //    sexo_id = Convert.ToInt32(ddlSexo.Text),
            //    status_id = Convert.ToInt32(ddlStatus.Text),
            //    tipo_id = Convert.ToInt32(ddlTipos.Text),
            //};

            //context.professor_tb.Add(Professor);
            //context.SaveChanges();
            //Response.Write("<script>alert('Registro Inserido com Sucesso!');</script>");
        }

        protected void ddlPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private DropDownList DropGenerico(DropDownList drop, int tp)
        //{
        //    //var pais = new List<pais_tb>();
        //    //var titulo = new List<titulo_tb>();
        //    //var sexo = new List<sexo_tb>();
        //    //var status = new List<status_tb>();
        //    //var tipo = new List<tipo_tb>();

        //    DropDownList dropTemp = new DropDownList();

        //    switch (tp)
        //    {
        //        case 1:
        //            pais = context.pais_tb.ToList();
        //            foreach (var item in pais.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 2:
        //            titulo = context.titulo_tb.ToList();
        //            foreach (var item in titulo.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 3:
        //            sexo = context.sexo_tb.ToList();
        //            foreach (var item in sexo.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 4:
        //            status = context.status_tb.ToList();
        //            foreach (var item in status.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 5:
        //            tipo = context.tipo_tb.ToList();
        //            foreach (var item in tipo.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;
        //    }

        //    foreach (ListItem item in dropTemp.Items)
        //    {
        //        drop.Items.Insert(0, new ListItem(item.Text, item.Value));
        //    }

        //    drop.Items.Insert(0, new ListItem("Selecione", ""));
        //    return drop;
        //}


        //public void carregaListaPaises()
        //    {
        //        List<pais_tb> pais = new List<pais_tb>();
        //        pais = context.pais_tb.ToList();
        //        foreach (var item in pais.ToList())
        //        {
        //            ddlPaises.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //        }
        //        ddlPaises.Items.Insert(0, new ListItem("", ""));
        //    }


        //protected void ddlTitulos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<titulo_tb> curso = new List<titulo_tb>();
        //    curso = context.titulo_tb.ToList();
        //    foreach (var item in curso.ToList())
        //    {
        //        ddlTitulo.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }
        //    ddlTitulo.Items.Insert(0, new ListItem("", ""));
        //}

        //protected void ddlSexo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<sexo_tb> sexo = new List<sexo_tb>();

        //    sexo = context.sexo_tb.ToList();
        //    foreach (var item in sexo.ToList())
        //    {
        //        ddlSexo.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }
        //    ddlSexo.Items.Insert(0, new ListItem("", ""));
        //}

        //protected void ddlStatus_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<status_tb> status = new List<status_tb>();

        //    status = context.status_tb.ToList();
        //    foreach (var item in status.ToList())
        //    {
        //        ddlStatus.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }
        //    ddlStatus.Items.Insert(0, new ListItem("", ""));
        //}

        //protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<tipo_tb> tipo = new List<tipo_tb>();
        //    tipo = context.tipo_tb.ToList();
        //    foreach (var item in tipo.ToList())
        //    {
        //        ddlTipos.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }
        //    ddlTipos.Items.Insert(0, new ListItem("", ""));
        //}


    }
 }
 