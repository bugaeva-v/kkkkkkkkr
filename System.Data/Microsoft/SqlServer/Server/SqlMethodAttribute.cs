using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Определяет детерминизм и свойства доступа к данным для метода или свойства пользовательского типа. Свойства этого атрибута отражают физические характеристики, используемые при регистрации типа в SQL Server.</summary>
	// Token: 0x0200005A RID: 90
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public sealed class SqlMethodAttribute : SqlFunctionAttribute
	{
		/// <summary>Атрибут пользовательского типа, определяющий детерминизм и свойства доступа к данным для метода или свойства этого типа.</summary>
		// Token: 0x06000472 RID: 1138 RVA: 0x000109B2 File Offset: 0x0000EBB2
		public SqlMethodAttribute()
		{
			this.m_fCallOnNullInputs = true;
			this.m_fMutator = false;
			this.m_fInvokeIfReceiverIsNull = false;
		}

		/// <summary>Указывает, вызывается ли метод для пользовательского типа, когда в вызове метода указаны входные аргументы <see langword="null" />.</summary>
		/// <returns>Значение <see langword="true" />, если метод вызывается, когда в вызове метода указаны входные аргументы <see langword="null" />. Значение <see langword="false" />, если метод возвращает значение <see langword="null" /> в одном из его входных параметров <see langword="null" />. Если метод не может быть вызвана (из-за атрибута метода), SQL Server <see langword="DbNull" /> возвращается.</returns>
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x000109CF File Offset: 0x0000EBCF
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x000109D7 File Offset: 0x0000EBD7
		public bool OnNullCall
		{
			get
			{
				return this.m_fCallOnNullInputs;
			}
			set
			{
				this.m_fCallOnNullInputs = value;
			}
		}

		/// <summary>Показывает, является ли метод пользовательского типа мутатором.</summary>
		/// <returns>
		///   <see langword="true" />, если метод является мутатором, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000109E0 File Offset: 0x0000EBE0
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000109E8 File Offset: 0x0000EBE8
		public bool IsMutator
		{
			get
			{
				return this.m_fMutator;
			}
			set
			{
				this.m_fMutator = value;
			}
		}

		/// <summary>Указывает, должен ли SQL Server вызывать метод для экземпляров со значением null.</summary>
		/// <returns>Значение <see langword="true" />, если SQL Server должен вызвать метод для экземпляров со значением null. В противном случае — значение <see langword="false" />. Если метод не может быть вызвана (из-за атрибута метода), SQL Server <see langword="DbNull" /> возвращается.</returns>
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000109F1 File Offset: 0x0000EBF1
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000109F9 File Offset: 0x0000EBF9
		public bool InvokeIfReceiverIsNull
		{
			get
			{
				return this.m_fInvokeIfReceiverIsNull;
			}
			set
			{
				this.m_fInvokeIfReceiverIsNull = value;
			}
		}

		// Token: 0x0400054F RID: 1359
		private bool m_fCallOnNullInputs;

		// Token: 0x04000550 RID: 1360
		private bool m_fMutator;

		// Token: 0x04000551 RID: 1361
		private bool m_fInvokeIfReceiverIsNull;
	}
}
