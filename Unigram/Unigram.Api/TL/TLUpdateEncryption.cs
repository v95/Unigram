// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateEncryption : TLUpdateBase 
	{
		public TLEncryptedChatBase Chat { get; set; }

		public TLUpdateEncryption() { }
		public TLUpdateEncryption(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdateEncryption; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Chat = TLFactory.Read<TLEncryptedChatBase>(from, cache);
			Date = from.ReadInt32();
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xB4A2E88D);
			to.WriteObject(Chat, cache);
			to.Write(Date);
			if (cache) WriteToCache(to);
		}
	}
}