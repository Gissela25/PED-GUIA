using System;
using System.Collections;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable datos = new Hashtable();
            bool flag = true;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("\n");
                Console.WriteLine("1)Ingresar Datos");
                Console.WriteLine("2)Mostrar Datos");
                Console.WriteLine("3)Buscar Cliente");
                Console.WriteLine("4)Salir");

                switch (Console.ReadLine())
                {
                    case "1":
                        bool v1 = false;
                        string n1 = null;
                        while (!(v1))
                        {

                            Console.WriteLine("Ingrese Llave");
                            string dui = Console.ReadLine();
                            Console.WriteLine("Ingrese Contenido");
                            string nombre = Console.ReadLine();
                            datos.Add(dui, nombre);
                            v1 = true;
                        }
                        break;

                    case "2":
                        bool v2 = false;
                        string n2 = null;
                        while (!(v2))
                        {
                            Console.WriteLine("Ingresar la llave del cual desea informacion");
                            string DUI5 = Console.ReadLine();
                            Console.WriteLine("Para la llave: {0} el contenido es:{1}", DUI5, datos[DUI5]);
                            v2 = true;
                        }

                        break;
                    case "3":
                        bool v3 = false;
                        string n3 = null;
                        while (!(v3))
                        {
                            Console.WriteLine("Ingresar la llave que desea remover");
                            string dui3 = Console.ReadLine();
                            Console.WriteLine("Remover: {0}", dui3);
                            datos.Remove(dui3);
                            v3 = true;
                            //Console.WriteLine("Verificando que ya no se encuentre el valor en la tabla");
                            //if (datos.ContainsKey(dui3))
                            //{
                            //    Console.WriteLine("Clave: {0} no encontrada", dui3);
                            //    v3 = true;
                            //}

                        }
                        break;
                    case "4":
                        bool v4 = false;
                        string n4 = null;
                        while (!(v4))
                        {
                            ICollection valuecoll = datos.Values;
                            ICollection keyscoll = datos.Keys;
                            Console.WriteLine();
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Imprimiendo los valores de la tabla");

                            datos.Add("Musica", "La musica es buena");
                            datos.Add("Arte","El arte es abstracto");
                            datos.Add("Medicina", "Ciencia que estudia las enfermedades que afectan al ser humano");
                            datos.Add("científico", " persona que se dedica a las ciencias ");
                            datos.Add("ley", "regla o norma jurídica que se dicta por la autoridad");
                            datos.Add("Deporte", "Actividad o ejercicio físico");
                            datos.Add("Gastronomía", "conocimientos y actividades que están relacionados con los ingredientes y recetas ");
                            datos.Add("Informática", "Conjunto de conocimientos técnicos que se ocupan del tratamiento automático de la información por medio de computadoras");
                            datos.Add("Fotografía ", "técnica y a una forma de arte");
                            datos.Add("Historia ", "ciencia social que estudia los diferentes sucesos históricos");
                            datos.Add("Astronomía", "ciencia que se dedica al estudio de los cuerpos celestes");
                            datos.Add("Seguridad ", "ausencia del peligro, miedo y riesgos");
                            datos.Add("Teatro", "Arte escénico");
                            datos.Add("Software", "Contenido virtual del sistema");
                            datos.Add("Hardware", "partes reales que integran el cuerpo de un computador");
                            datos.Add("Economía", "estudio de los modos de organización y distribución de los bienes escasos");
                            datos.Add("Tecnología", "nociones y conocimientos utilizados para lograr un objetivo preciso");
                            datos.Add("Geografía", "es la ciencia social encargada de la descripción y representación gráfica del planeta Tierra");
                            datos.Add("Turismo", "Desplazamiento de las personas de manera temporal y voluntaria");
                            datos.Add("Ingeniería", " Es el estudio y la aplicación de las distintas ramas de la tecnología");
                            datos.Add("Programación", "secuencia de pasos ordenados a seguir");
                            datos.Add("Química", "ciencia aplicada al estudio de la materia");
                            datos.Add("Arquitectura", " técnica de concebir, diseñar y construir edificaciones");
                            datos.Add("Mercadeo", "acción que se desarrolla en un medio social, entre personas o entidades");
                            datos.Add("jurisprudencia", "lenguaje jurídico");
      
                            foreach(string s in keyscoll)
                            {
                                Console.WriteLine("Llaves = {0}", s);
                            }
                            foreach (string s in valuecoll)
                            { 
                                Console.WriteLine("Value = {0}", s);
                                v4 = true;
                            }

                        }
                        break;
                }
                Console.ReadKey();
            }


        }
    }
}
