using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services.Description;

namespace BookClub.Models
{
    public enum GenreType { Fiction, NonFiction}
    public enum Genre { Thriller, Romance, Action, Sport, AutoBiography, History, Cookery, Health}


    public class Book
    {
        [Key]
        public int BookISBN { get; set; }

        [Required(ErrorMessage = "Book Name")]
        [StringLength(55, ErrorMessage = "Book Name cannot be longer than 25 characters.")]
        [Display(Name = "Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Author first name")]
        [StringLength(55, ErrorMessage = "Author's First Name cannot be longer than 25 characters.")]
        [Display(Name = "Author First Name")]
        public string AuthorFirstName { get; set; }


        [Required(ErrorMessage = "Author last name")]
        [StringLength(55, ErrorMessage = "Author's Last Name cannot be longer than 25 characters.")]
        [Display(Name = "Author Last Name")]
        public string AuthorLastName { get; set; }

        /*[Optional(MessagePartCollection = "Optional.")]*/
        [Range(1, 10)]
        [Display(Name = "Book Rating")]
        public int Rating { get; set; }


        public virtual ICollection<Book> Books { get; set; }

    }
}