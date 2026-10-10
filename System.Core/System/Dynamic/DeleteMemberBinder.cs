using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию удаления члена в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x020002FC RID: 764
	public abstract class DeleteMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.DeleteIndexBinder" />.
		///       </summary>
		/// <param name="name">
		///           Имя члена, который требуется удалить.
		///         </param>
		/// <param name="ignoreCase">
		///           Имеет значение true, если имя должно сравниваться без учета регистра; значение false в противном случае.
		///         </param>
		// Token: 0x06001702 RID: 5890 RVA: 0x0004D06E File Offset: 0x0004B26E
		protected DeleteMemberBinder(string name, bool ignoreCase)
		{
			ContractUtils.RequiresNotNull(name, "name");
			this.Name = name;
			this.IgnoreCase = ignoreCase;
		}

		/// <summary>
		///         Возвращает имя элемента для удаления.
		///       </summary>
		/// <returns>
		///         Имя члена, который требуется удалить.
		///       </returns>
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x0004D08F File Offset: 0x0004B28F
		public string Name { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если сравнение строк должно учитывать регистр имени члена.
		///       </summary>
		/// <returns>
		///         Значение true, если сравнение строк должно учитывать регистр, в противном случае — значение false.
		///       </returns>
		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0004D097 File Offset: 0x0004B297
		public bool IgnoreCase { get; }

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x000358FE File Offset: 0x00033AFE
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(void);
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции удаления члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001706 RID: 5894 RVA: 0x0004D09F File Offset: 0x0004B29F
		public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target)
		{
			return this.FallbackDeleteMember(target, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции удаления члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления члена.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001707 RID: 5895
		public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической операции удаления члена.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции удаления члена.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции удаления члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001708 RID: 5896 RVA: 0x0004D0A9 File Offset: 0x0004B2A9
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindDeleteMember(this);
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}
	}
}
