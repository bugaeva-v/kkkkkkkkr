using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, какой тип интерфейса класса должен генерироваться для класса, предоставленного модели COM, если интерфейс создан.</summary>
	// Token: 0x020006EA RID: 1770
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ClassInterfaceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" /> с указанным членом перечисления <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" />.</summary>
		/// <param name="classInterfaceType">Одно из значений <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" />, описывающее тип интерфейса, созданного для класса.</param>
		// Token: 0x06004069 RID: 16489 RVA: 0x000E0F9C File Offset: 0x000DF19C
		public ClassInterfaceAttribute(ClassInterfaceType classInterfaceType)
		{
			this._val = classInterfaceType;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ClassInterfaceAttribute" /> с заданным значением перечисления <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" />.</summary>
		/// <param name="classInterfaceType">Описывает тип интерфейса, созданного для класса.</param>
		// Token: 0x0600406A RID: 16490 RVA: 0x000E0F9C File Offset: 0x000DF19C
		public ClassInterfaceAttribute(short classInterfaceType)
		{
			this._val = (ClassInterfaceType)classInterfaceType;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" />, описывающее тип интерфейса, который должен быть создать для класса.</summary>
		/// <returns>Значение <see cref="T:System.Runtime.InteropServices.ClassInterfaceType" />, описывающее тип интерфейса, который требуется создать для класса.</returns>
		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x000E0FAB File Offset: 0x000DF1AB
		public ClassInterfaceType Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A39 RID: 10809
		internal ClassInterfaceType _val;
	}
}
