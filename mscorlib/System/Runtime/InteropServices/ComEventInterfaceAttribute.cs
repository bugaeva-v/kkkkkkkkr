using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет исходный интерфейс и класс, реализующий методы интерфейса событий, созданного при импорте компонентного класса из библиотеки типов COM.</summary>
	// Token: 0x0200070D RID: 1805
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComEventInterfaceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComEventInterfaceAttribute" />, используя интерфейс источника и класс поставщика событий.</summary>
		/// <param name="SourceInterface">
		///   <see cref="T:System.Type" />, содержащий исходный интерфейс источника из библиотеки типов. Этот интерфейс используется в COM для обратного вызова управляемого класса.</param>
		/// <param name="EventProvider">
		///   <see cref="T:System.Type" />, содержащий класс, реализующий методы интерфейса события.</param>
		// Token: 0x060040B6 RID: 16566 RVA: 0x000E158F File Offset: 0x000DF78F
		public ComEventInterfaceAttribute(Type SourceInterface, Type EventProvider)
		{
			this._SourceInterface = SourceInterface;
			this._EventProvider = EventProvider;
		}

		/// <summary>Возвращает исходный интерфейс источника из библиотеки типов.</summary>
		/// <returns>
		///   <see cref="T:System.Type" />, содержащий исходный интерфейс.</returns>
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x000E15A5 File Offset: 0x000DF7A5
		public Type SourceInterface
		{
			get
			{
				return this._SourceInterface;
			}
		}

		/// <summary>Возвращает класс, реализующий методы интерфейса события.</summary>
		/// <returns>
		///   <see cref="T:System.Type" />, содержащий класс, реализующий методы интерфейса события.</returns>
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060040B8 RID: 16568 RVA: 0x000E15AD File Offset: 0x000DF7AD
		public Type EventProvider
		{
			get
			{
				return this._EventProvider;
			}
		}

		// Token: 0x04002AE5 RID: 10981
		internal Type _SourceInterface;

		// Token: 0x04002AE6 RID: 10982
		internal Type _EventProvider;
	}
}
