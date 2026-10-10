using System;

namespace System.Runtime.Serialization
{
	/// <summary>Задает пространство имен среды CLR и пространство имен XML для контракта данных.</summary>
	// Token: 0x020000BA RID: 186
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, Inherited = false, AllowMultiple = true)]
	public sealed class ContractNamespaceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.ContractNamespaceAttribute" />, используя указанное пространство имен.</summary>
		/// <param name="contractNamespace">Пространство имен контракта.</param>
		// Token: 0x06000A66 RID: 2662 RVA: 0x0002CD78 File Offset: 0x0002AF78
		public ContractNamespaceAttribute(string contractNamespace)
		{
			this.contractNamespace = contractNamespace;
		}

		/// <summary>Возвращает или задает пространство имен среды CLR для типа контракта данных.</summary>
		/// <returns>Пространство имен типа, разрешенное средой CLR.</returns>
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0002CD87 File Offset: 0x0002AF87
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0002CD8F File Offset: 0x0002AF8F
		public string ClrNamespace
		{
			get
			{
				return this.clrNamespace;
			}
			set
			{
				this.clrNamespace = value;
			}
		}

		/// <summary>Возвращает пространство имен элементов контракта данных.</summary>
		/// <returns>Пространство имен элементов контракта данных.</returns>
		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002CD98 File Offset: 0x0002AF98
		public string ContractNamespace
		{
			get
			{
				return this.contractNamespace;
			}
		}

		// Token: 0x04000464 RID: 1124
		private string clrNamespace;

		// Token: 0x04000465 RID: 1125
		private string contractNamespace;
	}
}
