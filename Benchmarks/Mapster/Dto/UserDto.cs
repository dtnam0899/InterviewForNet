namespace Benchmarks.Mapster.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }

        public int ExperienceYears { get; set; }

    }
}
