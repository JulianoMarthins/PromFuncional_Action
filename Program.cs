using PromFuncional_Action.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromFuncional_Action {
     internal class Program {
          static void Main(string[] args) {

               List<Product> prod = new List<Product>();

               prod.Add(new Product("Televisor", 900));
               prod.Add(new Product("Mouse", 50));
               prod.Add(new Product("Tablet", 350.50));
               prod.Add(new Product("HD Case", 80.90));

               Console.WriteLine("Lista de Produtos: \n");

               foreach (Product p in prod) {
                    Console.WriteLine(p.ToString());
               }

               Console.WriteLine("\nProdutos com preço atualizado: (+10%)\n");

               foreach (Product p in prod) {
                    p.price = p.price * 1.1;
                    Console.WriteLine(p.ToString());
               }

               prod.ForEach(p => { p.price = p.price * 1.5; });

               Console.WriteLine("\nProdutos com Preço autualizado: (+50%) ");

               foreach(Product p in prod) {
                    Console.WriteLine(p.ToString());
               }

          }
     }
}
