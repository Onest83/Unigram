// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockAnchor : TLPageBlockBase 
	{
		public String Name { get; set; }

		public TLPageBlockAnchor() { }
		public TLPageBlockAnchor(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockAnchor; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Name = from.ReadString();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xCE0D37B0);
			to.Write(Name);
			if (cache) WriteToCache(to);
		}
	}
}