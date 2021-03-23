using System.Collections.Generic;
using System.Linq;

namespace  Bookallocationsystem.Models.Schools
{
    public class SchoolViewIndex
    {
        public SchoolViewIndex()
        {
            this.schoolList=new  List<School>();
        }
        public List<School> schoolList { get; set; }
        
        
    }
}