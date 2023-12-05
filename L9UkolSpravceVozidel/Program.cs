using L9UkolSpravceVozidel;

SpravceVozidel sprava = new SpravceVozidel ();

sprava.PridejMotorku("Motorka", "2004", "Černá", "skútr", 2);
sprava.PridejMotorku("Motorka", "1999", "Modrá", "sportovní", 2);
sprava.PridejAuto("Auto", "2014", "Bílé", 5, "Kombík");
sprava.PridejAuto("Auto", "1995", "Zelené", 3, "Brouček");

sprava.VypisVozidla();
