using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, является ли интерфейс при предоставлении COM сдвоенным, диспетчерским или только <see langword="IUnknown" />.</summary>
	// Token: 0x020006E7 RID: 1767
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class InterfaceTypeAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.InterfaceTypeAttribute" /> с указанным членом перечисления <see cref="T:System.Runtime.InteropServices.ComInterfaceType" />.</summary>
		/// <param name="interfaceType">Одно из значений <see cref="T:System.Runtime.InteropServices.ComInterfaceType" />, описывающих способ предоставления интерфейса клиентам COM.</param>
		// Token: 0x06004064 RID: 16484 RVA: 0x000E0F6E File Offset: 0x000DF16E
		public InterfaceTypeAttribute(ComInterfaceType interfaceType)
		{
			this._val = interfaceType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.InterfaceTypeAttribute" /> с указанным членом перечисления <see cref="T:System.Runtime.InteropServices.ComInterfaceType" />.</summary>
		/// <param name="interfaceType">Описывает способ предоставления интерфейса клиентам COM.</param>
		// Token: 0x06004065 RID: 16485 RVA: 0x000E0F6E File Offset: 0x000DF16E
		public InterfaceTypeAttribute(short interfaceType)
		{
			this._val = (ComInterfaceType)interfaceType;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.ComInterfaceType" />, описывающее способ предоставления интерфейса COM.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.ComInterfaceType" />, описывающее способ предоставления интерфейса COM.</returns>
		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x000E0F7D File Offset: 0x000DF17D
		public ComInterfaceType Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A33 RID: 10803
		internal ComInterfaceType _val;
	}
}
