namespace ITNiels.FluentSlackClient
{
	public class SlackElementBlockType : SlackBaseType
	{
		private SlackElementBlockType(string value) : base(value) { }

		public static SlackElementBlockType AsButton => new SlackElementBlockType("button");
		public static SlackElementBlockType AsCheckboxes => new SlackElementBlockType("checkboxes");
		public static SlackElementBlockType AsDatepicker => new SlackElementBlockType("datepicker");
		public static SlackElementBlockType AsImage => new SlackElementBlockType("image");
		public static SlackElementBlockType AsMultiStaticSelect => new SlackElementBlockType("multi_static_select");
		public static SlackElementBlockType AsOverflow => new SlackElementBlockType("overflow");
		public static SlackElementBlockType AsPlainTextInput => new SlackElementBlockType("plain_text_input");
		public static SlackElementBlockType AsRadio_Buttons => new SlackElementBlockType("radio_buttons");
		public static SlackElementBlockType AsStaticSelect => new SlackElementBlockType("static_select");
	}
}
