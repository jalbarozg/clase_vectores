using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        //Propiedades del Vector
        private int vector;
        private int lg;

        // Constructor -> Inicializar las propiedades
        public clsVector(){
            vector = new int[100];
            lg = 0;
        }
        // metodos (procedimiento o fuciones
        private void adicionar(int valor){
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor (int pos) {
            return vector pos;
        }
        //logintud del vector
        public int longitud(){
            return lg;

    }
}
