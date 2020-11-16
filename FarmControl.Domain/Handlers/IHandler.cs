namespace FarmControl.Domain.Handlers
{
	public interface IHandler<T, TDto>
	{
		public void Update(TDto entity);
		public void Add(TDto entity);
		public void Delete(TDto entity);
	}
}
