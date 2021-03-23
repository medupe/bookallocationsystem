using System.Collections.Generic;

namespace bookallocationsystem.Models.Learners
{
    public class LearnerViewIndex
    {
                public LearnerViewIndex()
        {
            this.LearnerList=new  List<Learner>();
        }
        public List<Learner> LearnerList { get; set; }
        
        
    }
}