using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JIL_AIS.Models.Domain
{
    public class Member
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }

        [StringLength(30)]
        public string Middlename { get; set; }

        [StringLength(30)]
        public string CompleteAddress { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(30)]
        public string ResidenceTelNo { get; set; }

        [StringLength(15)]
        public string CivilStatus { get; set; }

        [StringLength(30)]
        public string Occupation { get; set; }

        [StringLength(30)]
        public string CellphoneNo { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public bool? IsAttendingLifeGroup { get; set; }

        [StringLength(50)]
        public string LifeGroupLeader { get; set; }

        [StringLength(15)]
        public string MembershipProfile { get; set; }
    }
}
