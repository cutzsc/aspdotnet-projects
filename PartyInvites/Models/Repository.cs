using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
	public static class Repository
	{
		private static List<GuestResponse> guestResponses = new List<GuestResponse>();

		public static IEnumerable<GuestResponse> Responses => guestResponses;

		public static void AddResponse(GuestResponse guestResponse) => guestResponses.Add(guestResponse);
	}
}
