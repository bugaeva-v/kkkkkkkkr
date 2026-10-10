using System;

namespace System
{
	/// <summary>Средство синтаксического анализа на основе схемы NetTcp для системы Indigo.</summary>
	// Token: 0x02000165 RID: 357
	public class NetTcpStyleUriParser : UriParser
	{
		/// <summary>Создает средство синтаксического анализа на основе схемы NetTcp для системы Indigo.</summary>
		// Token: 0x06000992 RID: 2450 RVA: 0x0002A32B File Offset: 0x0002852B
		public NetTcpStyleUriParser() : base(UriParser.NetTcpUri.Flags)
		{
		}
	}
}
