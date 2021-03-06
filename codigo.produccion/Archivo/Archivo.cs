using System.Collections.Generic;
using codigo.produccion.Interfaces;

namespace codigo.produccion.Archivos
{

    public class Archivo : IArchivo
    {

        public Archivo(){

            Lineas = new List<string>();   

        }

        public List<string> Lineas {get; set;}
        public string Leer(string path)
        {

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {

                Lineas.Add(line);
                
            }

            file.Close();
            return "";

        }

    }
    
}