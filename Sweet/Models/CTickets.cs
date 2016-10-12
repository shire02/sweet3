using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Sweet.Models
{
    public class CTickets
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your user name ")]
        public string UserName { get; set; }
        //jjj
        [Required(ErrorMessage = "Please enter your Email ")]
        [DataType(DataType.EmailAddress, ErrorMessage = "wrong email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Issue ")]
        public string Issue { get; set; }

        public string Description { get; set; }
        public string Date { get; set; }
        public status Status { get; set; }
    }
    public enum status
    {
        Open = 0,
        close

    }
}

   