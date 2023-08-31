using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreCurso.Model
{
    public class Person : BaseClass
    {
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

        public Person(int id, string name) : base(id, name)
        {
            var idContructor = id;
        }

    }
}