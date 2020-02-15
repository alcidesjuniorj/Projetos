using System;
using System.Globalization;

namespace OrientacaoObjeto
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }//Auto Property - Tornando privado somente o Set
        private int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Utilizado o  conceito de Property devido haver uma validação no Set.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        private double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return _nome + ",R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2");
        }


    }
}
