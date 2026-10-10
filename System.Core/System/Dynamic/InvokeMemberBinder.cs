using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию вызова члена в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x0200031E RID: 798
	public abstract class InvokeMemberBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Dynamic.InvokeMemberBinder" />.
		///       </summary>
		/// <param name="name">
		///           Имя вызываемого члена.
		///         </param>
		/// <param name="ignoreCase">
		///           значение true, если имя должно сравниваться без учета регистра; значение false в противном случае.
		///         </param>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x06001800 RID: 6144 RVA: 0x0004FA07 File Offset: 0x0004DC07
		protected InvokeMemberBinder(string name, bool ignoreCase, CallInfo callInfo)
		{
			ContractUtils.RequiresNotNull(name, "name");
			ContractUtils.RequiresNotNull(callInfo, "callInfo");
			this.Name = name;
			this.IgnoreCase = ignoreCase;
			this.CallInfo = callInfo;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x000374E6 File Offset: 0x000356E6
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Возвращает имя элемента для вызова.
		///       </summary>
		/// <returns>
		///         Имя вызываемого члена.
		///       </returns>
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x0004FA3A File Offset: 0x0004DC3A
		public string Name { get; }

		/// <summary>
		///         Возвращает значение, указывающее, если сравнение строк должно учитывать регистр имени члена.
		///       </summary>
		/// <returns>
		///         Значение true, если регистр знаков не учитывается.
		///       </returns>
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0004FA42 File Offset: 0x0004DC42
		public bool IgnoreCase { get; }

		/// <summary>
		///         Получает сигнатуру аргументов на сайте вызова.
		///       </summary>
		/// <returns>
		///         Сигнатура аргументов на сайте вызова.
		///       </returns>
		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x0004FA4A File Offset: 0x0004DC4A
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции вызова члена.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова члена.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции вызова члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001805 RID: 6149 RVA: 0x0004FA52 File Offset: 0x0004DC52
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindInvokeMember(this, args);
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Выполняет привязку динамической операции вызова члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова члена.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции вызова члена.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001807 RID: 6151 RVA: 0x0004FA72 File Offset: 0x0004DC72
		public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackInvokeMember(target, args, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции вызова члена, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова члена.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции вызова члена.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001808 RID: 6152
		public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции вызова, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции вызова.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x06001809 RID: 6153
		public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
	}
}
