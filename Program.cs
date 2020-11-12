using System;

namespace Estruturas_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

           //Entrada de dados
           Console.WriteLine("digite o nome do aluno ");
           nomeCompleto = Console.ReadLine();
           Console.Write( "digite a primeira nota ");
           nota1 = float.Parse(Console.ReadLine());

           Console.Write("digite o segunda nota");
           nota2 = float.Parse(Console.ReadLine());

           Console.Write("digite a terceira nota");
           nota3 = float.Parse(Console.ReadLine());

           //Processamento
           media = (nota1+nota2+nota3)/3;

          //Exibir o resultado
          if (media>5){
              //Valor verdadeiro
              Console.WriteLine("O aluno "+nomeCompleto+" está aprovado com a media de: "+media);
          }
          else{
              //Valor falso
              Console.WriteLine("O aluno "+nomeCompleto+" está REPROVADO com a media de: "+media);
          }
          {
              
          }
        }
    }
}
