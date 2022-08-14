using System.Collections.Generic;
using System.Linq;

namespace ITNiels.FluentSlackClient
{
	public class SlackMessage
	{
		/// <summary>
		/// Contructs a new SlackMessage
		/// </summary>
		/// <param name="channel">#channel to post into</param>
		/// <param name="text">Message to post</param>
		public SlackMessage(string channel, string text = "")
		{
			Channel = channel;
			Text = text;
		}

		/// <summary>
		/// Channel, private group, or IM channel to send message to. Can be an encoded ID, or a name. See below for more details.
		/// </summary>
		[SlackRequired]
		public string Channel { get; private set; }

		/// <summary>
		/// How this field works and whether it is required depends on other fields you use in your API call. See below for more detail.
		/// </summary>
		[SlackRequired]
		public string Text { get; private set; }

		/// <summary>
		/// Pass true to post the message as the authed user, instead of as a bot. Defaults to false. See authorship below. This argument may not be used with newer bot tokens.
		/// </summary>
		public bool AsUser { get; private set; } = false;

		/// <summary>
		/// A JSON-based array of structured attachments, presented as a URL-encoded string.
		/// Obsoleted! Use blocks instead
		/// </summary>
		public List<SlackAttachment> Attachments { get; private set; }

		/// <summary>
		/// A JSON-based array of structured blocks, presented as a URL-encoded string.
		/// </summary>
		//public List<SlackBlock> Blocks { get; private set; }

		/// <summary>
		/// Emoji to use as the icon for this message. Overrides icon_url. Must be used in conjunction with as_user set to false, otherwise ignored. See authorship below. This argument may not be used with newer bot tokens.
		/// </summary>
		public string IconEmoji { get; private set; }

		/// <summary>
		/// URL to an image to use as the icon for this message. Must be used in conjunction with as_user set to false, otherwise ignored. See authorship below. This argument may not be used with newer bot tokens.
		/// </summary>
		public string IconUrl { get; private set; }

		/// <summary>
		/// Find and link channel names and usernames.
		/// </summary>
		public bool LinkNames { get; private set; }

		/// <summary>
		/// Change how messages are treated. Defaults to none. See below.
		/// </summary>
		public SlackParsingType Parse { get; private set; } = SlackParsingType.AsNone;

		/// <summary>
		/// Provide another message's ts value to make this message a reply. Avoid using a reply's ts value; use its parent instead.
		/// </summary>
		public string ThreadTs { get; private set; }

		/// <summary>
		/// Pass true to enable unfurling of primarily text-based content.
		/// </summary>
		public bool UnfurlLinks { get; private set; } = false;

		/// <summary>
		/// Set your bot's user name. Must be used in conjunction with as_user set to false, otherwise ignored. See authorship below.
		/// </summary>
		public string Username { get; private set; }

		// =========================================================
		// Fluent API
		// =========================================================

		public SlackMessage WithText(string text)
		{
			this.Text = text;

			return this;
		}

		public SlackMessage WithAsUser(bool asUser)
		{
			this.AsUser = asUser;

			return this;
		}

		public SlackMessage WithAttachment(SlackAttachment attachment)
		{
			if (Attachments == null)
				Attachments = new List<SlackAttachment>();

			this.Attachments.Add(attachment);

			return this;
		}

		public SlackMessage WithAttachments(IList<SlackAttachment> attachments)
		{
			if (Attachments == null)
				Attachments = attachments.ToList();

			this.Attachments.AddRange(attachments);

			return this;
		}

		//public SlackMessage WithBlock(SlackBlock block)
		//{
		//	if (Blocks == null)
		//		Blocks = new List<SlackBlock>();

		//	this.Blocks.Add(block);

		//	return this;
		//}

		//public SlackMessage WithBlocks(IList<SlackBlock> blocks)
		//{
		//	if (Blocks == null)
		//		Blocks = blocks.ToList();

		//	this.Blocks.AddRange(blocks);

		//	return this;
		//}

		public SlackMessage WithEmojiIcon(string emoji)
		{
			this.IconEmoji = emoji;

			return this;
		}

		public SlackMessage WithIconUrl(string iconUrl)
		{
			this.IconUrl = iconUrl;

			return this;
		}

		public SlackMessage WithLinkNames(bool linkNames)
		{
			this.LinkNames = linkNames;

			return this;
		}

		public SlackMessage WithParse(SlackParsingType type)
		{
			this.Parse = type;

			return this;
		}

		public SlackMessage WithThreadTs(string threadTs)
		{
			this.ThreadTs = threadTs;

			return this;
		}

		public SlackMessage WithUnfurlLinks(bool unfurlLinks)
		{
			this.UnfurlLinks = unfurlLinks;

			return this;
		}

		public SlackMessage WithUsername(string username)
		{
			this.Username = username;

			return this;
		}
	}
}