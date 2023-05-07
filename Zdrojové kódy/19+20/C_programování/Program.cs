/* --------- Datové typy ------------- */

bool pravda = true;
bool nePravda = false; 

int celeCislo = 2;
int celeCislo2 = -87;

double realneCislo = 5.148935;

string text = "Hele, jsem nějaký text"; // text vždy musím zapsat do uvozovek ""

char znak = 'z'; // znak musím vždy zapsat do apostrofů ''

/* Deklarace */
int cislo1;

/* přiřazení (inicializace) */
cislo1 = 5;  //inicializace již deklarované proměnné
int cislo2 = 7;  //deklarace s inicializací v jednom kroku



/* ------------------------ Operátory -------------------------- */

/* --- Binární operátory --- */
int cislo3 = cislo1 + cislo2; //operátor sčítání
int cislo4 = cislo2 - cislo3; //operátor odčítání
int cislo5 = cislo1 / cislo2; //operátor dělení
int cislo7 = cislo1 * cislo3; //operátor násobení

cislo7 = cislo7 + cislo3;
cislo7 += cislo3; //stejný zkrácený zápis řádku výše; tzv. operátor složeného přiřazení; analogicky to funguje i pro -
int cislo12 = cislo2 % cislo1; //modulo % je zbytek po celočíselném dělení, ergo 7/5 je jedna a zbytek je 2, dva je to modulo


/* --- Unární operátory --- */
cislo3 = -cislo3; //záporná hodnota cisla3
cislo4 = +cislo4; //kladná hodnota cisla4
bool pravda1 = true;
bool pravda2 = !pravda1; //negace, funguje jenom nad datovým typem bool
int cislo10 = 1;
int cislo11 = ++cislo10; //zvednu hodnotu o 1, analogicky i --; funguje jenom u integeru

/* Relační operátory - na porovnání 2 hodnot, patří taky mezi binární operátory, vyhodnocení jako pravda/nepravda
 == rovno
 != není rovno
 <= menší rovno
 >= větší rovno
 < menší
 > větší
 */

/* Logické operátory
|| konjunkce OR – Stačí, aby platil jeden výraz a celá podmínka se bere jakože platí
&& disjunkce AND – Musí platit všechny části výrazy v podmínce, aby byla podmínka vyhodnocena jako platná
 */


/* _______________________ POLE ---------------------------*/
string[] pole1;  //klasická deklarace
pole1 = new[] { "Vílém", "Jarmila", "Hynek" };  //klasická inicializace

string[] pole2 = new []{"Karla", "Jaromír", "Zdeněk"}; // deklarace pole s inicializací a rovnou ho naplním hodnotami

string[] pole3 = new string[3]; //deklarace pole s definicí, kdy já říkám, jak bude velké, ale ještě tam nedávám ty hodnoty
pole2[0] = "Maryje";
pole2[1] = "Karla";
pole2[2] = "Zbyněk";
//pole2[3] = "Anežka"; už nebude fungovat, pole2 má jenom 3 chlívečky a já se mu snažím dát něco na 4. pozici


/* ------------------ Větvění --------------------- */
if (cislo1 > cislo2)
{
  /* jestliže je splněno */
  Console.WriteLine("cislo1 je větší, než cislo2");
}
else
{
 /* jestliže není cislo1 větší, než číslo 2, provede se tahle část */
 Console.WriteLine("cislo1 není větší, než cislo2");
}


/* část else je nepovinná */
if (cislo1 < 10)
{
 Console.WriteLine("Číslo1 je menší, než 10");
}


/* ----------------- Cyklus --------------------- */
/* ---- for ---- */
for (int i = 0; i < 500; i++)
{
 Console.WriteLine("Papouškuji " + i+"x");
}

Console.WriteLine(pole2[0]);
Console.WriteLine(pole2[1]);
Console.WriteLine(pole2[2]);
//opět, nechci vypisovat ručně, takže pole můžu pomocí cyklu for projít a vypsat obsah

for (int i = 0; i < pole2.Length; i++)
{
 Console.WriteLine(pole2[i]);
}

/* --- foreach --- */
foreach(string jmeno in pole2){
 Console.WriteLine(jmeno + ", ale z cyklu foreach");
}

/* --- Složené větvení if - else if --- */
if (cislo3 > 18)
{
 Console.WriteLine("Je větší než 18");
}else if (cislo3 > 24)
{
 Console.WriteLine("Je větší než 24");
}else if (cislo3 > 54)
{
 Console.WriteLine("Jě větší, než 54");
}

/* Switch - přepínací podmínka větvení
 syntax: switch(podmínka){
  case hodnota/podmínka:
   break;
  default:
  break;
  }
 */

switch (cislo5)
{
 case 8:
  Console.WriteLine("Cislo5 má hodnotu 8");
  break;
 case 10:
  Console.WriteLine("Cislo5 má hodnotu 10");
  break;
 case <-40:
  Console.WriteLine("Číslo5 má hodnotu menší, než -40");
  break;
 default:
  Console.WriteLine("Číslo5 má jinou hodnotu");
  break;
}

/* Vnořené větvení - takže to je prostě podmínka v podmínce*/
if (cislo2 != 0)
{
 if (cislo3 != 0)
 {
  int cislo6 = cislo3 / cislo2;
  cislo7 = cislo2 / cislo3;
 }
}
/* pozn. v tom větvení if ta podmínka může být zřetězená, nebo se může jednat o sdružený logický výraz
 if(podmínka || druhá_podmínka){}
 */
cislo3 = 0;
if (cislo2 != 0 && cislo3 != 0)
{
 int cislo6 = cislo3 / cislo2;
 cislo7 = cislo2 / cislo3;
}

/* -------------------------- Cyklus while ----------------------------
 */
bool mojepravda = true;
int ii = 0;    
while (mojepravda == true)
{
  //aby nejel donekonečna, můžu si počítat kroky a ponějakém to utnou
  //ii mi bude počítat počet provedení toho cyklu, ale inicializaci té proměnné musím udělat mimo ten cyklus, nemůžu to udělat tady, jinak by při každém průchodu cyklem mi znova nastavil ii na 0
 Console.WriteLine("Dokud je pravda, udělej tento příkaz");
 ii++;                          //na konci cyklu zvětši ii o 1
 if (ii > 500)                  //no a pokud je ii větší, než 500, změň mojepravda na false a při příštím průchodu cyklem, vyhodnocení podmínky bude false a cyklus skončí
 {
  mojepravda = false;
 }
}

mojepravda = false;
do
{
Console.WriteLine("Toto se mi provede minimálně 1x");
} while (mojepravda);
/* Do -while funguje stejně jako while, ale vyhodnocení podmínky opětovného běhu je až na konci, ergo příkazy v cyklu se provedou aspoň 1x */

