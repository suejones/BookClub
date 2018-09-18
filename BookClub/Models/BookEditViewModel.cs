using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookClub.Models
{
    public class BookEditViewModel : BookCreateViewModel
    {
        [Required(ErrorMessage = "Indicate BookClub Member Name.")]
        [StringLength(55, ErrorMessage = "BookClub Member Name cannot be longer than 55 characters.")]
        [Display(Name = "BookClub Member name")]
        public string BookClubMemberName { get; set; }   /*??*/

        [Required]
        [Display(Name = "BookClub Member ID")]
        public int BookClubMemberId { get; set; }
    }
}