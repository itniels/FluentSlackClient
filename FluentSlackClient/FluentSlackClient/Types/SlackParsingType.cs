namespace ITNiels.FluentSlackClient
{
	public class SlackParsingType : SlackBaseType
	{
		private SlackParsingType(string value) : base(value) { }

		public static SlackParsingType AsNone => new SlackParsingType("none");
		public static SlackParsingType AsFull => new SlackParsingType("full");
	}
}
