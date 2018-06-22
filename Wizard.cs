using System;

namespace wizardNinjaSamurai
{
        public class Wizard
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Wizard(string person ){
            name = person;
            strength = 10;
            intelligence = 25;
            dexterity = 3;
            health = 50;
        }
        public Wizard(string person, int str, int intel, int dex, int hp){
            name= person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void heal(object obj){
            Wizard healing = obj as Wizard;
            if(healing == null){
                Console.WriteLine("Failed to Attack");
            }
            else{
                healing.intelligence += intelligence + 10;
            }
        }
        public void fireball(object obj){
            Wizard dechealth = obj as Wizard;
            if(dechealth == null){
                Console.WriteLine("Failed to decrease Health");
            }
            else{
                // dechealth. +=  Random ;
                Console.WriteLine("Working on decreasing health");
            }
        }
    }
}
