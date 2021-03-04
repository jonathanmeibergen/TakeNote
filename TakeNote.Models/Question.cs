using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.Models
{
    class Question
    {
        public string Id { get; set; }
        public Item Inquery { get; set; }
        public List<string> Answers { get; set; }
        public int AnswerIndex { get; set; }
    }
}
