using System.Collections.Generic;

namespace bookallocationsystem.Models.Allocation
{
    public class AllocateViewIndex
    {
        public AllocateViewIndex()
        {
            this.AllocationList = new List<Allocate>();
        }
        public List<Allocate> AllocationList { get; set; }


    }
}