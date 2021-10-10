using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
   public enum Garde { A, B, C, D,}
    public class Erollement
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ErollementID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Garde? Grade { get; set; }

        public Course Course {get; set;}

        public Student Student { get; set; }
    }
}
