using System;
namespace teachers_login_news
{
    internal class Person:Entity
	{
		internal int Id { get; set; }

		internal string Firstname { get; set; }

		internal string lastname { get; set; }

		internal int Age { get; set; }

		internal DateTime EntryDate { get; set; }

        public override string ToString()
        {
            return $"{Id} {Firstname} {lastname} ";
        }

    }
}

