using System;

namespace wizardNinjaSamurai
{
       public class Samurai
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Samurai(string person ){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 200;
        }
        public Samurai(string person, int str, int intel, int dex, int hp){
            name= person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void death_below(object obj){
            Samurai attack = obj as Samurai;
            if(attack == null){
                Console.WriteLine("Failed to Attack");
            }
                if(attack.health < 50){
                    attack.health -= health;
                }
            else{
                attack.health -= strength * 5;
                intelligence -= dexterity *2; 
            }
        }
         public void samuraiMeditate(object obj){
            Samurai meditate = obj as Samurai;
            if(meditate == null){
                Console.WriteLine("Failed to meditate");
            }

            else{
                meditate.health += health;
            }
        }
    }
}
