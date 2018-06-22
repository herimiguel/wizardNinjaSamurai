using System;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
        Ninja player1 = new Ninja("Eddie", 3,3,175,100 );
        Ninja player2 = new Ninja("Scott", 3,3,175,100 );
        Console.WriteLine($"{player1.name},: {player1.health},{player2.name},: {player2.health}");        
        Console.WriteLine($"{player1.name},: {player1.dexterity},{player2.name},: {player2.dexterity}");
        player1.steal(player2);
        Console.WriteLine($"{player1.name},: {player1.health},{player2.name},: {player2.health}");
                        

        }
    }
}
