// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Account
{
	/// <summary>
	/// RCP method account.getAccountTTL
	/// </summary>
	public partial class TLAccountGetAccountTTL : TLObject
	{
		public TLAccountGetAccountTTL() { }
		public TLAccountGetAccountTTL(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.AccountGetAccountTTL; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x8FC711D);
			if (cache) WriteToCache(to);
		}
	}
}