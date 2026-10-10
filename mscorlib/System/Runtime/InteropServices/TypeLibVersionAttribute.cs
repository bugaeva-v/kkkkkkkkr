using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Задает номер версии экспортированной библиотеки типов.</summary>
	// Token: 0x0200070E RID: 1806
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	[ComVisible(true)]
	public sealed class TypeLibVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.TypeLibVersionAttribute" /> с основным и дополнительным номерами версии библиотеки типов.</summary>
		/// <param name="major">Основной номер версии библиотеки типов.</param>
		/// <param name="minor">Дополнительный номер версии библиотеки типов.</param>
		// Token: 0x060040B9 RID: 16569 RVA: 0x000E15B5 File Offset: 0x000DF7B5
		public TypeLibVersionAttribute(int major, int minor)
		{
			this._major = major;
			this._minor = minor;
		}

		/// <summary>Получает основной номер версии библиотеки типов.</summary>
		/// <returns>Основной номер версии библиотеки типов.</returns>
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060040BA RID: 16570 RVA: 0x000E15CB File Offset: 0x000DF7CB
		public int MajorVersion
		{
			get
			{
				return this._major;
			}
		}

		/// <summary>Получает дополнительный номер версии библиотеки типов.</summary>
		/// <returns>Дополнительный номер версии библиотеки типов.</returns>
		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060040BB RID: 16571 RVA: 0x000E15D3 File Offset: 0x000DF7D3
		public int MinorVersion
		{
			get
			{
				return this._minor;
			}
		}

		// Token: 0x04002AE7 RID: 10983
		internal int _major;

		// Token: 0x04002AE8 RID: 10984
		internal int _minor;
	}
}
