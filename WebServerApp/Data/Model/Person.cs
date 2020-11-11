using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace WebApplication.Data.Model
{
    public class Person
    {
        [Required]
        public int Id { get; set; }
        [NotNull] public string FirstName { get; set; }
        [NotNull] public string LastName { get; set; }
        [ValidHairColor] public string HairColor { get; set; }
        [NotNull] [ValidEyeColor] public string EyeColor { get; set; }
        [NotNull, Range(0, 125)] public int Age { get; set; }
        [NotNull, Range(1, 250)] public float Weight { get; set; }
        [NotNull, Range(30, 250)] public int Height { get; set; }
        [NotNull] public string Sex { get; set; }

        public class ValidHairColor : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                List<string> valid = new[]
                {
                    "blond", "red", "brown", "black",
                    "white", "grey", "blue", "green", "leverpostej"
                }.ToList();
                if (valid == null || valid.Contains(value.ToString().ToLower()))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(
                    "Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
            }
        }

        public class ValidEyeColor : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                List<string> valid = new[]
                {
                    "brown", "grey", "green", "blue",
                    "amber", "hazel"
                }.ToList();
                if (valid != null && valid.Contains(value.ToString().ToLower()))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
        