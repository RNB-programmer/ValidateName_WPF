using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateName_WPF
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}