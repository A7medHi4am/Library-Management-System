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

