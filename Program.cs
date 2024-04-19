using System.Security.Policy;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /* // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());*/
           Library NasrCity = new Library();
           Library Shorouk = new Library();
            Book Invincible = new Book("Invincible", "Tom walter", "Action", 0764356, 3, NasrCity);
            Member a = new Member(0, "Mohamad", "Nasr city", 01176423364, NasrCity);
            Reservation z = new Reservation(Invincible, a);
        }
    }

    class Library
    {
        int maxLoanDuration = 30; //days
        int maxBooksPerMember = 5;
        int finePerDay = 2; // fine for overdue books
        private List<Book> books;
        private List<Member> members;
        private Dictionary<Book, int> availableBooks;
        private List<LoanedBook> loans;
        private List<Reservation> reservations;


        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            loans = new List<LoanedBook>();
            reservations = new List<Reservation>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void AddMember(Member member)
        {
            members.Add(member);
        }
        public void AddLoan(LoanedBook loan)
        {
            loans.Add(loan);
        }
        public void RemoveMember(Member member)
        {
            members.Remove(member);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void RemoveLoan(LoanedBook loan)
        {
            loans.Remove(loan);
        }
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }

    class Book : Library
    {
        string Title;
        string Author;
        string Genre;
        int ISBN;
        int NumberOfCopys;
        bool available = true; //book exists by default when created
        public Book(string Title, string Author,string Genre, int ISBN,int numberOfCopys,Library library)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.ISBN = ISBN;
            this.NumberOfCopys = numberOfCopys;

            library.AddBook(this);

        }
        public void checkAvailability(Book book)
        {
            if (available == true)
                Console.WriteLine("Book is available");
            else
                Console.WriteLine("Book is unavailable");
        }
        public void DecrementBook(Book book)
        {
            book.NumberOfCopys = book.NumberOfCopys - 1;
            if(NumberOfCopys <= 0)
                available = false;
        }
    }
    class Member : Library
    {
        public int ID;
        public string Name;
        public string Address;
        public int Number;
        public Member(int iD, string name, string address, int number, Library library)
        {
            ID = iD;
            Name = name;
            Address = address;
            Number = number;
            library.AddMember(this);
        }
        public void DeleteMember(Library library,Member member)
        {
            library.RemoveMember(member);
        }
        
    }

    class LoanedBook : Library
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool returned {  get; set; }

        public LoanedBook(Book book, Member member, DateTime loanDate, int LoanDurationDays, Library library)
        {
            Book = book;
            Member = member;
            LoanDate = loanDate;
            DueDate = loanDate.AddDays(LoanDurationDays);
            returned = false; //not returned by default
            library.AddLoan(this);
            book.DecrementBook(book);

        }
        public void MarkAsReturned(LoanedBook loanedBook)
        {
            loanedBook.returned = true;
            RemoveLoan(loanedBook);
        }

    }
    class Reservation : Library 
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime ReservationDate { get; set; } 
        public bool IsActive { get; set; }
        public Reservation(Book book, Member member)
        {
            Book= book;
            Member = member;
            ReservationDate = DateTime.Now;
            IsActive = true;
            book.DecrementBook(book);
        }
        public void CancelReservation()
        {
            IsActive = false;
        }
        public void ReservationConfirmed(LoanedBook loanedBook)
        {
            IsActive = false;
            AddLoan(loanedBook);
        }
        public string ReservationDetails()
        {
            return $"Reserved Book : {Book}, Reserving Member : {Member}";
        }
        public bool IsReservationValid()
        {
            return IsActive;
        }
    
    
    
    }


}