using System;
using System.Collections.Generic;
using Smart.Database;
using Smart.Model;
using TGSmartControls.Model;
using TGSmartControls.DAL;

namespace TGSmartControls.BLL
{
	public class ComentarioBLL : Smart.Model.BusinessObject
	{
		public ComentarioBLL() { }

		public ComentarioBLL(DbConn pDbHnd) : base (pDbHnd) { }

		public ComentarioInfo Get(Int32 pCdComentario)
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			return dal.Get(pCdComentario);
		}

		public Int32 Inserir(ComentarioInfo pInfo)
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			return dal.Inserir(pInfo);
		}

		public void Atualizar(Int32 pCdComentario, ComentarioInfo pInfo)
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			dal.Atualizar(pCdComentario, pInfo);
		}
		public void Deletar(Int32 pCdComentario)
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			dal.Deletar(pCdComentario);
		}
		public List<ComentarioInfo> Listar()
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.Listar();
		}
		public List<ComentarioInfo> ListarPaginado()
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.ListarPaginado();
		}
		public Int32 GetTotalRegistros()
		{
			ComentarioDAL dal = new ComentarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.GetTotalRegistros();
		}
	}
}
