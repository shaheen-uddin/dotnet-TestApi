using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Dtos.Comment;

public class UpdateCommentRequestDto
{
    [Required]
    [MinLength(5, ErrorMessage = "The title must be 5 character length.")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MinLength(10, ErrorMessage = "The title must be 20 character length.")]
    [MaxLength(500, ErrorMessage = "The content must not be above 500 characters long.")]
    public string Content { get; set; } = string.Empty;
}
