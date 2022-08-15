using System;


namespace ConsoleApp2
{
     class Program
    {
        #region Book Structure
         struct Book
        {
            private int bookId;
            private string title;
            private double price;
            private int bookType;


            public int BookId { get { return this.bookId; } set { this.bookId = value; } }
            public string Title { get { return this.title; } set { this.title = value; } }
            public double Price { get { return this.price; } set { this.price = value; } }
            public int BookType { get { return (int)this.bookType; } set { this.bookType = value; } }
        }
        #endregion

        #region Enum for Book Type
        private enum BookTypeEnum
        {
            Magazine = 1,
            Novel,
            ReferenceBook,
            Miscellaneous
        }
        #endregion

        #region Get Book Type In String Method
        private static string GetBookType(ref Book book)
        {
            string bookType = null;

            Console.WriteLine("This " + book.BookType);


            switch (book.BookType)
            {
                case (int)BookTypeEnum.Magazine:
                    bookType = "Magazine";
                    break;

                case (int)BookTypeEnum.Novel:
                    bookType = "Novel";
                    break;

                case (int)BookTypeEnum.ReferenceBook:
                    bookType = "Reference Book";
                    break;

                case (int)BookTypeEnum.Miscellaneous:
                    bookType = "Miscellaneous";
                    break;

                default:
                    Console.WriteLine("Enter a Valid type");
                    break;
            }
            return bookType;
        }
        #endregion

        #region Get Valid integer Method
        private static int GetValidInteger(string msg = null)
        {
            int value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid integer number");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occurred");
            }
            return value;
        }
        #endregion

        #region Get Valid Double Method
        private static double GetValidDouble(string msg = null)
        {
            double value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid integer number..");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
            return value;
        }
        #endregion

        #region Set Book Details Method
        public static bool SetBookDetails(ref Book book, int id)
        {
            book.BookId = id;

            Console.Write("Enter Book Title: ");
            book.Title = Console.ReadLine();

            book.Price = Program.GetValidDouble("Enter Book Price (Rs.): ");
            int type = Program.GetValidInteger("\n1.Magazine\n2.Novel\n3.Reference Book\n4.Miscellaneous\nBook Type:");
            if (type > 0 && type < 5)
            {
                book.BookType = type;
            }
            else
            {
                Console.WriteLine("Something went Wrong...Insert again...");
                return false;
            }

            Console.WriteLine("\nSuccessfully Inserted...");
            return true;
        }
        #endregion

        #region Display Book Details Method
        public static void DisplayBookDetails(ref Book[] books)
        {
            try
            {
                for (int i = 0; i < books.Length; i++)
                {
                    Console.WriteLine("\nBook Details {0}", books[i].BookId);
                    Console.WriteLine("Book Id: {0}", books[i].BookId);
                    Console.WriteLine("Book Title: {0}", books[i].Title);
                    Console.WriteLine("Book Price: {0}", books[i].Price);
                    Console.WriteLine("Book Type: {0}", Program.GetBookType(ref books[i]));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                int size = Program.GetValidInteger("Enter the number of Books: ");
                Book[] book = new Book[size];

                for (int n = 0; n < size; n++)
                {
                    Console.WriteLine("\nEnter Book Details No {0}", n + 1);
                    book[n] = new Book();
                    if (!Program.SetBookDetails(ref book[n], n + 1))
                    {
                        n--;
                    }



                }

                Program.DisplayBookDetails(ref book);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
            
        }
        #endregion
    }
}