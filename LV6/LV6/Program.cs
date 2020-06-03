using System;
using System.Collections.Generic;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zadatak

            List<Note> notes = new List<Note>();

            notes.Add(new Note("Note 1", "Text 1"));
            notes.Add(new Note("Note 2", "Text 2"));
            notes.Add(new Note("Note 3", "Text 3"));

            Notebook notebook = new Notebook(notes);
            IAbstractIterator iterator = notebook.GetIterator();
            for (Note note = iterator.First(); !iterator.IsDone; note = iterator.Next())
            {
                note.Show();
            }



            //2. Zadatak

            List<Product> products = new List<Product>();

            products.Add(new Product("Product 1", 4));
            products.Add(new Product("Product 2", 7));
            products.Add(new Product("Product 3", 14));

            Box box = new Box(products);
            /*IAbstractIterator iterator = box.GetIterator();
            for (Product product = iterator.First(); !iterator.IsDone; product = iterator.Next())
            {
                Console.WriteLine(product.ToString());
            }*/


            //3. Zadatak

            ToDoItem toDoItem = new ToDoItem("Razvoj programske podrške objektno orijentiranim načelima", "Predati zadaću.", new DateTime(2020, 6, 3, 20, 00, 00));

            CareTaker careTaker = new CareTaker();
            careTaker.SetLast(toDoItem.StoreState());

            toDoItem.Rename("Predati sve labose");
            toDoItem.ChangeTask("Naučiti za predrok.");
            toDoItem.ChangeTimeDue(new DateTime(2020, 6, 5, 17, 00, 00));
            careTaker.SetLast(toDoItem.StoreState());

            toDoItem.Rename("Napraviti i predati seminar");
            toDoItem.ChangeTask("Usmeni ispit");
            toDoItem.ChangeTimeDue(new DateTime(2020, 6, 15, 22, 00, 00));
            careTaker.SetLast(toDoItem.StoreState());

            toDoItem.Rename("Učiti za ispitne rokove");
            toDoItem.ChangeTask("Položiti kolegije na ispitnim rokovima.");
            toDoItem.ChangeTimeDue(new DateTime(2020, 6, 28, 16, 59, 59));

            Console.WriteLine(toDoItem.ToString());    //ispisuje se zadnje stanje koje je dodano
            
            toDoItem.RestoreState(careTaker.GetLast());

            Console.WriteLine(toDoItem.ToString());    //ispisuje se treće stanje

            toDoItem.RestoreState(careTaker.GetLast());

            Console.WriteLine(toDoItem.ToString());    //ispisuje se drugo stanje

            toDoItem.RestoreState(careTaker.GetLast());

            Console.WriteLine(toDoItem.ToString());    //ispisuje se prvo stanje

            Console.ReadKey();


            //4. Zadatak

            BankAccount account = new BankAccount("Domagoj Voćanec", "Ulica Prva desno", 7500);

            Console.WriteLine(account.ToString());
            Memento bankAccountSave = account.Store();

            account.ChangeOwnerAddress(" Ulica Prva lijevo ");

            account.UpdateBalance(+2500);
            Console.WriteLine("\n" + account.ToString() + "\n");

            account.Restore(bankAccountSave);
            Console.WriteLine(account.ToString());

            Console.ReadKey();

        }
    }
}
