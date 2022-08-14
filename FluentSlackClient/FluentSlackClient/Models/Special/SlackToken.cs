namespace ITNiels.FluentSlackClient
{
	public class SlackToken
	{
		private string _token;

		public SlackToken(string token)
		{
			_token = token.Trim();
		}

		/// <summary>
		/// Make it act like a string
		/// </summary>
		/// <param name="token">token value</param>
		public static implicit operator SlackToken(string token)
		{
			if (token == null)
				return null;

			return new SlackToken(token);
		}

		/// <summary>
		/// Return the token string formatted like slack requires.
		/// </summary>
		public override string ToString() => $"{_token}";
	}
}
