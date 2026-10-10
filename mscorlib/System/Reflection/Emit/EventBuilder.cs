using System;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection.Emit
{
	/// <summary>Определяет события для класса.</summary>
	// Token: 0x02000921 RID: 2337
	[ComVisible(true)]
	[ComDefaultInterface(typeof(_EventBuilder))]
	[ClassInterface(ClassInterfaceType.None)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class EventBuilder : _EventBuilder
	{
		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FEB RID: 20459 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EventBuilder.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FEC RID: 20460 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EventBuilder.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FED RID: 20461 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EventBuilder.GetTypeInfoCount(out uint pcTInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004FEE RID: 20462 RVA: 0x000479F8 File Offset: 0x00045BF8
		void _EventBuilder.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x000FA63E File Offset: 0x000F883E
		internal EventBuilder(TypeBuilder tb, string eventName, EventAttributes eventAttrs, Type eventType)
		{
			this.name = eventName;
			this.attrs = eventAttrs;
			this.type = eventType;
			this.typeb = tb;
			this.table_idx = this.get_next_table_index(this, 20, 1);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x000FA673 File Offset: 0x000F8873
		internal int get_next_table_index(object obj, int table, int count)
		{
			return this.typeb.get_next_table_index(obj, table, count);
		}

		/// <summary>Добавляет "дополнительный" метод, связанный с данным событием. "Дополнительным" называется метод, который не вызывается при наступлении события и не вызывает событие сам. Эту функцию можно вызывать много раз для добавления нужного числа "дополнительных" методов.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, представляющий "дополнительный" метод.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF1 RID: 20465 RVA: 0x000FA684 File Offset: 0x000F8884
		public void AddOtherMethod(MethodBuilder mdBuilder)
		{
			if (mdBuilder == null)
			{
				throw new ArgumentNullException("mdBuilder");
			}
			this.RejectIfCreated();
			if (this.other_methods != null)
			{
				MethodBuilder[] array = new MethodBuilder[this.other_methods.Length + 1];
				this.other_methods.CopyTo(array, 0);
				this.other_methods = array;
			}
			else
			{
				this.other_methods = new MethodBuilder[1];
			}
			this.other_methods[this.other_methods.Length - 1] = mdBuilder;
		}

		/// <summary>Возвращает токен для данного события.</summary>
		/// <returns>Значение <see langword="EventToken" /> для этого события.</returns>
		// Token: 0x06004FF2 RID: 20466 RVA: 0x000FA6F7 File Offset: 0x000F88F7
		public EventToken GetEventToken()
		{
			return new EventToken(335544320 | this.table_idx);
		}

		/// <summary>Устанавливает метод, используемый для подписки на событие.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, представляющий метод, используемый для подписки на данное событие.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF3 RID: 20467 RVA: 0x000FA70A File Offset: 0x000F890A
		public void SetAddOnMethod(MethodBuilder mdBuilder)
		{
			if (mdBuilder == null)
			{
				throw new ArgumentNullException("mdBuilder");
			}
			this.RejectIfCreated();
			this.add_method = mdBuilder;
		}

		/// <summary>Устанавливает метод, используемый для вызова данного события.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, представляющий метод, используемый для вызова данного события.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF4 RID: 20468 RVA: 0x000FA72D File Offset: 0x000F892D
		public void SetRaiseMethod(MethodBuilder mdBuilder)
		{
			if (mdBuilder == null)
			{
				throw new ArgumentNullException("mdBuilder");
			}
			this.RejectIfCreated();
			this.raise_method = mdBuilder;
		}

		/// <summary>Устанавливает метод, используемый для отказа от подписки на событие.</summary>
		/// <param name="mdBuilder">Объект <see langword="MethodBuilder" />, представляющий метод, используемый для отказа от подписки на данное событие.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="mdBuilder" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF5 RID: 20469 RVA: 0x000FA750 File Offset: 0x000F8950
		public void SetRemoveOnMethod(MethodBuilder mdBuilder)
		{
			if (mdBuilder == null)
			{
				throw new ArgumentNullException("mdBuilder");
			}
			this.RejectIfCreated();
			this.remove_method = mdBuilder;
		}

		/// <summary>Задает настраиваемый атрибут с помощью построителя настраиваемых атрибутов.</summary>
		/// <param name="customBuilder">Экземпляр вспомогательного класса для описания настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="con" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF6 RID: 20470 RVA: 0x000FA774 File Offset: 0x000F8974
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			if (customBuilder == null)
			{
				throw new ArgumentNullException("customBuilder");
			}
			this.RejectIfCreated();
			if (customBuilder.Ctor.ReflectedType.FullName == "System.Runtime.CompilerServices.SpecialNameAttribute")
			{
				this.attrs |= EventAttributes.SpecialName;
				return;
			}
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customBuilder;
				this.cattrs = array;
				return;
			}
			this.cattrs = new CustomAttributeBuilder[1];
			this.cattrs[0] = customBuilder;
		}

		/// <summary>Задает настраиваемый атрибут с помощью большого двоичного объекта настраиваемых атрибутов.</summary>
		/// <param name="con">Конструктор настраиваемого атрибута.</param>
		/// <param name="binaryAttribute">Большой двоичный объект байтов, представляющий атрибуты.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="con" /> или <paramref name="binaryAttribute" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Метод <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> был вызван для включающего типа.</exception>
		// Token: 0x06004FF7 RID: 20471 RVA: 0x000FA811 File Offset: 0x000F8A11
		[ComVisible(true)]
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			if (con == null)
			{
				throw new ArgumentNullException("con");
			}
			if (binaryAttribute == null)
			{
				throw new ArgumentNullException("binaryAttribute");
			}
			this.SetCustomAttribute(new CustomAttributeBuilder(con, binaryAttribute));
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x000FA842 File Offset: 0x000F8A42
		private void RejectIfCreated()
		{
			if (this.typeb.is_created)
			{
				throw new InvalidOperationException("Type definition of the method is complete.");
			}
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x000173AD File Offset: 0x000155AD
		internal EventBuilder()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400314E RID: 12622
		internal string name;

		// Token: 0x0400314F RID: 12623
		private Type type;

		// Token: 0x04003150 RID: 12624
		private TypeBuilder typeb;

		// Token: 0x04003151 RID: 12625
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x04003152 RID: 12626
		internal MethodBuilder add_method;

		// Token: 0x04003153 RID: 12627
		internal MethodBuilder remove_method;

		// Token: 0x04003154 RID: 12628
		internal MethodBuilder raise_method;

		// Token: 0x04003155 RID: 12629
		internal MethodBuilder[] other_methods;

		// Token: 0x04003156 RID: 12630
		internal EventAttributes attrs;

		// Token: 0x04003157 RID: 12631
		private int table_idx;
	}
}
