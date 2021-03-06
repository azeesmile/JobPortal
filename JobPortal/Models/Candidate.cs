//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobPortal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    [Bind(Exclude = "Id")]
    public partial class Candidate
    {
        public Candidate()
        {
            this.Applied_Job = new HashSet<Applied_Job>();
            this.Candidates_Address = new HashSet<Candidates_Address>();
            this.Candidates_Education = new HashSet<Candidates_Education>();
            this.Candidates_Hobbies = new HashSet<Candidates_Hobbies>();
            this.Candidates_Professional = new HashSet<Candidates_Professional>();
            this.Candidates_Skills = new HashSet<Candidates_Skills>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Father_Name { get; set; }
        public string Gender { get; set; }
        public string CNIC { get; set; }
        public System.DateTime Date_of_Birth { get; set; }
        public string Contact_No { get; set; }
        public string Email { get; set; }
        public System.DateTime Profile_Date { get; set; }
        public string Resume { get; set; }
        public bool Profile_Status_Ind { get; set; }
        public bool Is_Resume_Uploaded { get; set; }
        public int FK_Job_Applied_id { get; set; }

        public virtual ICollection<Applied_Job> Applied_Job { get; set; }
        public virtual ICollection<Candidates_Address> Candidates_Address { get; set; }
        public virtual ICollection<Candidates_Education> Candidates_Education { get; set; }
        public virtual ICollection<Candidates_Hobbies> Candidates_Hobbies { get; set; }
        public virtual ICollection<Candidates_Professional> Candidates_Professional { get; set; }
        public virtual ICollection<Candidates_Skills> Candidates_Skills { get; set; }
    }
}
