using System;
using src.Entities;
namespace Jogo_RPG
{   
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("rid", 2, "knight");
            Mago maga = new Mago("Jenica", 2, "wizard");


            Console.WriteLine(maga.Ataque());
        }

    }
}