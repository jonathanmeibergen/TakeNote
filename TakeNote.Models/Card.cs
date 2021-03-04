using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeNote.Models
{
    class Card
    {
        public string Id { get; set; }
        public Item FrontFace { get; set; }
        public Item BackFace { get; set; }
    }
}
