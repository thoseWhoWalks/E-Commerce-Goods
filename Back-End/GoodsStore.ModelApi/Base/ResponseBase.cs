using System.Collections.Generic;

namespace GoodsStore.ModelApi
{
	public class ResponseBase
	{
		public bool Ok { get; set; } = true;

		public List<Error> Errors { get; } = new List<Error>();
		
		public void AddError(string message)
		{
			Ok = false;
			Errors.Add(new Error { Message = message });
		} 
	}

	public class Error
	{
		public string Message { get; set; }
	}
}
