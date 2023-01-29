 namespace teachers_login_news
{
    internal class UniversityBoard:Entity
	{
		public int Id { get; set; }

		public string Name { get; set; }

        public string Leader { get; set; }

		public Teachers[] _teachers { get; set; } = new Teachers[100];

        public override string ToString()
        {
            string printInfo = "";
            foreach (var item in _teachers )
            {
                if (item ==null)
                    continue;
                printInfo += item.ToString() + "\n";
            }
            return $"{Leader}\n Teachers:\n{printInfo}";

        }

    }
}

