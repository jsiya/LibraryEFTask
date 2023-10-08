﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFTask.Entities
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        //nav prop
        public virtual ICollection<Book> Books { get; set;}
    }
}
