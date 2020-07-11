using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01072020_Tirgul
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple a = new Apple()
            {
                _name = "Green Apple",
                _calories = 50,
                _color = "Green",
                _isThisMyFavorite = false,
                _pinkLady = false
            };

            Banana b = new Banana()
            {
                _name = "Banana",
                _calories = 100,
                _hasBlackSpots = false,
                _isThisMyFavorite = true,
                _isGreen = false,
                _size = 5
            };

            Tomato t = new Tomato()
            {
                _name = "tomato",
                _isThisMyFavorite = false,
                _size = 10,
                _isGreen = true,
                _calories = 5
            };

            Cucumber c = new Cucumber()
            {
                _name = "cucumber",
                _calories = 20,
                _isThisMyFavorite = false,
                _size = 8,
                _isGreen = false
            };


            Fruit[] fruitArray = {a, b, c, t};

            FruitSalad fruitSalad = CreateFruitSalad(fruitArray);

            Console.WriteLine(a.ToString());
            ColorOfApple(a);

            Console.WriteLine();

            Console.WriteLine(b.ToString());
            BananaSize(b);

            Console.WriteLine();

            Console.WriteLine(c.ToString());
            Console.WriteLine();
            Console.WriteLine(t.ToString());
            Console.WriteLine();

            Console.WriteLine(fruitSalad.ToString());
            Console.WriteLine();
            FruitSaladCalories(fruitSalad);
            MyFavoriteIsThere(fruitSalad);



        }

        public static void ColorOfApple(Apple apple)
        {
            Console.WriteLine($"Apple color is : {apple._color}");
        }

        public static void BananaSize(Banana banana)
        {
            Console.WriteLine($"Banana size is : {banana._size}");
        }

        public static void FruitSaladCalories(FruitSalad fruitSalad)
        {
            Console.WriteLine($"Salad Calories: {fruitSalad.GetTotalCalories()}");
        }

        public static void MyFavoriteIsThere(FruitSalad fruitSalad)
        {
            Console.WriteLine($"Salad Contains My Favorite Fruit: {fruitSalad.ContainsMyFavoriteFruit()}");
        }

        public static FruitSalad CreateFruitSalad(Fruit[] fruitArry)
        {
            FruitSalad fruitSalad = new FruitSalad()
            {
                _fruits = fruitArry
            };

            return fruitSalad;
        }

    }
}
