namespace ITNiels.FluentSlackClient
{
	public class SlackTextBlockType : SlackBaseType
	{
		private SlackTextBlockType(string value) : base(value) { }

		public static SlackTextBlockType AsPlainText() => new SlackTextBlockType("plain_text");
		public static SlackTextBlockType AsMarkDown() => new SlackTextBlockType("mrkdwn");
	}
}
