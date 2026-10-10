using System;

namespace System
{
	/// <summary>Настраиваемое средство синтаксического анализа на основе схемы Gopher.</summary>
	// Token: 0x02000162 RID: 354
	public class GopherStyleUriParser : UriParser
	{
		/// <summary>Создает настраиваемое средство синтаксического анализа на основе схемы Gopher.</summary>
		// Token: 0x0600098F RID: 2447 RVA: 0x0002A2F5 File Offset: 0x000284F5
		public GopherStyleUriParser() : base(UriParser.GopherUri.Flags)
		{
		}
	}
}
