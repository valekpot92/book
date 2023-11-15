using System;


namespace biblioteka
{

    class program
    {

        static void Main(string[] args)
        {
           
             people klient= new people();
            klient.name = "Petr";
            klient.supername = "Ivanov";
            klient.id = 1;  
            Console.WriteLine("Имя: " + klient.name);
            Console.WriteLine("Фамилия: "+ klient.supername);
            Console.WriteLine("ID: "+ klient.id );
        book booking = new book();
            booking.author_1 = "Пушкин";
            booking.id = 236;
            booking.dolg = 3;
            Console.WriteLine("Вы взяли автора:" +booking.author_1);
            Console.WriteLine("ID: " + booking.id);
            Console.WriteLine("Ваша задолжность составляет:" + booking.dolg + "книги");

        }
        
        
    }

}
