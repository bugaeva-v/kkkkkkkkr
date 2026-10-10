using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Предоставляет доступ к метаданным и MSIL для тела метода.</summary>
	// Token: 0x020008F0 RID: 2288
	[ComVisible(true)]
	public class MethodBody
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.MethodBody" />.</summary>
		// Token: 0x06004CB0 RID: 19632 RVA: 0x0000259F File Offset: 0x0000079F
		protected MethodBody()
		{
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x000F316C File Offset: 0x000F136C
		internal MethodBody(ExceptionHandlingClause[] clauses, LocalVariableInfo[] locals, byte[] il, bool init_locals, int sig_token, int max_stack)
		{
			this.clauses = clauses;
			this.locals = locals;
			this.il = il;
			this.init_locals = init_locals;
			this.sig_token = sig_token;
			this.max_stack = max_stack;
		}

		/// <summary>Возвращает список, содержащий все предложения обработки исключений в теле метода.</summary>
		/// <returns>Список <see cref="T:System.Collections.Generic.IList`1" /> объектов <see cref="T:System.Reflection.ExceptionHandlingClause" />, представляющий предложения обработки исключений в теле метода.</returns>
		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06004CB2 RID: 19634 RVA: 0x000F31A1 File Offset: 0x000F13A1
		public virtual IList<ExceptionHandlingClause> ExceptionHandlingClauses
		{
			get
			{
				return Array.AsReadOnly<ExceptionHandlingClause>(this.clauses);
			}
		}

		/// <summary>Возвращает список локальных переменных, объявленных в теле метода.</summary>
		/// <returns>Список <see cref="T:System.Collections.Generic.IList`1" /> объектов <see cref="T:System.Reflection.LocalVariableInfo" />, которые описывают локальные переменные, объявленные в теле метода.</returns>
		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06004CB3 RID: 19635 RVA: 0x000F31AE File Offset: 0x000F13AE
		public virtual IList<LocalVariableInfo> LocalVariables
		{
			get
			{
				return Array.AsReadOnly<LocalVariableInfo>(this.locals);
			}
		}

		/// <summary>Возвращает значение, которое определяет, будут ли локальные переменные в теле метода инициализированы значениями по умолчанию, предусмотренными для соответствующих типов.</summary>
		/// <returns>Значение <see langword="true" />, если тело метода содержит код, инициализирующий локальные переменные значениями <see langword="null" /> для ссылочных типов, или нулевыми значениями для типов значений; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004CB4 RID: 19636 RVA: 0x000F31BB File Offset: 0x000F13BB
		public virtual bool InitLocals
		{
			get
			{
				return this.init_locals;
			}
		}

		/// <summary>Возвращает токен метаданных для подписи, которая описывает локальные переменные для этого метода в метаданных.</summary>
		/// <returns>Целочисленное значение, представляющее токен метаданных.</returns>
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06004CB5 RID: 19637 RVA: 0x000F31C3 File Offset: 0x000F13C3
		public virtual int LocalSignatureMetadataToken
		{
			get
			{
				return this.sig_token;
			}
		}

		/// <summary>Возвращает максимальное количество элементов в стеке операторов при выполнении метода.</summary>
		/// <returns>Максимальное количество элементов в стеке операторов при выполнении метода.</returns>
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06004CB6 RID: 19638 RVA: 0x000F31CB File Offset: 0x000F13CB
		public virtual int MaxStackSize
		{
			get
			{
				return this.max_stack;
			}
		}

		/// <summary>Возвращает код MSIL тела метода в виде массива байтов.</summary>
		/// <returns>Массив типа <see cref="T:System.Byte" />, который содержит MSIL для тела метода.</returns>
		// Token: 0x06004CB7 RID: 19639 RVA: 0x000F31D3 File Offset: 0x000F13D3
		public virtual byte[] GetILAsByteArray()
		{
			return this.il;
		}

		// Token: 0x04003035 RID: 12341
		private ExceptionHandlingClause[] clauses;

		// Token: 0x04003036 RID: 12342
		private LocalVariableInfo[] locals;

		// Token: 0x04003037 RID: 12343
		private byte[] il;

		// Token: 0x04003038 RID: 12344
		private bool init_locals;

		// Token: 0x04003039 RID: 12345
		private int sig_token;

		// Token: 0x0400303A RID: 12346
		private int max_stack;
	}
}
