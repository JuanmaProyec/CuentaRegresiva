using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuentaRegresiva.Models
{
    public class city //ENTIDAD Ciudad  int, decimal, string
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }

    public class School //ENTIDAD ESCUELA int, decimal, string
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }

    public class Table //ENTIDAD  Mesa int, decimal, string
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }

}
