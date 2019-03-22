using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consola
{
    public class Ejercicios
    {
        public void Ej01() {
            Console.WriteLine("Ingrese un primer numero");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un primer numero");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado de la suma de A y B ="+(a+b));
        }
        public void Ej02() {
            int a, b, c;
            int mul;
            Console.WriteLine("Ingrese valor A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese valor B: ");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese valor C: ");
            c = int.Parse(Console.ReadLine());



            mul = (a * b * c);


            Console.WriteLine("La Multipicacion es: " + mul);
        }
        public void Ej03() {
            double a, b;
            double div;
            Console.WriteLine("Ingrese valor a: ");
            a = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese valor b: ");
            b = double.Parse(Console.ReadLine());



            div = (a / b);

            Console.WriteLine("La Division es : " + div);
        }
        public void Ej04() {


            double v, t;
            double dis;
            Console.WriteLine("Digite la Velocidad: ");
            v = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el tiempo: ");
            t = double.Parse(Console.ReadLine());


            dis = (v * t);


            Console.WriteLine("La Distancia recorrida en metros es : " + dis);
        }
        public void Ej05() {

            int ac, an;
            int edad;
            Console.WriteLine("Digite el año Actual: ");
            ac = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite su año de Nacimiento: ");
            an = int.Parse(Console.ReadLine());


            edad = (ac - an);


            Console.WriteLine("La EDAD es : " + edad);
        }
        public void Ej06() {

            double des;
            int n;
            Console.WriteLine("Ingrese un numero : ");
            n = int.Parse(Console.ReadLine());

            des = (n % 20);


            Console.WriteLine("El Porcentaje es : " + des);
        }
        public void Ej07() {
              int n;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("El Porcentaje 30 es: " + (n * 0.3));
            Console.WriteLine("El Porcentaje 60 es: " + (n * 0.6));
            Console.WriteLine("El Porcentaje 90 es: " + (n * 0.9));
        }
        public void Ej08() {
         double lado;
         double resCua;
         Console.WriteLine("Ingrese valor de lado: ");
         lado = double.Parse(Console.ReadLine());


         resCua = (Math.Pow(lado, 2));

         Console.WriteLine("El Area del Cuadrado es: " + resCua);
        }
        public void Ej09() {
        int num1, num2, num3, num4, num5;
         double prom;

         Console.WriteLine("Ingrese Valor del numero 1: ");
         num1 = int.Parse(Console.ReadLine());


         Console.WriteLine("Ingrese Valor del numero 2: ");
         num2 = int.Parse(Console.ReadLine());


         Console.WriteLine("Ingrese Valor del numero 3: ");
         num3 = int.Parse(Console.ReadLine());


         Console.WriteLine("Ingrese Valor del numero 4: ");
         num4 = int.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese Valor del numero 5: ");
         num5 = int.Parse(Console.ReadLine());



         prom = (num1 + num2 + num3 + num4 + num5) / 5;


         Console.WriteLine("El Promedio es :" + prom);
        }
        public void Ej10() {
            double preU, des, TotC=0,t=0;
            int canpro;
            Console.WriteLine("Ingrese Cantidad de productos :");
            canpro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese precio Unitario :");
            preU = double.Parse(Console.ReadLine());

            t = (canpro * preU); ;
             

            Console.WriteLine("La Cantidad de productos son : " + canpro);
            Console.WriteLine("El precio Unitario es : " + (preU));
            Console.WriteLine("El precio total a pagar es IVA incluido es:  " + (t+(t*0.13)));
        }
        public void Ej11() { 
          double salm, des, salneto, pagdi;
          int diaTra;
          string nom;

          Console.WriteLine("Ingrese nombre del Empleado: ");
          nom = Console.ReadLine();

          Console.WriteLine("Ingrese dias trabajado: ");
          diaTra = int.Parse(Console.ReadLine());

          Console.WriteLine("Ingrese Pago diario: ");
          pagdi = double.Parse(Console.ReadLine());


          salm = (diaTra * pagdi);


          des = (diaTra * 0.10) - (diaTra * 0.15);


          salneto = des + salm;


          Console.WriteLine("Salario Mensual es: " + salneto);
        }
        public void Ej12() {
            double lado = 0;

            Console.WriteLine("Digite el lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());
            Console.WriteLine("El perimetro del cuadrado es: "+(lado*4));


        }
        public void Ej13() {
            int num1, num2, num3, num4, num5;
            double oper;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero: ");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto numero: ");
            num5 = int.Parse(Console.ReadLine());





            oper = ((num1 + num2 * num3) * (num4) / num5);



            Console.WriteLine("El resultado es: " + oper);
        }
        public void Ej14() {
            double val1, val2, val3, val4, prom;
            double sum;
            Console.WriteLine("Ingrese primer valor: ");
            val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo valor: ");
            val2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tercer valor: ");
            val3 = double.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese cuarto valor: ");
            val4 = double.Parse(Console.ReadLine());



            sum = (val1 + val2 + val3 + val4);

            prom = (val1 + val2 + val3 + val4) / 4;


            Console.WriteLine("La operacion suma es :" + sum);

            Console.WriteLine("La operacion promedio  es :" + prom);
        }
        public void Ej15() {

            double precio, abono;
            double canArt;
            Console.WriteLine("Ingrese el precio de los articulos: ");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de articulos: ");
            canArt = double.Parse(Console.ReadLine());



            abono = (canArt * precio);


            Console.WriteLine("El Abono a dar  es : " + abono);
        }
        public void Ej16() {
            double Val1 = 0,Val2=0,Resu1=0;
            Console.Clear();
            Console.WriteLine("Programa que determine si una persona es mayor de edad o no");
            Console.WriteLine("Ingrese el año en el que nacio");
            Val1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año actual");
            Val2 = double.Parse(Console.ReadLine());

            Resu1 = Val2 - Val1;

            Console.WriteLine("Usted tiene: " + Resu1 + " años de edad");
            if (Resu1 >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es mayor de edad");
            }
        }
        public void Ej17() {
            Console.Clear();
            double Val1 = 0;
            Console.WriteLine("Programa para determinar si un número cualquiera ingresado por el usuario es o no positivo");
            Console.WriteLine("Ingrese un numero");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("El numero ingresado es: **" + Val1 + "**");
            if (Val1 <= -1)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
        }
        public void Ej18() {
            double Val1 = 0,Val2=0;
            Console.Clear();
            Console.WriteLine("Programa para determinar cuál es mayor entre 2 números cualquiera ingresados por el usuario");
            Console.WriteLine("Ingrese un numero");
            Val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            Val2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El primer numero ingresado es: **" + Val1 + "**");
            Console.WriteLine("El segundo numero ingresado es: **" + Val2 + "**");
            if (Val1 < Val2)
            {
                Console.WriteLine(Val1 + " es mayor que " + Val2);
            }
            else
            {
                Console.WriteLine(Val1 + " es menor que " + Val2);
            }
        }
        public void Ej19() {
            double Val1 = 0;
            Console.Clear();
            Console.WriteLine("Programa para saber si un estudiante del Enrique Olaya Herrera requiere refrigerio");
            Console.WriteLine("Ingrese su grado");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("El grado ingresado es: **" + Val1 + "**");
            if (Val1 <= 6)
            {
                Console.WriteLine("Tiene derecho a refrigerio");
            }
            else
            {
                Console.WriteLine("No tiene derecho a refrigerio");
            }
        }
        public void Ej20() {
            double Val1 = 0;
            Console.Clear();
            Console.WriteLine("Programa para determinar la mitad de un número ingresado por el usuario es mayor o menor de 100");
            Console.WriteLine("Ingrese un numero");
            Val1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero ingresado es: **" + Val1 + "**");
            if (Val1 < 100 && Val1 > 0)
            {
                Console.WriteLine("El numero es mayor que 0 menor que 100");
            }
            if (Val1 > 100)
            {
                Console.WriteLine("El numero es mayor que 100");
            }
            if (Val1 < 0)
            {
                Console.WriteLine("El numero es menor que 0");
            }
        }
        public void Ej21() {
            
            Console.WriteLine("Digite el primer numero");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine("EL Resultado es: " + (n1 - n2));
            }
            else {
                Console.WriteLine("El Resultado es: " + (n1 + n2));
            }
    }
        public void Ej22() { 
            int i=0;
            double[] nota=new double[3];
           /* 22.	Programa en el cual reciba como entradas la siguiente información: Código del Estudiante, Nombre del Estudiante,
            Nombre de la Materia Tres Notas de 1.0 a 5.0.  Con esta  información  el programa debe calcular la nota definitiva (promedio) 
            y determinar si el estudiante aprueba o no la materia (Definitiva mayor a 4.0). Debe imprimir coma salidas el nombre, el código,
            la materia y si aprobó o no.*/
            
            Console.WriteLine("Inserte Codigo del estudiante");
            string Codigo = Console.ReadLine();
            Console.WriteLine("Inserte Nombre del estudiante");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Inserte Materia del estudiante");
            string Materia = Console.ReadLine();

            for (i = 0; i <3; i++) {
                Console.WriteLine("Digite la nota "+(i+1)+" del estudiante");
                Console.WriteLine("NOTA: Las notas deben ser de 1.0 a 5.0");
                nota[i] = double.Parse(Console.ReadLine());

            }

            double Promedio = ((nota[0] + nota[1] + nota[2]) / 3);
            Console.WriteLine("Estudiante: "+Nombre);
            Console.WriteLine("Carnet: " + Codigo);
            Console.WriteLine("Materia: " + Materia);

            if (Promedio >= 4)
            {
                Console.WriteLine("Promedio de la Asignatura: " + Promedio + "  APROBADA");
            }
            else {
                Console.WriteLine("Promedio de la Asignatura: " + Promedio + "  REPROBADA");
            }

        
        }

        public void Ej23() { 
            /*23.	Programa para determinar cuánto pagara una persona por  una  compra  de  la  cual  se  sabe  la cantidad de 
            artículos y el valor unitario. Se debe tener en cuenta que el almacén hace un 20% de descuento cuando la compra supera
            $100000.*/


            bool vf=true;
             int i=1;
             double sumatoria=0;
            while(vf==true){

                Console.WriteLine("Ingrese precio del artilulo: "+i);//Precionar "coma" como indicador de decimales
                Console.WriteLine("O presione 0 para terminar");
                double ingresado = double.Parse(Console.ReadLine());

                if (ingresado == 0)
                {
                    vf = false;
                }
                else {
                    sumatoria = sumatoria + ingresado;
                    i++;
                }
                
            }
            Console.WriteLine("Total articulos: "+i);
            Console.WriteLine("Total cancelar: " + sumatoria);
         
        }

        public void Ej24() { 
        /*24.	Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar 
            su suma y diferencia, en caso contrario informar el producto y la división del primero respecto
            al segundo.*/
            Console.WriteLine("Digite valor 1");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2");
            double v2 = double.Parse(Console.ReadLine());

            if (v1 > v2)
            {
                Console.WriteLine("el valor1 es mayor al valor2");
                Console.WriteLine("Resultado de la suma de los 2 valores: " + (v1 + v2));
                Console.WriteLine("Resultado de la resta de los 2 valores: " + (v1 - v2));
            }
            else {
                Console.WriteLine("El valor2 es mayor que el valor1");
                Console.WriteLine("Resultado del producto de los 2 valores: " + (v1 * v2));
                Console.WriteLine("Resultado del producto de los 2 valores: " + (v1 / v2));
            }
        }

        public void Ej25() { 
        //25.	Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado".

            int i = 0;
            double snota = 0;
            for (i = 1; i < 4;i++ )
            {
                Console.WriteLine("Ingrese la nota: "+i);
                snota = snota + double.Parse(Console.ReadLine());
            }
            snota=(snota/3);

            if (snota >= 7)
            {
                Console.WriteLine("!!!Promocionado!!!");
            }
            else {
                Console.WriteLine("Nota menor a 7.oo");
            }
           
        }

        public void Ej26() {
        /*26.	Se ingresa por teclado un número positivo de uno o   dos	dígitos   (1..99)	mostrar un mensaje indicando si el número tiene uno 
        o dos dígitos. (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero*/

            Console.WriteLine("Digite un valor positivo de uno o dos digitos");
            int valor = int.Parse(Console.ReadLine());
            if (valor < 10)
            {
                Console.WriteLine("El valor ingresado es de solamente un digito");
            }
            else if (valor > 9 && valor < 100)
            {
                Console.WriteLine("El valor ingresado es de dos digitos");
            }
            else {
                Console.WriteLine("Fuera de rango");
            }
        }

        public void Ej27() {
       /* 27.	Programa que permita determinar el total a pagar por una compra del la cual se sabe el valor unitario y
        la cantidad. Se debe tener en cuenta que se realiza un descuento del 15% por compra inferiores a $20000 y del
        35% por compras mayores o iguales a $20000.*/

            Console.WriteLine("Digite el valor unitario del producto");
            double vu = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de productos");
            double vt = double.Parse(Console.ReadLine());

           double total = vu * vt;

           if (total < 2000) {
               Console.WriteLine("Total a pagar con el 15% de descuento: $" + (total - (total * 0.15)));
           }
           else {
               Console.WriteLine("Total a pagar con el 35% de descuento: $" + (total - (total * 0.35)));
           }

        }

        public void Ej28() {
            Console.WriteLine("Digite un numero cualquiera");
            double valor = double.Parse(Console.ReadLine());

            if((valor % 2)==1){
                Console.WriteLine("El numero ingresado es un impar");

            }
            else if((valor % 2)==0){
            Console.WriteLine("El numero ingresado es un par");
            }
        }

        public void Ej29() { 
            int i=0;
            string dia = "";
            double t=0;
            for (i = 1; i < 8; i++)
            {
                if (i == 1) { dia = "Lunes"; }
                if (i == 2) { dia = "Martes"; }
                if (i == 3) { dia = "Miercoles"; }
                if (i == 4) { dia = "Jueves"; }
                if (i == 5) { dia = "Viernes"; }
                if (i == 6) { dia = "Sabado"; }
                if (i == 7) { dia = "Domingo"; }
                
                Console.WriteLine("Por favor ingrese la temperatura del dia "+dia);
                t=t+( double.Parse(Console.ReadLine()));
            
            }
            t = t / 7;
            if (t > 35) {
                Console.WriteLine("Que semana tan calurosa!!");
            }
            else if(t>=15 && t<=35){
                Console.WriteLine("Que clima tan delicioso!!");
            }
            else if(t<15){
                Console.WriteLine("Que semana tan fría!!");
            }
             
            
        }

        public void Ej30() {
            Console.WriteLine("Ingrese la cantidad a pagar sin descuento");
            double Cantidad = double.Parse(Console.ReadLine());
            if(Cantidad>10000 && Cantidad<20000){
                Console.WriteLine("Total a cancelar con el 10% de descuento> "+(Cantidad-(Cantidad*0.1)));
            }
            else if (Cantidad > 20000 && Cantidad < 50000)
            {
                Console.WriteLine("Total a cancelar con el 30% de descuento> " + (Cantidad - (Cantidad * 0.3)));
            }
            else if (Cantidad > 50000)
            {
                Console.WriteLine("Total a cancelar con el 50% de descuento> " + (Cantidad - (Cantidad * 0.5)));
            }
        }
        public void Ej31() {
            int edad1, estatura, peso;
            Console.WriteLine("Ingrese la edad, la estatura y el peso");
            edad1 = int.Parse(Console.ReadLine());
            estatura = int.Parse(Console.ReadLine());
            peso = int.Parse(Console.ReadLine());
            if (edad1 <= 18 && estatura >= 180 && peso <= 80)
            {

                Console.WriteLine("El candidato es aceptado");
            }
            else
            {
                Console.WriteLine("El candidato no cumple con los requisitos");
            }
        }
        public void Ej32() {
            string letra;
            int opc1;
            Console.WriteLine("Elije la 1 para la comprobacion de vocales");
            Console.WriteLine("O elije la 2 para la comprobacion de vocales");
            opc1 = int.Parse(Console.ReadLine());
            switch (opc1)
            {
                case 1:
                    Console.WriteLine("Escriba una letra");
                    letra = Console.ReadLine();
                    if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                    else
                    {
                        Console.WriteLine("La letra es consonante");
                    }
                    break;
                case 2:
                    Console.WriteLine("Escriba una letra");
                    letra = Console.ReadLine();
                    if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
                    {
                        Console.WriteLine("La letra es vocal");
                    }
                    else
                    {
                        Console.WriteLine("La letra es consonante");
                    }
                    break;

            }
        }
        public void Ej33() {
            double distancia = 0, tiempo = 0, velocidad = 0;
            int opc2;
            Console.WriteLine("Elija 1 para calcular la distancia recorrida");
            Console.WriteLine("Elija 2 para calcular el tiempo");
            Console.WriteLine("Elija 3 para calcular la velocidad");
            opc2 = int.Parse(Console.ReadLine());
            switch (opc2)
            {
                case 1:
                    Console.WriteLine("Ingrese el tiempo");
                    tiempo = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la velocidad");
                    velocidad = double.Parse(Console.ReadLine());
                    distancia = tiempo * velocidad;
                    Console.WriteLine("La distancia recorrida es: " + distancia + " mt");
                    break;

                case 2:
                    Console.WriteLine("Ingrese la distancia");
                    distancia = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la velocidad");
                    velocidad = double.Parse(Console.ReadLine());
                    tiempo = distancia / velocidad;
                    Console.WriteLine("El tiempo transcurrido es: " + tiempo + " seg");
                    break;

                case 3:
                    Console.WriteLine("Ingrese la distancia");
                    distancia = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tiempo");
                    tiempo = double.Parse(Console.ReadLine());
                    velocidad = distancia / tiempo;
                    Console.WriteLine("La velocidad empleada fue: " + velocidad + " m/s");
                    break;

            }
        }
        public void Ej34() {
        int num, opc3;
           Console.WriteLine("Elija 1 para comprobación positivo o negativo");
           Console.WriteLine("Elija 2 para comprobación par o impar");
           opc3 = int.Parse(Console.ReadLine());
           
           switch(opc3)
           {
               case 1:
                   Console.WriteLine("Digite un numero cualquiera");
                   num=int.Parse(Console.ReadLine());
                   if (num>0)
 {
                       Console.WriteLine("El numero es positivo");
                   }
                   else
                   {
                       Console.WriteLine("El numero es negativo");
                   }
                   break;

               case 2:
                   Console.WriteLine("Digite un numero cualquiera");
                   num=int.Parse(Console.ReadLine());
                   if(num%2==0)
                   {
                       Console.WriteLine("El numero es par");
                   }
                   else
                   {
 Console.WriteLine("El numero es impar");
                   }
                   break;
           }
        
        }
        public void Ej35() {
            double n1, n2, n3, prom = 0;
            int nacim, actual, edad2 = 0, opc4;
            Console.WriteLine("Elija 1 para comprobación de notas");
            Console.WriteLine("Elija 2 para comprobación de edad");
            opc4 = int.Parse(Console.ReadLine());

            switch (opc4)
            {
                case 1:
                    Console.WriteLine("Ingrese la nota 1, la nota 2 y la nota 3");
                    n1 = double.Parse(Console.ReadLine());
                    n2 = double.Parse(Console.ReadLine());
                    n3 = double.Parse(Console.ReadLine());
                    prom = (n1 + n2 + n3) / 5;
                    if (prom > 3.0)
                    {

                        Console.WriteLine("Materia aprobada");
                    }
                    else
                    {
                        Console.WriteLine("Materia reprobada");
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el anio de nacimiento");
                    nacim = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el anio actual");
                    actual = int.Parse(Console.ReadLine());
                    edad2 = actual - nacim;
                    if (edad2 >= 18)
                    {
                        Console.WriteLine("Es mayor de edad");
                    }
                    else
                    {
                        Console.WriteLine("Es menor de edad");
                    }
                    break;
            }
        }
        public void Ej36() {
            for (int i1 = 0; i1 <= 1000; i1++)
            {
                Console.Write("{0}|", i1);
            }
        }
        public void Ej37() {
            int i2, par = 0;
            for (i2 = 0; i2 <= 200; i2++)
            {
                if (i2 % 2 == 0)
                {
                    Console.Write("{0}|", i2);
                    par++;
                }
            }
        }
        public void Ej38() {
            int i3, impar = 0;
            for (i3 = 201; i3 <= 499; i3++)
            {
                if (i3 % 2 != 0)
                {
                    Console.Write("{0}|", i3);
                    impar++;
                }
            } 
        }
        public void Ej39() {
            int i4, edad3, c1 = 0;
            for (i4 = 1; i4 <= 20; i4++)
            {
                Console.WriteLine("Ingrese la edad de cada estudiante");
                edad3 = int.Parse(Console.ReadLine());
                if (edad3 >= 18)
                {
                    c1 = c1 + 1;
                    Console.WriteLine(c1 + " son mayores");
                }

            } 
        }
        public void Ej40() {
            int i5, c2 = 0, c3 = 0;
            String genero;
            for (i5 = 1; i5 <= 25; i5++)
            {
                Console.WriteLine("Ingrese el genero de cada uno");
                genero = Console.ReadLine();
                if (genero == "mujer")
                {
                    c2 = c2 + 1;
                    Console.WriteLine(c2 + " son mujeres");
                }
                else
                {
                    if (genero == "hombre")
                    {
                        c3 = c3 + 1;
                        Console.WriteLine(c3 + " son hombres");
                    }
                }
            }
        }
        public void Ej41() {
            int edad5, a1 = 0;
            for (int i6 = 1; i6 <= 15; i6++)
            {
                Console.WriteLine("Ingrese la edad de cada uno");
                edad5 = int.Parse(Console.ReadLine());
                a1 = a1 + edad5;
            }
            Console.WriteLine("El promedio de edad es: " + a1);
        }
        public void Ej42() {
            double a2=0, estatura2;
            for (int i7 = 1; i7 <= 18; i7++)
            {
                Console.WriteLine("Ingrese la estatura");
                estatura2 = double.Parse(Console.ReadLine());
                a2 = a2 + estatura2;
            }
            if (a2 < 140)
            {
                Console.WriteLine("Estudiantes muy bajos");
            }
            else
            {
                if (a2 >= 140 && a2 <= 170)
                {
                    Console.WriteLine("Estudiantes de estatura normal");
                }
                else
                {
                    if (a2 > 170)
                    {
                        Console.WriteLine("Estudiantes muy altos");
                    }
                }
            }
        }
        public void Ej43() {
            for (int i8 = 1; i8 <= 99; i8++)
            {
                if (i8 % 3 == 0)
                {
                    Console.Write("{0}|", i8);
                }
            }
        }
        public void Ej44() {
            int num1, result;
            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());

            for (int i9 = 1; i9 <= 10; i9++)
            {
                result = num1 * i9;
                Console.WriteLine(num1 + " x " + i9 + " = " + result);
            }
        }
        public void Ej45() {
            for (int i10 = 1; i10 <= 100; i10++)
            {
                if (i10 % 5 == 0)
                {
                    Console.Write("{0}|", i10);
                }
            }
        }
        public void Ej46() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej47() { 
        /*47.	Programa que encuentre el resultado de la operación potencia donde el usuario ingresa el valor de la base y el exponente.*/
            Console.WriteLine("Ingrese un numero base...");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero que sera el exponencial del numero base anterior...");
            double ne = double.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de "+n+" elevado a "+ne+" es:"+(Math.Pow(n,ne)));
        }

        public void Ej48() { 
        /*48.	Programa que calcule la suma de los N primeros números naturales, donde N es un número  digitado por el usuario.*/
            Console.WriteLine("Digite un numero N para calcular la sumatoria");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("La sumatoria de los numeros anteriores a "+n+"es: "+((n*(n+1))/2));

        }
        public void Ej49() { 
        /*49.	Programa que reciba un listado de N números ingresados por el usuario y luego determine el número mayor y el número menor de entre todos los datos ingresados.*/
            int i=0;
            double nmayor = 0;
            double nmenor = 0;
            double[] n=new double[5];
            for (i = 0; i < 5;i++ )
            {
                Console.WriteLine("Digite valor "+(i+1));
                double num = double.Parse(Console.ReadLine());
                if(i==0){
                    nmenor = num;                    
                }
                if(num>nmayor){
                    nmayor = num;
                }
                if (num < nmenor)
                {
                    nmenor = num;
                }
            }
            Console.WriteLine("Numero mayor: "+nmayor);
            Console.WriteLine("Numero menor: " + nmenor);
        }

        public void Ej50() { 
        /*50.	Programa que permita obtener el cubo, la cuarta y la quinta potencia de N números ingresados por el usuario*/
            bool vf = true;

            while(vf==true){
                Console.WriteLine("Ingrese un numero para calcular su 3, 4, 5 exponentes");                 
                double n=double.Parse(Console.ReadLine());
              
                Console.WriteLine("Resultado de: " + n + "^" + 3 +"="+ (Math.Pow(n, 3)));
                Console.WriteLine("Resultado de: " + n + "^" + 4 +"="+(Math.Pow(n, 4)));
                Console.WriteLine("Resultado de: " + n + "^" + 5 +"="+(Math.Pow(n, 5)));

            }


        }

        public void Ej51() { 
       /* 51.	Programa que permita ingresar N números y determine cuantas veces aparece el mismo número, 
        dicho número a buscar debe solicitarse al usuario al inicio del programa.*/

            bool vf = true;
            int total = 0;
            Console.WriteLine("intruduzca el numero que desea encontrar ");
            double n = double.Parse(Console.ReadLine());

            while (vf == true) {
                Console.WriteLine("intruducir numero al azar");
                Console.WriteLine("intruduzca 0 para ver el resultado");
                double num = double.Parse(Console.ReadLine());
                if (num == 0)
                {
                    vf = false;
                }
                else {
                    if (n == num)
                    {
                        total = total + 1;
                    }
                }
                
            }
            Console.WriteLine("El numero "+n+" se ha encontrado "+total+" de veces en los numeros ingresados");





        }

        public void Ej52() { 
       /* 52.	Programa que reciba N calificaciones de una materia, y luego calcule:
            a)	La nota promedio
            b)	La nota mayor
            c)	Si El estudiante pasa o no la materia (Promedio>=40)*/

            bool vf = true;
            int i = 1;
            double nota=0,notas=0, nmayor = 0,nmenor=0;
             
            
            while(vf==true){
               
               
                    Console.WriteLine("Ingrese nota " + i);                    
                    if (i == 1)
                    {
                        Console.WriteLine("Rango de Notas de 10 a 100");

                    }
                    Console.WriteLine("Presione 0 para finalizar");

                    
                
                nota = double.Parse(Console.ReadLine());
                    if (i == 1) { nmenor = nota; nmayor = nota; }
                    if (nota == 0)
                    {
                        vf = false;
                    }
                    else {
                        notas = notas + nota;
                        if(nota>nmayor){
                            nmayor = nota;
                        }
                        if(nota<nmenor){
                            nmenor = nota;
                        }
                         
                    }
                
                i++;
            }
            double nf=notas/(i-2);
            Console.WriteLine("Nota promedio="+nf);
            Console.WriteLine("Nota mayor=" + nmayor);
            Console.WriteLine("Nota menor=" + nmenor);
            if (nf >= 40)
            {
                Console.WriteLine("Aprobado");
            }
            else {
                Console.WriteLine("Reprobado");
            }

        }

        public void Ej53() {

            int num, i = 1, fac = 1;
            Console.WriteLine("Digite un numero a calcular :");
            num = int.Parse(Console.ReadLine());



            while (i <= num)
            {

                fac = fac * i;
                i++;


            }

            Console.WriteLine("El factorial del numero es :" + fac);
        }
        public void Ej54() {

            int pro, i=1;
            double pag=0, pre;
            Console.WriteLine("Ingrese la cantidad de productos: ");
            pro = int.Parse(Console.ReadLine());

            

            while (i <= pro)
            {
                Console.WriteLine("Digite precio del producto: " + i);
                pre = double.Parse(Console.ReadLine());

                pag = pag+pre;
                i++;



            }


            Console.WriteLine("El pago es: " + pag);

        }
        public void Ej55() {
            double est,may=0,men=0;
            int alum = 0, n=0,i=0;
            Console.WriteLine("Ingrese cantidad de alumnos :");
            alum = int.Parse(Console.ReadLine());
            
            while (i < alum)
            {
                

                Console.WriteLine("Ingrese estatura del alumno :"+(i+1));
                est = double.Parse(Console.ReadLine());
                if(i==0){
                     may=est;
                     men=est;
                    }
                if (est >may)
                {
                    may = est;
                }
                if(est<men){
                    men = est;
                }
                i++;

            }
            Console.WriteLine("El alumno mayor estatura es : "+may);
            Console.WriteLine("El alumno menor estatura es : " + men);
        }
        public void Ej56() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej57() { 
         double  resul = 1;
         int num, num1, k;
         string opcion; 

            Console.WriteLine("Que operacion desea realizar :");
            Console.WriteLine("Factorial :");
            Console.WriteLine("Potencia :");

            Console.WriteLine("SALIR :");

            opcion = Console.ReadLine();


            Console.WriteLine("Ingrese un numero :");
            num = int.Parse(Console.ReadLine());



            switch (opcion)
            {



                case "Factorial":

                    for ( k = 2; k <= num; k++)
                    {

                        resul = resul * k;

                    }

                    Console.WriteLine("Factorial es : " + resul);

                    break;


                case "Potencia":


                    Console.WriteLine("Digite un numero ;");
                    num1 = int.Parse(Console.ReadLine());


                    Console.WriteLine("POTENCIA ES : " + Math.Pow(num1, 3));


                    break;


                default:

                    Console.WriteLine();
                    Console.WriteLine("Salir");

                    break; 





            }


        }
        public void Ej58() {
           int resul;
          int  i = 0;
          int num = 0; 
          string opcion;
          Console.WriteLine("Que operacion desea realizar :");
          Console.WriteLine("1---Numeros pares :");
          Console.WriteLine("2---Multiplos de 4 :");
          Console.WriteLine("3---Tablas de multiplicar :");
          Console.WriteLine("4---SALIR :");

          opcion = Console.ReadLine();


          switch (opcion)
          {


              case "1":     
                                  

                  for (i = 2; i <= 100; i = i+2)
                  {

                      Console.WriteLine(i);


                  }
                  

                  break;

              case "2": 


                  Console.WriteLine(" multiplo de 4 :");
                  


                  while (i <= 96)
                  {
                      Console.WriteLine(i+4);
                      i = i + 4;
                  }

                  break;

              case "3":


                  Console.WriteLine("Ingrese un numero :");
                  num = int.Parse(Console.ReadLine());

                  i = 1;

                  while (i <= 10)
                  {

                      resul = num * i;

                      Console.WriteLine(" {0} * {1} = {2}", num, i, resul);
                      i = i + 1;

                  }

                  break;


              case "4":
                  Environment.Exit(0);
                  break;

              default:

                  
                  Console.WriteLine("No ha elegido bien!!");
                  

                  break;


          }
            //-----------------------------------------------
        }
        public void Ej59() { 
          int  E = 0;
             int[] EDAD = null;
            EDAD = new int[]
            {
                13,19,25,53,42,17,33,20,36,55

            };

            for (E = 0; E <= EDAD.Length - 1; E++)
            {

                Console.WriteLine("Edad persona"+(E+1)+"----"+EDAD[E]);


            }
            Console.WriteLine();



         



            //--------------
        }
        public void Ej60() {
            Console.Clear();
            string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15;
            Console.WriteLine("Programa que solicita 15 nombres \n almacenarlos en un vector,luego se muestra en el orden igresado ");
            string[] vector;
            vector = new string[15];
            Console.WriteLine("Ingrese 15 nombre para el vector: ");
            Console.Write("N1  "); n1 = Console.ReadLine();
            Console.Write("N2  "); n2 = Console.ReadLine();
            Console.Write("N3  "); n3 = Console.ReadLine();
            Console.Write("N4  "); n4 = Console.ReadLine();
            Console.Write("N5  "); n5 = Console.ReadLine();
            Console.Write("N6  "); n6 = Console.ReadLine();
            Console.Write("N7  "); n7 = Console.ReadLine();
            Console.Write("N8  "); n8 = Console.ReadLine();
            Console.Write("N9  "); n9 = Console.ReadLine();
            Console.Write("N10 "); n10 = Console.ReadLine();
            Console.Write("N11 "); n11 = Console.ReadLine();
            Console.Write("N12 "); n12 = Console.ReadLine();
            Console.Write("N13 "); n13 = Console.ReadLine();
            Console.Write("N14 "); n14 = Console.ReadLine();
            Console.Write("N15 "); n15 = Console.ReadLine();


            Console.WriteLine("---------------------------------------");
            vector[0] = n1;
            vector[1] = n2;
            vector[2] = n3;
            vector[3] = n4;
            vector[4] = n5;
            vector[5] = n6;
            vector[6] = n7;
            vector[7] = n8;
            vector[8] = n9;
            vector[9] = n10;
            vector[10] = n11;
            vector[11] = n12;
            vector[12] = n13;
            vector[13] = n14;
            vector[14] = n15;

            foreach (string elemento in vector)
            {
                Console.WriteLine("Nombre :  " + elemento);
            }

            Console.ReadKey();
        }
        public void Ej61() { 
        int[] n=new int[12];
            int i=0,ns=0;
            for (i = 1; i < 13;i++ )
            {
                Console.WriteLine("Digite numero: " + i);
                n[(i - 1)] = int.Parse(Console.ReadLine());
            }
            for (i = 1; i < 13; i++)
            {
                ns =ns+ n[(i - 1)];
            }
            Console.WriteLine("Total de los 12 numeros ingresados es ="+ns);
        }
        public void Ej62() { 
        int[] n=new int[20];
        int i = 0,ne=0,po=0,ce=0;
            for (i = 1; i < 21;i++ )
            {
                Console.WriteLine("Digite numero: "+i);
                n[(i - 1)] = int.Parse( Console.ReadLine());
            }
            for (i = 1; i < 21; i++)
            {
                if (n[(i - 1)]<0)
                {
                    ne = ne + 1;
                 }
                else if (n[(i - 1)] > 0)
                {
                    po = po + 1;
                }
                else {
                    ce = ce + 1;
                }
            }
            Console.WriteLine("Total positivos="+po);
            Console.WriteLine("Total negativos=" + ne);
            Console.WriteLine("Total ceros=" + ce);

        }
        public void Ej63() {
          int[] numeros;
          numeros = new int[20];
          int posicion;

          for (int n = 0; n < 20; n++)
          {
              Console.WriteLine(" coloque el numero: "+(n+1));
              String Num;
              Num = Console.ReadLine();
              numeros[n] = int.Parse(Num);
          }
          do
          {
              Console.WriteLine("¿Adonde desea mostrar?");
              posicion = int.Parse(Console.ReadLine());
              Console.WriteLine(numeros[posicion]);
          } while (posicion < 20);
        }

         
        public void Ej64() {
            Console.Clear();
            Console.WriteLine("Programa que me permite llenar un vector y despues se muestra al reves");
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17;

            int[] vector;
            vector = new int[17];
            Console.WriteLine("Ingrese 17 numero para el vector: ");
            Console.Write("N1  "); n1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); n2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); n3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); n4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); n5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); n6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); n7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); n8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); n9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); n10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); n11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); n12 = int.Parse(Console.ReadLine());
            Console.Write("N13 "); n13 = int.Parse(Console.ReadLine());
            Console.Write("N14 "); n14 = int.Parse(Console.ReadLine());
            Console.Write("N15 "); n15 = int.Parse(Console.ReadLine());
            Console.Write("N16 "); n16 = int.Parse(Console.ReadLine());
            Console.Write("N17 "); n17 = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------------");
            vector[0] = n1;
            vector[1] = n2;
            vector[2] = n3;
            vector[3] = n4;
            vector[4] = n5;
            vector[5] = n6;
            vector[6] = n7;
            vector[7] = n8;
            vector[8] = n9;
            vector[9] = n10;
            vector[10] = n11;
            vector[11] = n12;
            vector[12] = n13;
            vector[13] = n14;
            vector[14] = n15;
            vector[15] = n16;
            vector[16] = n17;

            foreach (int elemento in vector)
            {
                Console.WriteLine("vector :  " + elemento);
            }


            vector[16] = n1;
            vector[15] = n2;
            vector[14] = n3;
            vector[13] = n4;
            vector[12] = n5;
            vector[11] = n6;
            vector[10] = n7;
            vector[9] = n8;
            vector[8] = n9;
            vector[7] = n10;
            vector[6] = n11;
            vector[5] = n12;
            vector[4] = n13;
            vector[3] = n14;
            vector[2] = n15;
            vector[1] = n16;
            vector[0] = n17;

            Console.WriteLine("--------------------------------------------");
            foreach (int elemento in vector)
            {

                Console.WriteLine("vector : " + elemento);
            }

            Console.ReadKey();
        }
        public void Ej65() {
            int[] numeros;
            int t = 0;
            numeros = new int[31];

            for (int d = 1; d < 31; d++)
            {
                Console.WriteLine("Total de clientes dia " + d + ": ");
                String nu;
                nu = Console.ReadLine();
                numeros[d] = int.Parse(nu);
            }
            for (int d = 0; d < 31; d++)
            {

                t=t+numeros[d];
            }
            Console.WriteLine("Total clientes ="+t);
        }
        public void Ej66() {
            Console.Clear();
            int n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12;
            int j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12;
            Console.WriteLine("Programa que permite llenar dos vectores de 12 posiciones ");
            Console.WriteLine("y luego en un tercer y cuarto vector guardar la suma y restar cada posicion");
            Console.WriteLine("Ingrese 12 numero para el primer vector: ");
            Console.Write("N1  "); n1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); n2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); n3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); n4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); n5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); n6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); n7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); n8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); n9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); n10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); n11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); n12 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese 12 numero para el segundo vector: ");
            Console.Write("N1  "); j1 = int.Parse(Console.ReadLine());
            Console.Write("N2  "); j2 = int.Parse(Console.ReadLine());
            Console.Write("N3  "); j3 = int.Parse(Console.ReadLine());
            Console.Write("N4  "); j4 = int.Parse(Console.ReadLine());
            Console.Write("N5  "); j5 = int.Parse(Console.ReadLine());
            Console.Write("N6  "); j6 = int.Parse(Console.ReadLine());
            Console.Write("N7  "); j7 = int.Parse(Console.ReadLine());
            Console.Write("N8  "); j8 = int.Parse(Console.ReadLine());
            Console.Write("N9  "); j9 = int.Parse(Console.ReadLine());
            Console.Write("N10 "); j10 = int.Parse(Console.ReadLine());
            Console.Write("N11 "); j11 = int.Parse(Console.ReadLine());
            Console.Write("N12 "); j12 = int.Parse(Console.ReadLine());

            int[] Vector1 = new int[12] { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 };
            int[] Vector2 = new int[12] { j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12 };
            int[] Vector3 = new int[12];
            int[] Vector4 = new int[12];


            Console.WriteLine("");
            Console.WriteLine("La suma del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i < 12; i++)
            {
                Vector3[i] = Vector1[i] + Vector2[i];

                Console.WriteLine("La suma es: " + Vector3[i]);

            }

            Console.WriteLine("");
            Console.WriteLine("La resta del vector 1 y 2 es: ");
            Console.WriteLine("------------------------------------ ");
            for (int i = 0; i < 12; i++)
            {
                Vector4[i] = Vector1[i] - Vector2[i];

                Console.WriteLine("La resta es: " + Vector4[i]);

            }
             
        }
        public void Ej67() {
            Console.Clear();
            Console.WriteLine("Programa que permite llenar un vector de N posiciones y luego un segundo y tercer vector ");
            Console.WriteLine("guarde el cuadrado y el cubo de cada una de las posiciones");
            int[] vector1 = new int[15];
            double[] vector2 = new double[15];
            double[] vector3 = new double[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Dijite un valor para el vector en la posicion: " + (i + 1));
                vector1[i] = int.Parse(Console.ReadLine());
                vector2[i] = Math.Pow(vector1[i], 2);

            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 2 elevado a la 2( arreglo resultante)");
                }
                Console.WriteLine(vector2[i]);
            }
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < 15; i++)
            {

                vector3[i] = Math.Pow(vector1[i], 3);

            }
            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 1 (original)");
                }

                Console.WriteLine(vector1[i]);
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Vector 3 elevado a la 3( arreglo resultante)");
                }
                Console.WriteLine(vector3[i]);
            }

        }
        public void Ej68() {
            Console.Clear();
            int[] Num;
            int cant, menor, mayor;
            int suma = 0;
            Console.WriteLine("Programa que permita regresar el numeros de estudiantes asignados cada uno");
            Console.WriteLine("de los 20 salones de un colegio");

            Console.WriteLine("Dijte la cantidad de Salones: ");
            cant = int.Parse(Console.ReadLine());
            Num = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Cuantos alumnos tiene el salon numero " + (i + 1) + "  : ");
                Num[i] = int.Parse(Console.ReadLine());
                suma = Num[i] * cant;
            }

            mayor = Num[0];
            menor = Num[0];
            for (int i = 0; i < cant; i++)
            {
                if (Num[i] > mayor)
                {
                    mayor = Num[i];
                }
                else if (Num[i] < menor)
                {
                    menor = Num[i];
                }
            }

            Console.WriteLine("El total de estdudiantes es es: " + suma);
            Console.WriteLine("El numero menor de estudiantes es: " + menor);
            Console.WriteLine("El numero mayor de estudiantes es: " + mayor);
            Console.ReadKey();

        }
        public void Ej69() { 
            int i=0;
        string[] nombre=new string[25];
        string[] apellido = new string[25];
        for (i = 1; i < 26;i++ )
        {
            Console.WriteLine("Digite nombre de persona " + i);
            nombre[(i-1)]=Console.ReadLine();
            Console.WriteLine("Digite nombre de persona " + i);
            apellido[(i - 1)] = Console.ReadLine();

        }
        for (i = 1; i < 26; i++)
        {
            Console.WriteLine("nombre completo de persona " + i + "es :" + nombre[(i - 1)] +"  "+ nombre[(i - 1)]);
             

        }


        }
        public void Ej70() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej71() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej72() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej73() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej74() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej75() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej76() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej77() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
        public void Ej78() {
            Console.WriteLine("Este ejercicio lamentablemente no fue completado");
        }
       
    }
}
