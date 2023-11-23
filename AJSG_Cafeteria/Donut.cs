using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AJSG_Cafeteria
{
    // antes habia internal en vez de public, pero se quejaba al pasarle a
    // fillBoxes(Donut donut) por accesibilidad
    public class Donut
    {
        // los atributos tienen que ser publicos, ya que si no, no se puede acceder a los setters
        public int id { get; set; }
        public bool inStock { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public double precio { get; set; }
        public char calidad { get; set; }

        public Donut() { }

        public Donut(int id, bool inStock, string nombre, string imagen, double precio, char calidad)
        {
            this.id = id;
            this.inStock = inStock;
            this.nombre = nombre;
            this.imagen = imagen;
            this.precio = precio;
            this.calidad = calidad;
        }

        public override string ToString()
        {
            return $"ID: {this.id} InStock: {inStock} Nombre: {nombre}, Precio: {precio}, Calidad: {calidad}";
        }

        public void SaveToFile(string filePath, List<Donut> lista)
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                // Escribe el numero de Donuts
                writer.Write(lista.Count);

                // Escribe cada donut de la lista
                foreach (var Donut in lista)
                {
                    writer.Write(Donut.id);
                    writer.Write(Donut.inStock);

                    // Escribe la longitud del string y luego el propio string
                    byte[] nameBytes = System.Text.Encoding.UTF8.GetBytes(Donut.nombre);
                    writer.Write(nameBytes.Length);
                    writer.Write(nameBytes);

                    // Escribe la longitud del la imagen y la propia imagen
                    byte[] imagenBytes = System.Text.Encoding.UTF8.GetBytes(Donut.imagen);
                    writer.Write(imagenBytes.Length);
                    writer.Write(imagenBytes);

                    writer.Write(Donut.precio);
                    writer.Write(Donut.calidad);
                }
            }
        }

        public static List<Donut> LoadFromFile(string filePath)
        {
            List<Donut> loadedDonuts = new List<Donut>();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                // Leemos el numero de donuts
                int donutCount = reader.ReadInt32();

                // Leemos cada donut del fichero
                for (int i = 0; i < donutCount; i++)
                {
                    Donut loadedDonut = new Donut();
                    loadedDonut.id = reader.ReadInt32();
                    loadedDonut.inStock = reader.ReadBoolean();

                    // Lee la longitud del string y luego el propio string
                    int nombreLength = reader.ReadInt32();
                    byte[] nombreBytes = reader.ReadBytes(nombreLength);
                    loadedDonut.nombre = System.Text.Encoding.UTF8.GetString(nombreBytes);

                    int imagenLength = reader.ReadInt32();
                    byte[] imagenBytes = reader.ReadBytes(imagenLength);
                    loadedDonut.imagen = System.Text.Encoding.UTF8.GetString(imagenBytes);

                    loadedDonut.precio = reader.ReadDouble();
                    loadedDonut.calidad = reader.ReadChar();

                    loadedDonuts.Add(loadedDonut);
                }
            }

            return loadedDonuts;
        }
    }
}
