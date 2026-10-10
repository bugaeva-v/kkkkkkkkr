using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Указывает версию целевого типа, который первым реализовал указанный интерфейс.</summary>
	// Token: 0x02000784 RID: 1924
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, Inherited = false, AllowMultiple = true)]
	public sealed class InterfaceImplementedInVersionAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.InterfaceImplementedInVersionAttribute" /> с указанием интерфейса, реализуемого целевым типом, и версии, в которой этот интерфейс был первоначально реализован.</summary>
		/// <param name="interfaceType">Интерфейс, который сначала был реализован в указанной версии целевого типа.</param>
		/// <param name="majorVersion">Основной номер версии целевого типа, в котором в первый раз реализован тип <paramref name="interfaceType" />.</param>
		/// <param name="minorVersion">Дополнительный номер версии целевого типа, в котором в первый раз реализован тип <paramref name="interfaceType" />.</param>
		/// <param name="buildVersion">Компонент сборки версии целевого типа, в котором в первый раз реализован тип <paramref name="interfaceType" />.</param>
		/// <param name="revisionVersion">Номер редакции версии целевого типа, в котором в первый раз реализован тип <paramref name="interfaceType" />.</param>
		// Token: 0x0600447E RID: 17534 RVA: 0x000E3AE5 File Offset: 0x000E1CE5
		public InterfaceImplementedInVersionAttribute(Type interfaceType, byte majorVersion, byte minorVersion, byte buildVersion, byte revisionVersion)
		{
			this.m_interfaceType = interfaceType;
			this.m_majorVersion = majorVersion;
			this.m_minorVersion = minorVersion;
			this.m_buildVersion = buildVersion;
			this.m_revisionVersion = revisionVersion;
		}

		/// <summary>Получает тип интерфейса, реализуемого целевым типом.</summary>
		/// <returns>Тип интерфейса.</returns>
		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000E3B12 File Offset: 0x000E1D12
		public Type InterfaceType
		{
			get
			{
				return this.m_interfaceType;
			}
		}

		/// <summary>Получает основной компонент версии целевого типа, который первым реализовал интерфейс.</summary>
		/// <returns>Основной компонент версии.</returns>
		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x000E3B1A File Offset: 0x000E1D1A
		public byte MajorVersion
		{
			get
			{
				return this.m_majorVersion;
			}
		}

		/// <summary>Получает дополнительный компонент версии целевого типа, который первым реализовал интерфейс.</summary>
		/// <returns>Дополнительный компонент версии.</returns>
		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x000E3B22 File Offset: 0x000E1D22
		public byte MinorVersion
		{
			get
			{
				return this.m_minorVersion;
			}
		}

		/// <summary>Получает компонент построения версии целевого типа, который первым реализовал интерфейс.</summary>
		/// <returns>Компонент построения версии.</returns>
		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x000E3B2A File Offset: 0x000E1D2A
		public byte BuildVersion
		{
			get
			{
				return this.m_buildVersion;
			}
		}

		/// <summary>Получает компонент-редакцию версии целевого типа, который первым реализовал интерфейс.</summary>
		/// <returns>Номер редакции версии.</returns>
		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06004483 RID: 17539 RVA: 0x000E3B32 File Offset: 0x000E1D32
		public byte RevisionVersion
		{
			get
			{
				return this.m_revisionVersion;
			}
		}

		// Token: 0x04002C1E RID: 11294
		private Type m_interfaceType;

		// Token: 0x04002C1F RID: 11295
		private byte m_majorVersion;

		// Token: 0x04002C20 RID: 11296
		private byte m_minorVersion;

		// Token: 0x04002C21 RID: 11297
		private byte m_buildVersion;

		// Token: 0x04002C22 RID: 11298
		private byte m_revisionVersion;
	}
}
