namespace ITNiels.FluentSlackClient
{
	public class SlackLayoutBlockType : SlackBaseType
	{
		private SlackLayoutBlockType(string value) : base(value) { }

		public static SlackLayoutBlockType AsActions() => new SlackLayoutBlockType("actions");
		public static SlackLayoutBlockType AsContext() => new SlackLayoutBlockType("context");
		public static SlackLayoutBlockType AsDivider() => new SlackLayoutBlockType("divider");
		public static SlackLayoutBlockType AsFile => new SlackLayoutBlockType("file");
		public static SlackLayoutBlockType AsImage => new SlackLayoutBlockType("image");
		public static SlackLayoutBlockType AsInput => new SlackLayoutBlockType("input");
		public static SlackLayoutBlockType AsSection => new SlackLayoutBlockType("section");
	}
}
