// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdatesChannelDifferenceTooLong : TLUpdatesChannelDifferenceBase, ITLReadMaxId 
	{
		[Flags]
		public enum Flag : Int32
		{
			Final = (1 << 0),
			Timeout = (1 << 1),
		}

		public override bool IsFinal { get { return Flags.HasFlag(Flag.Final); } set { Flags = value ? (Flags | Flag.Final) : (Flags & ~Flag.Final); } }
		public bool HasTimeout { get { return Flags.HasFlag(Flag.Timeout); } set { Flags = value ? (Flags | Flag.Timeout) : (Flags & ~Flag.Timeout); } }

		public Flag Flags { get; set; }
		public Int32 TopMessage { get; set; }
		public Int32 ReadInboxMaxId { get; set; }
		public Int32 ReadOutboxMaxId { get; set; }
		public Int32 UnreadCount { get; set; }
		public TLVector<TLMessageBase> Messages { get; set; }

		public TLUpdatesChannelDifferenceTooLong() { }
		public TLUpdatesChannelDifferenceTooLong(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UpdatesChannelDifferenceTooLong; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Flags = (Flag)from.ReadInt32();
			Pts = from.ReadInt32();
			if (HasTimeout) Timeout = from.ReadInt32();
			TopMessage = from.ReadInt32();
			ReadInboxMaxId = from.ReadInt32();
			ReadOutboxMaxId = from.ReadInt32();
			UnreadCount = from.ReadInt32();
			Messages = TLFactory.Read<TLVector<TLMessageBase>>(from, cache);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from, cache);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			UpdateFlags();

			to.Write(0x410DEE07);
			to.Write((Int32)Flags);
			to.Write(Pts);
			if (HasTimeout) to.Write(Timeout.Value);
			to.Write(TopMessage);
			to.Write(ReadInboxMaxId);
			to.Write(ReadOutboxMaxId);
			to.Write(UnreadCount);
			to.WriteObject(Messages, cache);
			to.WriteObject(Chats, cache);
			to.WriteObject(Users, cache);
			if (cache) WriteToCache(to);
		}

		private void UpdateFlags()
		{
			HasTimeout = Timeout != null;
		}
	}
}