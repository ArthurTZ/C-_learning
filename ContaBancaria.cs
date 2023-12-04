using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class ContaBancaria {
        public int Numero { get; private set; }
        public string Titular { get; set; }

        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            DepositarSaldo(depositoInicial);
        }

        public override string ToString() {
            return $"Conta {Numero} , Titular : {Titular} , Saldo : ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}" ;
        }

        public void DepositarSaldo(double quantia) {
            Saldo += quantia;
        }

        public void SacarSaldo(double quantia) {
            Saldo -= quantia + 5.0;
        }
    }
}
