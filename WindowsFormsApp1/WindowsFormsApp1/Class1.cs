using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Vehiculo
    {
        public String placa;
        public String nombre;
        public String nit;

        public Vehiculo()
        {

        }
        public Vehiculo(String Placa, String Nombre, String Nit)
        {
            this.placa = Placa;
            this.nombre = Nombre;
            this.nit = Nit;
        }
        public string Placa
        {
            get
            {
                return placa;
            }
            set
            {
                placa = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Nit
        {
            get
            {
                return nit;
            }
            set
            {
                nit = value;
            }
        }
    }
    public class Moto : Vehiculo
    {
        public Moto(string p, string name, String nit):base(p,name,nit)
        {
        }
        
    }
    public class Carro : Vehiculo
    {
        public Carro(string p, string name, String nit) : base(p, name, nit)
        {
        }

    }
    public class Camión : Vehiculo
    {
        public Camión(string p, string name, String nit) : base(p, name, nit)
        {
        }

    }
}
