using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi{
    class Pila{
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        public int Top { get; set; }
        public List<Disco> Elementos { get; set; }
        public int id { get; }
        public int tam;


        /* TODO: Implementar métodos */
        /*
        public Pila()
        {

        }
        */

        public Pila(int n){
            this.id=n;
            this.tam=0;
            this.Top=null;
            this.Elementos=new List<Disco>();
        } // Pila()

        public void push(Disco d){
            this.Size++;
            this.Elementos.Add(d);
            this.Top=d;
        } // push()

        public Disco pop(){
            if(this.Elementos.Count==0){
                this.Size--;
            } // if
            else{
                Disco ultimo = this.Elementos[this.Elementos.Count-1];
                this.Size--;
                return ultimo;
            } // else
        } // pop()   

        public bool isEmpty({
            if (this.Elementos.Count == 0){
                return true;
            } // if
            else{
                return false;
            } // else
        } // isEmpty()

    } // Pila
} // ()
