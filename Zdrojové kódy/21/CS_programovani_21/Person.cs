namespace CS_programovani_21
{
    public class Person
    {
        /* dělám zde čistě deklaraci atributů, nepřiřazuji jim hodnoty (nedělám inicializaci) */
        /* Atributy dělíme na proměnné a vlastnosti.
     Proměnné třídy (atributy) bývají private a deklarují se private _název
     Vlastnosti (Properties) které bývají veřejné, nebo mají tzv. get/set a deklarují se public Název
     */
        /* Pokud je něco private, ale chci k tomu přistupovat zvenčí, tak si k tomu můžu napsat public metody, ve kterých mohu kontrolovat, nějaké podmínky */
        /*
     * Kdybych to tedy chtěl jako obyčejné atributy, tak:
     private string _name;
     private string _surname;
     ...
     neexistuje tedy něco jako public _name, tedy veřejný atribut
     */
    
        /* všechno jsou to teď private (soukromé) vlastnosti */
        // private string Name { get; set; }     //automaticky vygeneruje nějaký public GetName() a SetName()
        private string Name;
        private string Surname;
        private int Age;
        private int Height;    // in cm
        private double Weight; // in kg
    
        // příklad proměnné, kterou chci inicializovat a bude společná pro všechny 
        public string _species = "Člověk";
    
        /* konstruktor - je metoda, která mi říká, jak se vytvoří, nebo jak vytvořit objekt(instanci) dané třídy */
        public Person(string input_name, string input_surname, int input_age, int input_height, double input_weight)
        {
            this.Name = input_name;
            this.Surname = input_surname;
            this.Age = input_age;
            this.Height = input_height;
            this.Weight = input_weight;
        }
        /* Obecně Get/set jsou metody, které mi umožňují získat/nastavit nějakou private vlastnost */
        public string GetName()
        {
            return Name;
        }

        /* void - je návratový typ, který mi říká, že nic nevreacím (ale musí to být řečeno), nemám žádné return */
        public void SetName(string name)
        {
            // pokud je proměnná/atribut deklarovaný, ale není inicializovaný, má hodnotu tzv. null - to je vlastně hodnota, která mi říká, že to nemá hodnotu
            /* Jakmilu už pracuji nějak s tím atributem/vlastností, tak si musím ověřit, jestli to není null + ještě nějaké moje podmínky
         Rovněž musím dávat pozor na pořadí v té podmínce, VŽDYCKY SE PTÁM JAKO PRVNÍ NA null a až potom na zbytek */
            if (name != null && name.Length > 1)
            {
                this.Name = name;
            }
            else
            {
                Console.WriteLine("Zadané jméno bylo null nebo má jenom 1 znak");
            }
        }

        public string GetSurname()
        {
            return Surname;
        }
        public int GetAge()
        {
            return Age;
        }
        public int GetHeight()
        {
            return Height;
        }
        public double GetWeight()
        {
            return Weight;
        }

        public void SetSurname(string surname)
        {
            if (surname != null && surname.Length > 1)
            {
                this.Surname = surname;
            }
            else
            {
                Console.WriteLine("Nepodařilo se nastavit příjmení, zadané příjmení bylo null nebo kratší jak 1");
            }
        
        }

        public void SetAge(int age)
        {
            if (age != null && age >= 0 && age < 200)
            {
                this.Age = age;
            }
            else
            {
                Console.WriteLine("Zadaný věk neodpovídá vstupním podmínkám na velikost.");
            }
        }

        public void SetHeight(int Height)
        {
            if (Height != null && Height > 0)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Nepodařilo se nastavit výšku.");
            }
        }

        public void SetWeight(double Weight)
        {
            if (Weight != null && Weight > 0)
            {
                this.Weight = Weight;
            }
        }

        /* Metoda - je nějaká funkce, která vykonává příkazy, které obsahuje. Poznám ji tak, že za názvem jsou ()
     Povinné části metody: modifikátor přístupu, návratový datový typ, název metody
     Nepovinné části: vstupní parametry
     */

        public string ToString()
        {
            return "Jméno: " + Name + ", příjmení: " + Surname + ", věk: " + Age + ", výška: " + Height + ", váha: " + Weight + ", druh: " + _species;
        }

        /* Pokud má metdoa něco vracet (nějaký datový typ nebo objekt), musím uvnitř použít klíčové slovíčko return */
        public double CalculateBMI()
        {
            return  Weight / ((double)Height / 100.0 * (double)Height / 100.0);
        }
        /* Implicitní datová konverze - je změna jednoho datového typu na jiný, kdy ten jazyk si to dokáže rozpoznat a udělat sám
     např. často si umí převést sám čísla na string, viz metoda ToString()
     Nebo Integer / double * Integer mi nemusí vrátit double (i když by měl)
     Explicitní datová konverze - přímo řeknu tomu programu, kterou proměnnou má změnit na jaký datový typ
     (datový_typ)proměnná
     
     Dávat tedy pozor na dělení integer / double a použítvat tu typovou konverzi
     */
    
        /*  Modifikátory přístupu - mi říkají, kdo má přístup k daným atributům, nebo metodám
     má hodnotu private nebo public */
    }
}