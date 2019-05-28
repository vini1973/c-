using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercicio.DAL;
using Exercicio.Model;
using Smart.Database;

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
            ContatoDAL dal = new ContatoDAL(this.DbHnd);
            return dal.Inserir(pInfo);
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
