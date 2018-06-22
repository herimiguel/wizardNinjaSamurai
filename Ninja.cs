using System;

namespace wizardNinjaSamurai
{
       public class Ninja
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Ninja(string person ){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 175;
            health = 100;
        }
        public Ninja(string person, int str, int intel, int dex, int hp){
            name= person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void steal(object obj){
            Ninja attacks = obj as Ninja;
            if(attacks == null){
                Console.WriteLine("Failed to Attack");
            }
            else{
                attacks.health +=  strength  * 3;
            }
        }
        public void get_away(object obj){
            Ninja away = obj as Ninja;
            if(away == null){
                Console.WriteLine("Failed to get away");
            }
            else{
                away.health +=  strength  * 5;
            }
        }
    }
}
