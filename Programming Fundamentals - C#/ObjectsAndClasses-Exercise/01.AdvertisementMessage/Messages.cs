using System;
using System.Collections.Generic;
using System.Text;

namespace _01.AdvertisementMessage
{
	class Messages
	{
		public Messages(List<string> phrases)
		{
			Phrases = phrases;
		}

		public List<string> Phrases { get; set; }

		public string GetRandom()
		{
			Random random = new Random();
			return Phrases[random.Next(Phrases.Count)];
		}
	}
}
