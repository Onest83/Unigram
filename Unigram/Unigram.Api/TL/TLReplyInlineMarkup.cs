// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLReplyInlineMarkup : TLReplyMarkupBase 
	{
		public TLVector<TLKeyboardButtonRow> Rows { get; set; }

		public TLReplyInlineMarkup() { }
		public TLReplyInlineMarkup(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.ReplyInlineMarkup; } }

		public override void Read(TLBinaryReader from)
		{
			Rows = TLFactory.Read<TLVector<TLKeyboardButtonRow>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Rows);
		}
	}
}