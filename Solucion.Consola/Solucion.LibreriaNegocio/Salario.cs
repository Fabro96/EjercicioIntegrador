using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Salario
    {
        //ATRIBUTOS
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        //CONSTRUCTOR
        public Salario(double bruto)
        {
            this._bruto = bruto;
            this._fecha = DateTime.Now;
            this._descuentos = bruto * 0.17;
            
        }

        //PROPIEDADES
        public double Bruto
        {
            set { _bruto = value; }
            get { return _bruto;  }
        }
        public string CodigoTransferencia
        {
            set { _codigoTransferencia = value; }
            get { return _codigoTransferencia;  }
        }
        public double Descuentos
        {
            set { _descuentos = value; }
            get { return _descuentos;  }
        }
        public DateTime Fecha
        {
            set { _fecha = value; }
            get { return _fecha;  }
        }

        //MÉTODOS
        public double GetSalarioNeto()
        {
            return _bruto - _descuentos;
        }

        
        
    }
}
