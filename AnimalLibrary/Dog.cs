using System;

namespace AnimalLibrary {

    public enum MuzzleType { Long, Short, Collapsed};
    public enum BarkPitchType { High, Medium, Low };

    public class Dog {

        public bool LongTail { get; set; }
        public BarkPitchType BarkPitch { get; set; } //high, medium, low
        public MuzzleType Muzzle { get; set; } //long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;//normal sense 
        public string Name { get; set; }

        public virtual string GetTypeOfDog() {
            return "Dog";
        }

        //always add default constructor that takes no parameters
        public Dog() {

        }
        public Dog(string Name) {
            if (Name == null) {
                this.Name = "Doggy";
            } else {
                this.Name = Name;
            }
        }



    }
}
