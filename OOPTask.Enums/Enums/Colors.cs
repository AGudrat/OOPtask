using System.ComponentModel.DataAnnotations;

namespace OOPTask.Enums.Enums
{
    public enum Colors : byte
    {
        [Display(Name = "#d50000")]
        Red = 1,
        [Display(Name = "#aa00ff")]
        Purple = 2,
        [Display(Name = "#004d40")]
        Green = 3,
    }

}
