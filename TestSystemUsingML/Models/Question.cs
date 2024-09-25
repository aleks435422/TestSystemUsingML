using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystemUsingML.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Test")]
        public int TestId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }

        public Test Test { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}
