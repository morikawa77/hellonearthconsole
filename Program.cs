using System;

namespace HellOnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            int vidas = 3;
            int demianLife = 5;

            Console.WriteLine("HELL ON EARTH\n");
            Console.WriteLine($"Você tem {vidas} vidas\n");
            Console.WriteLine("James está caminhando pelas ruas ao caminho de casa, passando por becos. Quando ele percebe uma presença, é quando ele vê uma criatura, que estava o seguindo desde a saída do bar.");
            Console.WriteLine("A criatura corre em direção a ele.\n");

            Fase1:
            Console.WriteLine("\nAperte 1 para correr ou 2 para ficar parado");
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1) {
                goto Fase2;
            } else if (opcao == 2) {
                vidas--;
                if (vidas == 0) {
                    GameOver();
                } else {
                    Console.WriteLine($"\nVocê ainda tem {vidas} vidas");
                    goto Fase1;
                }
            } else {
                Console.WriteLine("\nEntrada inválida");
                goto Fase1;
            }

            Fase2:
            Console.WriteLine("James corre e vai pra sua casa.");
            Console.WriteLine("James diz:\n Acho que bebi demais, to vendo coisas que não existem. Melhor dormir.");
            Console.WriteLine("\nNo dia seguinte James vai ao trabalho e logo após vai ao bar. Depois de tomar algumas, ele sai pelo beco.");
            Console.WriteLine("James percebe que a mesma criatura estava o seguindo novamente, mas dessa vez ele decide enfrentá - la. James olha para o chão e encontra uma barra de ferro.");

            Fase2actions:
            Console.WriteLine("\nAperte 1 para pegar a barra ou 2 para ficar parado");
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("\nAperte 1 para bater com a barra ou 2 para ficar parado");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("\nJames mata o monstro e vai pra sua casa.");
                    goto Fase3;
                }
                else if (opcao == 2)
                {
                    vidas--;
                    Console.WriteLine("\nVocê morreu");


                    if (vidas == 0)
                    {
                        GameOver();
                    }
                    else
                    {
                        Console.WriteLine($"\nVocê ainda tem {vidas} vidas");
                        goto Fase2actions;
                    }
                }
                else
                {
                    Console.WriteLine("\nEntrada inválida");
                    goto Fase2actions;
                }
            }
            else if (opcao == 2)
            {
                vidas--;
                Console.WriteLine("\nVocê morreu");


                if (vidas == 0)
                {
                    GameOver();
                }
                else
                {
                    Console.WriteLine($"\nVocê ainda tem {vidas} vidas");
                    goto Fase2actions;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada inválida");
                goto Fase2actions;
            }

            Fase3:
            Console.WriteLine("\n\n\nNo outro dia James encontra Demian no bar.");
            Console.WriteLine("James diz:\n Demian, quanto tempo, meu amigo!");
            Console.WriteLine("Demian diz:\n É, faz muito tempo mesmo, senti sua falta!");
            Console.WriteLine("James diz:\n Gostaria de colocar o papo em dia, mas eu ando muito ocupado. Com essa invasão de monstros, eu todo dia os caço.");
            Console.WriteLine("Demian diz:\n Eu posso te ajudar com isso.");
            Console.WriteLine("James está com pressa e se despede rapidamente de Demian e segue sua jornada.\n");
            Console.WriteLine("... digite 1 para continuar ...");
            fase3continue:
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao==1){
                goto fase3continue2;
            } else {
                goto fase3continue;
            }

            fase3continue2:
            Console.WriteLine("Depois de mais um dia enfrentando os monstros, James entra em uma igreja no final de um beco.");
            Console.WriteLine("James encontra Demian em cima do altar.");
            Console.WriteLine("Demian diz:\n Estou aqui para te ajudar.\n Como te prometi.");
            Console.WriteLine("James diz:\n Como você pode me ajudar?");
            Console.WriteLine("Demian diz:\n Te transformando em uma de minhas criaturas, assim não terá mais que se preocupar com elas.");
            Console.WriteLine("Nesse momento James descobre que quem estava atrás dessa invasão era Demian, seu amigo de infância.");
            Console.WriteLine("James pensa:\n Então é tudo culpa desse desgraçado. Filho de uma puta, como posso ser amigo de um maldito desses.");
            Console.WriteLine("Em um flashback, Demian faz um pacto com Lúcifer para ganhar poderes sobrenaturais e dinheiro em troca de criar uma legião de monstros para a invasão do inferno na terra, criando um exército para Lúcifer.");
            Console.WriteLine("James diz:\n Jamais, e sua tentativa de reinado acaba aqui!");

            Fase3actions:
            Console.WriteLine("\nAperte 1 para bater com o facão ou 2 para ficar parado");
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1)
            {
                demianLife--;
                if (demianLife == 0 ){
                    Console.WriteLine("\nDemian morreu");
                    goto Final;
                } else {
                    Console.WriteLine($"\nDemian ainda tem {demianLife} de energia");
                    goto Fase3actions;
                }
            }
            else if (opcao == 2)
            {
                vidas--;
                Console.WriteLine("\nVocê morreu");
                if (vidas == 0)
                {
                    GameOver();
                }
                else
                {
                    Console.WriteLine($"\nVocê ainda tem {vidas} vidas");
                    goto Fase3actions;
                }
            }
            else
            {
                    Console.WriteLine("\nEntrada inválida");
                    goto Fase3actions;
            }

        Final:
            Console.WriteLine("\n\n\nJames corta a cabeça de Demian, e com isso todas as criaturas criadas por ele morrem instantaneamente. James olha para a cabeça de Demian no chão apontando o facão para ela.");
            Console.WriteLine("Seu dias de trevas na Terra terminam por aqui!");
            Console.WriteLine("\n Mesmo muito machucado, James vai beber para comemorar sua vitória.");
            Console.WriteLine("THE END");
        }

        static void GameOver(){
            Console.WriteLine("\nGAME OVER");
            Console.ReadLine();
        }
    }
}
