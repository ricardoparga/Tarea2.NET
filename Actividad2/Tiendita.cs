using System;

namespace actividad2{
    public class Tiendita {

        List<string> inventario = new List<string>();
        List<string> registroVentas = new List<string>();
        List<string> registroCategorias = new List<string>();
        List<int> vecesRepetidas = new List<int>();

        public void agregarProducto(Productos producto)
        {
            string nombre = producto.ToString();
            inventario.Add(nombre);
        }

        public void mostrarProductos()
        {
            for (int i = 0; i < inventario.Count; i++)
            {
                Console.WriteLine(inventario[i] + "\n");
            }
        }

        public void comprarProductos(Productos producto, int cantidad)
        {
            for (int i = 0; i < cantidad; i++)
            {
                registroVentas.Add(producto.ToString());
                registroCategorias.Add(producto.categoria);
            }
            double total = producto.getPrecio()*cantidad;
            Console.WriteLine($"Compraste {cantidad} {producto.ToString()}. El total de tu compra es ${total}");
        }

        public void productoMasVendido()
        {
            registroVentas.Sort();
            int contador = 1;
            for (int i = 0; i < registroVentas.Count; i++)
            {
                if (registroVentas[i] == registroVentas[i+1])
                {
                    contador++;
                }
                else
                {
                    vecesRepetidas.Add(contador);
                    contador = 1;
                }
            }
            HashSet<string> repetidos = new HashSet<string>(registroVentas);
            registroVentas.Clear();
            registroVentas.AddRange(repetidos);
            for  (int i = 0; i < vecesRepetidas.Count; i++)
                {
                Console.WriteLine($"El producto {registroVentas[i]} se vendio {vecesRepetidas[i]} ");
                }
        }
    }
}
