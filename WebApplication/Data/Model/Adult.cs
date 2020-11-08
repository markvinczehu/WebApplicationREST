using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace WebApplication.Data.Model
{
    public class Adult : Person
    {
        public string JobTitle { get; set; }
    }
}