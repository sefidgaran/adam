using System;
using System.Collections.Generic;
using System.Text;

namespace ADAM.Models
{
    public class LockersModel
    {
        public List<Column> Columns { get; set; }
    }
    public class Column
    {
        public List<Locker> Lockers { get; set; }
    }
    public class Locker
    {
        public string Name { get; set; }
        public int Size { get; set; }
    }
}
