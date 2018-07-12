using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodsStore.Mock
{
	public static class MockString
	{
		private static List<string> FirstNames = new List<string> {"Marc","Frank","Bill","Illon"};
		private static List<string> LastNames = new List<string> { "Zuckerberg", "Zayne", "Geyets", "Mask" };
		private static List<string> Emails = new List<string> { "some@mail.com", "example@mail.com", "try@mail.com", "catch@mail.com" };
		private static List<string> Titles = new List<string> { "The Best Product", "The Best Ever Product", "Great Product", "The Greatest Product" };
		private static List<string> Descriptions = new List<string> { "Yes, this is the best product","Some product description",
																		"Lorem ipsu, dolo sit amet", "Alrem init yren solot" };
		private static List<string> Notations = new List<string> {"This product was bought yesterday", "Some notation to the bought","Another notation to the order",
																		"Last one but not least notation"};

		public static string GetFirstName() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetLastName() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetEmail() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetTitle() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetDescription() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetNotation() => FirstNames.OrderBy(x => Guid.NewGuid()).First();
		public static string GetPassword() => "123456";
	}
}
