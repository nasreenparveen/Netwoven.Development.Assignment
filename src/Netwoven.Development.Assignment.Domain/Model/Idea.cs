using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netwoven.Development.Assignment.Domain.Model
{
    internal class Idea
    {
        public int Id { get; set; }
        public string ContainerUrl { get; set; }
        public string ModificationDate { get; set; }
        public string PlaceType { get; set; }
        public string GroupType { get; set; }
        public int NoOfComments { get; set; }
        public string ContainerType { get; set; }
        public long ContainerID { get; set; }
        public string Email  { get; set; }        
        public string Userid { get; set; }
        public string IdeaSubject { get; set; }
        
        
    }
}
