﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromFuncional_Action.Entities {
     internal class Product {

          public string name { get; set;}
          public double price { get; set;}



          public Product(string name, double price) {
               this.name = name;
               this.price = price;
          }


          public override string ToString() {
               string valorFormatado = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", this.price);
               return $"{this.name}: {valorFormatado}";
          }

     }
}