/*Made by:
 * Victor Emiliano Fernandez Rubio
 * Antonio Luis Suarez Solis*/

//Teacher: Marco Antonio

/*Practice of the subject AGILE PRODUCTION METHODOLOGIES of the UCM
 *
 * It consists of 7 simple methods and check through tests if these methods work
 * The methods are:
 * -Convert to seconds
 * -Check if it is leap
 * -Get the factorial
 * -Invert the order of the elements of a number
 * -Say if a number is capiculate
 * -Say if a number is binary
 * -Give the MCD of two numbers
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {

        public static uint numSegundos(uint horas, uint minutos, uint segundos)
        {

            return (horas * 3600 + minutos * 60 + segundos);//devolvemos la suma en segundos

        }


        public static bool esBisiesto(uint anio)
        {

            if (anio % 4 == 0) //si es divisible entre 4 y no entre 100 es bisiesto
            
                if (anio % 100 != 0)
                    return true;

                else if (anio % 400 == 0) //si es divisible entre 4 y 400 es bisiesto
                    return true;
            
            return false;
        }


        public static ulong factorial(uint n) {

                ulong res = 1; //variable donde guardamos el resultado, la inicializamos a 1 
            //ya que en caso de que pidamos el factorial de 0 muestre 1
                for (ulong i = 1; i <= n; i++) //hacemos un bucle en el que en la variable guardamos el resultrado actualizado
                    res = res * i;

                return res; //devolvemos el resultado
             
        }


        public static uint invertirNumero(uint n) {
          
                uint inverso = 0; //declaramos la variable inverso y digito
                uint digito;

                while (n >= 1u)//mientras se cumpla la condicion
                    {//guardamos en digito el resto del numero entre 10
                        digito = n % 10u;
                        inverso = (inverso * 10u) + digito; //el numero invertido lo multiplicamos por 10 y
                //le sumamos digito para ir dando la vuelta al numero
                        n = n / 10u;
                    }
                return inverso; // devolvemos el numero invertido       
        }


        public static bool esCapicua(uint n)
        {

             if (n == invertirNumero(n))//llamamos a invertir numero para comprobar si el numero y su inverso son el mismo 
                 return true;
             else
                 return false;
        }


        public static string aBinario(uint n)
        {
            uint inverso = 0u;//declaramos un string vacio y varible uint
            string digito = "";

            if (n == 0u) //en el caso de que el numero se 0 devolvemos un 0 en la variable string
                return "0";
            else 
            {
                while (n > 0u)//mientra el numero sea mayor que cero
                {
                    inverso = n % 2u; //guardamos el reto en inverso
                    n /= 2u; 
                    digito = inverso.ToString() + digito; //guardamos en digito el numero parseado a string sumado
                    //con lo que habia anterirormente guardado en digito
                }  
            }
            return digito;
        }


        public static uint MCD(uint a, uint b)
        {
                uint r = 1; //declaramos un varible iniciada a 1
                while (b != 0)
                { // (n,m) = (m,n%m) con variable auxiliar
                    r = a % b; //guardamos en r el resto de a entre b
                    a = b; //asignamos a `a´ el valor de b y en b el de r
                    b = r;
                }
                return a;
        }

        static void Main(string[] args)
        {
        }
    }
}


