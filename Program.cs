while(true)
{
    Console.WriteLine();
    Console.WriteLine("Gissa ett tal mellan 1 och 100");

    Random rd = new Random();
    int rand = rd.Next(0,101);

    int input;
    int i = 0;

    while(true)
    {
        input = int.Parse(Console.ReadLine());
        
        i ++;
        if(input > rand)
        {
            Console.WriteLine("Talet är för högt");
        } else if(input < rand)
        {
            Console.WriteLine("Talet är för lågt");
        } else 
        {
            Console.WriteLine();
            Console.WriteLine("Det är rätt tal");
            Console.WriteLine("Det tog {0} försök", i);
            Console.WriteLine();
            break;
        }
        Console.WriteLine();
    }
    Console.WriteLine("vil du försöka igen?");
    string svar = Console.ReadLine();
    Console.WriteLine();
    if(svar == "Ja" || svar == "ja" || svar == ""){}
    else if(svar == "Nej" || svar == "nej")
    {
        break;
    } else 
    {
        Console.WriteLine("Jag förstår inte men jag andtar att du vil fortsätta"); Console.WriteLine();
    }
}