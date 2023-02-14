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
            return Resultado = NumeroUm + NumeroDois;
        }

        public float Subtracao()
        {
            return Resultado = NumeroUm - NumeroDois;
        }

        public float Multipicacao()
        {
            return Resultado = NumeroUm * NumeroDois;
        }

        public float Divisao()
        {
            return Resultado = NumeroUm / NumeroDois;
        }

        public float Potenciacao()
        {
            return Resultado = (float)Math.Pow(NumeroUm, NumeroDois);

        }

        public float RaizQuadrada()
        {
            return Resultado = (float)Math.Sqrt(NumeroUm);
        }

        public override string ToString()
        {
            return "Resultado: " + Resultado.ToString("F2");
        }
    }
}
