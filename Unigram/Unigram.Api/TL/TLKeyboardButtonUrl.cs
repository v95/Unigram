// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonUrl : TLKeyboardButtonBase 
	{
		public String Url { get; set; }

		public TLKeyboardButtonUrl() { }
		public TLKeyboardButtonUrl(TLBinaryReader from, TLType type = TLType.KeyboardButtonUrl)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonUrl; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.KeyboardButtonUrl)
		{
			Text = from.ReadString();
			Url = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x258AFF05);
			to.Write(Text);
			to.Write(Url);
		}
	}
}