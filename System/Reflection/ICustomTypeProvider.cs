using System;

namespace System.Reflection
{
	/// <summary>Представляет объект, представляющий пользовательский тип.</summary>
	// Token: 0x0200087B RID: 2171
	public interface ICustomTypeProvider
	{
		/// <summary>Получает пользовательский тип, предоставленный этим объектом.</summary>
		/// <returns>Настраиваемый тип.</returns>
		// Token: 0x060044C2 RID: 17602
		Type GetCustomType();
	}
}
