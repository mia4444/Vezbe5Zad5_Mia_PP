using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe5Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Zadatak 5
                Napraviti konzolnu aplikaciju koja pronalazi najmanji elemenat
                dvodimenzionalne matrice. Omogućiti korisniku unos broja redova
                i kolona matrice, kao i elementa matrice sa komandne linije.
                Zadatak realizovati tako da prati sliku ispod.  */


            int[,] insertedMatrix = Insert();
            Console.WriteLine(Min(insertedMatrix));
            Console.Read();



            /*Ponovni pokušaj 2. zadatka
             Napraviti konzolnu aplikaciju koja sadrži dve funkcije. Jednu za
            sortiranje elemenata niza u rastućem redosledu i jednu za ispis
            elemenata niza. Pogledati datu sliku.
             */

            Console.WriteLine("Unesite dužinu niza:");
            int length = int.Parse(Console.ReadLine());//tu unetu duzinu u konzoli pretvoriti u integer
            int[] niz = new int[length];
            //length = niz.Length;
            Console.WriteLine("Unesite elemente niza:");

            for (int i=0; i<length;i++)
            {
                niz[i]=int.Parse(Console.ReadLine());       
            }

            Sort(niz);
            Print(niz);
            Console.ReadKey();


        }//kraj Main-a

        //OVDE DENIFINISI NOVE F-JE
        //Za 5. zadatak imacu 2 f-je, jednu za insertovanje matrice iz konzole i jednu za pronalazenje min elementa matrice

        public static int[,] Insert() {


            Console.WriteLine("Aplikacija za pronalaženje najmanjeg elementa niza");

            //Za redove i kolone posebno, pretvaramo u integer
            Console.WriteLine("Unesite broj redova matrice:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj kolona matrice:");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];//definisem svoju matricu, koja vazi unutar ove f-je
            Console.WriteLine("Unesite elemente matrice:");

            for (int i=0; i<matrix.GetLength(0);i++) {

                for (int j=0; j<matrix.GetLength(1);j++) {

                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            
            
            }// kraj veceg for loop-a

            Console.WriteLine("Unesena matrica:");
            for (int i = 0; i < matrix.GetLength(0); i++) {

                for (int j=0; j<matrix.GetLength(1);j++) {

                    Console.Write("\t{0}",matrix[i, j] );  //da bismo imali format matrice
                
                }
                Console.WriteLine();
            }
            return matrix;
        }


        public static int Min(int[,]matrix) {

            int smallest = matrix[0,0];
            for (int i=0;i<matrix.GetLength(0);i++) {

                for (int j = 0; j < matrix.GetLength(1); j++) {

                    if (smallest > matrix[i, j]) {

                        smallest = matrix[i, j];

                    }
                
                }
            }

            return smallest;
        
        }



        //Funkcije za 2. zadatak

        static int[] Sort(int[] niz) {
            int temp;
            for (int i=0; i< niz.Length-1; i++) {

                int min = i;

                for (int j=i+1; j< niz.Length;j++) {

                    if (niz[j] < niz[min]) {

                        min = j;
                    }
                }     
                
                if (min != i) { 
                //ako je if uslov true, zamenicemo mesta elementima
                        temp = niz[min];
                        niz[min] = niz[i];
                        niz[i] = temp;
                    
                }
                
            
            }

            return niz;//niz vrati, ako smo ispali iz velikog FOR loop-a
        
        }


        static void Print(int[]niz) {

            for (int i = 0; i <niz.Length; i++) {

                Console.Write(niz[i]+" ");
            }    
        }


    }//kraj internal class Program
}// kraj namespace-a
