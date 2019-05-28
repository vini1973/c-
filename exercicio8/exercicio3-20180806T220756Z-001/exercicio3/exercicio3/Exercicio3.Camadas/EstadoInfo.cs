using System;
using Smart.Model;

namespace Exercicio.Model
{
    public class EstadoInfo : Smart.Model.DbTable
    {
        public EstadoInfo()
        {
        }

        /// <summary>
        /// All fields constructor (Except Auto Increment)
        /// </summary>
        /// <param name="pUfEstado">Default value for property 'UfEstado'</param>
        public EstadoInfo(String pUfEstado)
        {
            _UfEstado.Value = pUfEstado;
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
        static public StringDbField GetUfEstado()
        {
            return _GetUfEstado();
        }
        static public StringDbField GetUfEstado(System.DBNull val)
        {
            StringDbField dbfield = _GetUfEstado();
            dbfield.IsNullValue = true;
            return dbfield;
        }
        static public StringDbField GetUfEstado(String pUfEstado)
        {
            StringDbField dbfield = _GetUfEstado();
            dbfield.Value = pUfEstado;
            return dbfield;
        }
        static StringDbField _GetUfEstado()
        {
            StringDbField dbfield = new StringDbField();
            dbfield.AllowsNull = true;
            dbfield.DataTypeName = "varchar";
            dbfield.DefaultValue = "";
            dbfield.IsAutoId = false;
            dbfield.IsPrimaryKey = false;
            dbfield.Name = "uf_estado";
            dbfield.Scale = 0;
            dbfield.Size = 2;
            dbfield.TableName = "ESTADO";
            return dbfield;
        }
        private Int32DbField _CdEstado = GetCdEstado();
        public Int32DbField CdEstado
        {
            get { return _CdEstado; }
            set { _CdEstado = value; }
        }

        private StringDbField _UfEstado = GetUfEstado();
        public StringDbField UfEstado
        {
            get { return _UfEstado; }
            set { _UfEstado = value; }
        }

    }
}
