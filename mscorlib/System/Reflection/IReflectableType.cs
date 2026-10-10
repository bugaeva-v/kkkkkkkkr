using System;

namespace System.Reflection
{
	/// <summary>Представляет тип, отражение которого можно выполнить</summary>
	// Token: 0x020008A3 RID: 2211
	public interface IReflectableType
	{
		/// <summary>Извлекает Объект, представляющий данный тип.</summary>
		/// <returns>Объект, представляющий данный тип.</returns>
		// Token: 0x06004902 RID: 18690
		TypeInfo GetTypeInfo();
	}
}
