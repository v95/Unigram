// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateUserStatus : TLUpdateBase 
	{
		public TLUserStatusBase Status { get; set; }

		public TLUpdateUserStatus() { }
		public TLUpdateUserStatus(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateUserStatus; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			UserId = from.ReadInt32();
			Status = TLFactory.Read<TLUserStatusBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x1BFBD823);
			to.Write(UserId);
			to.WriteObject(Status, cache);
			if (cache) WriteToCache(to);
		}
	}
}