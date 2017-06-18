// <auto-generated/>
using System;

namespace Telegram.Api.TL.Auth.Methods
{
	/// <summary>
	/// RCP method auth.cancelCode.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAuthCancelCode : TLObject
	{
		public String PhoneNumber { get; set; }
		public String PhoneCodeHash { get; set; }

		public TLAuthCancelCode() { }
		public TLAuthCancelCode(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AuthCancelCode; } }

		public override void Read(TLBinaryReader from)
		{
			PhoneNumber = from.ReadString();
			PhoneCodeHash = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x1F040578);
			to.Write(PhoneNumber);
			to.Write(PhoneCodeHash);
		}
	}
}