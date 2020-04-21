using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_Design.Models;

namespace Database_Design.Interfaces
{
    public class ICategoryRepository
    {
        IEnumerable<Category>Categories { get; }
    }
}
