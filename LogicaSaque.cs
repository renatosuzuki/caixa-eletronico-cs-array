using static System.Console;

namespace TransData.TesteTecnico.Saque {
   class FuncoesSaque {
        static List<int> LogicaPrincipalSaque() {
            int valorSaque = -1;

            string valorInput;

            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            List<int> QuantidadeNotas = new List<int>();

            while (valorSaque < 0) {
                WriteLine("Digite o valor do saque: ");

                valorInput = ReadLine()!;

                valorSaque = Convert.ToInt32(valorInput); 

                if (valorSaque < 0) {
                    WriteLine("O valor deve ser maior que 0");
                }
                else {
                    for (int i = 0; i < notas.Length; i++) {
                        int qtdNotas = valorSaque / notas[i];

                        valorSaque = valorSaque % notas[i];

                        if (valorSaque == 1 || valorSaque == 3) {
                            valorSaque = valorSaque + 1;
                        };

                        QuantidadeNotas.Add(qtdNotas);
                    }
                }
            };
            return QuantidadeNotas;
        }

        public static void QuantidadeNotas() {
            List<int> QuantidadeNotas = LogicaPrincipalSaque();

            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            for (int i = 0; i < QuantidadeNotas.Count; i++) {
                if (QuantidadeNotas[i] == 0) {
                    WriteLine();
                }
                else if (QuantidadeNotas[i] == 1) {
                    WriteLine($"{QuantidadeNotas[i]} nota de R$ {notas[i]},00");
                }
                else {
                    WriteLine($"{QuantidadeNotas[i]} notas de R$ {notas[i]},00");
                }
            }
        }
    }
}