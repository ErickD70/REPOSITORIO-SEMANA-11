using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{

    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }

        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime Enrrollments { get; set; }

        public ICollection<Erollement> erollements { get; set; }
    }
}
