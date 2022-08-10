namespace примеры1
{
    using System;
    // Определить структуру.
    struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;
        
        public Book(string a, string t, int c )
        {
            Author = a;
            Title = t;
            Copyright = c;
          
        }
    }
    // Продемонстрировать применение структуры Book.
    
     struct StructDemo
    {
        static void Main()
        {
            Book book1 = new Book("История Ивана Грозного",  1533); // вызов явно заданного конструктора
            Book book2 = new Book(); // вызов конструктора по умолчанию
            Book bоок3; // конструктор не вызывается
            Book book4;
            Book book5;
            Book book6;
            Book book7;
            Console.WriteLine(book1.Author + ", " + book1.Title + ", (c) " + book1.Copyright);
            Console.WriteLine();
            if (book2.Title == null)
                Console.WriteLine("Начало жизни  ивана грозного.");
            // А теперь ввести информацию в структуру book2.
            book2.Title = "Святой Иван грозный";
            book2.Author = "Иван";
            book2.Copyright = 1533;
            book4.Copyright = 1565;
            book5.Copyright = 1572;
            book6.Copyright = 1584;
            book7.Title = " смерть Ивана грозного";
            Console.Write("Вот так оно начаналось");
            Console.WriteLine(book2.Author + ", " +book2.Title + "ИВАН ГРОЗНЫЙ начало " + book2.Copyright + " событие "+ book4.Copyright + "  Начало  CВЯТАЯ опричнены " + book5.Copyright + " Закончилась святая опричнина " + book6.Copyright + " значимое событие " + book7.Title );
            Console.WriteLine();
            // Console.WriteLine(ЬоокЗ.Title); // неверно, этот член структуры
            // нужно сначала инициализировать
            bоок3.Title = "Конец";
            Console.WriteLine(bоок3.Title); // теперь верно
        }
    }
}
    

            
        
    














