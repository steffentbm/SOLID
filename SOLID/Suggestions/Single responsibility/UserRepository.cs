using System.Collections.Generic;

namespace Suggestions.Single_responsibility
{
	public class UserRepository
	{
		private IList<User> _users = new List<User>();

		public void Add(User user)
		{
			// In this example we're just storing to a list in memory, but this could be swapped out for database-, file- or any other type of storage.
			_users.Add(user);
		}
	}
}
