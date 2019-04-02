using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace BigSchool.Models
{
    public class Following
    {
        [key]
        [Column(Order =1)]
        public string FollowerId { get; set; }

        [key]
        [Column(Order = 2)]
        public string FolloweeId { get; set; }
        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followee { get; set; }


    }
}