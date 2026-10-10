using System;

namespace System
{
	/// <summary>Средство синтаксического анализа, основанное на схеме NetPipe для системы Indigo.</summary>
	// Token: 0x02000164 RID: 356
	public class NetPipeStyleUriParser : UriParser
	{
		/// <summary>Создает средство синтаксического анализа, основанное на схеме NetPipe для системы Indigo.</summary>
		// Token: 0x06000991 RID: 2449 RVA: 0x0002A319 File Offset: 0x00028519
		public NetPipeStyleUriParser() : base(UriParser.NetPipeUri.Flags)
		{
		}
	}
}
