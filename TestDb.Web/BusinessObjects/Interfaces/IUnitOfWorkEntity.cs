using System;

namespace TestDb.BusinessObjects.Interfaces
{
	public partial interface IUnitOfWorkEntity
	{
		void SaveNew();
		void Update();
		void Delete();
	}

}
