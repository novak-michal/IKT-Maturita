using CS_programovani_21;

Person person1 = new Person("Karla", "Zápotocká", 22, 178, 68.0);

Person person2 = new Person("Ondřej", "Komínek", 16, 165, 67.0);

Person person3 = new Person("Jana", "Zelená", 34, 160, 79.2);

Console.WriteLine(person1.ToString());
Console.WriteLine("BMI: " + person1.CalculateBMI());
Console.WriteLine(person2.ToString());
Console.WriteLine("BMI: " + person2.CalculateBMI());
Console.WriteLine(person3.ToString());
Console.WriteLine("BMI: " + person3.CalculateBMI());


Console.WriteLine("Nyní experimentuji s úpravou vlastností:");
person3.SetSurname("Krásnohorská");
person3.SetAge(41);
Console.WriteLine(person3.ToString());

/* ----------------- Dědičnost ------------------ */
Animal animal1 = new Animal(80, 70, "Nějaké zvíře");
animal1.FeedAnimal();
Mammal father = new Mammal(); //využití bezparametrického kontruktoru, kdy se mi vytvoří prázdná instance
Mammal mother = new Mammal();
Mammal mammal1 = new Mammal(70, 60, "Nějaký savec", mother, father);
Birds bird1 = new Birds(0.5, 0.2, "Nějaký pták", 0.08);

/* --------------------- Polymorfismus --------------------- - pozdní vazba, kdy obecně deklaruji rodiče, kterého můžu později inicializivat jako on sám nebo potomka */
Animal animal2;
animal2 = new Birds(70, 60, "Pták 2", 0.1);
Animal animal3 = new Animal();
string name = animal3.Name;

Animal animal4 = new Mammal();
animal4.FeedAnimal();

/* Static */

Console.WriteLine(Calculator.SubstractTwoNumbers(14.2, 15.6));
















