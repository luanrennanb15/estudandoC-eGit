using System;
using System.Net.Mail;

class aula02
{

    static void Main(string[] args)
    {
        

        double nota1, nota2, tcc, resultado;
        int opcao;
        string contatos, historia;
        string login = "aluno123";
        string senha = "1234";
        string loginuser, senhauser;
        int tentativas = 0;
        
        
        

        do
        {
            Console.Clear();

            Console.WriteLine("treinando laços");
            Console.WriteLine("login é : aluno123");
            Console.WriteLine("senha é : 1234");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Caso seja aluno, entre com seu cadstro.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(" _______________________________");
            Console.WriteLine("| Login                         |");
            Console.WriteLine(" ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            loginuser = Console.ReadLine();
            
            Console.WriteLine(" _______________________________");
            Console.WriteLine("| Senha                         |");
            Console.WriteLine(" ¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            senhauser = Console.ReadLine();

            if (login != loginuser || senha != senhauser)
            {
                Console.WriteLine("login ou senha incorreta, tente novamente.");
                tentativas++;
                Console.WriteLine("           {0} Tentativa",tentativas );
                Console.ReadLine();
                if( tentativas == 5)
                {
                    Console.Clear();

                    Console.WriteLine("Numero de tentativas excedida, saindo do programa...");
                    Console.ReadLine();

                }
            }
            else
            {
                Console.WriteLine("login bem sucedido");
                Console.ReadLine();

                Console.Clear();
            }
           
        } while (login != loginuser && senha != senhauser && tentativas != 5);


        





        do
        {
            Console.Clear();

            Console.WriteLine("      Menu da escola UNIP");
            Console.WriteLine("Escolha a baixo a opção desejada");
            Console.WriteLine("[ 1 ]  - Calculo de notas semestrais.");
            Console.WriteLine("[ 2 ]  - Historia da UNIP.");
            Console.WriteLine("[ 3 ]  - Entre em contato conosco.");
            Console.WriteLine("[ 4 ]  - Salvar Notas das Diciplinas");
            Console.WriteLine("[ 0 ]  - sair.");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {

                case 1:


                // label, pode voltar para qualquer parte do programa , neste caso, esta voltando para somar outra nota!
                calculo:

                    Console.Clear();

                    Console.WriteLine("Digite sua primeira nota");
                    nota1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite sua segunda nota");
                    nota2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite sua nota do tcc");
                    tcc = double.Parse(Console.ReadLine());

                    Console.Clear();

                    resultado = (((nota1 + nota2) * 4) + (tcc * 2)) / 10;

                    if (resultado <= 4)
                    {
                        Console.WriteLine("Voce ficou de DP!");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);

                        if (resultado <= 2)
                        {
                            Console.WriteLine("Infelizmente para essa materia precisa-se se dedicar mais aos estudos.");
                            Console.WriteLine("VOCE ESTÀ DE DP !!!");
                            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);
                        }
                        else
                        {
                            Console.WriteLine("Você ficou de DP, mas não desista, sei que você consegue !!");
                            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);
                        }
                    }
                    else if (resultado == 5 || resultado == 6)
                    {
                        Console.WriteLine("Voce ficou de exame");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);
                    }
                    else if (resultado == 9 || resultado == 10)
                    {
                        Console.WriteLine("Parabens, você teve umas das melhores notas!!\n Poucos conseguem chegar aqui. :)\n\n\n\n ");
                    }
                    else if (resultado >= 9)
                    {
                        if (resultado == 9)
                        {
                            Console.WriteLine("Parabens, você teve uma nota boa !!\nVoce passou!) ");
                            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);

                        }
                        else
                        {
                            Console.WriteLine("                               Meus parabens \n\n!!");
                            Console.WriteLine("Voce se saiu muito bem,é um dos poucos que tiveram as melhores notas da escola !!");
                            Console.WriteLine("Voce está super aprovado!!");
                            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}\n\n\n\n", nota1, nota2, tcc, resultado);
                        }

                    }
                    else
                    {
                        Console.WriteLine(" Parabens voce passou!! ");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
                    }

                    Console.WriteLine("\n\n\n\nDeseja refazer o calculo ? ");
                    Console.WriteLine("[ S ]  - SIM ");
                    Console.WriteLine("[ N ]  - NÃo ");
                    opcao = char.Parse(Console.ReadLine());

                    if (opcao == 's' || opcao == 'S')
                    {
                        // caso ele queira fazer mais um calculo o goto volta la no inicio(label) para refazer novamente ou apenas encerra o programa
                        goto calculo;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Fim do programa...");
                        Console.WriteLine("Bons estudos !!");
                    }


                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                     A Universidade Paulista, UNIP, reconhecida pela Portaria nº 550/88, iniciou suas atividades em 9 de novembro de 1988. Foi constituída a partir do");
                    Console.WriteLine("                     Instituto Unificado Paulista, IUP, do Instituto de Ensino de Engenharia Paulista, IEEP, e do Instituto de Odontologia Paulista, IOP; o primeiro");
                    Console.WriteLine("                     destes, autorizado a funcionar em 1972, inicialmente com os cursos de Comunicação Social, Letras, Pedagogia e Psicologia.");
                    Console.WriteLine("");
                    Console.WriteLine("                     Hoje, em razão do processo de evolução, a UNIP, por meio de uma proposta acadêmica moderna, vem expandindo suas atividades por diversos");
                    Console.WriteLine("                     Campi, visando à preparação de recursos humanos altamente qualificados demandados pela política de desenvolvimento nacional.");
                    Console.WriteLine("");
                    Console.WriteLine("                     A UNIP promove a formação atualizada dos alunos e sua capacitação para uma sociedade em mudança, por meio de um ensino de qualidade,");
                    Console.WriteLine("                     tecnologicamente avançado e dirigido para o futuro, nas áreas das ciências humanas, sociais, exatas e da saúde. Sua finalidade maior é promover o");
                    Console.WriteLine("                     desenvolvimento do potencial dos alunos, estabelecendo condições que possibilitem uma inserção ativa no mercado de trabalho e a solução criativa");
                    Console.WriteLine("                     de problemas que a sociedade propõe.");
                    Console.WriteLine("");
                    Console.WriteLine("                     A realidade brasileira, que merece especial atenção por parte da UNIP, faz com que também seja dada ênfase aos programas de estudos pós-");
                    Console.WriteLine("                     graduados. Estes dedicam-se ao aperfeiçoamento do seu próprio corpo docente assim como ao atendimento às necessidades da comunidade em");
                    Console.WriteLine("                     geral, já que, além de formar profissionais de todas as áreas, de desenvolver pesquisas que venham a gerar descobertas científicas e inovações");
                    Console.WriteLine("                     tecnológicas, a UNIP propõe-se a saber cumprir as exigências apresentadas pelo mundo moderno.");
                    Console.WriteLine("");
                    Console.WriteLine("                     Assim, a Universidade Paulista vem sendo reconhecida como um importante centro de produção de conhecimento e de sua difusão a um número");
                    Console.WriteLine("                     maior de pessoas, através das atividades de ensino, pesquisa, extensão e pós-graduação.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                                                                                Pressione enter para sair.");
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                     Se você já é estudante da UNIP, entre em");
                    Console.WriteLine("                     contato através do número do 0800 010 9000");
                    Console.WriteLine("                     ou pelo WhatsApp: (11) 94303-5000.");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                             Pressione enter para sair.");
                    Console.ReadLine();

                    break;

                case 4:

                nota1:
                    Console.Clear();

                    string[] materia = new string[3];
                    int[] nota = new int[3];

                    for (int i = 0; i < materia.Length; i++)
                    {
                        materia[i] = "0";

                        for (int j = 0; j < nota.Length; j++)
                        {
                            nota[j] = 0;

                            Console.WriteLine("Digite o nome da materia, disciplina.");
                            materia[i] = Console.ReadLine();

                            Console.WriteLine("Digite sua nota final.");
                            nota[j] = int.Parse(Console.ReadLine());

                            Console.Clear();
                            
                        }
                    }

                    for (int i = 0; i < materia.Length; i++)
                    {
                        Console.WriteLine("***< Notas salvas >****");
                        Console.WriteLine(materia[i]);

                        for (int j = 0; j < nota.Length; j++)
                        {

                            Console.WriteLine(nota[j]);


                        }
                    }






                    Console.WriteLine("\n\n\n\nDeseja guardar mais alguma nota ? ");
                    Console.WriteLine("[ S ]  - SIM ");
                    Console.WriteLine("[ N ]  - NÃO ");
                    opcao = char.Parse(Console.ReadLine());

                    if (opcao == 's' || opcao == 'S')
                    {
                        // caso ele queira fazer mais um calculo o goto volta la no inicio(label) para refazer novamente ou apenas encerra o programa
                        goto nota1;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Voltando para o menu principal pressione enter.");

                    }

                    break;


                case 0:

                    Console.WriteLine("Saindo em 3 2 1 ...");

                    break;


                default:
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                  NUMERO DIGITDO INVALIDO !!!");

                    break;



            }
        } while (opcao != 0);

    }

}