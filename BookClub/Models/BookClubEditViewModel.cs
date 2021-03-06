﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookClub.Models
{
    public class BookClubEditViewModel : BookClubCreateViewModel
    {
        [Required(ErrorMessage = "Indicate BookClub Name.")]
        [StringLength(55, ErrorMessage = "BookClub Name cannot be longer than 55 characters.")]
        [Display(Name = "BookClub details")]
        public new string BookClubName { get; set; }   /*??*/

        [Required]
        [Display(Name = "BookClub ID")]
        public int BookClubId { get; set; }
    }
}