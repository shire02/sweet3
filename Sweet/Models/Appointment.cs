using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sweet.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer name ")]
        public string Date { get; set; }

        [Required(ErrorMessage = "Please enter Customer name ")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your Issue ")]
        [DataType(DataType.EmailAddress, ErrorMessage = "enter valid  email")]
        public string Email { get; set; }

        public subject Subject { get; set; }
        public string messgae { get; set; }

    }
    public enum subject
    {
        Appointment = 0,
        Message,
        other

    }
}