namespace Entities
{
    public enum ApplicationState
    {
        PENDING,
        APPROVED,
        REJECTED,
        IN_REVIEW,
        CANCELLED
    }

    public class Application
    {
        public int Id { get; set; }
        public int ApplicantId { get; set; }
        public int BootcampId { get; set; }
        public ApplicationState ApplicationState { get; set; }
    }
}
