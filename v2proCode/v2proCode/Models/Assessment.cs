﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace v2proCode.Models
{
    public class Assessment
    {

        //Property key
        [Key]
        public int AssessmentID { get; set; }

        //textbox
        [Required(ErrorMessage = "Enter Grade")]
        public string Grade
        {
            get; set;
        }

        //start and end time
        [DataType(DataType.Time)]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Start Time:")]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "End Time:")]
        public DateTime EndTime { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date:")]
        [Required]
        public DateTime AssessmentDate { get; set; }


        [Required(ErrorMessage = "Enter Test Venue")]
        [Display(Name = "Assessment Venue")]
        public string AssessmentVenue { get; set; }


        [Required(ErrorMessage = "Select Term ")]
        public string Term { get; set; }

        //radiobutton (test,project,presentation,exam)
        [Required(ErrorMessage = "Enter Test Type")]
        [Display(Name = "Assessment Type ")]
        public string Type { get; set; }


    }
}