﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMarket.Data.Model;
using WebMarket.Data.Repository;
using WebMarket.Service;

namespace WebMarket.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingService shoppingService = new ShoppingService();

            //Product apple = new Product { Id = 1, Name = "apple", Price = 1m };

            //ShoppingCart cart = new ShoppingCart();
            //cart.ShoppingItems.Add(new ShoppingItem { ProductId = 1, Count = 1 });

            //Receipt receipt = new Receipt();
            //receipt.ShoppingItems.AddRange(cart.ShoppingItems);

            //MockShoppingCartRepository mockShoppingCartRepository = new MockShoppingCartRepository();

            //var shoppingCart1 = mockShoppingCartRepository.Create();
            //var shoppingCart2 = mockShoppingCartRepository.Create();


            var allproduct = shoppingService.GetAllProducts();

            var cart = shoppingService.CreateShoppingCart();

            shoppingService.BuyProduct(cart.Id, 1, 2);

            Console.ReadLine();
        }
    }
}
