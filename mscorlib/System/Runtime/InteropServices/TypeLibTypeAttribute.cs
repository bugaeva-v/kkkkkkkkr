using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Содержит флаги <see cref="T:System.Runtime.InteropServices.TYPEFLAGS" />, ранее импортированные для данного типа из библиотеки COM-типов.</summary>
	// Token: 0x020006F9 RID: 1785
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibTypeAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="TypeLibTypeAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> для типа с атрибутом, обнаруженное в библиотеке типов, из которой выполнялся импорт.</param>
		// Token: 0x06004082 RID: 16514 RVA: 0x000E1145 File Offset: 0x000DF345
		public TypeLibTypeAttribute(TypeLibTypeFlags flags)
		{
			this._val = flags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="TypeLibTypeAttribute" /> заданным значением <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" />.</summary>
		/// <param name="flags">Значение <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> для типа с атрибутом, обнаруженное в библиотеке типов, из которой выполнялся импорт.</param>
		// Token: 0x06004083 RID: 16515 RVA: 0x000E1145 File Offset: 0x000DF345
		public TypeLibTypeAttribute(short flags)
		{
			this._val = (TypeLibTypeFlags)flags;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> для этого типа.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.TypeLibTypeFlags" /> для этого типа.</returns>
		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x000E1154 File Offset: 0x000DF354
		public TypeLibTypeFlags Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A70 RID: 10864
		internal TypeLibTypeFlags _val;
	}
}
