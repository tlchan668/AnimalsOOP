using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Boxer : Dog {

        public Boxer (string Name, bool LongTail, BarkPitchType barkPitch, MuzzleType muzzle, bool ExtremeSenseOfSmell) {
           

           
        }

        public Boxer(string Name) : base(Name) {
            this.LongTail = false;
            this.Muzzle = MuzzleType.Short;

        }
        public Boxer() : this("Sam") {

        }
        public override string GetTypeOfDog() {
            return "Boxer";
        }
    }
}
