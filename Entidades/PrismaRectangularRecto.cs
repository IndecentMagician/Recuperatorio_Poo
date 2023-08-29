using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_Poo.Entidades
{
    internal class PrismaRectangularRecto
    {
        private int _largo;
        private int _ancho;
        private int _altura;

        public int GetLargo() => _largo;
        public int GetAncho() => _ancho;
        public int GetAltura() => _altura;
        public PrismaRectangularRecto(int largo, int ancho, int altura)
        {
            if ((largo <= 0) || (altura <= 0) || (ancho <= 0))
            {
                throw new ArgumentException("Valores no válidos");
            }
            _largo = largo;
            _ancho = ancho;
            _altura = altura;

        }
        public PrismaRectangularRecto()
        {
            _largo = 1;
            _ancho = 1;
            _altura = 1;

        }

        private int getAreaBase()=> GetLargo() * GetAncho();
        private int getAreaAltura() => GetAncho() * GetAltura();
        private int getAreaAncho() => GetAltura() * GetAncho();


        public int Area() => (getAreaBase()+getAreaAncho()+getAreaAltura());

        public int Volumen() => GetAltura() * GetAncho() * GetLargo();

        public double Diagonal() => Math.Sqrt(Math.Pow(GetLargo(), 2) + Math.Pow(GetAncho(), 2) + Math.Pow(GetAltura(), 2));

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Datos Prisma Rectangular Recto ");
            sb.AppendLine($"Ancho.....: {GetAncho()}");
            sb.AppendLine($"Altura....: {GetAltura()}");
            sb.AppendLine($"Largo.....: {GetLargo()}");
            sb.AppendLine($"Volumen...: {Volumen()}");
            sb.AppendLine($"Area......: {Area()}");
            sb.AppendLine($"Diagonal..: {Diagonal():N}");

            return sb.ToString();
        }
    }
}
