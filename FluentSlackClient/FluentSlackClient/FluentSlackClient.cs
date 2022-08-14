using ITNiels.FluentSlackClient.BL;
using SlackAPI;

namespace ITNiels.FluentSlackClient
{
	public class FluentSlackClient
	{
		private static SlackToken _token;

		public FluentSlackClient(SlackToken token)
		{
			_token = token;
		}

		public PostMessageResponse PostMessage(SlackMessage message) => SlackApis.PostMessage(_token, message).Result;
	}
}
