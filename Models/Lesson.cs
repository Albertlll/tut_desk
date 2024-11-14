using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutdesk.Models
{
    public class Lesson
    {
        public string? Id { get; set; }
        public string? Title {  get; set; }

        public List<LessonPart>? Context {  get; set; }
    }
}
