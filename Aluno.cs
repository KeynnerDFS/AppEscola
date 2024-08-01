using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola.RegarasDeNegocio
{
    internal class Aluno
    {
        //Atributos com mátodos GET e SET automatizados
        public int Id { get; set; }
        public int NumeroDeMatricula { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        //Métodos
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }
        public string MostrarSituação()
        {
            string situação = "REPROVADO(A)";
            if (CalcularMedia() >= 60)
            {
                situação = "APROVADO(A)";
            }
            return situação;
        }

    }
}
