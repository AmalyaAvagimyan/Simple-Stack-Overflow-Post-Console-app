using System;

namespace StackOverFlowPost

{
    public class StOvPost
    {
        public int CurrentUpVotes { get; set; }
        public int CurrentDownVotes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date 
        {
            get
            { return DateTime.Now;}
        }

        public StOvPost()
        {

        }

        public StOvPost(string title)
        {
            this.Title = title;
          
        }
        public StOvPost(string title, string description)
            : this(title)

        {
            this.Description = description;
        }

        public int UpVote()
        {
            return CurrentUpVotes += 1;
           
        }

        public int DownVote()
        {
            return CurrentDownVotes += 1;
           
        }

    }
}
