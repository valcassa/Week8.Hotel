using ManageFunds.Core.Models;
using ManageFunds.EF.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageFunds.Client
{
    public class Menu
    {
        private static MainBL mainBL = new MainBL(new EFExpensesRepository(), new EFCategoriesRepository());

        internal static void Start()
        {
            Console.WriteLine("***AVVIO****");

            char choice;

            do
            {
                Console.WriteLine("1- Inserisci nuova spesa");
                Console.WriteLine("2 - Approva le spese esistenti");
                Console.WriteLine("3 - Cancella tutte le spese");
                Console.WriteLine("4 - Elenco spese approvate");
                Console.WriteLine("5 - Elenco spese Utente");
                Console.WriteLine("Premi Q per uscire");

                choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        //Aggiungi libro
                        AddNewExpenses();
                        Console.WriteLine();
                        break;
                    case '2':
                        //elimina libro
                        DeleteExpenses();
                        Console.WriteLine();
                        break;
                    case '3':
                        //visualizzare tutti i libri
                        ShowExpenses();
                        Console.WriteLine();
                        break;
                    case '4':
                        //modificare la quantità di un libro
                        UpdateExpenses();
                        Console.WriteLine();
                        break;
                    case '5':
                        //visualizzare i libri di uno scaffale
                        FetchExpensesByApproved();
                        Console.WriteLine();
                        break;
                    case 'Q':
                        return;
                    default:
                        Console.WriteLine("Scelta non disponibile");
                        break;
                }
            }
            while (!(choice == 'Q'));
        }
        private static void FetchExpensesByApproved()
        {
            string code;
            Console.WriteLine("Quale spesa vuoi modificare?");
            ShowExpenses();
            do
            {
                Console.Write("Inserisci l'id della spesa:");
                code = Console.ReadLine();
            }
            while (code.Length == 0 && code.Length > 6);

            var chosenExpenses = GetExpensesByCode(code);

            if (chosenExpenses != null)
            {
                var expensesNotApproved = mainBL.FetchExpensesByApproved(chosenExpenses);

                foreach (var e in expensesNotApproved)
                {
                    Console.WriteLine($"Data: { e.Date} Descrizione: { e.Description} Utente: { e.User} " +
                      $"Importo: { e.Amount} Categoria: { e.Categories}");
                }
            }
            else
                Console.WriteLine("Non ci sono spese con questo codice");
        }


        private static Expenses GetExpensesByCode(string code)
        {
            var expenses = mainBL.GetByCode(code);

            return expenses;
        }
   
        private static void ShowExpenses()
        {
            var expenses = mainBL.FetchExpenses();

            if (expenses.Count != 0)
            {
                Console.WriteLine("Spese memorizzate");
                foreach (var e in expenses)
                {
                    Console.WriteLine($"Data: { e.Date} Descrizione: { e.Description} Utente: { e.User} " +
                                 $"Importo: { e.Amount} Categoria: { e.Categories}");
                }
            }
            else
            {
                Console.WriteLine("\nNon ci sono spese registrate");
            }
        }

        private static void UpdateQuantity()
        {
            int id;

            Console.WriteLine("Digita il codice della spesa da modificare");
            ShowExpenses();
            do {

                Console.Write("Inserisci il codice della spesa:");
                Int32.TryParse(Console.ReadLine(), out id);
            } while ();
            
            var expenseToUpdate = GetExpensesByCode(id);

           
                expenseToUpdate.ExpensesId = id;
                mainBL.UpdateExpenses(expenseToUpdate);
        }
               else
            {
                Console.WriteLine("\nNon ci sono spese registrate");
            }


        private static void DeleteExpenses()
        {
            int id;
            Console.WriteLine("Digita il codice ISBN del libro che vuoi eliminare");
            ShowExpenses();

        ShowExpenses();
        do
        {

            Console.Write("Inserisci il codice della spesa:");
            Int32.TryParse(Console.ReadLine(), out id);
        }
            while (isbn.Length != 10);

            var bookToDelete = GetBookByISBN(isbn);

            if (bookToDelete != null)
            {
                mainBL.DeleteBook(bookToDelete);
            }
            else
            {
                Console.WriteLine("Non c'è un libro in magazzino con questo codice ISBN");
            }
        }

        private static Expense GetExpenseById(int ExpenseId)
        {
            var expense = mainBL.GetById(isbn);

            return book;
        }

        public static void AddNewBook()
        {
            //interazione con utente
            string title, author;
            string isbn;

            do
            {
                Console.Write("Inserisci il codice ISBN di 10 cifre:");
                isbn = Console.ReadLine();
            }
            while (isbn.Length != 10);

            if (GetBookByISBN(isbn) == null)
            {
                do
                {
                    Console.Write("Inserisci il titolo:");
                    title = Console.ReadLine();
                }
                while (title.Length == 0);

                do
                {
                    Console.Write("Inserisci l'autore:");
                    author = Console.ReadLine();
                } while (author.Length == 0);

                Console.Write("Inserisci la quantità che sarà disponibile in magazzino:");
                int quantity = 0;
                while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
                {
                    Console.WriteLine("Devi inserire un valore valido");
                }

                Shelf shelf;
                do
                {
                    Console.WriteLine("Inserisci il codice dello scaffale in cui posizionare il libro");
                    ShowShelves(); //mostra tutti i codici degli scaffali
                    string code = Console.ReadLine();

                    //Recupero lo scaffale con il codice inserito 
                    //Se esiste, ok. Altrimenti mi richiede di inserire il codice
                    shelf = GetExpensesByCode(code);
                }
                while (shelf == null);

                Book newBook = new Book
                {
                    ISBN = isbn,
                    Title = title,
                    Author = author,
                    Quantity = quantity,
                    Shelf = shelf
                };

                mainBL.AddBook(newBook);

                //Console.WriteLine($"Libro aggiunto. ISBN: {newBook.ISBN} " +
                //    $"Titolo: {newBook.Title} Autore: {newBook.Author}" +
                //    $" Quantità: {newBook.Quantity} Scaffale: {newBook.Shelf.Code}");
            }
            else
            {
                Console.WriteLine("Esiste già un libro con questo ISBN in magazzino");
            }
        }

        private static Expenses GetExpensesByCode(int id)
        {
            var expenses = mainBL.GetByCode(id);

            return expenses;
        }

    
        }
    }
}
}
