using System;


namespace Library_WinForms.Domain.Entities
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }

}
