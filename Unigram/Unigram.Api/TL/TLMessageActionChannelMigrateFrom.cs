// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChannelMigrateFrom : TLMessageActionBase 
	{
		public Int32 ChatId { get; set; }

		public TLMessageActionChannelMigrateFrom() { }
		public TLMessageActionChannelMigrateFrom(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.MessageActionChannelMigrateFrom; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Title = from.ReadString();
			ChatId = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xB055EAEE);
			to.Write(Title);
			to.Write(ChatId);
			if (cache) WriteToCache(to);
		}
	}
}