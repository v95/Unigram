// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPrivacyValueDisallowContacts : TLPrivacyRuleBase 
	{
		public TLPrivacyValueDisallowContacts() { }
		public TLPrivacyValueDisallowContacts(TLBinaryReader from, TLType type = TLType.PrivacyValueDisallowContacts)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.PrivacyValueDisallowContacts; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.PrivacyValueDisallowContacts)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF888FA1A);
		}
	}
}