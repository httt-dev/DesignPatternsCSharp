using System;

namespace Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // create milk tea
            //EggPudding+ FruitPudding + BlackSugar + Bubble + MilkTea
            // cost = 14$
            var ourMildTea = new EggPuddingDecorator(
                            new FruitPuddingDecorator(
                                    new BlackSugarDecorator(
                                        new BubbleDecorator(
                                            new MilkTea()))));
            
            Console.WriteLine($"Our milk tea cost : {ourMildTea.Cost()}");

            var boyTeaOf = new EggPuddingDecorator(
                            new BlackSugarDecorator(
                                new WhitePuddingDecorator(
                                    new MilkTea())));
            Console.WriteLine($"Boy milk tea cost : {boyTeaOf.Cost()}");
        }
    }
}