using System.ComponentModel.DataAnnotations;

namespace ODataSampleApi.Data
{
    public class School
    {
        [Key]
        public int Id { get; set; }
        public string SchhoolName { get; set; } = null!;
    }
}
