using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRIPATH_Auth.Models
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }

    public class Users
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid(); // UUID tự sinh

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(255)]
        public string Password { get; set; }

        [MaxLength(255)]
        public string? AvatarUrl { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(12)]
        public string? Phone { get; set; }

        [MaxLength(50)]
        public string? AddressStreet { get; set; }

        [MaxLength(50)]
        public string? AddressWard { get; set; }

        [MaxLength(50)]
        public string? AddressCity { get; set; }

        [MaxLength(50)]
        public string? AddressCountry { get; set; }

        public Gender? Gender { get; set; }

        [MaxLength(50)]
        public string? FirebaseUid { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? LastLoggedIn { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public bool PhoneVerified { get; set; } = false;

        public int RoleId { get; set; }

        public string? CompanyId { get; set; }


        [ForeignKey("RoleId")]
        public Roles Role { get; set; }

    }
}
