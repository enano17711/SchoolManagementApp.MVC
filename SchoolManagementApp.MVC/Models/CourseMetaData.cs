using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class CourseMetaData
{
    [Display(Name = "Course")] public string Name { get; set; } = null!;

    [Display(Name = "Code")] public string? Code { get; set; }

    [Display(Name = "Points")] public int? Credits { get; set; }
}

[ModelMetadataType(typeof(CourseMetaData))]
public partial class Course
{
}