using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netwoven.Development.Assignment.Domain.Model
{
    internal class Inventory
    {
        public int Id { get; set; }
        public string PlaceType { get; set; }
        public string ContainerType { get; set; }
        public long ContainerID { get; set; }
        public string DisplayName { get; set; }
        public string ContainerUrl { get; set; }
        public string Status { get; set; }
        public string CreationDate { get; set; }
        public string ModificationDate { get; set; }
        public string GroupType { get; set; }
        public int DiscussionCount { get; set; }
        public int TotalDocumentCount { get; set; }
        public int CollaborativeDocument { get; set; }
        public int BinaryDocument { get; set; }
        public int EventsCount { get; set; }
        public int IdeaCount { get; set; }
        public int VideoCount { get; set; }
        public int ProjectCount { get; set; }
        public int TaskCount { get; set; }
        public int PollCount { get; set; }
        public int BlogCount { get; set; }
        public int AttachmentCount { get; set; }
        public long AttachmentSize { get; set; }
        public int ImageCount { get; set; }
        public int ImazeSize { get; set; }
        public int BinaryCount { get; set; }
        public long BinarySize { get; set; }
        public int CollabCount { get; set; }
        public int VideoSizeKb { get; set; }
        public int VideoSizeMb { get; set; }
        public int PlaceSizeMb { get; set; }
        public int PlaceSizeGb { get; set; }
        public string Admins { get; set; }
        public string TopContributors { get; set; }
        public string? LastActivityDate { get; set; }
        public string? LastActivityDatefromAnalytics { get; set; }
        public string PlaceswithContent { get; set; }
    }
}
