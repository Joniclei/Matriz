using System;

namespace Matrixx
{
  class Program
  {
    public static void Main(string[] args)
    {
      int soma = 0;
      int x = 0;
      string [] testelinha = Console.ReadLine().Split(' ');
      int linha = Convert.ToInt32(testelinha[0]);
      int coluna = Convert.ToInt32(testelinha[1]);
      int[,] matriX = new int[linha, coluna];
      for (int l = 0; l < linha; l++)
      {
        string [] y = Console.ReadLine().Split(' ');
        for (int c = 0; c < coluna; c++)
        {
          matriX [l,c] = Convert.ToInt32(y[c]);

        }

      }

      int a = Convert.ToInt32(Console.ReadLine());

      for(int i = 0; i < linha ; i++){
        for(int j = 0; j < coluna ; j++){
          if (matriX[i,j] == a){
            Console.Write($"Position:{i},{j}");


            if(j >0){

            Console.Write($"Left:{matriX[(i),(j-1)]}");
            }else{
              Console.Write("Left:nulo");
            }


            if(j >0 ){
            Console.WriteLine($"Right:{(matriX[(i),(j+1)])}");
            }else{
              Console.WriteLine("Right:nulo");
            }


            if(i >0){
            Console.WriteLine($"UP:{(matriX[(i-1),(j)])}");
            }else{
              Console.WriteLine("UP:nulo");
            }


            if(i >0){
            Console.WriteLine($"Down:{(matriX[(i+1),(j)])}");
            }else{
              Console.WriteLine("Down:nulo");
            }

          }


        }

      }

    }
  }
}
