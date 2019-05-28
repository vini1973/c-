using System;
using Smart.Model;

namespace TGSmartControls.Model
{
	public class EstadoInfo : Smart.Model.DbTable
	{
		#region Automaticaly generated by Smart.AutoModeling 2.0
		public EstadoInfo()
		{
		}

		/// <summary>
		/// All fields constructor (Except Auto Increment)
		/// </summary>
		/// <param name="pDsSigla">Default value for property 'DsSigla'</param>
		/// <param name="pDsNome">Default value for property 'DsNome'</param>
		public EstadoInfo(Char pDsSigla, String pDsNome)
		{
			_DsSigla.Value = pDsSigla;
			_DsNome.Value = pDsNome;
		}

		static public Int32DbField GetCdEstado()
		{
			return _GetCdEstado();
		}
		static public Int32DbField GetCdEstado(Int32 pCdEstado)
		{
			Int32DbField dbfield = _GetCdEstado();
			dbfield.Value = pCdEstado;
			return dbfield;
		}
		static Int32DbField _GetCdEstado()
		{
			Int32DbField dbfield = new Int32DbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "int";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = true;
			dbfield.IsPrimaryKey = true;
			dbfield.Name = "cd_estado";
			dbfield.Scale = 0;
			dbfield.Size = 4;
			dbfield.TableName = "ESTADO";
			return dbfield;
		}
		static public CharDbField GetDsSigla()
		{
			return _GetDsSigla();
		}
		static public CharDbField GetDsSigla(Char pDsSigla)
		{
			CharDbField dbfield = _GetDsSigla();
			dbfield.Value = pDsSigla;
			return dbfield;
		}
		static CharDbField _GetDsSigla()
		{
			CharDbField dbfield = new CharDbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "char";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_sigla";
			dbfield.Scale = 0;
			dbfield.Size = 2;
			dbfield.TableName = "ESTADO";
			return dbfield;
		}
		static public StringDbField GetDsNome()
		{
			return _GetDsNome();
		}
		static public StringDbField GetDsNome(String pDsNome)
		{
			StringDbField dbfield = _GetDsNome();
			dbfield.Value = pDsNome;
			return dbfield;
		}
		static StringDbField _GetDsNome()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "nvarchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_nome";
			dbfield.Scale = 0;
			dbfield.Size = 100;
			dbfield.TableName = "ESTADO";
			return dbfield;
		}
		private Int32DbField _CdEstado = GetCdEstado();
		public Int32DbField CdEstado
		{
			get { return _CdEstado; }
			set { _CdEstado = value; }
		}

		private CharDbField _DsSigla = GetDsSigla();
		public CharDbField DsSigla
		{
			get { return _DsSigla; }
			set { _DsSigla = value; }
		}

		private StringDbField _DsNome = GetDsNome();
		public StringDbField DsNome
		{
			get { return _DsNome; }
			set { _DsNome = value; }
		}

		#endregion
	}
}