using System;
using System.Collections.Generic;
using AnimalLibrary;//if using someone elses need to do this way
                    //if your own class can change the namespace 
                    //so both would have Animals namespace

namespace Animals {
    class Program {
        static void Main(string[] args) {
            var germansheperd1 = new GermanShepherd("Killer");
            germansheperd1.LongTail = true;//instance created and now assign value

            var germanSheperd = new GermanShepherd {
                LongTail = true,
                BarkPitch = BarkPitchType.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = true,
                Name = "Fred"
            };

            var pug = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchType.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"
               
            };

            var Barker = new Pug("Barker");
            var pug2 = new Pug();

            var Stan = new Boxer();
            var Sam = new Boxer("Sam");

            //create a collection of dogs
            //example of polymorphism
            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(germansheperd1);
            dogs.Add(Barker);
            dogs.Add(pug2);
            dogs.Add(Stan);
            dogs.Add(Sam);

            foreach (var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());//this just prints Dog
            }


        }
    }
}
