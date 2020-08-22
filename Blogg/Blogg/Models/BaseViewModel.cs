using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogg.Models
{
    public class BaseViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
