using static System.Console;

namespace TransData.TesteTecnico.Saque {
   class FuncaoSaque {
        static List<int> LogicaSaque() {
            int valorSaque = -1;

            string valorInput;

            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            List<int> quantidade = new List<int>();

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

                        quantidade.Add(qtdNotas);
                    }
                }
            };
            return quantidade;
        }

        public static void QuantidadeNotas() {
            List<int> quantidade = LogicaSaque();
            
            int[] notas = new int[6] {100, 50, 20, 10, 5, 2};

            for (int i = 0; i < quantidade.Count; i++) {
                if (quantidade[i] == 0) {
                    WriteLine();
                }
                else if (quantidade[i] == 1) {
                    WriteLine($"{quantidade[i]} nota de R$ {notas[i],00}");
                }
                else {
                    WriteLine($"{quantidade[i]} notas de R$ {notas[i],00}");
                }
            }
        }
    }
}