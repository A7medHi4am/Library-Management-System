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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
           ILibrary NasrCity = new Library();
           ILibrary Shorouk = new Library();
            Book Invincible = new Book("Invincible", "Tom walter", "Action", 0764356, 3, NasrCity);
            Member a = new Member(0, "Mohamad", "Nasr city", 01176423364, NasrCity);
            Reservation z = new Reservation(Invincible, a, NasrCity);
            DateTime loandate = DateTime.Now;
            LoanedBook g = new LoanedBook(Invincible,a,loandate,14,NasrCity);
            z.ReservationDetails();
        }
    }

    interface ILibrary
    {
        void AddBook(Book book);
        void AddMember(Member member);
        void AddLoan(LoanedBook loan);
        void RemoveMember(Member member);
        void AddOverdue(Member member);
        void RemoveOverdue(Member member);
        void RemoveBook(Book book);
        void RemoveLoan(LoanedBook loan);
        void AddReservation(Reservation reservation);
        void RemoveReservation(Reservation reservation);
    }
    public class Library : ILibrary
    {
        int maxLoanDuration = 30; //days
        int maxBooksPerMember = 5;
        int finePerDay = 2; // fine for overdue books
        private List<Book> books;
        private List<Member> members;
        private Dictionary<Book, int> availableBooks;
        private List<LoanedBook> loans;
        private List<Member> overdueMembers;
        private List<Reservation> reservations;


        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            loans = new List<LoanedBook>();
            overdueMembers = new List<Member>();
            reservations = new List<Reservation>();
        }

         void ILibrary.AddBook(Book book)
        {
            books.Add(book);
        }
         void ILibrary.AddMember(Member member)
        {
            members.Add(member);
        }
         void ILibrary.AddLoan(LoanedBook loan)
        {
            loans.Add(loan);
        }
         void ILibrary.RemoveMember(Member member)
        {
            members.Remove(member);
        }
        void ILibrary.RemoveBook(Book book)
        {
            books.Remove(book);
        }
        void ILibrary.RemoveLoan(LoanedBook loan)
        {
            loans.Remove(loan);
        }
         void ILibrary.AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
        void ILibrary.RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
        }
        void ILibrary.AddOverdue(Member member)
        {
            overdueMembers.Add(member);
        }
        void ILibrary.RemoveOverdue(Member member)
        {
            overdueMembers.Remove(member);
        }
    }

    class Book : Library
    {
        public string Title;
        string Author;
        string Genre;
        int ISBN;
        int TotalCopies;
        bool available = true; //book exists by default when created
        public Book(string Title, string Author,string Genre, int ISBN,int TotalCopies,ILibrary library)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.ISBN = ISBN;
            this.TotalCopies = TotalCopies;

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
            book.TotalCopies = book.TotalCopies - 1;
            if(TotalCopies <= 0)
                available = false;
        }
    }
    class Member : Library
    {
        public int ID;
        public string Name;
        public string Address;
        public int Number;
        public bool isOverdue = false;
        public Member(int iD, string name, string address, int number, ILibrary library)
        {
            ID = iD;
            Name = name;
            Address = address;
            Number = number;
            library.AddMember(this);
        }
        public void DeleteMember(ILibrary library,Member member)
        {
            library.RemoveMember(member);
        }
        public void MarkAsOverdue()
        {
            isOverdue = true;
        }
    }

    class LoanedBook : Library
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool returned {  get; set; }

        public LoanedBook(Book book, Member member, DateTime loanDate, int LoanDurationDays, ILibrary library)
        {
            Book = book;
            Member = member;
            LoanDate = loanDate;
            DueDate = loanDate.AddDays(LoanDurationDays);
            returned = false; //not returned by default
            library.AddLoan(this);
            book.DecrementBook(book);

        }
        public void MarkAsReturned(ILibrary library,LoanedBook loanedBook)
        {
            loanedBook.returned = true;
            library.RemoveLoan(loanedBook);
        }
        public void checkloan(ILibrary library,Member member)
        {
            if(DateTime.Now > DueDate || !returned)
            {
                library.AddOverdue(member);
                member.isOverdue = true;
            }
            else
            {
                MessageBox.Show("No loans Overdue.");
            }
        }

    }
    class Reservation : Library 
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime ReservationDate { get; set; } 
        public bool IsActive { get; set; }
        public Reservation(Book book, Member member, ILibrary library)
        {
            Book= book;
            Member = member;
            ReservationDate = DateTime.Now;
            IsActive = true;
            book.DecrementBook(book);
            library.AddReservation(this);
        }
        public void CancelReservation(ILibrary library)
        {
            IsActive = false;
            library.RemoveReservation(this);
        }
        public void ReservationConfirmed(ILibrary library,LoanedBook loanedBook)
        {
            IsActive = false;
            library.AddLoan(loanedBook);
            library.RemoveReservation(this);
        }
        public string ReservationDetails()
        {
            return $"Reserved Book : {Book.Title}, Reserving Member : {Member.Name}";
        }
        public bool IsReservationValid()
        {
            return IsActive;
        }
    
    
    
    }
    //Fee Calculator
    public interface Pricing
    {
        decimal CalculateLateFee(int daysLate);
        decimal CalculateMembershipFee();
        decimal CalculateRentalFee(int daysRented);
    }

    public class BookPricing : Pricing
    {
        private decimal lateFeePerDay = 0.50m;
        private decimal membershipFee = 10.00m;
        private decimal rentalFeePerDay = 1.00m;

        public decimal CalculateLateFee(int daysLate)
        {
            return lateFeePerDay * daysLate;
        }

        public decimal CalculateMembershipFee()
        {
            return membershipFee;
        }

        public decimal CalculateRentalFee(int daysRented)
        {
            return rentalFeePerDay * daysRented;
        }
    }

    public class DVDPricing : Pricing
    {
        private decimal lateFeePerDay = 1.00m;
        private decimal membershipFee = 15.00m;
        private decimal rentalFeePerDay = 2.00m;

        public decimal CalculateLateFee(int daysLate)
        {
            return lateFeePerDay * daysLate;
        }

        public decimal CalculateMembershipFee()
        {
            return membershipFee;
        }

        public decimal CalculateRentalFee(int daysRented)
        {
            return rentalFeePerDay * daysRented;
        }
    }



}