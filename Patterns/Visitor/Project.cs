using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Visitor
{
    class Project : IElementOfProject
    {
        List<IElementOfProject> projectsElements;

        public Project()
        {
            projectsElements = new List<IElementOfProject>()
            {
                new ProjectClass(),
                new Database(),
                new Test()
            };
        }
        public void writtenBy(IDeveloper developer)
        {
            foreach (var element in projectsElements)
            {
                element.writtenBy(developer);
            }
        }
    }
}
