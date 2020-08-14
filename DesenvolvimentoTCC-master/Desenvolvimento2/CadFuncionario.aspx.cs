using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desenvolvimento2
{
    public partial class CadFuncionario : System.Web.UI.Page
    {

        //Desenvolvimento_TCCEntities2 context = new Desenvolvimento_TCCEntities2();

        protected void Page_Load(object sender, EventArgs e)
        {

            //ddlPais = DropGenerico(ddlPais, 1);
            //ddlSexo = DropGenerico(ddlSexo, 2);
            //ddlStatus = DropGenerico(ddlStatus, 3);
            //ddlTipo = DropGenerico(ddlTipo, 4);

        }

        protected void btn_salvar_Click(object sender, EventArgs e)
        {

            //funcionario_tb Funcionario = new funcionario_tb()
            //{
            //    nome_completo = txt_nome_completo.Text,
            //    rg = Convert.ToInt32(txt_RG.Text),
            //    cpf = Convert.ToInt32(txt_CPF.Text),
            //    telefone_fixo = txt_telefone_fixo.Text,
            //    telefone_celular = txt_telefone_celular.Text,
            //    telefone_emergencial = txt_telefone_emergencial.Text,
            //    nacionalidade_id = Convert.ToInt32(ddlPais.Text),
            //    end_cep = txtCEP.Text,
            //    end_complemento = txt_complemento.Text,
            //    end_bairro = txt_bairro.Text,
            //    end_cidade = txt_cidade.Text,
            //    tipo_logradouro = txt_tipo_logradouro.Text,
            //    end_rua = txtRua.Text,
            //    numresidencia = Convert.ToInt32(txtNumResidencia.Text),
            //    data_cadastro = Convert.ToDateTime(txtDTCadastro.Text),
            //    dt_alteracao = Convert.ToDateTime(txtdt_alteracao.Text),

            //};

            //context.funcionario_tb.Add(Funcionario);
            //context.SaveChanges();
            //Response.Write("<script>alert('Registro Inserido com Sucesso!');</script>");


        }

        protected void ddlPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private DropDownList DropGenerico(DropDownList drop, int tp)
        //{
        //    //neste switch os paiíses serão listados.
        //    var pais = new List<pais_tb>();
        //    var sexo = new List<sexo_tb>();
        //    var status = new List<status_tb>();
        //    var tipo = new List<tipo_tb>();

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
        //            sexo = context.sexo_tb.ToList();
        //            foreach (var item in sexo.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 3:
        //            status = context.status_tb.ToList();
        //            foreach (var item in status.ToList())
        //            {
        //                dropTemp.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //            }
        //            break;

        //        case 4:
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
        //{

        //    List<pais_tb> pais = new List<pais_tb>();

        //    pais = context.pais_tb.ToList();

        //    foreach (var item in pais.ToList())
        //    {
        //        ddlPais.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }

        //    ddlPais.Items.Insert(0, new ListItem("", ""));

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
        //        ddlTipo.Items.Insert(0, new ListItem(item.nome, item.id.ToString()));
        //    }
        //    ddlTipo.Items.Insert(0, new ListItem("", ""));
        //}


    }
}