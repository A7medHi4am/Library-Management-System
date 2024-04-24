using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

class Program
{
    static void Main()
    {
        Pricing bookPricing = new BookPricing();
        Pricing dvdPricing = new DVDPricing();

        decimal lateFeeForBook = bookPricing.CalculateLateFee(5);
        decimal membershipFeeForDVD = dvdPricing.CalculateMembershipFee();
        decimal rentalFeeForDVD = dvdPricing.CalculateRentalFee(3);

        Console.WriteLine($"Late fee for book: {lateFeeForBook} EGP");
        Console.WriteLine($"Membership fee for DVD: {membershipFeeForDVD} EGP");
        Console.WriteLine($"Rental fee for DVD: {rentalFeeForDVD} EGP");

        Console.ReadLine();
    }
}

