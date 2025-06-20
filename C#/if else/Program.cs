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
            Console.WriteLine("Voce ficou de DP!");
            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}",nota1,nota2,tcc,resultado);
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
        else
        {
            Console.WriteLine(" Parabens voce passou!! ");
            Console.WriteLine("nota1 = {0} \nnota2= {1} \ntcc= {2} \nresultado= {3}", nota1, nota2, tcc, resultado);
        }


    }

}