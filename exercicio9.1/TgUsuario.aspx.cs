using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Smart.Database.SQL;
using Smart.Model;
using SmartShare.Web.TelaPadrao;
using SmartShare.Web.TelaPadrao.Gerenciamento;
using Exercicio.Model;
using Exercicio.BLL;
using Exercicio.View;
public partial class TgUsuario : TGHelper2<ContatoInfo>
{
    TelaGerenciamentoMasterBase tg;
    protected void Page_Load(object sender, EventArgs e)
    {
        tg = (TelaGerenciamentoMasterBase)this.Master;

        BindControls(rptLista, tgFooterLista, tgBotoesDetalhes, tgBotoesNovo, tgOrdenacao, tg, lnkBuscar, tgNoRows);
        
        tgOrdenacao.Adicionar("Código", ContatoInfo.GetCdContato(), 80, AlinhamentoHorizontal.Centro);
        tgOrdenacao.Adicionar("Nome", ContatoInfo.GetDsNome());
        tgOrdenacao.Adicionar("Email", ContatoInfo.GetDsEmail());
        tgOrdenacao.Adicionar("Nasci", ContatoInfo.GetDtNasci());
        tgOrdenacao.Adicionar("Cpf", ContatoInfo.GetDsCpf());
        tgOrdenacao.Adicionar("Sexo", ContatoInfo.GetDsSexo());
        tgOrdenacao.Adicionar("Cidade", ContatoInfo.GetDsCidade());
        tgOrdenacao.Adicionar("Estado", ContatoInfo.GetCdEstado());
        tgOrdenacao.Adicionar("Endereco", ContatoInfo.GetDsEndereco());
        if (!IsPostBack)
            this.FirstLoad();
    }

    public override ContatoInfo CarregarCamposPorID(int intIdRegistro)
    {
        return new  ContatoBLL().Get(intIdRegistro);
    }

    public override ContatoInfo CarregarCamposPorIndice(int intIndice)
    { 
        ContatoBLL bll = new ContatoBLL();
        bll.Filters = GetFilters();
        bll.Filters.PageNumber = intIndice;
        bll.Filters.EntriesPerPage = 1;
        ContatoInfo info = bll.ListarPaginado()[0];

        this.IdRegistroAtual = info.CdContato.Value;
        return info;
    }

    public override void ExcluirMultiplo(System.Collections.ArrayList arlIds)
    {
        ContatoBLL bll = new ContatoBLL();
        foreach (object oId in arlIds)
        {
            bll.Deletar((int)oId);
        }
        this.DefaultExcluirSucesso();
    }

    public override void ExcluirRegistro(int intIdRegistro)
    {
        new ContatoBLL().Deletar(intIdRegistro);
        this.DefaultExcluirSucesso();
    }

    public override void FirstLoad()
    {
        this.DefaultFirstLoad("Gerenciamento de Usuários");
    }

    public override QueryOptions GetFilters()
    {
        QueryOptions filters = this.GetDefaultFilters();
        if (txtNome.Text.Length > 0)
            filters.FilterFields.Add(new Smart.Model.DbFilterLike(ContatoInfo.GetDsNome(txtNome.Text)));

        return filters;
    }

    public override void ListarRegistros()
    {
        ContatoBLL bll = new ContatoBLL();

        bll.Filters = GetFilters();
        
        rptLista.DataSource = bll.ListarPaginado();
        
        bll.Filters = GetFilters();
        
        tgFooterLista.TotalRegistros = bll.GetTotalRegistros();
        
        rptLista.DataBind();
    }

    public override void PreencherDetalhes(ContatoInfo info)
    {
        formDetalhes.Nome = info.DsNome.Value;
        formDetalhes.Email = info.DsEmail.Value;
        formDetalhes.Nasc = info.DtNasci.Value;
        formDetalhes.Cpf = info.DsCpf.Value;
        formDetalhes.Sexo = info.DsSexo.Value;
        formDetalhes.Cidade = info.DsCidade.Value;
        formDetalhes.Estado = info.CdEstado.Value;
        formDetalhes.endereco = info.DsEndereco.Value;
    }

    public override void SalvarNovoRegistro()
    {
        new ContatoBLL().Inserir(preencherModel(formIncluir));
        this.DefaultSalvarNovoSucesso();
      //  formIncluir.LimparFormulario();
    }

    public override void SalvarRegistro(int intIdRegistro)
    {
        new ContatoBLL().Atualizar(intIdRegistro, preencherModel(formDetalhes));
        this.DefaultSalvarSucesso();
    }

    private ContatoInfo preencherModel(UsuarioForm form)
    {
        ContatoInfo info = new ContatoInfo();
        info.DsEmail.Value = form.Email;
        info.DsNome.Value = form.Nome;
        info.DtNasci.Value = form.Nasc;
        info.DsCpf.Value = form.Cpf;
        info.DsSexo.Value = form.Sexo;
        info.DsCidade.Value = form.Cidade;
        info.CdEstado.Value = form.Estado;
        info.DsEndereco.Value = form.endereco;
        return info;
    }

   /* protected void clear()
    {
        
        nomeid.Text = "";
        emailid.Text = "";
        nasciid.Text = "";
        cpfid.Text = "";
        sexoid.SelectedValue = "Masculino";
        estadoid.SelectedValue = "1";
        cidadeid.Text = "";
        enderecoid.Text = "";
    }*/
}