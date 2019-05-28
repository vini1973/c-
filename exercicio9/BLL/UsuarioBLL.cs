using System;
using System.Collections.Generic;
using Smart.Database;
using Smart.Model;
using TGSmartControls.Model;
using TGSmartControls.DAL;

namespace TGSmartControls.BLL
{
	public class UsuarioBLL : Smart.Model.BusinessObject
	{
		public UsuarioBLL() { }

		public UsuarioBLL(DbConn pDbHnd) : base (pDbHnd) { }

		public UsuarioInfo Get(Int32 pCdUsuario)
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			return dal.Get(pCdUsuario);
		}

		public Int32 Inserir(UsuarioInfo pInfo)
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			return dal.Inserir(pInfo);
		}

		public void Atualizar(Int32 pCdUsuario, UsuarioInfo pInfo)
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			dal.Atualizar(pCdUsuario, pInfo);
		}
		public void Deletar(Int32 pCdUsuario)
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			dal.Deletar(pCdUsuario);
		}
		public List<UsuarioInfo> Listar()
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.Listar();
		}
		public List<UsuarioInfo> ListarPaginado()
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.ListarPaginado();
		}
		public Int32 GetTotalRegistros()
		{
			UsuarioDAL dal = new UsuarioDAL(this.DbHnd);
			dal.Filters = this.Filters;
			return dal.GetTotalRegistros();
		}
	}
}
