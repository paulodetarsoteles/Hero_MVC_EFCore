namespace Hero_MVC_EFCore.Domain.Models
{
    public class SecretIdentity
    {
        public int SecretIdentityId { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
