using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Domain
{
    public class Game
    {
        #region Propiedades
        public int[,] fila;
        public string input;
        Random random;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public Game()
        {
            input = "";
            fila = new int[4, 4];
            random = new Random();
        }
       
        /// <summary>
        /// mostrar en pantalla el arreglo
        /// </summary>
        public void Show_fila()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}",fila[i, j]);
                }
                Console.WriteLine();
            }
        }
        
        /// <summary>
        /// generando num random
        /// </summary>
        public void generator_random_num()
        {
            //generacion de dos numeros random 
            int x = 0;
            int n = 0;
            int m = 0;
            //caso de que se llenen las casillas
            while (x < 16)
            {
                n = random.Next(0, 4);
                m = random.Next(0, 4);
                if (fila[n, m] == 0)
                {
                    fila[n, m] = 2;
                    break;
                }

                ++x;
            }
            
        }

        /// <summary>
        /// prueba para ver si perdi
        /// </summary>
        public void lost_test()
        {
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (fila[i, j] != 0) { cont++; }
                }
            }
            if (cont == 16)
            {
                Console.WriteLine("you have lost");
            }
        }
        
        /// <summary>
        /// ingrese la direccion para mover el tablero
        /// </summary>
        public void in_value()
        {
            input = Console.ReadLine();
        }

        #region Mover arriba
        public void move_up()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {//validando que se cumpla que hay un numero && no es la ultima fila && la anterior es 0
                    if ((fila[i, j] != 0) && (i - 1 >= 0) && (fila[i - 1, j] == 0))
                    {

                        //corrimiento de numero 
                        fila[i - 1, j] = fila[i, j];
                        fila[i, j] = 0;
                        i = 0;
                    }
                    //si son iguales dos numeros concecutivos se mult
                    if ((i - 1 >= 0) && (fila[i - 1, j] == fila[i, j]))
                    {
                        fila[i - 1, j] = fila[i, j] + fila[i - 1, j];
                        fila[i, j] = 0;
                    }

                }

            }
            //generando num aleatorio
            generator_random_num();
            //para ver si perdi
            lost_test();
            //mostrar el array
            Show_fila();
        }
        #endregion

        #region Mover abajo
        public void move_down()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {//validando que cumpla las condiciones que la casilla sea un num && que no sea la ultima && que la de arriba sea 0
                    if ((fila[i, j] != 0) && (i + 1 < 4) && (fila[i + 1, j] == 0))
                    {


                        fila[i + 1, j] = fila[i, j];
                        fila[i, j] = 0;
                        i = 0;
                    }
                    //validando que el num y el anterior son iguales
                    if ((i - 1 >= 0) && (fila[i - 1, j] == fila[i, j]))
                    {
                        fila[i, j] = fila[i, j] + fila[i - 1, j];
                        fila[i - 1, j] = 0;
                    }

                }

            }
            //generando num aleatorio
            generator_random_num();
            lost_test();
            //mostrando en pantalla
            Show_fila();
        }
        #endregion

        #region Mover izquierda
        public void move_left()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((fila[i, j] != 0) && (j - 1 >= 0) && (fila[i, j - 1] == 0))
                    {


                        fila[i, j - 1] = fila[i, j];
                        fila[i, j] = 0;
                        j = 0;
                    }
                    if ((j - 1 >= 0) && (fila[i, j - 1] == fila[i, j]))
                    {
                        fila[i, j - 1] = fila[i, j] + fila[i, j - 1];
                        fila[i, j] = 0;
                    }

                }

            }
            generator_random_num();
            lost_test();
            Show_fila();
            
        }
        #endregion

        #region Mover derecha
        public void move_right()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((fila[i, j] != 0) && (j + 1 < 4) && (fila[i, j + 1] == 0))
                    {


                        fila[i, j + 1] = fila[i, j];
                        fila[i, j] = 0;
                        j = -1;
                    }
                    if ((j - 1 >= 0) && (fila[i, j - 1] == fila[i, j]))
                    {
                        fila[i, j] = fila[i, j] + fila[i, j - 1];
                        fila[i, j - 1] = 0;
                    }

                }

            }
            generator_random_num();
            lost_test() ;
            Show_fila();
            
        }
        #endregion
    }




}
