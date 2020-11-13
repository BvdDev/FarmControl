namespace FarmControl.Domain.Handlers
{
	public interface IHandler<T> where T : class
	{
		public void Update(T entity);
		public void Add(T entity);
		public void Delete(T entity);
	}
}
