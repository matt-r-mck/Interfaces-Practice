using System;

namespace InterfacesDogs {
    class Program {
        static void Main(string[] args) {

            var col = new Collie {
                Name = "Lassie", Color = "Light Brown", BarkSound = "Woof!"
            };
            col.Bark();

            var box = new Boxer {
                Name = "Rocky", Color = "Black", BarkSound = "Bark!"
            };
            box.Bark();

            var chi = new Chihuahua {
                Name = "Killer", Color = "White", BarkSound = "Yip yip!"
            };
            chi.Bark();

            IDog [] dogs = new IDog [10];
            dogs[0] = col;
            dogs[1] = box;
            dogs[3] = chi;

            foreach(var dog in dogs) {
                if (dog == null) continue;
                Console.WriteLine($"A dog named {dog.Name} is {dog.Color}");
                dog.Bark();
            }

        }
    }
}
