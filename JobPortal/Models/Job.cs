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
    public partial class Job
    {
        public Job()
        {
            this.Applied_Job = new HashSet<Applied_Job>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public int No_of_Post { get; set; }
        public string Gender { get; set; }
        public System.DateTime Start_Date { get; set; }
        public System.DateTime End_Date { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public int Position_Code { get; set; }
        public int Category_Code { get; set; }
        public int Area_Code { get; set; }
        public int Job_Shift_Code { get; set; }
        public int Salary_Range_Code { get; set; }
        public bool Experience_Ind { get; set; }
        public string Education_Req { get; set; }
        public string Job_Description { get; set; }
        public bool Job_Post_Status { get; set; }
        public int FK_Company_id { get; set; }

        public virtual ICollection<Applied_Job> Applied_Job { get; set; }
        public virtual Company Company { get; set; }
    }
}
