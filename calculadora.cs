using System.Collections.Generic;


namespace ProgCalculadora
{
    class calculadora
    {
        private List<double> listNumero = new List<double>();

        public void addNumero(double num)
        {
            this.listNumero.Add(num);
        }

        public double somar()
        {
            double resultado = 0;
            foreach (double numero in this.listNumero)
            {
                resultado += numero;
            }

            this.listNumero.Clear();
            return resultado;
        }

        public double subtrair()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado -= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
        public double multiplicar()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double Dividir()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach (double numero in this.listNumero)
            {
                resultado /= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }
    }
}
