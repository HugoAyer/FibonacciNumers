using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class FibonacciNumbers
    {
    public static Dictionary<int, int> store; //Se crea un HashTable para almacenar el resultado de cada número de fibonacci. Esto es necesario para que el programa no vuelva a calcular cada resultado cada vez que va avanzando
        public static int calc(int num)
        {
        if (store == null) store = new Dictionary<int, int>(); //Si el diccionario no ha sido inicializado...

        int valor=0;

        if (store.ContainsKey(num)) //Sí el número ya ha sido calculado, devuelve el valor en lugar de correr el proceso de nuevo
        {
            return store[num];
        }
        if (num < 3)
        {
            valor = 1;
        }
        else
        {
            valor = calc(num - 1) + calc(num - 2); //Sí el número no ha sido calculado, va a obtener el valor de ambos números mediante la función recursiva
        }

        store.Add(num, valor);
        return valor;

        }
    }
