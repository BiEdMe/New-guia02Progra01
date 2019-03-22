using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios Obj = new Ejercicios();
            bool opcion=false;
            while(opcion==false){
                Console.Clear();
                Console.WriteLine("Por favor digite el numero de ejercicio a evaluar: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num < 79)
                {
                    if(num==1){Obj.Ej01();}
                    else if (num == 2) { Obj.Ej02(); }
                    else if (num == 3) { Obj.Ej03(); }
                    else if (num == 4) { Obj.Ej04(); }
                    else if (num == 5) { Obj.Ej05(); }
                    else if (num == 6) { Obj.Ej06(); }
                    else if (num == 7) { Obj.Ej07(); }
                    else if (num == 8) { Obj.Ej08(); }
                    else if (num == 9) { Obj.Ej09(); }
                    else if (num == 10) { Obj.Ej10(); }
                    else if (num == 11) { Obj.Ej11(); }
                    else if (num == 12) { Obj.Ej12(); }
                    else if (num == 13) { Obj.Ej13(); }
                    else if (num == 14) { Obj.Ej14(); }
                    else if (num == 15) { Obj.Ej15(); }
                    else if (num == 16) { Obj.Ej16(); }
                    else if (num == 17) { Obj.Ej17(); }
                    else if (num == 18) { Obj.Ej18(); }
                    else if (num == 19) { Obj.Ej19(); }
                    else if (num == 20) { Obj.Ej20(); }
                    else if (num == 21) { Obj.Ej21(); }
                    else if (num == 22) { Obj.Ej22(); }
                    else if (num == 23) { Obj.Ej23(); }
                    else if (num == 24) { Obj.Ej24(); }
                    else if (num == 25) { Obj.Ej25(); }
                    else if (num == 26) { Obj.Ej26(); }
                    else if (num == 27) { Obj.Ej27(); }
                    else if (num == 28) { Obj.Ej28(); }
                    else if (num == 29) { Obj.Ej29(); }
                    else if (num == 30) { Obj.Ej30(); }
                    else if (num == 31) { Obj.Ej31(); }
                    else if (num == 32) { Obj.Ej32(); }
                    else if (num == 33) { Obj.Ej33(); }
                    else if (num == 34) { Obj.Ej34(); }
                    else if (num == 35) { Obj.Ej35(); }
                    else if (num == 36) { Obj.Ej36(); }
                    else if (num == 37) { Obj.Ej37(); }
                    else if (num == 38) { Obj.Ej38(); }
                    else if (num == 39) { Obj.Ej39(); }
                    else if (num == 40) { Obj.Ej40(); }
                    else if (num == 41) { Obj.Ej41(); }
                    else if (num == 42) { Obj.Ej42(); }
                    else if (num == 43) { Obj.Ej43(); }
                    else if (num == 44) { Obj.Ej44(); }
                    else if (num == 45) { Obj.Ej45(); }
                    else if (num == 46) { Obj.Ej46(); }
                    else if (num == 47) { Obj.Ej47(); }
                    else if (num == 48) { Obj.Ej48(); }
                    else if (num == 49) { Obj.Ej49(); }
                    else if (num == 50) { Obj.Ej50(); }
                    else if (num == 51) { Obj.Ej51(); }
                    else if (num == 52) { Obj.Ej52(); }
                    else if (num == 53) { Obj.Ej53(); }
                    else if (num == 54) { Obj.Ej54(); }
                    else if (num == 55) { Obj.Ej55(); }
                    else if (num == 56) { Obj.Ej56(); }
                    else if (num == 57) { Obj.Ej57(); }
                    else if (num == 58) { Obj.Ej58(); }
                    else if (num == 59) { Obj.Ej59(); }
                    else if (num == 60) { Obj.Ej60(); }
                    else if (num == 61) { Obj.Ej61(); }
                    else if (num == 62) { Obj.Ej62(); }
                    else if (num == 63) { Obj.Ej63(); }
                    else if (num == 64) { Obj.Ej64(); }
                    else if (num == 65) { Obj.Ej65(); }
                    else if (num == 66) { Obj.Ej66(); }
                    else if (num == 67) { Obj.Ej67(); }
                    else if (num == 68) { Obj.Ej68(); }
                    else if (num == 69) { Obj.Ej69(); }
                    else if (num == 70) { Obj.Ej70(); }
                    else if (num == 71) { Obj.Ej71(); }
                    else if (num == 72) { Obj.Ej72(); }
                    else if (num == 73) { Obj.Ej73(); }
                    else if (num == 74) { Obj.Ej74(); }
                    else if (num == 75) { Obj.Ej75(); }
                    else if (num == 76) { Obj.Ej76(); }
                    else if (num == 77) { Obj.Ej77(); }
                    else if (num == 78) { Obj.Ej78(); }
                   

                     
                    Console.ReadKey();
                }
                else {
                    Console.WriteLine("Este ejercicio no esta incluido en la guia");
                }
            }
            

           
        }

        

    }
}
