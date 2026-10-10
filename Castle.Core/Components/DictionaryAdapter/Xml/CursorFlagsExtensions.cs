using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x0200016B RID: 363
	public static class CursorFlagsExtensions
	{
		// Token: 0x06000ABA RID: 2746 RVA: 0x0001ACE2 File Offset: 0x00018EE2
		public static CursorFlags MutableIf(this CursorFlags flags, bool mutable)
		{
			if (!mutable)
			{
				return flags;
			}
			return flags | CursorFlags.Mutable;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001ACEC File Offset: 0x00018EEC
		public static bool IncludesElements(this CursorFlags flags)
		{
			return (flags & CursorFlags.Elements) > CursorFlags.None;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		public static bool IncludesAttributes(this CursorFlags flags)
		{
			return (flags & CursorFlags.Attributes) > CursorFlags.None;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001ACFC File Offset: 0x00018EFC
		public static bool AllowsMultipleItems(this CursorFlags flags)
		{
			return (flags & CursorFlags.Multiple) > CursorFlags.None;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001AD04 File Offset: 0x00018F04
		public static bool SupportsMutation(this CursorFlags flags)
		{
			return (flags & CursorFlags.Mutable) > CursorFlags.None;
		}
	}
}
