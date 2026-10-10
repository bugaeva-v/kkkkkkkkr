using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Используется, чтобы пометить определение метода в сборке как хранимую процедуру. Свойства этого атрибута отражают физические характеристики, используемые при регистрации типа в SQL Server. Этот класс не наследуется.</summary>
	// Token: 0x0200005B RID: 91
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public sealed class SqlProcedureAttribute : Attribute
	{
		/// <summary>Атрибут определения метода в сборке, показывающий, следует ли регистрировать данный метод в SQL Server как хранимую процедуру.</summary>
		// Token: 0x06000479 RID: 1145 RVA: 0x00010A02 File Offset: 0x0000EC02
		public SqlProcedureAttribute()
		{
			this.m_fName = null;
		}

		/// <summary>Имя хранимой процедуры.</summary>
		/// <returns>Значение типа <see cref="T:System.String" />, представляющее имя хранимой процедуры.</returns>
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00010A11 File Offset: 0x0000EC11
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00010A19 File Offset: 0x0000EC19
		public string Name
		{
			get
			{
				return this.m_fName;
			}
			set
			{
				this.m_fName = value;
			}
		}

		// Token: 0x04000552 RID: 1362
		private string m_fName;
	}
}
