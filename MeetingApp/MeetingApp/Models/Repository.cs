using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Models
{
	public static class Repository
	{
		private static List<UserInfo> _users = new ();
		
		static Repository()
		{
			_users.Add (new UserInfo()
			{
				Id = 1,
				Name="Batuhan",
				Email="Celebi@gmail.com",
				Phone="121212",
				WhillAttend=true,
			});
			_users.Add(new UserInfo()
			{
				Id = 2,
				Name = "Yasin",
				Email = "Yasin@gmail.com",
				Phone = "58256",
				WhillAttend = true,
			});
			_users.Add(new UserInfo()
			{
				Id = 3,
				Name = "Ali",
				Email = "Ali@gmail.com",
				Phone = "896545",
				WhillAttend = false,
			});
		}
		public static List<UserInfo> Users { get { return _users; } }

		public static void CreateUser(UserInfo user)
		{
			user.Id=Users.Count+1;
			_users.Add(user);
		}
		public static UserInfo? GetbyId(int id)
		{
			return _users.FirstOrDefault(u=>u.Id==id);//Nulldan dolayı uyarı verir ? ondan
		}
	}
}
