// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessagesStickersNotModified : TLMessagesStickersBase 
	{
		public TLMessagesStickersNotModified() { }
		public TLMessagesStickersNotModified(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessagesStickersNotModified; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xF1749A22);
			if (cache) WriteToCache(to);
		}
	}
}