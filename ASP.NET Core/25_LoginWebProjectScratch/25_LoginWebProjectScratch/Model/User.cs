namespace _25_LoginWebProjectScratch.Model
{
    public class User
    {
        public string Name {  get; set; }
        public string Password {  get; set; }

        public Gender Gender { get; set; }
    }
    public enum Gender{ Male,Female}
}
