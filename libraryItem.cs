using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }

    public abstract void CheckOut();
    public abstract void CheckIn();
}
public class Book : LibraryItem
{
    public string ISBN { get; set; }
    public string Genre { get; set; }

    public override void CheckOut()
    {

    }

    public override void CheckIn()
    {

    }
}
public class DVD : LibraryItem
{
    public string Director { get; set; }
    public int Runtime { get; set; }

    public override void CheckOut()
    {

    }

    public override void CheckIn()
    {

    }
}

