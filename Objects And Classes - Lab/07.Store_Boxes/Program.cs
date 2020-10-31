using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] info = input.Split();
                string serialNumber = info[0];
                string itemName = info[1];
                int itemQuantity = int.Parse(info[2]);
                double itemPrice = double.Parse(info[3]);

                boxes.Add(new Box(serialNumber, new Item(itemName, itemPrice), itemQuantity));
            }
            boxes = boxes.OrderBy(box => box.PriceForABox).Reverse().ToList();
            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber + "\n" +
                    $"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}" + "\n" +
                    $"-- ${box.PriceForABox:F2}");
            }
        }

        class Item
        {
            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }

            public string Name;
            public double Price;
        }

        class Box
        {
            public Box(string serialNumber, Item item, int itemQuantity)
            {
                this.SerialNumber = serialNumber;
                this.Item = item;
                this.ItemQuantity = itemQuantity;
                this.PriceForABox = item.Price * itemQuantity;
            }
            public string SerialNumber;
            public Item Item;
            public int ItemQuantity;
            public double PriceForABox;
        }
    }
}
