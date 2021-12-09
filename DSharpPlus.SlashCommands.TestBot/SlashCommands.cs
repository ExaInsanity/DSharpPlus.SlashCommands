using System;
using System.Threading.Tasks;
using DSharpPlus.Entities;

namespace DSharpPlus.SlashCommands.TestBot
{
	public class SlashCommands : ApplicationCommandModule
	{
		#region Before / After

		public override Task<bool> BeforeSlashExecutionAsync(InteractionContext ctx)
		{
			Console.WriteLine($"Before executing the slash command '{ctx.CommandName}'");
			return Task.FromResult(true);
		}

		public override Task AfterSlashExecutionAsync(InteractionContext ctx)
		{
			Console.WriteLine($"After executing the slash command '{ctx.CommandName}'");
			return Task.FromResult(true);
		}

		#endregion

		[SlashCommand("string", "String")]
		public async Task StringCommand(InteractionContext ctx,
			[Option("string", "Required string")]
			string required,
			[Option("opt-string", "Optional string")]
			string optional = "DEFAULT_VALUE") =>
			await ctx.CreateResponseAsync($"Required: {required}\nOptional: {optional}");

		[SlashCommand("int", "Integer")]
		public async Task IntegerCommand(InteractionContext ctx,
			[Option("int", "Required int")]
			long required,
			[Option("opt-int", "Optional int")]
			long optional = long.MinValue) =>
			await ctx.CreateResponseAsync($"Required: {required}\nOptional: {optional}");

		[SlashCommand("bool", "Boolean")]
		public async Task BooleanCommand(InteractionContext ctx,
			[Option("bool", "Required bool")]
			bool required,
			[Option("opt-bool", "Optional bool")]
			bool optional = false) =>
			await ctx.CreateResponseAsync($"Required: {required}\nOptional: {optional}");

		[SlashCommand("user", "User")]
		public async Task UserCommand(InteractionContext ctx,
			[Option("user", "Required user")]
			DiscordUser required,
			[Option("opt-user", "Optional user")]
			DiscordUser optional = null) =>
			await ctx.CreateResponseAsync($"Required: {required.Mention}\nOptional: {optional?.Mention}");

		[SlashCommand("channel", "Channel")]
		public async Task ChannelCommand(InteractionContext ctx,
			[Option("channel", "Required channel")]
			DiscordChannel required,
			[Option("opt-channel", "Optional channel")]
			DiscordChannel optional = null) =>
			await ctx.CreateResponseAsync($"Required: {required.Mention}\nOptional: {optional?.Mention}");

		[SlashCommand("role", "Role")]
		public async Task RoleCommand(InteractionContext ctx,
			[Option("role", "Required role")]
			DiscordRole required,
			[Option("opt-role", "Optional role")]
			DiscordRole optional = null) =>
			await ctx.CreateResponseAsync($"Required: {required.Mention}\nOptional: {optional?.Mention}");

		[SlashCommand("mentionable", "Mentionable")]
		public async Task MentionableCommand(InteractionContext ctx,
			[Option("mentionable", "Required mentionable")]
			SnowflakeObject required,
			[Option("opt-mentionable", "Optional mentionable")]
			SnowflakeObject optional = null) =>
			await ctx.CreateResponseAsync($"Required: {required}\nOptional: {optional}");

		[SlashCommand("number", "Number")]
		public async Task NumberCommand(InteractionContext ctx,
			[Option("number", "Required number")]
			double required,
			[Option("opt-number", "Optional number")]
			double optional = double.MinValue) =>
			await ctx.CreateResponseAsync($"Required: {required}\nOptional: {optional}");
	}
}