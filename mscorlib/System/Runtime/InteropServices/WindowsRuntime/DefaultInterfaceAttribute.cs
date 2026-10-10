using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Указывает интерфейс по умолчанию для управляемого класса среды выполнения Windows.</summary>
	// Token: 0x02000782 RID: 1922
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class DefaultInterfaceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.DefaultInterfaceAttribute" />.</summary>
		/// <param name="defaultInterface">Тип интерфейса, определенный как интерфейс по умолчанию для класса, к которому применяется атрибут.</param>
		// Token: 0x0600447B RID: 17531 RVA: 0x000E3ACE File Offset: 0x000E1CCE
		public DefaultInterfaceAttribute(Type defaultInterface)
		{
			this.m_defaultInterface = defaultInterface;
		}

		/// <summary>Получает тип интерфейса по умолчанию.</summary>
		/// <returns>Тип интерфейса по умолчанию.</returns>
		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x0600447C RID: 17532 RVA: 0x000E3ADD File Offset: 0x000E1CDD
		public Type DefaultInterface
		{
			get
			{
				return this.m_defaultInterface;
			}
		}

		// Token: 0x04002C1D RID: 11293
		private Type m_defaultInterface;
	}
}
