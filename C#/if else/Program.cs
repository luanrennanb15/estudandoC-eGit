using System;

class aula02 {

    static void Main(string[] args) 
    {
        double nota1, nota2, tcc, resultado;


        Console.WriteLine("Calculo de notas semestrais.");
        Console.WriteLine("Digite sua primeira nota");
        nota1= double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua segunda nota");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua nota do tcc");
        tcc = double.Parse(Console.ReadLine());

        resultado = (((nota1 + nota2) * 4) + (tcc * 2))/10;

        if (resultado <= 4)
        {
<<<<<<< HEAD
            Console.WriteLine("Voce ficou de DP!");
            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}",nota1,nota2,tcc,resultado);
=======
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
>>>>>>> estudando
        }
        else if (resultado == 5 || resultado == 6)
        {
            Console.WriteLine("Voce ficou de exame");
            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
        }
<<<<<<< HEAD
        else if (resultado == 9 || resultado == 10)
        {
            Console.WriteLine("Parabens, você teve umas das melhores notas!!\n Poucos conseguem chegar aqui. :) ");
=======
        else if (resultado >= 9 )
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
            
>>>>>>> estudando
        }
        else
        {
            Console.WriteLine(" Parabens voce passou!! ");
            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
        }


    }

}