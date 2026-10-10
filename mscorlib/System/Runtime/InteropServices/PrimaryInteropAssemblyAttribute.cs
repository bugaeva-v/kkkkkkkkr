using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Показывает, что сборка с данным атрибутом является основной сборкой взаимодействия.</summary>
	// Token: 0x0200070B RID: 1803
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class PrimaryInteropAssemblyAttribute : Attribute
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.InteropServices.PrimaryInteropAssemblyAttribute" />, используя основной и дополнительный номера версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</summary>
		/// <param name="major">Основной номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</param>
		/// <param name="minor">Дополнительный номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</param>
		// Token: 0x060040B1 RID: 16561 RVA: 0x000E1552 File Offset: 0x000DF752
		public PrimaryInteropAssemblyAttribute(int major, int minor)
		{
			this._major = major;
			this._minor = minor;
		}

		/// <summary>Возвращает основной номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</summary>
		/// <returns>Основной номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</returns>
		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x000E1568 File Offset: 0x000DF768
		public int MajorVersion
		{
			get
			{
				return this._major;
			}
		}

		/// <summary>Возвращает номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</summary>
		/// <returns>Дополнительный номер версии библиотеки типов, для которой эта сборка является основной сборкой взаимодействия.</returns>
		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x000E1570 File Offset: 0x000DF770
		public int MinorVersion
		{
			get
			{
				return this._minor;
			}
		}

		// Token: 0x04002AE2 RID: 10978
		internal int _major;

		// Token: 0x04002AE3 RID: 10979
		internal int _minor;
	}
}
