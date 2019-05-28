using Exercicio.DAL;
using Exercicio.Model;
using Smart.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.BLL
{
    public class EstadoBLL : Smart.Model.BusinessObject
    {
        public EstadoBLL() { }

        public EstadoBLL(DbConn pDbHnd) : base(pDbHnd) { }

        public EstadoInfo Get(Int32 pCdEstado)
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            return dal.Get(pCdEstado);
        }

        public Int32 Inserir(EstadoInfo pInfo)
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            return dal.Inserir(pInfo);
        }

        public void Atualizar(Int32 pCdEstado, EstadoInfo pInfo)
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            dal.Atualizar(pCdEstado, pInfo);
        }
        public void Deletar(Int32 pCdEstado)
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            dal.Deletar(pCdEstado);
        }
        public List<EstadoInfo> Listar()
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            dal.Filters = this.Filters;
            return dal.Listar();
        }
        public List<EstadoInfo> ListarPaginado()
        {
            EstadoDAL dal = new EstadoDAL(this.DbHnd);
            dal.Filters = this.Filters;
            return dal.ListarPaginado();
        }
    }
}
