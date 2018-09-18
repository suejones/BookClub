using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookClub.Models
{
    public class BookListCreateViewModel
    {
        [Key]
        public int BookListID { get; set; }

        [Required(ErrorMessage = "Indicate Book List Name.")]
        [StringLength(55, ErrorMessage = "Book Club List cannot be longer than 25 characters.")]
        [Display(Name = "BookListName")]
        public string BookListName { get; set; }

        [Required]
        [Display(Name = "BookList Type")] /* enum?*/
        public string BookListType { get; set; }

        [Required(ErrorMessage = "This BookList contains....")]
        [Display(Name = "BookClub Content")]
        public string BookListContent { get; set; }
    }
}