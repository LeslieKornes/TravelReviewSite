using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime PublishedDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}