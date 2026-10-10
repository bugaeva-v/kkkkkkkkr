using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Определяет вид переменной.</summary>
	// Token: 0x020007BF RID: 1983
	[Serializable]
	public enum VARKIND
	{
		/// <summary>Переменная является полем или элементом типа. Она существует в фиксированном смещении в каждом экземпляре типа.</summary>
		// Token: 0x04002CB8 RID: 11448
		VAR_PERINSTANCE,
		/// <summary>Имеется только один экземпляр переменной.</summary>
		// Token: 0x04002CB9 RID: 11449
		VAR_STATIC,
		/// <summary>Структура <see langword="VARDESC" /> описывает символьную константу. Связанная с ней память отсутствует.</summary>
		// Token: 0x04002CBA RID: 11450
		VAR_CONST,
		/// <summary>Доступ к переменной может быть получен только при помощи <see langword="IDispatch::Invoke" />.</summary>
		// Token: 0x04002CBB RID: 11451
		VAR_DISPATCH
	}
}
