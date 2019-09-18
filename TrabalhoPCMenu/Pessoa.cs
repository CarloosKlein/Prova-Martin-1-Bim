using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TrabalhoPCMenu
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string DataDeCadastro { get; set; }
        public float ScoreFuncionario { get; set; }

        public void PercentualSalario(double percentual)
        {
            Salario += Salario * percentual / 100.0;
        }

        public void PercentualScore(float percentualScore)
        {
            ScoreFuncionario += percentualScore;
        }

        public void alteraNome(string textoNovo)
        {
            Nome = textoNovo;
        }

        public void alteraData(string DataNova)
        {
            DataDeCadastro = DataNova;
        }


        public override string ToString()
        {
            return "Id:" + Id
                + ", Nome: "
                + Nome
                + ", Data De Cadastro: "
                + DataDeCadastro
                + ", Score do funcionario: "
                + ScoreFuncionario
                + ", Salario Atualizado: "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
                
        }

        //private async void LetTheGameStart_Load(object sender, EventArgs e)
        //{
        //    timer.Interval = 5000;

        //    Environment.Exit(1); // Encerrar
        //}
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Pessoa objAsPart = obj as Pessoa;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Id;
        }
        public bool Equals(Pessoa other)
        {
            if (other == null) return false;
            return (this.Id.Equals(other.Id));
        }
    }
}

