using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADHD.Models.Disorder
{
    public enum QuestionType
    {
        CheckBox,
        RadioButton,
        Text
    }
    public record Question
    {
        public int Id { get; init; }
        public string Description { get; init; }
        public QuestionType QuestionType{ get; set; }
        public List<QuestionOption> QuestionOptions { get; set; }
        public List<SymptomQuestion> SymptomQuestions { get; set; }
    }
}
