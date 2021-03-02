using System;

namespace TestDb.Web.DataObjects.Interfaces
{
	public interface IDataCriterion
	{
		string ToSql();
	}

	public interface IDataOrderBy
	{
		string ToSql();
	}

	public interface IDataSkip
	{
		string ToSql();
	}

	public interface IDataTake
	{
		string ToSql();
	}

	public interface IDataProjection
	{
		string Member { get; set; }
		string ToSql();
	}

}
