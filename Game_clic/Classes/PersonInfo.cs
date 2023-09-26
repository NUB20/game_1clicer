using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_clic.Classes
{
    public class PersonInfo
    {
        ///<summary> Наименование
        public string Name { get; set; }
        ///<summary> Жизненые показатели
        public int Health { get; set; } 
        ///<summary> Броня
        public int Armor {get; set; }
        /// <summary> Уровень
        public int Level { get; set; }
        /// <summary> Опыт 
        public int Glasses {get; set; }
        /// <summary> Денежные средства 
        public int Money { get; set; }
        /// <summary> Урон
        public float Damage { get; set; }
        public PersonInfo (string Name, int Health, int Armor, int Level, int Glasses, int Money, float Damage) { 
            this.Name = Name;
            this.Health = Health;
            this.Armor = Armor;
            this.Level = Level;
            this.Glasses = Glasses;
            this.Money = Money; 
            this. Damage = Damage;
        }
    }

}
