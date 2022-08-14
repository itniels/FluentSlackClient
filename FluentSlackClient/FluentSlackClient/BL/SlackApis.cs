using System.Threading.Tasks;
using SlackAPI;

namespace ITNiels.FluentSlackClient.BL
{
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
#pragma warning disable CS0618 // Type or member is obsolete
	public static class SlackApis
	{
		internal async static Task<PostMessageResponse> PostMessage(SlackToken token, SlackMessage message)
		{
			var client = new SlackTaskClient(token.ToString());

			return await client.PostMessageAsync(
				channelId: message.Channel.ToString(),
				text: message.Text,
				botName: message.Username,
				parse: message.Parse.Value,
				linkNames: message.LinkNames,
				//blocks: message.Blocks?.ToArray() ?? null,
				attachments: message.Attachments?.ToArray() ?? null,
				unfurl_links: message.UnfurlLinks,
				icon_url: message.IconUrl,
				icon_emoji: message.IconEmoji.ToString(),
				as_user: message.AsUser,
				thread_ts: message.ThreadTs
			);
		}
	}
}
