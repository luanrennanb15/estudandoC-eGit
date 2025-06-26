using System;

class aula02 {

    static void Main(string[] args) 
    {
        double nota1, nota2, tcc, resultado;
        int opcao;
        string contatos, historia;


        Console.WriteLine("      Menu da escola UNIP");
        Console.WriteLine("Escolha a baixo a opção desejada");
        Console.WriteLine("[ 1 ]  - Calculo de notas semestrais.");
        Console.WriteLine("[ 2 ]  - Historia da UNIP.");
        Console.WriteLine("[ 3 ]  - Entre em contato conosco.");
        Console.WriteLine("[ 0 ]  - sair.");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (opcao)
        {
            case 1:

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
                    Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);

                    if (resultado <= 2)
                    {
                        Console.WriteLine("Infelizmente para essa materia precisa-se se dedicar mais aos estudos.");
                        Console.WriteLine("VOCE ESTÀ DE DP !!!");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
                    }
                    else
                    {
                        Console.WriteLine("Você ficou de DP, mas não desista, sei que você consegue !!");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
                    }
                }
                else if (resultado == 5 || resultado == 6)
                {
                    Console.WriteLine("Voce ficou de exame");
                    Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
                }
                else if (resultado == 9 || resultado == 10)
                {
                    Console.WriteLine("Parabens, você teve umas das melhores notas!!\n Poucos conseguem chegar aqui. :) ");
                }
                else if (resultado >= 9)
                {
                    if (resultado == 9)
                    {
                        Console.WriteLine("Parabens, você teve uma nota boa !!\nVoce passou!) ");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);

                    }
                    else
                    {
                        Console.WriteLine("Meus parabens !!");
                        Console.WriteLine("Voce se saiu muito bem,é um dos poucos que tiveram as melhores notas da escola !!");
                        Console.WriteLine("Voce está super aprovado!!");
                        Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
                    }

                }
                else
                {
                    Console.WriteLine(" Parabens voce passou!! ");
                    Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
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

    }

}