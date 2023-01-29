using System;
namespace teachers_login_news
{
    internal interface ICrudService
	{
		void Add(Entity entity);

		void Update(int id, Entity entity,Entity entity1);

		void Delete(int id);

		Person Get(int id);

		Person[] GetAll();

	}
}

