using SlackAPI;

namespace ITNiels.FluentSlackClient
{
	public class SlackAttachment : Attachment
	{
		public static SlackAttachment AsBarWithText(string text, string color, string fallback = "")
		{
			return new SlackAttachment {
				text = text,
				color = color,
				fallback = !string.IsNullOrWhiteSpace(fallback) ? fallback : text,
			};
		}
	}
}
