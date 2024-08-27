using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Serializacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro umlivro = new Livro();

            umlivro.setCodigo("1");
            umlivro.setTitulo("Serializacao em C#");
            umlivro.setAutor("Maurício Asenjo");
            umlivro.setEditora("UNISANTA");
            umlivro.setAno("2013");

            Console.WriteLine(umlivro.getCodigo());
            Console.WriteLine(umlivro.getTitulo());
            Console.WriteLine(umlivro.getAutor());
            Console.WriteLine(umlivro.getEditora());
            Console.WriteLine(umlivro.getAno());
            Console.WriteLine();

            XmlSerializer obj = new XmlSerializer(umlivro.GetType());
            obj.Serialize(Console.Out, umlivro);
        
            Console.ReadKey();

        }
    }
}
