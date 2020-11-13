using FarmControl.Domain.Repositories;
using System;

namespace FarmControl.Domain
{
	public class UnitOfWork : IDisposable
	{
		public RepoFactory RepoFactory { get; private set; }

		private FarmControlContext _context;

		internal FarmControlContext Context
		{
			get
			{
				if (_context == null)
				{
					_context = new FarmControlContext();
				}

				return _context;
			}
		}

		public UnitOfWork()
		{
			RepoFactory = new RepoFactory(this);
		}

		public void SaveChanges()
		{
			Context.SaveChanges();
		}

		public void Dispose()
		{
			Context.Dispose();
		}
	}
}
