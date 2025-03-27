using System;

class Program { 

    static void Main(string[] args) { 

        Console.Write("Введіть ім'я персонажа: ");
        string name = Console.ReadLine(); 
        
        Console.Write("Введіть расу персонажа: ");
        string race = Console.ReadLine(); 
        
        Console.Write("Введіть клас персонажа: ");
        string classPlayer = Console.ReadLine(); 
 
        int strength = 8; 
        var dexterity = 8; 
        var constitution = 8;
        var intelligence = 8;
        var wisdom = 8;
        var charisma = 8;

        int choice;
        var MAX_POINTS = 15; 
 
        var skills = 27; 

        while(skills > 0) {

            Console.WriteLine("\nПоточні характеристики:");
            Console.WriteLine($"Сила: {strength}");
            Console.WriteLine($"Спритність: {dexterity}");
            Console.WriteLine($"Конституція: {constitution}");
            Console.WriteLine($"Інтелект: {intelligence}");
            Console.WriteLine($"Мудрість: {wisdom}");
            Console.WriteLine($"Харизма: {charisma}");
            Console.WriteLine($"Залишилось очків: {skills}\n");

        

        Console.WriteLine("Куди хочете вкачати поінти?\n1.Сила \n2.Спритність \n3.Конституція \n4.Інтелект \n5.Мудрість \n6.Харизма"); 
        choice = Convert.ToInt32(Console.ReadLine());

        if(choice == 1) {

            if(strength <= 13) {

                strength = strength + 1;
                skills = skills - 1;

            }

            else if(strength < MAX_POINTS) {

                strength = strength + 1;
                skills = skills - 2;

            }
        }

        else if(choice == 2) {

            if(dexterity <= 13) {

                dexterity = dexterity + 1;
                skills = skills - 1;

            }

            else if(dexterity < MAX_POINTS) {

                dexterity = dexterity + 1;
                skills = skills - 2;

            }
        }

        else if(choice == 3) {

            if(constitution <= 13) {

                constitution = constitution + 1;
                skills = skills - 1;

            }

            else if(constitution < MAX_POINTS) {

                constitution = constitution + 1;
                skills = skills - 2;

            }
        }

        else if(choice == 4) {

            if(intelligence <= 13) {

                intelligence = intelligence + 1;
                skills = skills - 1;

            }

            else if(intelligence < MAX_POINTS) {

                intelligence = intelligence + 1;
                skills = skills - 2;

            }
        }

        else if(choice == 5) {

            if(wisdom <= 13) {

                wisdom = wisdom + 1;
                skills = skills - 1;

            }

            else if(wisdom < MAX_POINTS) {

                wisdom = wisdom + 1;
                skills = skills - 2;

            }
        }

        else if(choice == 6) {

            if(charisma <= 13) {

                charisma = charisma + 1;
                skills = skills - 1;

            }

            else if(charisma < MAX_POINTS) {

                charisma = charisma + 1;
                skills = skills - 2;

            }
        }
    }

        Console.WriteLine("\n=== Ваш персонаж ===");
        Console.WriteLine($"Ім'я: {name}");
        Console.WriteLine($"Раса: {race}");
        Console.WriteLine($"Клас: {classPlayer}");
        Console.WriteLine($"Сила: {strength}");
        Console.WriteLine($"Спритність: {dexterity}");
        Console.WriteLine($"Конституція: {constitution}");
        Console.WriteLine($"Інтелект: {intelligence}");
        Console.WriteLine($"Мудрість: {wisdom}");
        Console.WriteLine($"Харизма: {charisma}");

    }
}
