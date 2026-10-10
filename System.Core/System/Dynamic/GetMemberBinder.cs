using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию получения члена в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x0200031A RID: 794
	public abstract class GetMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.GetMemberBinder" />.
		///       </summary>
		/// <param name="name">
		///           Имя члена, который требуется получить.
		///         </param>
		/// <param name="ignoreCase">
		///           Имеет значение true, если имя должно сравниваться без учета регистра; значение false в противном случае.
		///         </param>
		// Token: 0x060017EF RID: 6127 RVA: 0x0004F956 File Offset: 0x0004DB56
		protected GetMemberBinder(string name, bool ignoreCase)
		{
			ContractUtils.RequiresNotNull(name, "name");
			this.Name = name;
			this.IgnoreCase = ignoreCase;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x000374E6 File Offset: 0x000356E6
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Получает имя члена, который требуется получить.
		///       </summary>
		/// <returns>
		///         Имя члена, который требуется получить.
		///       </returns>
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0004F977 File Offset: 0x0004DB77
		public string Name { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если сравнение строк должно учитывать регистр имени члена.
		///       </summary>
		/// <returns>
		///         Значение true, если регистр знаков не учитывается.
		///       </returns>
		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0004F97F File Offset: 0x0004DB7F
		public bool IgnoreCase { get; }

		/// <summary>
		///         Выполняет привязку динамической операции получения члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017F3 RID: 6131 RVA: 0x0004F987 File Offset: 0x0004DB87
		public DynamicMetaObject FallbackGetMember(DynamicMetaObject target)
		{
			return this.FallbackGetMember(target, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции получения члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения члена.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017F4 RID: 6132
		public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической операции получения члена.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции получения члена.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции получения члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060017F5 RID: 6133 RVA: 0x0004F991 File Offset: 0x0004DB91
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.Requires(args == null || args.Length == 0, "args");
			return target.BindGetMember(this);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}
	}
}
