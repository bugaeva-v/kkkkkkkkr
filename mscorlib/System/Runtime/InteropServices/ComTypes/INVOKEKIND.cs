using System;

namespace System.Runtime.InteropServices.ComTypes
{
	/// <summary>Задает способ вызова функции при помощи <see langword="IDispatch::Invoke" />.</summary>
	// Token: 0x020007C5 RID: 1989
	[Flags]
	[Serializable]
	public enum INVOKEKIND
	{
		/// <summary>Член, вызываемый при помощи синтаксиса вызова обычной функции.</summary>
		// Token: 0x04002CD8 RID: 11480
		INVOKE_FUNC = 1,
		/// <summary>Функция, вызываемая при помощи синтаксиса обычного доступа к свойству.</summary>
		// Token: 0x04002CD9 RID: 11481
		INVOKE_PROPERTYGET = 2,
		/// <summary>Функция, вызываемая при помощи синтаксиса присвоения значения свойству.</summary>
		// Token: 0x04002CDA RID: 11482
		INVOKE_PROPERTYPUT = 4,
		/// <summary>Функция, вызываемая при помощи синтаксиса присвоения ссылки свойству.</summary>
		// Token: 0x04002CDB RID: 11483
		INVOKE_PROPERTYPUTREF = 8
	}
}
