using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Добавляет к возвращаемому результату пользовательского типа (UDT) дополнительную информацию, которая может быть использована в Transact-SQL.</summary>
	// Token: 0x02000056 RID: 86
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
	public class SqlFacetAttribute : Attribute
	{
		/// <summary>Показывает, имеет ли тип возвращаемого значения пользовательского типа фиксированную длину.</summary>
		/// <returns>
		///   <see langword="true" />, если тип возвращаемого значения имеет фиксированную длину, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000108AD File Offset: 0x0000EAAD
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000108B5 File Offset: 0x0000EAB5
		public bool IsFixedLength
		{
			get
			{
				return this.m_IsFixedLength;
			}
			set
			{
				this.m_IsFixedLength = value;
			}
		}

		/// <summary>Максимальный размер базового типа поля для пользовательского типа (в логических единицах).</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее максимальный размер базового типа поля в логических единицах.</returns>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000108BE File Offset: 0x0000EABE
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000108C6 File Offset: 0x0000EAC6
		public int MaxSize
		{
			get
			{
				return this.m_MaxSize;
			}
			set
			{
				this.m_MaxSize = value;
			}
		}

		/// <summary>Точность типа возвращаемого значения пользовательского типа.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее точность типа возвращаемого значения.</returns>
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000108CF File Offset: 0x0000EACF
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000108D7 File Offset: 0x0000EAD7
		public int Precision
		{
			get
			{
				return this.m_Precision;
			}
			set
			{
				this.m_Precision = value;
			}
		}

		/// <summary>Масштаб типа возвращаемого значения пользовательского типа.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее масштаб типа возвращаемого значения.</returns>
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000108E0 File Offset: 0x0000EAE0
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x000108E8 File Offset: 0x0000EAE8
		public int Scale
		{
			get
			{
				return this.m_Scale;
			}
			set
			{
				this.m_Scale = value;
			}
		}

		/// <summary>Показывает, допускается ли <see langword="null" /> в качестве типа возвращаемого значения пользовательского типа.</summary>
		/// <returns>
		///   <see langword="true" />, если типом возвращаемого значения пользовательского типа может быть <see langword="null" />, в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x000108F1 File Offset: 0x0000EAF1
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x000108F9 File Offset: 0x0000EAF9
		public bool IsNullable
		{
			get
			{
				return this.m_IsNullable;
			}
			set
			{
				this.m_IsNullable = value;
			}
		}

		// Token: 0x0400053D RID: 1341
		private bool m_IsFixedLength;

		// Token: 0x0400053E RID: 1342
		private int m_MaxSize;

		// Token: 0x0400053F RID: 1343
		private int m_Scale;

		// Token: 0x04000540 RID: 1344
		private int m_Precision;

		// Token: 0x04000541 RID: 1345
		private bool m_IsNullable;
	}
}
