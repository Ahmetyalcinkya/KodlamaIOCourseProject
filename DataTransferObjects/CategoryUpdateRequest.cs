using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObjects;

public class CategoryUpdateRequest
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
