using System;
using System.Xml.Schema;

namespace System.Xml.XPath
{
	/// <summary>
	///         Представляет элемент в XQuery 1.0 и модели данных XPath 2.0.
	///       </summary>
	// Token: 0x02000257 RID: 599
	public abstract class XPathItem
	{
		/// <summary>
		///         При переопределении в производном классе получает значение, указывающее, представляет ли элемент узел XPath или атомарное значение.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если элемент представляет узел XPath; <see langword="false" /> Если элемент представляет атомарное значение.
		///       </returns>
		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060015F8 RID: 5624
		public abstract bool IsNode { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает <see cref="T:System.Xml.Schema.XmlSchemaType" /> для элемента.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaType" /> для элемента.
		///       </returns>
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060015F9 RID: 5625
		public abstract XmlSchemaType XmlType { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает <see langword="string" /> значение элемента.
		///       </summary>
		/// <returns>
		///         <see langword="string" /> Значение элемента.
		///       </returns>
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060015FA RID: 5626
		public abstract string Value { get; }

		/// <summary>
		///         При переопределении в производном классе возвращает текущий элемент в виде упакованного объекта наиболее подходящего .NET Framework 2.0 тип в соответствии с типом схемы.
		///       </summary>
		/// <returns>
		///         Текущий элемент в виде упакованного объекта наиболее подходящего .NET Framework типа.
		///       </returns>
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060015FB RID: 5627
		public abstract object TypedValue { get; }

		/// <summary>
		///         При переопределении в производном классе получает .NET Framework 2.0 тип элемента.
		///       </summary>
		/// <returns>
		///
		///           .NET Framework Тип элемента.
		///          Значение по умолчанию — <see cref="T:System.String" />.
		///       </returns>
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060015FC RID: 5628
		public abstract Type ValueType { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как <see cref="T:System.Boolean" />.
		///       </summary>
		/// <returns>
		///         Значение элемента как <see cref="T:System.Boolean" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат <see cref="T:System.Boolean" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Boolean" /> является недопустимым.
		///           </exception>
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060015FD RID: 5629
		public abstract bool ValueAsBoolean { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как <see cref="T:System.DateTime" />.
		///       </summary>
		/// <returns>
		///         Значение элемента как <see cref="T:System.DateTime" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат <see cref="T:System.DateTime" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.DateTime" /> является недопустимым.
		///           </exception>
		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060015FE RID: 5630
		public abstract DateTime ValueAsDateTime { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как <see cref="T:System.Double" />.
		///       </summary>
		/// <returns>
		///         Значение элемента как <see cref="T:System.Double" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат <see cref="T:System.Double" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Double" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060015FF RID: 5631
		public abstract double ValueAsDouble { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как <see cref="T:System.Int32" />.
		///       </summary>
		/// <returns>
		///         Значение элемента как <see cref="T:System.Int32" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат <see cref="T:System.Int32" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int32" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001600 RID: 5632
		public abstract int ValueAsInt { get; }

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как <see cref="T:System.Int64" />.
		///       </summary>
		/// <returns>
		///         Значение элемента как <see cref="T:System.Int64" />.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат <see cref="T:System.Int64" /> типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения к <see cref="T:System.Int64" /> является недопустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001601 RID: 5633
		public abstract long ValueAsLong { get; }

		/// <summary>
		///         Возвращает значение элемента указанного типа.
		///       </summary>
		/// <param name="returnType">
		///           Тип, который необходимо возвратить значение элемента.
		///         </param>
		/// <returns>
		///         Значение элемента в заданном типе.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат для целевого типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x06001602 RID: 5634 RVA: 0x0008561C File Offset: 0x0008381C
		public virtual object ValueAs(Type returnType)
		{
			return this.ValueAs(returnType, null);
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает значение элемента как тип, указанный с помощью <see cref="T:System.Xml.IXmlNamespaceResolver" /> объект, заданный для разрешения префиксов пространств имен.
		///       </summary>
		/// <param name="returnType">
		///           Тип, который необходимо возвратить значение элемента.
		///         </param>
		/// <param name="nsResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения префиксов пространств имен.
		///         </param>
		/// <returns>
		///         Значение элемента в заданном типе.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Значение элемента не правильный формат для целевого типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Попытка приведения привела к переполнению.
		///           </exception>
		// Token: 0x06001603 RID: 5635
		public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);
	}
}
