using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.TemplateMethod
{
    abstract class Education
    {
        public void Learning()
        {
            StartLearn();
            Studying();
            Exams();
            GetDocument();
        }
        protected abstract void StartLearn();
        protected virtual void Studying()
        {
            Console.WriteLine("Проходит обучение");
        }
        protected virtual void Exams()
        {
            Console.WriteLine("Сдача экзаменов");
        }
        protected abstract void GetDocument();
    }
}
