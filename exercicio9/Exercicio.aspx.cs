using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TGSmartControls.BLL;
using TGSmartControls.Model;
using TGSmartControls.View;
using Smart.Model;
using SmartShare.Web.TelaPadrao;
using SmartShare.Web.TelaPadrao.Gerenciamento;

public partial class Exercicio : TGHelper2<UsuarioInfo>
{
    TelaGerenciamentoMasterBase tg;
    protected void Page_Load(object sender, EventArgs e)
    {
        tg = (TelaGerenciamentoMasterBase)this.Master;

        BindControls(rptLista, tgFooterLista, tgBotoesDetalhes, tgBotoesNovo, tgOrdenacao, tg, lnkBuscar, tgNoRows);
        tgOrdenacao.Adicionar("Código", UsuarioInfo.GetCdUsuario(), 80, AlinhamentoHorizontal.Centro);
        tgOrdenacao.Adicionar("Nome", UsuarioInfo.GetDsNome());
        tgOrdenacao.Adicionar("Cidade", CidadeInfo.GetDsNome());

        if (!IsPostBack)
            this.FirstLoad();
    }

    public override UsuarioInfo CarregarCamposPorID(int intIdRegistro)
    {
        return new UsuarioBLL().Get(intIdRegistro);
    }

    public override UsuarioInfo CarregarCamposPorIndice(int intIndice)
    {
        CidadeUsuarioBLL bll = new CidadeUsuarioBLL();
        bll.Filters = GetFilters();
        bll.Filters.PageNumber = intIndice;
        bll.Filters.EntriesPerPage = 1;
        UsuarioInfo info = bll.ListarPaginado()[0].Usuario;
        this.IdRegistroAtual = info.CdUsuario.Value;
        return info;
    }

    public override void ExcluirMultiplo(System.Collections.ArrayList arlIds)
    {
        UsuarioBLL bll = new UsuarioBLL();
        foreach (object oId in arlIds)
        {
            bll.Deletar((int)oId);
        }
        this.DefaultExcluirSucesso();
    }

    public override void ExcluirRegistro(int intIdRegistro)
    {
        new UsuarioBLL().Deletar(intIdRegistro);
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
            filters.FilterFields.Add(new Smart.Model.DbFilterLike(UsuarioInfo.GetDsNome(txtNome.Text)));

        return filters;
    }

    public override void ListarRegistros()
    {
        CidadeUsuarioBLL bll = new CidadeUsuarioBLL();
        bll.Filters = GetFilters();
        
        //Object obj = bll.ListarPaginado();
        //rptLista.DataSource = 
        //bll.Filters = GetFilters();
        //tgFooterLista.TotalRegistros = bll.GetTotalRegistros(); 
        rptLista.DataBind();
    }

    public override void PreencherDetalhes(UsuarioInfo info)
    {
        formDetalhes.CdCidadeNasc = info.CdCidadenasc.Value;
        formDetalhes.DtNasc = info.DtNasc.Value;
        formDetalhes.Nome = info.DsNome.Value;
        formDetalhes.Ativo = Convert.ToBoolean(info.StAtivo.Value);
        formDetalhes.Email = info.DsEmail.Value;
    }

    public override void SalvarNovoRegistro()
    {
        new UsuarioBLL().Inserir(preencherModel(formIncluir));
        this.DefaultSalvarNovoSucesso();
        formIncluir.LimparFormulario();
    }

    public override void SalvarRegistro(int intIdRegistro)
    {
        new UsuarioBLL().Atualizar(intIdRegistro, preencherModel(formDetalhes));
        this.DefaultSalvarSucesso();
    }

    private UsuarioInfo preencherModel(UsuarioForm form)
    {
        UsuarioInfo info = new UsuarioInfo();
        info.CdCidadenasc.Value = form.CdCidadeNasc;
        info.DsEmail.Value = form.Email;
        info.DsNome.Value = form.Nome;
        info.DtNasc.Value = form.DtNasc;
        info.StAtivo.Value = Convert.ToByte(form.Ativo);
        return info;
    }
}