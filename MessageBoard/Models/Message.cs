using System.ComponentModel.DataAnnotations;
using System;
using System.Globalization;

namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    [Required]
    [StringLength(20)]
    public string Username { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Topic must be less than 50 characters.")]
    public string Topic { get; set; }
    [Required]
    public string MessageBody { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "0:MM/dd/yyyy")]
    public DateTime PostDate { get; set; }
  }
}