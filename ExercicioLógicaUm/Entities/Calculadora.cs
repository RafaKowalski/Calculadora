using ExercicioLógicaUm.Entities.Enums;

namespace ExercicioLógicaUm.Entities
{
    public class Calculadora
    {
        public float NumeroUm { get; set; }
        public float NumeroDois { get; set; }
        public float Resultado { get; set; }
        public Operacoes Operacoes { get; set; }

        public Calculadora()
        {
        }
        public Calculadora(float numeroUm, float numeroDois, Operacoes operacoes)
        {
            NumeroUm = numeroUm;
            NumeroDois = numeroDois;
            Operacoes = operacoes;
        }

        public float Adicao()
        {
            Resultado = NumeroUm + NumeroDois;
            return Resultado;
        }

        public float Subtracao()
        {
            Resultado = NumeroUm - NumeroDois;
            return Resultado;
        }

        public float Multipicacao()
        {
            Resultado = NumeroUm * NumeroDois;
            return Resultado;
        }

        public float Divisao()
        {
            Resultado = NumeroUm / NumeroDois;
            return Resultado;
        }

        public float Potenciacao()
        {
            Resultado = (float)Math.Pow(NumeroUm, NumeroDois);
            return Resultado;

        }

        public float RaizQuadrada()
        {
            Resultado = (float)Math.Sqrt(NumeroUm);
            return Resultado;
        }

        public override string ToString()
        {
            return "Resultado: " + Resultado.ToString("F2");
        }
    }
}
