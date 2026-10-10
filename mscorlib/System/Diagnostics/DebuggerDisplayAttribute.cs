using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Определяет, как класс или поле отображается в окнах переменных отладчика.</summary>
	// Token: 0x020009BD RID: 2493
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Delegate, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class DebuggerDisplayAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerDisplayAttribute" />.</summary>
		/// <param name="value">Строка, отображаемая в столбце значений для экземпляров типа; при использовании пустой строки ("") столбец значений оказывается скрытым.</param>
		// Token: 0x060059AB RID: 22955 RVA: 0x001330B7 File Offset: 0x001312B7
		public DebuggerDisplayAttribute(string value)
		{
			if (value == null)
			{
				this.value = "";
			}
			else
			{
				this.value = value;
			}
			this.name = "";
			this.type = "";
		}

		/// <summary>Возвращает строку, отображаемую в столбце значений в окнах переменных отладчика.</summary>
		/// <returns>Строка, отображаемая в столбце значений переменных отладчика.</returns>
		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060059AC RID: 22956 RVA: 0x001330EC File Offset: 0x001312EC
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		/// <summary>Возвращает или задает имя, отображаемое в окнах переменных отладчика.</summary>
		/// <returns>Имя, отображаемое в окнах переменных отладчика.</returns>
		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060059AD RID: 22957 RVA: 0x001330F4 File Offset: 0x001312F4
		// (set) Token: 0x060059AE RID: 22958 RVA: 0x001330FC File Offset: 0x001312FC
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Возвращает или задает строку, отображаемую в столбце типа в окнах переменных отладчика.</summary>
		/// <returns>Строка, отображаемая в столбце типа в окнах переменных отладчика.</returns>
		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x060059AF RID: 22959 RVA: 0x00133105 File Offset: 0x00131305
		// (set) Token: 0x060059B0 RID: 22960 RVA: 0x0013310D File Offset: 0x0013130D
		public string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		/// <summary>Возвращает или задает тип целевого объекта атрибута.</summary>
		/// <returns>Целевой тип атрибута.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Diagnostics.DebuggerDisplayAttribute.Target" /> задается значение <see langword="null" />.</exception>
		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x060059B2 RID: 22962 RVA: 0x0013313F File Offset: 0x0013133F
		// (set) Token: 0x060059B1 RID: 22961 RVA: 0x00133116 File Offset: 0x00131316
		public Type Target
		{
			get
			{
				return this.target;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.targetName = value.AssemblyQualifiedName;
				this.target = value;
			}
		}

		/// <summary>Возвращает или задает имя целевого объекта атрибута.</summary>
		/// <returns>Имя типа целевого объекта атрибута.</returns>
		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x060059B3 RID: 22963 RVA: 0x00133147 File Offset: 0x00131347
		// (set) Token: 0x060059B4 RID: 22964 RVA: 0x0013314F File Offset: 0x0013134F
		public string TargetTypeName
		{
			get
			{
				return this.targetName;
			}
			set
			{
				this.targetName = value;
			}
		}

		// Token: 0x04003783 RID: 14211
		private string name;

		// Token: 0x04003784 RID: 14212
		private string value;

		// Token: 0x04003785 RID: 14213
		private string type;

		// Token: 0x04003786 RID: 14214
		private string targetName;

		// Token: 0x04003787 RID: 14215
		private Type target;
	}
}
