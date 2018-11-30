using Beerhall.Models.Domain;
using System;
using System.ComponentModel.DataAnnotations;

namespace Beerhall.Models.ViewModels
{
    public class BrewerEditViewModel {
        //[Required]
        //[StringLength(50)]
        public string Name { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        //[Range(0, 100000, ErrorMessage = "{0} must be between {1} and {2}")]
        public int? Turnover { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name="Enter the e-mail address", Prompt ="email address")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }
        [Display(Name="Date established")]
        [DataType(DataType.Date)]
        public DateTime? DateEstablished { get; set; }

        public BrewerEditViewModel()
        {
        }

        public BrewerEditViewModel(Brewer brewer)
        {
            Name = brewer.Name;
            Street = brewer.Street;
            PostalCode = brewer.Location?.PostalCode;
            ContactEmail = brewer.ContactEmail;
            Description = brewer.Description;
            DateEstablished = brewer.DateEstablished;
            Turnover = brewer.Turnover;
        }
    }
}
