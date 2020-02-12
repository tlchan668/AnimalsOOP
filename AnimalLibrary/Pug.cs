using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog{

        public bool IsSmall { get; set; } 

        public Pug() :this("Spot"){//this calls the parent constructor

        }

        public Pug(string Name) : base(Name) {
            this.LongTail = false;
            this.Muzzle = MuzzleType.Collapsed;

        }
        public override string GetTypeOfDog() {
            return "Pug";
        }
    }
}
