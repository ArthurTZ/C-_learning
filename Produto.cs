using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    public class Produto {
        private string _nome;
        public double  Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return ($"{_nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)} , {Quantidade} Unidades, Total : R$ {ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }


    }
}
