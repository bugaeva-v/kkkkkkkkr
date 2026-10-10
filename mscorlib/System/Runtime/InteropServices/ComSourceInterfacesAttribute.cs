using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет список интерфейсов, предоставляемых в виде источников событий COM для класса с атрибутом.</summary>
	// Token: 0x020006F4 RID: 1780
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	[ComVisible(true)]
	public sealed class ComSourceInterfacesAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComSourceInterfacesAttribute" /> с именем исходного интерфейса событий.</summary>
		/// <param name="sourceInterfaces">Список полных имен исходных интерфейсов событий, разделенных нулями.</param>
		// Token: 0x0600407B RID: 16507 RVA: 0x000E1042 File Offset: 0x000DF242
		public ComSourceInterfacesAttribute(string sourceInterfaces)
		{
			this._val = sourceInterfaces;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComSourceInterfacesAttribute" /> с типом, используемым в качестве исходного интерфейса.</summary>
		/// <param name="sourceInterface">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		// Token: 0x0600407C RID: 16508 RVA: 0x000E1051 File Offset: 0x000DF251
		public ComSourceInterfacesAttribute(Type sourceInterface)
		{
			this._val = sourceInterface.FullName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComSourceInterfacesAttribute" /> с типами, используемыми в качестве исходных интерфейсов.</summary>
		/// <param name="sourceInterface1">Тип <see cref="T:System.Type" /> исходного интерфейса, используемого по умолчанию.</param>
		/// <param name="sourceInterface2">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		// Token: 0x0600407D RID: 16509 RVA: 0x000E1065 File Offset: 0x000DF265
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2)
		{
			this._val = sourceInterface1.FullName + "\0" + sourceInterface2.FullName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="ComSourceInterfacesAttribute" /> с типами, используемыми в качестве исходных интерфейсов.</summary>
		/// <param name="sourceInterface1">Тип <see cref="T:System.Type" /> исходного интерфейса, используемого по умолчанию.</param>
		/// <param name="sourceInterface2">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		/// <param name="sourceInterface3">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		// Token: 0x0600407E RID: 16510 RVA: 0x000E108C File Offset: 0x000DF28C
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3)
		{
			this._val = string.Concat(new string[]
			{
				sourceInterface1.FullName,
				"\0",
				sourceInterface2.FullName,
				"\0",
				sourceInterface3.FullName
			});
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComSourceInterfacesAttribute" /> с типами, используемыми в качестве исходных интерфейсов.</summary>
		/// <param name="sourceInterface1">Тип <see cref="T:System.Type" /> исходного интерфейса, используемого по умолчанию.</param>
		/// <param name="sourceInterface2">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		/// <param name="sourceInterface3">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		/// <param name="sourceInterface4">Тип <see cref="T:System.Type" /> исходного интерфейса.</param>
		// Token: 0x0600407F RID: 16511 RVA: 0x000E10DC File Offset: 0x000DF2DC
		public ComSourceInterfacesAttribute(Type sourceInterface1, Type sourceInterface2, Type sourceInterface3, Type sourceInterface4)
		{
			this._val = string.Concat(new string[]
			{
				sourceInterface1.FullName,
				"\0",
				sourceInterface2.FullName,
				"\0",
				sourceInterface3.FullName,
				"\0",
				sourceInterface4.FullName
			});
		}

		/// <summary>Возвращает полное имя исходного интерфейса событий.</summary>
		/// <returns>Возвращает полное имя интерфейса-источника событий.</returns>
		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x000E113D File Offset: 0x000DF33D
		public string Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A44 RID: 10820
		internal string _val;
	}
}
