﻿namespace TestWebApp.Models
{
    public class Student
    {

        public long Id { get; set; }

        public string Name { get; set; }

        public long GroupId { get; set; }

        public Group Group { get; set; }
    }
}
