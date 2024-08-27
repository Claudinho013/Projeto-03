using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Serializacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro umlivro = new Livro();

            umlivro.setCodigo("");
            umlivro.setTitulo("");
            umlivro.setAutor("");
            umlivro.setEditora("");
            umlivro.setAno("");

            String json = File.ReadAllText("teste.json");
            Console.WriteLine(json);

            umlivro = JsonConvert.DeserializeObject<Livro>(json);

            Console.WriteLine(umlivro.getCodigo());
            Console.WriteLine(umlivro.getTitulo());
            Console.WriteLine(umlivro.getAutor());
            Console.WriteLine(umlivro.getEditora());
            Console.WriteLine(umlivro.getAno());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
