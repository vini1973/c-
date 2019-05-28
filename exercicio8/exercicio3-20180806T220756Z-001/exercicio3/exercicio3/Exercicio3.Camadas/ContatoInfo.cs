using System;
using Smart.Model;

namespace Exercicio.Model
{
    public class ContatoInfo : Smart.Model.DbTable
	{
		public ContatoInfo()
		{
		}

		/// <summary>
		/// All fields constructor (Except Auto Increment)
		/// </summary>
		/// <param name="pCdEstado">Default value for property 'CdEstado'</param>
		/// <param name="pDtNasci">Default value for property 'DtNasci'</param>
		/// <param name="pDsCpf">Default value for property 'DsCpf'</param>
		/// <param name="pDsSexo">Default value for property 'DsSexo'</param>
		/// <param name="pDsCidade">Default value for property 'DsCidade'</param>
		/// <param name="pDsEndereco">Default value for property 'DsEndereco'</param>
		/// <param name="pDsNome">Default value for property 'DsNome'</param>
		/// <param name="pDsEmail">Default value for property 'DsEmail'</param>
		public ContatoInfo(Int32 pCdEstado, DateTime pDtNasci, String pDsCpf, String pDsSexo, String pDsCidade, String pDsEndereco, String pDsNome, String pDsEmail)
		{
			_CdEstado.Value = pCdEstado;
			_DtNasci.Value = pDtNasci;
			_DsCpf.Value = pDsCpf;
			_DsSexo.Value = pDsSexo;
			_DsCidade.Value = pDsCidade;
			_DsEndereco.Value = pDsEndereco;
			_DsNome.Value = pDsNome;
			_DsEmail.Value = pDsEmail;
		}

		/// <summary>
		/// Not null fields constructor (Except Auto Increment)
		/// </summary>
		/// <param name="pDtNasci">Default value for property 'DtNasci'</param>
		/// <param name="pDsCpf">Default value for property 'DsCpf'</param>
		/// <param name="pDsNome">Default value for property 'DsNome'</param>
		/// <param name="pDsEmail">Default value for property 'DsEmail'</param>
		public ContatoInfo(DateTime pDtNasci, String pDsCpf, String pDsNome, String pDsEmail)
		{
			_DtNasci.Value = pDtNasci;
			_DsCpf.Value = pDsCpf;
			_DsNome.Value = pDsNome;
			_DsEmail.Value = pDsEmail;
		}

		static public Int32DbField GetCdContato()
		{
			return _GetCdContato();
		}
		static public Int32DbField GetCdContato(Int32 pCdContato)
		{
			Int32DbField dbfield = _GetCdContato();
			dbfield.Value = pCdContato;
			return dbfield;
		}
		static Int32DbField _GetCdContato()
		{
			Int32DbField dbfield = new Int32DbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "int";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = true;
			dbfield.IsPrimaryKey = true;
			dbfield.Name = "cd_contato";
			dbfield.Scale = 0;
			dbfield.Size = 4;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public Int32DbField GetCdEstado()
		{
			return _GetCdEstado();
		}
		static public Int32DbField GetCdEstado(System.DBNull val)
		{
			Int32DbField dbfield = _GetCdEstado();
			dbfield.IsNullValue = true;
			return dbfield;
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
			dbfield.AllowsNull = true;
			dbfield.DataTypeName = "int";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "cd_estado";
			dbfield.Scale = 0;
			dbfield.Size = 4;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public DateTimeDbField GetDtNasci()
		{
			return _GetDtNasci();
		}
		static public DateTimeDbField GetDtNasci(DateTime pDtNasci)
		{
			DateTimeDbField dbfield = _GetDtNasci();
			dbfield.Value = pDtNasci;
			return dbfield;
		}
		static DateTimeDbField _GetDtNasci()
		{
			DateTimeDbField dbfield = new DateTimeDbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "datetime";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "dt_nasci";
			dbfield.Scale = 3;
			dbfield.Size = 8;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public StringDbField GetDsCpf()
		{
			return _GetDsCpf();
		}
		static public StringDbField GetDsCpf(String pDsCpf)
		{
			StringDbField dbfield = _GetDsCpf();
			dbfield.Value = pDsCpf;
			return dbfield;
		}
		static StringDbField _GetDsCpf()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_cpf";
			dbfield.Scale = 0;
			dbfield.Size = 20;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public StringDbField GetDsSexo()
		{
			return _GetDsSexo();
		}
		static public StringDbField GetDsSexo(System.DBNull val)
		{
			StringDbField dbfield = _GetDsSexo();
			dbfield.IsNullValue = true;
			return dbfield;
		}
		static public StringDbField GetDsSexo(String pDsSexo)
		{
			StringDbField dbfield = _GetDsSexo();
			dbfield.Value = pDsSexo;
			return dbfield;
		}
		static StringDbField _GetDsSexo()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = true;
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_sexo";
			dbfield.Scale = 0;
			dbfield.Size = 30;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public StringDbField GetDsCidade()
		{
			return _GetDsCidade();
		}
		static public StringDbField GetDsCidade(System.DBNull val)
		{
			StringDbField dbfield = _GetDsCidade();
			dbfield.IsNullValue = true;
			return dbfield;
		}
		static public StringDbField GetDsCidade(String pDsCidade)
		{
			StringDbField dbfield = _GetDsCidade();
			dbfield.Value = pDsCidade;
			return dbfield;
		}
		static StringDbField _GetDsCidade()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = true;
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_cidade";
			dbfield.Scale = 0;
			dbfield.Size = 50;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public StringDbField GetDsEndereco()
		{
			return _GetDsEndereco();
		}
		static public StringDbField GetDsEndereco(System.DBNull val)
		{
			StringDbField dbfield = _GetDsEndereco();
			dbfield.IsNullValue = true;
			return dbfield;
		}
		static public StringDbField GetDsEndereco(String pDsEndereco)
		{
			StringDbField dbfield = _GetDsEndereco();
			dbfield.Value = pDsEndereco;
			return dbfield;
		}
		static StringDbField _GetDsEndereco()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = true;
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_endereco";
			dbfield.Scale = 0;
			dbfield.Size = 200;
			dbfield.TableName = "CONTATO";
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
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_nome";
			dbfield.Scale = 0;
			dbfield.Size = 50;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		static public StringDbField GetDsEmail()
		{
			return _GetDsEmail();
		}
		static public StringDbField GetDsEmail(String pDsEmail)
		{
			StringDbField dbfield = _GetDsEmail();
			dbfield.Value = pDsEmail;
			return dbfield;
		}
		static StringDbField _GetDsEmail()
		{
			StringDbField dbfield = new StringDbField();
			dbfield.AllowsNull = false;
			dbfield.DataTypeName = "varchar";
			dbfield.DefaultValue = "";
			dbfield.IsAutoId = false;
			dbfield.IsPrimaryKey = false;
			dbfield.Name = "ds_email";
			dbfield.Scale = 0;
			dbfield.Size = 50;
			dbfield.TableName = "CONTATO";
			return dbfield;
		}
		private Int32DbField _CdContato = GetCdContato();
		public Int32DbField CdContato
		{
			get { return _CdContato; }
			set { _CdContato = value; }
		}

		private Int32DbField _CdEstado = GetCdEstado();
		public Int32DbField CdEstado
		{
			get { return _CdEstado; }
			set { _CdEstado = value; }
		}

		private DateTimeDbField _DtNasci = GetDtNasci();
		public DateTimeDbField DtNasci
		{
			get { return _DtNasci; }
			set { _DtNasci = value; }
		}

		private StringDbField _DsCpf = GetDsCpf();
		public StringDbField DsCpf
		{
			get { return _DsCpf; }
			set { _DsCpf = value; }
		}

		private StringDbField _DsSexo = GetDsSexo();
		public StringDbField DsSexo
		{
			get { return _DsSexo; }
			set { _DsSexo = value; }
		}

		private StringDbField _DsCidade = GetDsCidade();
		public StringDbField DsCidade
		{
			get { return _DsCidade; }
			set { _DsCidade = value; }
		}

		private StringDbField _DsEndereco = GetDsEndereco();
		public StringDbField DsEndereco
		{
			get { return _DsEndereco; }
			set { _DsEndereco = value; }
		}

		private StringDbField _DsNome = GetDsNome();
		public StringDbField DsNome
		{
			get { return _DsNome; }
			set { _DsNome = value; }
		}

		private StringDbField _DsEmail = GetDsEmail();
		public StringDbField DsEmail
		{
			get { return _DsEmail; }
			set { _DsEmail = value; }
		}

	}
}
