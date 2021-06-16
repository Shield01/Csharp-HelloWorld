 using System;
using System.IO;

namespace HelloWorld
{
    class MyClass
    {
        public string name = "Hussein";
    }

    
    class Program
    {
        string DevelopersName = "Hussein";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! 1");

            //declaring variables
            int counter;

            counter = 5;

            Console.WriteLine("Counter has a value of " + counter);

            //declaring another integer

            int test = 2;

            Console.WriteLine(test);

            test = test + 3;

            Console.WriteLine("Hi, i increased by 3... and now my value is " + test);

            // testing the plus shortcut

            test++;

            Console.WriteLine("And now my value is " + test);

            // testing the minus shortcut

            test--;

            Console.WriteLine(test + " is my new Value... Lol, I kept you guessing.");

            test *= 5;

            Console.WriteLine("Honestly, i don't know my value anymore... I am " + test);

            // reversing the multiplication

            test /= 5;

            Console.WriteLine("Now i am " + test + " i reversed the multiplication");

            var array = new int[] { 1, 2, 3 };
            
            foreach (var a in array)
            {
                Console.WriteLine("Var is " + a);
            }

            Program wahab = new Program();
            Console.WriteLine(wahab.DevelopersName);

            MyClass anotherClass = new MyClass();
            Console.WriteLine(anotherClass.name);


            Cars myObj = new Cars();
            myObj.color = "red";
            myObj.maxSpeed = 170;
            myObj.name = "Ferrari";

            Cars anotherObj = new Cars();

            anotherObj.color = "blue";
            anotherObj.maxSpeed = 780;
            anotherObj.name = "Rollce Royyes";

            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            Console.WriteLine(myObj.name);
            Console.WriteLine($"Hello i am {myObj.name} i am color {myObj.color} i have a max speed of {myObj.maxSpeed}");
            myObj.sentence();

            Console.WriteLine(anotherObj.color);
            Console.WriteLine(anotherObj.maxSpeed);
            Console.WriteLine(anotherObj.name);
            Console.WriteLine($"Hello i am {anotherObj.name} i am color {anotherObj.color} i have a max speed of {anotherObj.maxSpeed}");
            anotherObj.sentence();


            Family member = new Family("Hussein", 19, "Male", 3);
            Console.WriteLine(member.name);
            Console.WriteLine(member.position);
            
            // The madu inheritance class is being manifested here 
            Madu aMember = new Madu("Baba Mallam", 5, "Provision Sales", 01);
            aMember.maxSpeed = 4;
            Console.WriteLine($"Hello i am {aMember.individual}, my rating is {aMember.rating}, i am into {aMember.bussiness}.... my house number is {aMember.address}." +
                $"I could run at {aMember.maxSpeed} Kilometer per hour for 180 seconds.");


            // Trying to do polymorphism

            Avantador aCar = new Avantador();
            aCar.vehicleSound();

            Urus thisCar = new Urus();
            thisCar.vehicleSound();

            question aQues = new question();

            aQues.whoDey();
            aQues.idontKnow();

            anEnum initiateEnum = anEnum.firstEnum;
            anEnum initiateEnumInNumbers = (int) anEnum.firstEnum;
            Console.WriteLine(initiateEnum);
            Console.WriteLine(Convert.ToInt32(initiateEnum));
            Console.WriteLine(initiateEnumInNumbers);

            //using enum in switch statements

            anEnum var = anEnum.secondEnum;

            switch (var)
            {
                case anEnum.firstEnum:
                    {
                        Console.WriteLine("I am not looking for the first enum");
                    }
                    break;
                case anEnum.secondEnum:
                    {
                        Console.WriteLine(anEnum.secondEnum);
                    }
                    break;
                case anEnum.thirdEnum:
                    {
                        Console.WriteLine("I am not looking for the third enum");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("There's no value to be displayed.");
                    }
                    break;
            }

            //working with files
            string thisAppCode = "Some texts";
            File.WriteAllText("aFile.txt", thisAppCode);
            string thisTxt = File.ReadAllText("aFile.txt");
            Console.WriteLine(thisTxt);
        }

        class Cars
        {
            public string name;
            public string color;
            public int maxSpeed;
            public void sentence()
            {
                Console.WriteLine("Hello i am a car, i have a color and i have a max speed");
            }
        }

        class Family
        {
            public string name;
            public string gender;
            public int position;
            public int age;

            public Family(string memberName, int memberAge, string memberGender, int memberPosition)
            {
                name = memberName;
                age = memberAge;
                gender = memberGender;
                position =memberPosition;
            }
        }

        //trying to create an inheritance from another class... this class will be inheriting from the family class

        class Madu : Cars
        {
            public string individual;
            public int rating;
            public string bussiness;
            public int address;

            public Madu(string particularIndividual, int particularRating, string particularBussiness, int particularAddress)
            {
                individual = particularIndividual;
                rating = particularRating;
                bussiness = particularBussiness;
                address = particularAddress;
            }
        }

        //this is polymorphism

        abstract class Vehicle
        {
            public abstract void vehicleSound();

        }

        class Avantador : Vehicle
        {
            public override void vehicleSound()
            {
                Console.WriteLine("This should sound like a Lamborghini Avantador.");
            }
        }

        class Urus : Vehicle
        {
            public override void vehicleSound()
            {
                Console.WriteLine("This should sound like a Lamboghini Urus.");
            }
        }

        //using interface

        interface iAbstract
        {
           void idontKnow();
            void whoDey();
            
        }

        interface iAnotherAbstract
        {
            void iAnotherAbstract();
        }

        class question : iAbstract, iAnotherAbstract
        {
            public void whoDey()
            {
                Console.WriteLine("Wonders of an interface");
            }
            public void idontKnow()
            {
                Console.WriteLine("This is being displayed with an interface");
            }

            public void iAnotherAbstract()
            {
                Console.WriteLine("This is inherited from another interface");
            }

        }

        //using enums

        enum anEnum
        {
            firstEnum,
            secondEnum,
            thirdEnum,
        }

    }
}
 