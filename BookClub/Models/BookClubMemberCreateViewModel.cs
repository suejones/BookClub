﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace BookClub.Models
{
    public class MemberCreateViewModel
    {

        [Key]
        public int MemberID { get; set; }

        [Required(ErrorMessage = "What is your first name.")]
        [StringLength(55, ErrorMessage = "First Name cannot be longer than 25 characters.")]
        [Display(Name = "Member First Name")]
        public string MemberFirstName { get; set; }


        [Required(ErrorMessage = "What is your last name.")]
        [StringLength(55, ErrorMessage = "Last Name cannot be longer than 25 characters.")]
        [Display(Name = "Member Last Name")]
        public string MemberLastName { get; set; }

        [Required(ErrorMessage = "What is you email address?")]
        [Display(Name = "Member email address")]
        public MailAddress MemberEmail { get; set; }

        public virtual ICollection<BookClubMember> BookClubMembers { get; set; }
    }
}