// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Auth
{
	public partial class TLAuthSentCodeTypeFlashCall : TLAuthSentCodeTypeBase 
	{
		public String Pattern { get; set; }

		public TLAuthSentCodeTypeFlashCall() { }
		public TLAuthSentCodeTypeFlashCall(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthSentCodeTypeFlashCall; } }

		public override void Read(TLBinaryReader from)
		{
			Pattern = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Pattern ?? string.Empty);
		}
	}
}