// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelPinnedMessage : TLUpdateBase 
	{
		public Int32 ChannelId { get; set; }
		public Int32 Id { get; set; }

		public TLUpdateChannelPinnedMessage() { }
		public TLUpdateChannelPinnedMessage(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelPinnedMessage; } }

		public override void Read(TLBinaryReader from)
		{
			ChannelId = from.ReadInt32();
			Id = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(ChannelId);
			to.WriteInt32(Id);
		}
	}
}