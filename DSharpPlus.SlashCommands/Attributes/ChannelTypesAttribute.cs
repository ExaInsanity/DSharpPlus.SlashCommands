﻿using System;
using System.Collections.Generic;

namespace DSharpPlus.SlashCommands
{
	/// <summary>
	///     Defines allowed channel types for a channel parameter.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter)]
	public class ChannelTypesAttribute : Attribute
	{
		/// <summary>
		///     Allowed channel types.
		/// </summary>
		public IEnumerable<ChannelType> ChannelTypes { get; }

		/// <summary>
		///     Defines allowed channel types for a channel parameter.
		/// </summary>
		/// <param name="channelTypes">The channel types to allow.</param>
		public ChannelTypesAttribute(params ChannelType[] channelTypes)
		{
			ChannelTypes = channelTypes;
		}
	}
}