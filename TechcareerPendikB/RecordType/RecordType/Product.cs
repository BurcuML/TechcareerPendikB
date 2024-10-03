using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordType
{
    public record Product(string Name, string Description, string Stock, string Price, Category category);

   
}
