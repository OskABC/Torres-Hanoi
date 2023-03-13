using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi{
    class Hanoi{
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b){
            if(!a.isEmpty() && b.isEmpty()){
                Disco auxiliar = a.pop();
                b.push(auxiliar);
                Console.WriteLine("El disco " + auxiliar.Valor + " se movió de " + a.id + " a " + b.id + ".");
                Console.WriteLine(a.tam);
                Console.WriteLine(b.tam);
            } // if
            else if (a.Top.Valor < b.Top.Valor){
                Disco auxiliar=a.pop();
                b.push(auxiliar);
                Console.WriteLine("El disco " + auxiliar.Valor + " se movió de " + a.id + " a " + b.id + ".");
                Console.WriteLine(a.tam);
                Console.WriteLine(b.tam);
            } // else if
            else{
                Console.WriteLine("No se pueden mover mas elementos de la pila"+a.id+" a la pila "+b.id+".");
                Console.WriteLine(a.tam);
                Console.WriteLine(b.tam);
            } // else

        } // mover_disco

        public int iterativo(int n, Pila ini, Pila fin, Pila aux){
            
        } // Iterativo
    } // Hanoi
} // ()
