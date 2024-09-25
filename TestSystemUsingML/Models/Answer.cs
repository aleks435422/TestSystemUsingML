using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystemUsingML.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        [Required]
        public string AnswerText { get; set; }

        [Required]
        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
    }
}
