﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class GroupPost
    {
        public int GroupId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }

        public Post Post { get; set; }
        public Groupp Group { get;set; }
        public User User { get;set; }
    }
}
