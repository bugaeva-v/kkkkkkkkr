using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Dynamic
{
	/// <summary>
	///         Предоставляет базовый класс для указания динамического поведения в среде выполнения.
	///          Этот класс должен наследоваться; создать его экземпляр напрямую нельзя.
	///       </summary>
	// Token: 0x020002FF RID: 767
	[Serializable]
	public class DynamicObject : IDynamicMetaObjectProvider
	{
		/// <summary>
		///         Включает производные типы для инициализации нового экземпляра <see cref="T:System.Dynamic.DynamicObject" /> типа.
		///       </summary>
		// Token: 0x0600172C RID: 5932 RVA: 0x00002162 File Offset: 0x00000362
		protected DynamicObject()
		{
		}

		/// <summary>
		///         Предоставляет реализацию для операций, получающие значения членов.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как получение значения свойства.
		///       </summary>
		/// <param name="binder">
		///           Сведения об объекте, который называется динамической операции.
		///           binder.Name Предоставляет имя члена, на котором выполняется динамическая операция.
		///            Например, для Console.WriteLine(sampleObject.SampleProperty) инструкции, где sampleObject является экземпляром класса, производного от <see cref="T:System.Dynamic.DynamicObject" /> класса binder.Name возвращает «SampleProperty».
		///           binder.IgnoreCase Свойство указывает, учитывается ли регистр в имени члена.
		///         </param>
		/// <param name="result">
		///           Результат операции получения.
		///            Например, если для свойства вызывается метод, можно назначить значение свойства <paramref name="result" />.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев во время выполнения исключения.)
		///       </returns>
		// Token: 0x0600172D RID: 5933 RVA: 0x0004D602 File Offset: 0x0004B802
		public virtual bool TryGetMember(GetMemberBinder binder, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, задающих значения членов.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как значение для свойства.
		///       </summary>
		/// <param name="binder">
		///           Сведения об объекте, который называется динамической операции.
		///           binder.Name Предоставляет имя члена, к которому присваивается значение.
		///            Например, для инструкции sampleObject.SampleProperty = "Test", где sampleObject является экземпляром класса, производного от <see cref="T:System.Dynamic.DynamicObject" /> класса binder.Name возвращает «SampleProperty».
		///           binder.IgnoreCase Свойство указывает, учитывается ли регистр в имени члена.
		///         </param>
		/// <param name="value">
		///           Значение, задаваемое для члена.
		///            Например, sampleObject.SampleProperty = "Test", где sampleObject является экземпляром класса, производного от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="value" /> — «Test».
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x0600172E RID: 5934 RVA: 0x000023D1 File Offset: 0x000005D1
		public virtual bool TrySetMember(SetMemberBinder binder, object value)
		{
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, удаляющих элемент объекта.
		///          Этот метод не предназначен для использования в C# или Visual Basic.
		///       </summary>
		/// <param name="binder">
		///           Сведения об удалении.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x0600172F RID: 5935 RVA: 0x000023D1 File Offset: 0x000005D1
		public virtual bool TryDeleteMember(DeleteMemberBinder binder)
		{
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, вызывающих член.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как вызов метода.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения о динамической операции.
		///           binder.Name Предоставляет имя члена, на котором выполняется динамическая операция.
		///            Например, для инструкции sampleObject.SampleMethod(100), где sampleObject является экземпляром класса, производного от <see cref="T:System.Dynamic.DynamicObject" /> класса binder.Name возвращает «SampleMethod».
		///           binder.IgnoreCase Свойство указывает, учитывается ли регистр в имени члена.
		///         </param>
		/// <param name="args">
		///           Аргументы, переданные члену объекта во время операции вызова.
		///            Например, для инструкции sampleObject.SampleMethod(100), где sampleObject является производным от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="args[0]" /> равно 100.
		///         </param>
		/// <param name="result">
		///           Результат вызова члена.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001730 RID: 5936 RVA: 0x0004D608 File Offset: 0x0004B808
		public virtual bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для типа операции преобразования.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, преобразующих объект из одного типа в другой.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения об операции преобразования.
		///           binder.Type Предоставляет тип, в который необходимо преобразовать объект.
		///            Например, для инструкции (String)sampleObject в C# (CType(sampleObject, Type) в Visual Basic), где sampleObject является экземпляром класса, производного от <see cref="T:System.Dynamic.DynamicObject" /> класса binder.Type возвращает <see cref="T:System.String" /> типа.
		///           binder.Explicit Свойстве содержатся сведения о типе при преобразовании.
		///            Он возвращает <see langword="true" /> для явного преобразования и <see langword="false" /> для неявного преобразования.
		///         </param>
		/// <param name="result">
		///           Результат операции преобразования типа.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001731 RID: 5937 RVA: 0x0004D602 File Offset: 0x0004B802
		public virtual bool TryConvert(ConvertBinder binder, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, инициализирующих новый экземпляр динамического объекта.
		///          Этот метод не предназначен для использования в C# или Visual Basic.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения об операции инициализации.
		///         </param>
		/// <param name="args">
		///           Аргументы, переданные объекту во время инициализации.
		///            Например, для new SampleType(100) операции, где SampleType тип является производным от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="args[0]" /> равно 100.
		///         </param>
		/// <param name="result">
		///           Результат инициализации.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001732 RID: 5938 RVA: 0x0004D608 File Offset: 0x0004B808
		public virtual bool TryCreateInstance(CreateInstanceBinder binder, object[] args, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, вызывающих объект.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как вызов объекта или делегата.
		///       </summary>
		/// <param name="binder">
		///           Сведения об операции вызова.
		///         </param>
		/// <param name="args">
		///           Аргументы, переданные объекту во время операции вызова.
		///            Например, для sampleObject(100) операции, где sampleObject является производным от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="args[0]" /> равно 100.
		///         </param>
		/// <param name="result">
		///           Результат вызова объекта.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев возникает исключение времени выполнения конкретного языка.
		///       </returns>
		// Token: 0x06001733 RID: 5939 RVA: 0x0004D608 File Offset: 0x0004B808
		public virtual bool TryInvoke(InvokeBinder binder, object[] args, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для двоичных операций.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как сложение и умножение.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения о двоичной операции.
		///           binder.Operation Возвращает свойство <see cref="T:System.Linq.Expressions.ExpressionType" /> объекта.
		///            Например, для sum = first + second инструкции, где first и second являются производными от <see langword="DynamicObject" /> класса binder.Operation возвращает ExpressionType.Add.
		///         </param>
		/// <param name="arg">
		///           Правый операнд для двоичной операции.
		///            Например, для sum = first + second инструкции, где first и second являются производными от <see langword="DynamicObject" /> класса <paramref name="arg" /> равен second.
		///         </param>
		/// <param name="result">
		///           Результат бинарной операции.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001734 RID: 5940 RVA: 0x0004D608 File Offset: 0x0004B808
		public virtual bool TryBinaryOperation(BinaryOperationBinder binder, object arg, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию унарные операции.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, таких как вычитание, увеличение или уменьшение.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения об унарной операции.
		///           binder.Operation Возвращает свойство <see cref="T:System.Linq.Expressions.ExpressionType" /> объекта.
		///            Например, для negativeNumber = -number инструкции, где number является производным от <see langword="DynamicObject" /> класса binder.Operation возвращает «Negate».
		///         </param>
		/// <param name="result">
		///           Результат унарной операции.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001735 RID: 5941 RVA: 0x0004D602 File Offset: 0x0004B802
		public virtual bool TryUnaryOperation(UnaryOperationBinder binder, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, получающих значение по индексу.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций индексации.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения об операции.
		///         </param>
		/// <param name="indexes">
		///           Индексы, которые используются в операции.
		///            Например, для sampleObject[3] операции в C# (sampleObject(3) в Visual Basic), где sampleObject является производным от <see langword="DynamicObject" /> класса <paramref name="indexes[0]" /> равно 3.
		///         </param>
		/// <param name="result">
		///           Результат операции с индексами.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001736 RID: 5942 RVA: 0x0004D608 File Offset: 0x0004B808
		public virtual bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
		{
			result = null;
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, задающих значение по индексу.
		///          Классы, производные от <see cref="T:System.Dynamic.DynamicObject" /> класс может переопределить этот метод, чтобы задать динамическое поведение для операций, осуществляющих доступ к объектам по заданному индексу.
		///       </summary>
		/// <param name="binder">
		///           Предоставляет сведения об операции.
		///         </param>
		/// <param name="indexes">
		///           Индексы, которые используются в операции.
		///            Например, для sampleObject[3] = 10 операции в C# (sampleObject(3) = 10 в Visual Basic), где sampleObject является производным от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="indexes[0]" /> равно 3.
		///         </param>
		/// <param name="value">
		///           Значение в объект, имеющий указанный индекс.
		///            Например, для sampleObject[3] = 10 операции в C# (sampleObject(3) = 10 в Visual Basic), где sampleObject является производным от <see cref="T:System.Dynamic.DynamicObject" /> класса <paramref name="value" /> равно 10.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев возникает исключение времени выполнения конкретного языка.
		///       </returns>
		// Token: 0x06001737 RID: 5943 RVA: 0x000023D1 File Offset: 0x000005D1
		public virtual bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
		{
			return false;
		}

		/// <summary>
		///         Предоставляет реализацию для операций, удаляющих объект по индексу.
		///          Этот метод не предназначен для использования в C# или Visual Basic.
		///       </summary>
		/// <param name="binder">
		///           Сведения об удалении.
		///         </param>
		/// <param name="indexes">
		///           Индексы, будут удалены.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если операция выполнена успешно; в противном случае — значение <see langword="false" />.
		///          Если этот метод возвращает <see langword="false" />, связыватель времени выполнения языка определяет поведение.
		///          (В большинстве случаев конкретного языка во время выполнения исключения.)
		///       </returns>
		// Token: 0x06001738 RID: 5944 RVA: 0x000023D1 File Offset: 0x000005D1
		public virtual bool TryDeleteIndex(DeleteIndexBinder binder, object[] indexes)
		{
			return false;
		}

		/// <summary>
		///         Возвращает перечисление всех имен динамических членов.
		///       </summary>
		/// <returns>
		///         Последовательность, содержащая имена динамических членов.
		///       </returns>
		// Token: 0x06001739 RID: 5945 RVA: 0x0004D29E File Offset: 0x0004B49E
		public virtual IEnumerable<string> GetDynamicMemberNames()
		{
			return Array.Empty<string>();
		}

		/// <summary>
		///         Предоставляет <see cref="T:System.Dynamic.DynamicMetaObject" /> отправляет динамические виртуальные методы.
		///          Объект можно инкапсулировать внутри другого <see cref="T:System.Dynamic.DynamicMetaObject" /> Чтобы обеспечить пользовательское поведение для отдельных действий.
		///          Этот метод поддерживает инфраструктуру среды DLR для разработчиков языков и не предназначен для непосредственного использования в коде.
		///       </summary>
		/// <param name="parameter">
		///           Выражение, представляющее <see cref="T:System.Dynamic.DynamicMetaObject" /> для перенаправления динамические виртуальные методы.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Dynamic.DynamicMetaObject" /> типа.
		///       </returns>
		// Token: 0x0600173A RID: 5946 RVA: 0x0004D60E File Offset: 0x0004B80E
		public virtual DynamicMetaObject GetMetaObject(Expression parameter)
		{
			return new DynamicObject.MetaDynamic(parameter, this);
		}

		// Token: 0x02000300 RID: 768
		private sealed class MetaDynamic : DynamicMetaObject
		{
			// Token: 0x0600173B RID: 5947 RVA: 0x0004D617 File Offset: 0x0004B817
			internal MetaDynamic(Expression expression, DynamicObject value) : base(expression, BindingRestrictions.Empty, value)
			{
			}

			// Token: 0x0600173C RID: 5948 RVA: 0x0004D626 File Offset: 0x0004B826
			public override IEnumerable<string> GetDynamicMemberNames()
			{
				return this.Value.GetDynamicMemberNames();
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x0004D634 File Offset: 0x0004B834
			public override DynamicMetaObject BindGetMember(GetMemberBinder binder)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryGetMember))
				{
					return this.CallMethodWithResult<GetMemberBinder>(CachedReflectionInfo.DynamicObject_TryGetMember, binder, DynamicObject.MetaDynamic.s_noArgs, (DynamicObject.MetaDynamic @this, GetMemberBinder b, DynamicMetaObject e) => b.FallbackGetMember(@this, e));
				}
				return base.BindGetMember(binder);
			}

			// Token: 0x0600173E RID: 5950 RVA: 0x0004D688 File Offset: 0x0004B888
			public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TrySetMember))
				{
					DynamicMetaObject localValue = value;
					return this.CallMethodReturnLast<SetMemberBinder>(CachedReflectionInfo.DynamicObject_TrySetMember, binder, DynamicObject.MetaDynamic.s_noArgs, value.Expression, (DynamicObject.MetaDynamic @this, SetMemberBinder b, DynamicMetaObject e) => b.FallbackSetMember(@this, localValue, e));
				}
				return base.BindSetMember(binder, value);
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x0004D6DC File Offset: 0x0004B8DC
			public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryDeleteMember))
				{
					return this.CallMethodNoResult<DeleteMemberBinder>(CachedReflectionInfo.DynamicObject_TryDeleteMember, binder, DynamicObject.MetaDynamic.s_noArgs, (DynamicObject.MetaDynamic @this, DeleteMemberBinder b, DynamicMetaObject e) => b.FallbackDeleteMember(@this, e));
				}
				return base.BindDeleteMember(binder);
			}

			// Token: 0x06001740 RID: 5952 RVA: 0x0004D730 File Offset: 0x0004B930
			public override DynamicMetaObject BindConvert(ConvertBinder binder)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryConvert))
				{
					return this.CallMethodWithResult<ConvertBinder>(CachedReflectionInfo.DynamicObject_TryConvert, binder, DynamicObject.MetaDynamic.s_noArgs, (DynamicObject.MetaDynamic @this, ConvertBinder b, DynamicMetaObject e) => b.FallbackConvert(@this, e));
				}
				return base.BindConvert(binder);
			}

			// Token: 0x06001741 RID: 5953 RVA: 0x0004D784 File Offset: 0x0004B984
			public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args)
			{
				DynamicMetaObject errorSuggestion = this.BuildCallMethodWithResult<InvokeMemberBinder>(CachedReflectionInfo.DynamicObject_TryInvokeMember, binder, DynamicMetaObject.GetExpressions(args), this.BuildCallMethodWithResult<GetMemberBinder>(CachedReflectionInfo.DynamicObject_TryGetMember, new DynamicObject.MetaDynamic.GetBinderAdapter(binder), DynamicObject.MetaDynamic.s_noArgs, binder.FallbackInvokeMember(this, args, null), (DynamicObject.MetaDynamic @this, GetMemberBinder ignored, DynamicMetaObject e) => binder.FallbackInvoke(e, args, null)), null);
				return binder.FallbackInvokeMember(this, args, errorSuggestion);
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x0004D810 File Offset: 0x0004BA10
			public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryCreateInstance))
				{
					DynamicMetaObject[] localArgs = args;
					return this.CallMethodWithResult<CreateInstanceBinder>(CachedReflectionInfo.DynamicObject_TryCreateInstance, binder, DynamicMetaObject.GetExpressions(args), (DynamicObject.MetaDynamic @this, CreateInstanceBinder b, DynamicMetaObject e) => b.FallbackCreateInstance(@this, localArgs, e));
				}
				return base.BindCreateInstance(binder, args);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x0004D860 File Offset: 0x0004BA60
			public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryInvoke))
				{
					DynamicMetaObject[] localArgs = args;
					return this.CallMethodWithResult<InvokeBinder>(CachedReflectionInfo.DynamicObject_TryInvoke, binder, DynamicMetaObject.GetExpressions(args), (DynamicObject.MetaDynamic @this, InvokeBinder b, DynamicMetaObject e) => b.FallbackInvoke(@this, localArgs, e));
				}
				return base.BindInvoke(binder, args);
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x0004D8B0 File Offset: 0x0004BAB0
			public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryBinaryOperation))
				{
					DynamicMetaObject localArg = arg;
					return this.CallMethodWithResult<BinaryOperationBinder>(CachedReflectionInfo.DynamicObject_TryBinaryOperation, binder, new Expression[]
					{
						arg.Expression
					}, (DynamicObject.MetaDynamic @this, BinaryOperationBinder b, DynamicMetaObject e) => b.FallbackBinaryOperation(@this, localArg, e));
				}
				return base.BindBinaryOperation(binder, arg);
			}

			// Token: 0x06001745 RID: 5957 RVA: 0x0004D908 File Offset: 0x0004BB08
			public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryUnaryOperation))
				{
					return this.CallMethodWithResult<UnaryOperationBinder>(CachedReflectionInfo.DynamicObject_TryUnaryOperation, binder, DynamicObject.MetaDynamic.s_noArgs, (DynamicObject.MetaDynamic @this, UnaryOperationBinder b, DynamicMetaObject e) => b.FallbackUnaryOperation(@this, e));
				}
				return base.BindUnaryOperation(binder);
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x0004D95C File Offset: 0x0004BB5C
			public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryGetIndex))
				{
					DynamicMetaObject[] localIndexes = indexes;
					return this.CallMethodWithResult<GetIndexBinder>(CachedReflectionInfo.DynamicObject_TryGetIndex, binder, DynamicMetaObject.GetExpressions(indexes), (DynamicObject.MetaDynamic @this, GetIndexBinder b, DynamicMetaObject e) => b.FallbackGetIndex(@this, localIndexes, e));
				}
				return base.BindGetIndex(binder, indexes);
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x0004D9AC File Offset: 0x0004BBAC
			public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TrySetIndex))
				{
					DynamicMetaObject[] localIndexes = indexes;
					DynamicMetaObject localValue = value;
					return this.CallMethodReturnLast<SetIndexBinder>(CachedReflectionInfo.DynamicObject_TrySetIndex, binder, DynamicMetaObject.GetExpressions(indexes), value.Expression, (DynamicObject.MetaDynamic @this, SetIndexBinder b, DynamicMetaObject e) => b.FallbackSetIndex(@this, localIndexes, localValue, e));
				}
				return base.BindSetIndex(binder, indexes, value);
			}

			// Token: 0x06001748 RID: 5960 RVA: 0x0004DA08 File Offset: 0x0004BC08
			public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes)
			{
				if (this.IsOverridden(CachedReflectionInfo.DynamicObject_TryDeleteIndex))
				{
					DynamicMetaObject[] localIndexes = indexes;
					return this.CallMethodNoResult<DeleteIndexBinder>(CachedReflectionInfo.DynamicObject_TryDeleteIndex, binder, DynamicMetaObject.GetExpressions(indexes), (DynamicObject.MetaDynamic @this, DeleteIndexBinder b, DynamicMetaObject e) => b.FallbackDeleteIndex(@this, localIndexes, e));
				}
				return base.BindDeleteIndex(binder, indexes);
			}

			// Token: 0x06001749 RID: 5961 RVA: 0x0004DA58 File Offset: 0x0004BC58
			private static ReadOnlyCollection<Expression> GetConvertedArgs(params Expression[] args)
			{
				Expression[] array = new Expression[args.Length];
				for (int i = 0; i < args.Length; i++)
				{
					array[i] = Expression.Convert(args[i], typeof(object));
				}
				return new TrueReadOnlyCollection<Expression>(array);
			}

			// Token: 0x0600174A RID: 5962 RVA: 0x0004DA98 File Offset: 0x0004BC98
			private static Expression ReferenceArgAssign(Expression callArgs, Expression[] args)
			{
				ReadOnlyCollectionBuilder<Expression> readOnlyCollectionBuilder = null;
				for (int i = 0; i < args.Length; i++)
				{
					ParameterExpression parameterExpression = args[i] as ParameterExpression;
					ContractUtils.Requires(parameterExpression != null, "args");
					if (parameterExpression.IsByRef)
					{
						if (readOnlyCollectionBuilder == null)
						{
							readOnlyCollectionBuilder = new ReadOnlyCollectionBuilder<Expression>();
						}
						readOnlyCollectionBuilder.Add(Expression.Assign(parameterExpression, Expression.Convert(Expression.ArrayIndex(callArgs, Utils.Constant(i)), parameterExpression.Type)));
					}
				}
				if (readOnlyCollectionBuilder != null)
				{
					return Expression.Block(readOnlyCollectionBuilder);
				}
				return Utils.Empty;
			}

			// Token: 0x0600174B RID: 5963 RVA: 0x0004DB10 File Offset: 0x0004BD10
			private static Expression[] BuildCallArgs<TBinder>(TBinder binder, Expression[] parameters, Expression arg0, Expression arg1) where TBinder : DynamicMetaObjectBinder
			{
				if (parameters != DynamicObject.MetaDynamic.s_noArgs)
				{
					if (arg1 == null)
					{
						return new Expression[]
						{
							DynamicObject.MetaDynamic.Constant<TBinder>(binder),
							arg0
						};
					}
					return new Expression[]
					{
						DynamicObject.MetaDynamic.Constant<TBinder>(binder),
						arg0,
						arg1
					};
				}
				else
				{
					if (arg1 == null)
					{
						return new Expression[]
						{
							DynamicObject.MetaDynamic.Constant<TBinder>(binder)
						};
					}
					return new Expression[]
					{
						DynamicObject.MetaDynamic.Constant<TBinder>(binder),
						arg1
					};
				}
			}

			// Token: 0x0600174C RID: 5964 RVA: 0x0004DB7A File Offset: 0x0004BD7A
			private static ConstantExpression Constant<TBinder>(TBinder binder)
			{
				return Expression.Constant(binder, typeof(TBinder));
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x0004DB91 File Offset: 0x0004BD91
			private DynamicMetaObject CallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) where TBinder : DynamicMetaObjectBinder
			{
				return this.CallMethodWithResult<TBinder>(method, binder, args, fallback, null);
			}

			// Token: 0x0600174E RID: 5966 RVA: 0x0004DBA0 File Offset: 0x0004BDA0
			private DynamicMetaObject CallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback, DynamicObject.MetaDynamic.Fallback<TBinder> fallbackInvoke) where TBinder : DynamicMetaObjectBinder
			{
				DynamicMetaObject fallbackResult = fallback(this, binder, null);
				DynamicMetaObject errorSuggestion = this.BuildCallMethodWithResult<TBinder>(method, binder, args, fallbackResult, fallbackInvoke);
				return fallback(this, binder, errorSuggestion);
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x0004DBD0 File Offset: 0x0004BDD0
			private DynamicMetaObject BuildCallMethodWithResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicMetaObject fallbackResult, DynamicObject.MetaDynamic.Fallback<TBinder> fallbackInvoke) where TBinder : DynamicMetaObjectBinder
			{
				if (!this.IsOverridden(method))
				{
					return fallbackResult;
				}
				ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
				ParameterExpression parameterExpression2 = (method != CachedReflectionInfo.DynamicObject_TryBinaryOperation) ? Expression.Parameter(typeof(object[]), null) : Expression.Parameter(typeof(object), null);
				ReadOnlyCollection<Expression> convertedArgs = DynamicObject.MetaDynamic.GetConvertedArgs(args);
				DynamicMetaObject dynamicMetaObject = new DynamicMetaObject(parameterExpression, BindingRestrictions.Empty);
				if (binder.ReturnType != typeof(object))
				{
					UnaryExpression ifTrue = Expression.Convert(dynamicMetaObject.Expression, binder.ReturnType);
					string value = Strings.DynamicObjectResultNotAssignable("{0}", this.Value.GetType(), binder.GetType(), binder.ReturnType);
					Expression test;
					if (binder.ReturnType.IsValueType && Nullable.GetUnderlyingType(binder.ReturnType) == null)
					{
						test = Expression.TypeIs(dynamicMetaObject.Expression, binder.ReturnType);
					}
					else
					{
						test = Expression.OrElse(Expression.Equal(dynamicMetaObject.Expression, Utils.Null), Expression.TypeIs(dynamicMetaObject.Expression, binder.ReturnType));
					}
					dynamicMetaObject = new DynamicMetaObject(Expression.Condition(test, ifTrue, Expression.Throw(Expression.New(CachedReflectionInfo.InvalidCastException_Ctor_String, new TrueReadOnlyCollection<Expression>(new Expression[]
					{
						Expression.Call(CachedReflectionInfo.String_Format_String_ObjectArray, Expression.Constant(value), Expression.NewArrayInit(typeof(object), new TrueReadOnlyCollection<Expression>(new Expression[]
						{
							Expression.Condition(Expression.Equal(dynamicMetaObject.Expression, Utils.Null), Expression.Constant("null"), Expression.Call(dynamicMetaObject.Expression, CachedReflectionInfo.Object_GetType), typeof(object))
						})))
					})), binder.ReturnType), binder.ReturnType), dynamicMetaObject.Restrictions);
				}
				if (fallbackInvoke != null)
				{
					dynamicMetaObject = fallbackInvoke(this, binder, dynamicMetaObject);
				}
				return new DynamicMetaObject(Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression,
					parameterExpression2
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					(method != CachedReflectionInfo.DynamicObject_TryBinaryOperation) ? Expression.Assign(parameterExpression2, Expression.NewArrayInit(typeof(object), convertedArgs)) : Expression.Assign(parameterExpression2, convertedArgs[0]),
					Expression.Condition(Expression.Call(this.GetLimitedSelf(), method, DynamicObject.MetaDynamic.BuildCallArgs<TBinder>(binder, args, parameterExpression2, parameterExpression)), Expression.Block((method != CachedReflectionInfo.DynamicObject_TryBinaryOperation) ? DynamicObject.MetaDynamic.ReferenceArgAssign(parameterExpression2, args) : Utils.Empty, dynamicMetaObject.Expression), fallbackResult.Expression, binder.ReturnType)
				})), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions).Merge(fallbackResult.Restrictions));
			}

			// Token: 0x06001750 RID: 5968 RVA: 0x0004DEA0 File Offset: 0x0004C0A0
			private DynamicMetaObject CallMethodReturnLast<TBinder>(MethodInfo method, TBinder binder, Expression[] args, Expression value, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) where TBinder : DynamicMetaObjectBinder
			{
				DynamicMetaObject dynamicMetaObject = fallback(this, binder, null);
				ParameterExpression parameterExpression = Expression.Parameter(typeof(object), null);
				ParameterExpression parameterExpression2 = Expression.Parameter(typeof(object[]), null);
				ReadOnlyCollection<Expression> convertedArgs = DynamicObject.MetaDynamic.GetConvertedArgs(args);
				DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression,
					parameterExpression2
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Assign(parameterExpression2, Expression.NewArrayInit(typeof(object), convertedArgs)),
					Expression.Condition(Expression.Call(this.GetLimitedSelf(), method, DynamicObject.MetaDynamic.BuildCallArgs<TBinder>(binder, args, parameterExpression2, Expression.Assign(parameterExpression, Expression.Convert(value, typeof(object))))), Expression.Block(DynamicObject.MetaDynamic.ReferenceArgAssign(parameterExpression2, args), parameterExpression), dynamicMetaObject.Expression, typeof(object))
				})), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
				return fallback(this, binder, errorSuggestion);
			}

			// Token: 0x06001751 RID: 5969 RVA: 0x0004DF90 File Offset: 0x0004C190
			private DynamicMetaObject CallMethodNoResult<TBinder>(MethodInfo method, TBinder binder, Expression[] args, DynamicObject.MetaDynamic.Fallback<TBinder> fallback) where TBinder : DynamicMetaObjectBinder
			{
				DynamicMetaObject dynamicMetaObject = fallback(this, binder, null);
				ParameterExpression parameterExpression = Expression.Parameter(typeof(object[]), null);
				ReadOnlyCollection<Expression> convertedArgs = DynamicObject.MetaDynamic.GetConvertedArgs(args);
				DynamicMetaObject errorSuggestion = new DynamicMetaObject(Expression.Block(new TrueReadOnlyCollection<ParameterExpression>(new ParameterExpression[]
				{
					parameterExpression
				}), new TrueReadOnlyCollection<Expression>(new Expression[]
				{
					Expression.Assign(parameterExpression, Expression.NewArrayInit(typeof(object), convertedArgs)),
					Expression.Condition(Expression.Call(this.GetLimitedSelf(), method, DynamicObject.MetaDynamic.BuildCallArgs<TBinder>(binder, args, parameterExpression, null)), Expression.Block(DynamicObject.MetaDynamic.ReferenceArgAssign(parameterExpression, args), Utils.Empty), dynamicMetaObject.Expression, typeof(void))
				})), this.GetRestrictions().Merge(dynamicMetaObject.Restrictions));
				return fallback(this, binder, errorSuggestion);
			}

			// Token: 0x06001752 RID: 5970 RVA: 0x0004E058 File Offset: 0x0004C258
			private bool IsOverridden(MethodInfo method)
			{
				foreach (MethodInfo methodInfo in this.Value.GetType().GetMember(method.Name, MemberTypes.Method, BindingFlags.Instance | BindingFlags.Public))
				{
					if (methodInfo.DeclaringType != typeof(DynamicObject) && methodInfo.GetBaseDefinition() == method)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06001753 RID: 5971 RVA: 0x0004E0BE File Offset: 0x0004C2BE
			private BindingRestrictions GetRestrictions()
			{
				return BindingRestrictions.GetTypeRestriction(this);
			}

			// Token: 0x06001754 RID: 5972 RVA: 0x0004E0C6 File Offset: 0x0004C2C6
			private Expression GetLimitedSelf()
			{
				if (TypeUtils.AreEquivalent(base.Expression.Type, typeof(DynamicObject)))
				{
					return base.Expression;
				}
				return Expression.Convert(base.Expression, typeof(DynamicObject));
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06001755 RID: 5973 RVA: 0x0004E100 File Offset: 0x0004C300
			private new DynamicObject Value
			{
				get
				{
					return (DynamicObject)base.Value;
				}
			}

			// Token: 0x04000B86 RID: 2950
			private static readonly Expression[] s_noArgs = new Expression[0];

			// Token: 0x02000301 RID: 769
			// (Invoke) Token: 0x06001758 RID: 5976
			private delegate DynamicMetaObject Fallback<TBinder>(DynamicObject.MetaDynamic @this, TBinder binder, DynamicMetaObject errorSuggestion);

			// Token: 0x02000302 RID: 770
			private sealed class GetBinderAdapter : GetMemberBinder
			{
				// Token: 0x0600175B RID: 5979 RVA: 0x0004E11A File Offset: 0x0004C31A
				internal GetBinderAdapter(InvokeMemberBinder binder) : base(binder.Name, binder.IgnoreCase)
				{
				}

				// Token: 0x0600175C RID: 5980 RVA: 0x000080E3 File Offset: 0x000062E3
				public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
				{
					throw new NotSupportedException();
				}
			}
		}
	}
}
