using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEFTask.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        [ForeignKey("FK_StudentId")]
        public int StudentId { get; set; }
        public int BookTypeId { get; set; }
        public virtual ICollection<Author> Authors { get; set; }

        //Nav prop
        public Student Student { get; set; }
        public BookType BookType { get; set; }
    }
}
