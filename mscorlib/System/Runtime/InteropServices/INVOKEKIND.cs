using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.INVOKEKIND" />.</summary>
	// Token: 0x02000732 RID: 1842
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.INVOKEKIND instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[Serializable]
	public enum INVOKEKIND
	{
		/// <summary>Член, вызываемый при помощи синтаксиса вызова обычной функции.</summary>
		// Token: 0x04002B7E RID: 11134
		INVOKE_FUNC = 1,
		/// <summary>Функция, вызываемая при помощи синтаксиса обычного доступа к свойству.</summary>
		// Token: 0x04002B7F RID: 11135
		INVOKE_PROPERTYGET,
		/// <summary>Функция, вызываемая при помощи синтаксиса присвоения значения свойству.</summary>
		// Token: 0x04002B80 RID: 11136
		INVOKE_PROPERTYPUT = 4,
		/// <summary>Функция, вызываемая при помощи синтаксиса присвоения ссылки свойству.</summary>
		// Token: 0x04002B81 RID: 11137
		INVOKE_PROPERTYPUTREF = 8
	}
}
