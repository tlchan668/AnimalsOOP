using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class GermanShepherd : Dog { //shows inheritance 
        public bool BigDog { get; set; } = true;//property on gs that is different than dog

        public GermanShepherd() {
            this.Muzzle = MuzzleType.Long;//make default constructor to set it to long part of dog
        }
        public GermanShepherd(string Name) : base(Name) {//this constructor takes name
                                                                        //from base and pass constructor 
            this.LongTail = true;

        }

        public override string GetTypeOfDog() {
            return "German Shepherd";
        }
    }
}
