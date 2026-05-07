using Agregacja;

Console.WriteLine("Agregacja - przypisanie Kursntów do Kursu");

//twórzenie kursantów - niezależne obiekty

Kursant kursant1 = new Kursant("Jan", "Kowalski");
Kursant kursant2 = new Kursant("Anna", "Sroka");
Kursant kursant3 = new Kursant("Adam", "Kot");
Kursant kursant4 = new Kursant("Henryk", "Nowak");

//tworzenie kursu

Kurs kursAI = new Kurs("Sztuczna Inteligencja - architektury");

//przypisanie kursantów do kursu
kursAI.DodajKursanta(kursant1);
kursAI.DodajKursanta(kursant2);
kursAI.DodajKursanta(kursant3);
kursAI.DodajKursanta(kursant4);

//wyswietlmy informacje o kursie i kursantach
Console.WriteLine("kursanci istnieją jako obiekty poza kursem");
kursant1.WyswietlDane();
kursant2.WyswietlDane();

Console.WriteLine("Informacje o kursie i jego kursantach:");
kursAI.WyswietlInformacjeOKursie();
