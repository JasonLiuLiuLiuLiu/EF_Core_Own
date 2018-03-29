using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_Own.Model
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Student Student { get; set; }
    }
}
