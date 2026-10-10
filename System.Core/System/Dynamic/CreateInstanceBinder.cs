using System;
using System.Dynamic.Utils;

namespace System.Dynamic
{
	/// <summary>
	///         Представляет динамическую операцию создания в источнике вызова с указанием семантики привязки и сведений об операции.
	///       </summary>
	// Token: 0x020002FA RID: 762
	public abstract class CreateInstanceBinder : DynamicMetaObjectBinder
	{
		/// <summary>
		///         Инициализирует новый intsance из <see cref="T:System.Dynamic.CreateInstanceBinder" />.
		///       </summary>
		/// <param name="callInfo">
		///           Сигнатура аргументов на сайте вызова.
		///         </param>
		// Token: 0x060016F4 RID: 5876 RVA: 0x0004CFD4 File Offset: 0x0004B1D4
		protected CreateInstanceBinder(CallInfo callInfo)
		{
			ContractUtils.RequiresNotNull(callInfo, "callInfo");
			this.CallInfo = callInfo;
		}

		/// <summary>
		///         Тип результата операции.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Type" />, представляющий тип результата операции.
		///       </returns>
		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x000374E6 File Offset: 0x000356E6
		public sealed override Type ReturnType
		{
			get
			{
				return typeof(object);
			}
		}

		/// <summary>
		///         Получает сигнатуру аргументов на сайте вызова.
		///       </summary>
		/// <returns>
		///         Сигнатура аргументов на сайте вызова.
		///       </returns>
		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0004CFEE File Offset: 0x0004B1EE
		public CallInfo CallInfo { get; }

		/// <summary>
		///         Выполняет привязку динамической операции создания, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции создания.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции создания.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016F7 RID: 5879 RVA: 0x0004CFF6 File Offset: 0x0004B1F6
		public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return this.FallbackCreateInstance(target, args, null);
		}

		/// <summary>
		///         При переопределении в производном классе выполняет привязку динамической операции создания, если не удается привязать динамический целевой объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции создания.
		///         </param>
		/// <param name="args">
		///           Аргументы динамической операции создания.
		///         </param>
		/// <param name="errorSuggestion">
		///           Результат привязки для использования при сбое привязки или значение NULL.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016F8 RID: 5880
		public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

		/// <summary>
		///         Выполняет привязку динамической операции создания.
		///       </summary>
		/// <param name="target">
		///           Целевой объект динамической операции создания.
		///         </param>
		/// <param name="args">
		///           Массив аргументов динамической операции создания.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" />, представляющий результат привязки.
		///       </returns>
		// Token: 0x060016F9 RID: 5881 RVA: 0x0004D001 File Offset: 0x0004B201
		public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			ContractUtils.RequiresNotNull(target, "target");
			ContractUtils.RequiresNotNullItems<DynamicMetaObject>(args, "args");
			return target.BindCreateInstance(this, args);
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00007E1D File Offset: 0x0000601D
		internal sealed override bool IsStandardBinder
		{
			get
			{
				return true;
			}
		}
	}
}
