using AutoMapper;
using GoodsStore.Data;
using GoodsStore.ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;

namespace GoodsStore.Services
{
	public class UserService : ModelServiceBase<UserModelApi, Guid>
	{
		public UserService(GoodsStoreContext goodsStoreContext) : base(goodsStoreContext)
		{
		}

		public override UserModelApi Get(Guid id)
		{
			return AutoMapperConfig.Mapper.Map<UserModelApi>(_goodsStoreContext.Users.FirstOrDefault(u => u.Id == id));
		}

		public override ICollection<UserModelApi> GetAll()
		{
			return AutoMapperConfig.Mapper.Map<List<UserModelApi>>(_goodsStoreContext.Users);
		}

		public override UserModelApi Update(UserModelApi model)
		{
			var res = _goodsStoreContext.Users.FirstOrDefault(u => u.Id == model.Id);
			 
			res.FirstName = model.FirstName;
			res.LastName = model.LastName;
			res.Gender = model.Gender; 
			res.IsDeleted = model.IsDeleted;

			_goodsStoreContext.SaveChanges();

			return Get(res.Id);
		}

		public override UserModelApi Create(UserModelApi model)
		{
			var newUser = AutoMapperConfig.Mapper.Map<User>(model);

			newUser.Id = Guid.NewGuid();

			newUser.HashPassword = Crypto.HashPassword(model.Password);

			_goodsStoreContext.Users.Add(newUser);
			_goodsStoreContext.SaveChanges();

			return Get(newUser.Id);
		}

		public override bool Delete(Guid Id)
		{
			var res = _goodsStoreContext.Users.FirstOrDefault(u => u.Id == Id);

			res.IsDeleted = true;

			_goodsStoreContext.SaveChanges();

			var IsSucces = Get(res.Id);

			return IsSucces==null?false:true;
		}

		public UserModelApi VerifyUser(string email,string password)
		{
			var res = _goodsStoreContext.Users.FirstOrDefault(u => u.Email == email);


			if (res!=null&&Crypto.VerifyHashedPassword(res.HashPassword, password))
			{
				return AutoMapperConfig.Mapper.Map<UserModelApi>(res);
			}
			else
				return null;
		}
	}
}
