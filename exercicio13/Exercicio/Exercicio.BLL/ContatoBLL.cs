using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercicio.DAL;
using Exercicio.Model;
using Smart.Database;
using Exercicio.View;

namespace Exercicio.BLL
{
    public class ContatoBLL : Smart.Model.BusinessObject
    {
        public ContatoBLL() { }

        public ContatoBLL(DbConn pDbHnd) : base(pDbHnd) { }

        public ContatoInfo Get(Int32 pCdContato)
        {
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            return dal.Get(pCdContato);
        }

        
        
        public Int32 Inserir(ContatoInfo pInfo)
        {
            if(!validaNome(pInfo.DsNome.Value))
            {
                this.Errors.Add("Deve conter nome e sobrenome!");

                return 0;
            }//(Convert.ToDateTime(pInfo.DtNasci.Value)).Year > AnoBase
            else if (VerificarIdade(pInfo.DtNasci.Value))
            {
                this.Errors.Add("Tem que ter entre 18 e 60 anos!");
                return 0;
            }

            else if (ValidaCpf(pInfo.DsCpf.Value))
            {
                this.Errors.Add("Cpf já cadastrado!");
                return 0;
            }
            else
            {
                ContatoDAL dal = new ContatoDAL(this.DbHnd);
                return dal.Inserir(pInfo);
            }

            return 0;
        }
        public bool validaNome(String nome)
        {
            return nome.Contains(" ");
        }
        public bool VerificarIdade(DateTime DataNascimento)
        {
            int AnoBase = DateTime.Today.Year - 18;
            int AnoMax = DateTime.Today.Year - 60;
            if ( DataNascimento.Year > AnoBase)
            {
                return true;
            }
            if (DataNascimento.Year < AnoMax)
            {
                return true;
            }

            if (AnoBase == DataNascimento.Year)
            {
                if (DataNascimento.Month > DateTime.Now.Month)
                {
                    return true;
                }

                if (DataNascimento.Month == DateTime.Now.Month && DataNascimento.Day >= DateTime.Now.Day)
                {
                        return true;
                }
            }
            if (AnoMax == DataNascimento.Year)
            {
                if (DataNascimento.Month < DateTime.Now.Month)
                {
                    return true;
                }

                if (DataNascimento.Month == DateTime.Now.Month && DataNascimento.Day <= DateTime.Now.Day)
                {   
                        return true;
                 }
            }
            return false;
        }
        public bool ValidaCpf(String cpf)
        {
            using (ContatoEstadoBLL contEstBll = new ContatoEstadoBLL())
            {
                //contEstBll.Filters = new Smart.Model.QueryOptions();
                //contEstBll.Filters.FilterFields.Add(new Smart.Model.DbFilterLike(ContatoInfo.GetDsCpf(cpf)));

                Smart.Model.QueryOptions filt = new Smart.Model.QueryOptions();
                filt.FilterFields.Add(new Smart.Model.DbFilterLike(ContatoInfo.GetDsCpf(cpf)));
                contEstBll.Filters = filt;
                
                if (contEstBll.listaRelatorio() != null)
                {
                    return true;
                }
            }

            return false;
        }
        public void Atualizar(Int32 pCdContato, ContatoInfo pInfo)
        {
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            dal.Atualizar(pCdContato, pInfo);
        }
        public void Deletar(Int32 pCdContato)
        {
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            dal.Deletar(pCdContato);
        }
        public List<ContatoInfo> Listar()
        {
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            dal.Filters = this.Filters;
            return dal.Listar();
        }
        public List<ContatoInfo> ListarPaginado()
        {
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            dal.Filters = this.Filters;
            return dal.ListarPaginado();
        }

        public int GetTotalRegistros()
        {
            return 50;
        }
    }
}
