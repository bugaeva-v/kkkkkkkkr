using System;

namespace System.Runtime
{
	/// <summary>Указывает, что наборы исправлений, скорее всего, не повлияют на метод библиотеки классов платформы .NET Framework, к которому применяется этот атрибут, поэтому его можно встраивать в образы генератора образов в машинном коде (NGen).</summary>
	// Token: 0x0200054D RID: 1357
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class TargetedPatchingOptOutAttribute : Attribute
	{
		/// <summary>Получает причину, по которой метод, к которому применяется данный атрибут, считается доступным для встраивания в образы генератора образов в машинном коде (NGen).</summary>
		/// <returns>Причина, по которой метод, к которому применяется атрибут, считается доступным для встраивания в образы NGen.</returns>
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x000C1F8C File Offset: 0x000C018C
		public string Reason { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.TargetedPatchingOptOutAttribute" />.</summary>
		/// <param name="reason">Причина, по которой метод, к которому применяется атрибут <see cref="T:System.Runtime.TargetedPatchingOptOutAttribute" />, считается доступным для встраивания в образы генератора образов в машинном коде (NGen).</param>
		// Token: 0x060035AA RID: 13738 RVA: 0x000C1F94 File Offset: 0x000C0194
		public TargetedPatchingOptOutAttribute(string reason)
		{
			this.Reason = reason;
		}
	}
}
