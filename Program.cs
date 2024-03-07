namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }
    //Enumeration for migratory status
    public enum MigratoryStatus
    {
        NonMigratory,
        PartiallyMigratory,
        Migratory
    }

    // derived class of Animal 
    class Bird : Animal
    {
        public string color;
        public string callDescription;
        public MigratoryStatus migratoryStatus;

        // default constructor
        public Bird()
        {
            color = "";
            callDescription = "";
            migratoryStatus = MigratoryStatus.NonMigratory; //default value
        }

        // parameterized constructor
        public Bird(string name, string color, string callDescription, MigratoryStatus migratoryStatus) : base(name)
        {
            this.color = color;
            this.callDescription = callDescription;
            this.migratoryStatus = migratoryStatus;
        }

        public string GetMigratoryStatus()
        {
            switch (migratoryStatus)
            {
                case MigratoryStatus.NonMigratory:
                    return "non-migratory";
                case MigratoryStatus.PartiallyMigratory:
                    return "partially migratory";
                case MigratoryStatus.Migratory:
                    return "migratory";
                default:
                    return "unknown";
            }
        }

        public void display()
        {
            string migratoryStatus = GetMigratoryStatus();
            Console.WriteLine($"I am a bird, my name is {name}, my coloring is {color}, my call would be described as {callDescription}, and my migratory status is {migratoryStatus}");
        }
    }

    // 2nd derived class of Animal 
    class Arachnid : Animal
    {
        public int eyeCount;
        public bool canSpinWeb;
        public bool IsVenomous;
        public string habitat;

        // default constructor
        public Arachnid()
        {
            eyeCount = 8;
            canSpinWeb = true;
            IsVenomous = false;
            habitat = "";
        }

        // parameterized constructor
        public Arachnid(string name, int eyeCount, bool canSpinWeb, bool isVenomous, string habitat) : base(name)
        {
            this.eyeCount = eyeCount;
            this.canSpinWeb = true;
            this.IsVenomous = true;
            this.habitat = habitat;
        }

        public void display()
        {
            Console.WriteLine($"I am a spider, my name is {name}, I have {eyeCount} eyes, it is {canSpinWeb} that I can spin a web, and {IsVenomous} that I am venomous, and I primarily reside in {habitat}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();
            Console.WriteLine();

            // derived class object using default constructor
            Bird Chickadee = new Bird();
            Chickadee.name = "Black-Capped Chickadee";
            Chickadee.color = "black and white";
            Chickadee.callDescription = "chick-a-dee-dee-dee";
            Chickadee.migratoryStatus = MigratoryStatus.NonMigratory;
            Chickadee.display();
            Console.WriteLine();

            //derived class object using parameterized constructor
            Bird Robin = new Bird("Robin", "rusty Red & Gray", "cheerful-sounding chirps", MigratoryStatus.PartiallyMigratory);
            Robin.display();
            Console.WriteLine();
            Bird BlueJay = new Bird("BlueJay", "blue with whitish gray", "a loud 'jeer' or 'jay-jay'", MigratoryStatus.PartiallyMigratory);
            BlueJay.display();
            Console.WriteLine();
            Bird Sparrow = new Bird("Sparrow", "streaks of brown and white", "chirps of melodious song", MigratoryStatus.NonMigratory);
            Sparrow.display();
            Console.WriteLine();
            Bird Eagle = new Bird("Eagle", "white head and tail with dark brown body and wings", "high-pitched whistles, chirps, and peal calls", MigratoryStatus.Migratory);
            Eagle.display();
            Console.WriteLine();

            //2nd derived class object using default constructor
            Arachnid Tarantula = new Arachnid();
            Tarantula.name = "Tarantula";
            Tarantula.eyeCount = 8;
            Tarantula.canSpinWeb = false;
            Tarantula.IsVenomous = true;
            Tarantula.habitat = "tropical, subtropical, and desert regions";
            Tarantula.display();
            Console.WriteLine();

            //2nd derived class object using parameterized constructor
            Arachnid BlackWidow = new Arachnid("Black Widow", 8, true, true, "dark, dry places");
            BlackWidow.display();
            Console.WriteLine();
            Arachnid BrownRecluse = new Arachnid("Brown Recluse", 6, true, true, "dark, secluded, indoor places");
            BrownRecluse.display();
            Console.WriteLine();
            Arachnid WolfSpider = new Arachnid("Wolf Spider", 8, true, false, "woods, grasslands, and shrublands");
            WolfSpider.display();
            Console.WriteLine();
            Arachnid OrbWeaver = new Arachnid("Orb Weaver", 8, true, true, "gardens, fields, forests, and a variety of other places");
            OrbWeaver.display();
            Console.WriteLine();
            Arachnid DaddyLongLegs = new Arachnid("Daddy Long Legs", 2, false, false, "moist habitats");
            DaddyLongLegs.display();
            Console.WriteLine();


        }

    }
}

