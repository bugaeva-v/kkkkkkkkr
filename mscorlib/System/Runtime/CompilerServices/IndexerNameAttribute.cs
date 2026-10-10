using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает имя, под которым индексатор известен в языках программирования, не поддерживающих индексаторы напрямую.</summary>
	// Token: 0x020007F9 RID: 2041
	[AttributeUsage(AttributeTargets.Property, Inherited = true)]
	[Serializable]
	public sealed class IndexerNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.IndexerNameAttribute" />.</summary>
		/// <param name="indexerName">Имя индексатора в том виде, в каком оно представляется в других языках программирования.</param>
		// Token: 0x0600460C RID: 17932 RVA: 0x00002050 File Offset: 0x00000250
		public IndexerNameAttribute(string indexerName)
		{
		}
	}
}
