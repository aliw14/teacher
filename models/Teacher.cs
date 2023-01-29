namespace teachers_login_news
{
    internal class Teachers:Person
	{
        internal string subject { get; set; }
       
		internal string Profession { get; set; }

		internal DateTime EntryDate { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nAge:{Age}\nAd,Soyad:{Firstname} {lastname}\nsubject:{subject}\nProfession:{Profession}\nEntryDate:{EntryDate}";
        }
        public override bool Equals(object? obj)
        {
            var student = obj as Teachers;

            return student.Id == Id;
        }

       
    }
}

