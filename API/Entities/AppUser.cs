namespace API.Entities

// acess 
// Public means other class can get or set from ANY CLASS
// Protected acessed from this class or any class that is nested
// private means ONLY that class can interact with it
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}