﻿namespace Core
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public string Gender { get; set; } = string.Empty;  
        public DateTime Birthdate { get; set; }

    }
}
