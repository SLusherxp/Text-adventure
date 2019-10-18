using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myadventure : MonoBehaviour
{
    private enum states
    {
        Mainmenu,
        StartIntro,
        Controls,
        credits,
        Verhaal,
        keuze1,
        ja1,
        nee1,
        ja2,
        nee2,
        overleefd,
        dood,

    }

    private states currentState = states.Mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case states.Mainmenu:
                if (input == "start")
                {
                    StartIntro();
                }
                else if (input == "controls")
                {
                    Controls();
                }

                else if (input == "credits")
                {
                    credits();
                }

                else
                {
                    MainMenu();
                }
                break;

            case states.Controls:
                if (input == "back")
                {
                    MainMenu();

                }
                else
                {
                    Controls();
                }
                break;

            case states.credits:
                if (input == "back")
                {
                    MainMenu();
                }
                else
                {
                    credits();
                }
                break;

            case states.StartIntro:
                if (input == "verder")
                {
                    Verhaal();
                }
                else
                {
                    StartIntro();
                }
                break;

            case states.Verhaal:
                if (input == "verder")
                {
                    Keuze1();
                }
                else
                {
                    Verhaal();
                }
                break;

            case states.keuze1:
                if (input == "ja")
                {
                    ja1();
                }
                else if (input == "nee")
                {
                    nee1();
                }
                else
                {
                    Keuze1();
                }
                break;

            case states.nee1:
                if (input == "overnieuw")
                {
                    MainMenu();
                }
                else
                {
                    nee1();
                }
                break;

            case states.ja1:
                if (input == "ja")
                {
                    ja2();
                }
                else if (input == "nee")
                {
                    nee2();
                }
                else
                {
                    ja1();
                }
                break;

            case states.ja2:
                if (input == "nee")
                {
                    overleefd();
                }
                else if (input =="ja")
                {
                    dood();
                }
                else
                {
                    ja2();
                }
                break;

            case states.nee2:
                if (input =="overnieuw")
                {
                    MainMenu();
                }
                else
                {
                    nee2();
                }
                break;

            case states.overleefd:
               if (input =="mainmenu")
                {
                    MainMenu();
                }
               else
                {
                    overleefd();
                }
                break;

            case states.dood:
                if (input =="overnieuw")
                {
                    MainMenu();
                }
               else
                {
                    dood();
                }
                break;






        }


    }

    void MainMenu()
    {
        currentState = states.Mainmenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("         Welkom bij Ravager!     ");
        Terminal.WriteLine("");
        Terminal.WriteLine(" controls      start        credits");
        Terminal.WriteLine("");
        Terminal.WriteLine("        typ waar je heen wil!    ");

    }

    void credits()
    {
        currentState = states.credits;
        Terminal.ClearScreen();
        Terminal.WriteLine("Dit Spel is Gemaakt door:");
        Terminal.WriteLine("      Jaimy Dekker      ");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ Back om terug te gaan.");

    }

    void Controls()
    {
        currentState = states.Controls;
        Terminal.ClearScreen();
        Terminal.WriteLine("De Controls zijn makkelijk.");
        Terminal.WriteLine("je typt gewoon het gekozen andtwoord om door te gaan.");
        Terminal.WriteLine("typ back om terug te gaan");

    }
    void StartIntro()
    {
        currentState = states.StartIntro;
        Terminal.ClearScreen();
        Terminal.WriteLine("Weet u heel zeker");
        Terminal.WriteLine("dat u dit spel wilt spelen?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ Verder om door te gaan");
    }

    void Verhaal()
    {
        currentState = states.Verhaal;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent op een zwaarverdiende vakantie naar The Great Oak Sherwood Forest.");
        Terminal.WriteLine("Op het moment dat je de auto parkeert");
        Terminal.WriteLine("merk je dat dit bos een apart");
        Terminal.WriteLine("gevoel geeft…");
        Terminal.WriteLine("Je nadert een bospad");
        Terminal.WriteLine("en loopt het pad af.");
        Terminal.WriteLine("Aan het eind van het pad heb je wat");
        Terminal.WriteLine("bosjes waar een gek geluid van komt.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ Verder om door te gaan");
    }

    void Keuze1()
    {
        currentState = states.keuze1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je nadert de bosjes");
        Terminal.WriteLine("Ga je ze checken…?");
        Terminal.WriteLine("");
        Terminal.WriteLine("         ja               nee    ");
    }
    void ja1()
    {
        currentState = states.ja1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je kijkt achter de bosjes..");
        Terminal.WriteLine("tot je verbazing ligt er een puppy");
        Terminal.WriteLine("op de grond te spelen.");
        Terminal.WriteLine("uh... misschien is ie wel van iemand..");
        Terminal.WriteLine("          ga je hem houden?           ");
        Terminal.WriteLine("      ja                    nee    ");

    }
    void nee1()
    {
        currentState = states.nee1;
        Terminal.ClearScreen();
        Terminal.WriteLine("je denkt ach wat kan");
        Terminal.WriteLine("die bosjes me boeie.");
        Terminal.WriteLine("todat je een harde brul hoort!");
        Terminal.WriteLine("OH NEE!!!! het is de Ravager!");
        Terminal.WriteLine("je bent dood.");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ overnieuw om het");
        Terminal.WriteLine("nog een keer te proberen.");
    }
    
    void ja2()
    {
        currentState = states.ja2;
        Terminal.ClearScreen();
        Terminal.WriteLine("je besluit de pup te houden");
        Terminal.WriteLine("je pakt hem op en loopt het pad terug ");
        Terminal.WriteLine("");
        Terminal.WriteLine("je hoort van verweg een brul..");
        Terminal.WriteLine("dat was geen normale wolf..");
        Terminal.WriteLine("ren je naar de auto?");
        Terminal.WriteLine("");
        Terminal.WriteLine("     ja                   nee   ");

    }
    void nee2()
    {
        currentState = states.nee2;
        Terminal.ClearScreen();
        Terminal.WriteLine("De pup vindt jouw wel leuk");
        Terminal.WriteLine("en blijft daarom achter je aan lopen");
        Terminal.WriteLine("je loopt veder het bos in");
        Terminal.WriteLine("opeens verschijnt de Ravager in het schemerige bos");
        Terminal.WriteLine("je rent in paniek weg.");
        Terminal.WriteLine("je wordt levend verslonden ");
        Terminal.WriteLine("door de Ravager.");
        Terminal.WriteLine("typ overnieuw om het");
        Terminal.WriteLine("nog een keer te proberen.");
    }
    
    void overleefd()
    {
        currentState = states.overleefd;
        Terminal.ClearScreen();
        Terminal.WriteLine("je blijft rustig op je plek staan.");
        Terminal.WriteLine("de pup in je handen probeert zich los ");
        Terminal.WriteLine("te schudden en valt op de grond");
        Terminal.WriteLine("de pup die nu op de grond is ");
        Terminal.WriteLine("rent naar de ravager.");
        Terminal.WriteLine("de ravager blijft je strak aankijken");
        Terminal.WriteLine("todat de pup bij haar is en");
        Terminal.WriteLine("samen lopen ze rustig weg");
        Terminal.WriteLine("           The End           ");
    }
    
    void dood()
    {
        currentState = states.dood;
        Terminal.ClearScreen();
        Terminal.WriteLine("je trekt een volle sprint naar je auto");
        Terminal.WriteLine("maar de Ravager is sneller");
        Terminal.WriteLine("hij verslind je levend en ");
        Terminal.WriteLine("neemt haar pup mee");
        Terminal.WriteLine("typ overnieuw om het nog een");
        Terminal.WriteLine("keer te proberen");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
