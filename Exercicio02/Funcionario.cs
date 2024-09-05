using System.Globalization;


namespace Exercicio02 {
    internal class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double Salarioliquido() {
            return Salario - Imposto;
        }

        public void AumentoSalario(double porcentagem) {


            Salario = Salario + (Salario * porcentagem / 100);


        }
        public override string ToString() {
            return
             Nome
             + " , "
             + "R$"
             + Salarioliquido().ToString(CultureInfo.InvariantCulture);



        }




    }
}
