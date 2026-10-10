using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Mono;
using Unity;

namespace System.Reflection
{
	/// <summary>Выявляет атрибуты события и обеспечивает доступ к метаданным события.</summary>
	// Token: 0x02000899 RID: 2201
	[Serializable]
	public abstract class EventInfo : MemberInfo, _EventInfo
	{
		/// <summary>Возвращает значение, <see cref="T:System.Reflection.MemberTypes" /> указывающее, что этот член является событием.</summary>
		/// <returns>Значение, <see cref="T:System.Reflection.MemberTypes" /> показывающее, что этот член является событием.</returns>
		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x00015831 File Offset: 0x00013A31
		public override MemberTypes MemberType
		{
			get
			{
				return MemberTypes.Event;
			}
		}

		/// <summary>Получает атрибуты этого события.</summary>
		/// <returns>Атрибуты этого события, доступные только для чтения.</returns>
		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x0600489C RID: 18588
		public abstract EventAttributes Attributes { get; }

		/// <summary>Возвращает значение, показывающее, есть ли у <see langword="EventInfo" /> имя со специальным значением.</summary>
		/// <returns>Значение <see langword="true" />, если у события есть специальное имя, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x000EE266 File Offset: 0x000EC466
		public bool IsSpecialName
		{
			get
			{
				return (this.Attributes & EventAttributes.SpecialName) > EventAttributes.None;
			}
		}

		/// <summary>Возвращает открытые методы, которые были сопоставлены событию в метаданных с использованием директивы <see langword=".other" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющих открытые методы, которые были сопоставлены событию в метаданных с использованием директивы <see langword=".other" />. Если такие открытые методы отсутствует, возвращается пустой массив.</returns>
		// Token: 0x0600489E RID: 18590 RVA: 0x000EE277 File Offset: 0x000EC477
		public MethodInfo[] GetOtherMethods()
		{
			return this.GetOtherMethods(false);
		}

		/// <summary>Возвращает методы, которые были сопоставлены событию в метаданных с использованием директивы <see langword=".other" />, определяя, должны ли быть включены методы, не являющиеся открытыми.</summary>
		/// <param name="nonPublic">Значение <see langword="true" /> для включения методов, не являющихся открытыми, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Reflection.EventInfo" />, представляющих открытые методы, которые были сопоставлены событию в метаданных с использованием директивы <see langword=".other" />. Если соответствующие спецификации методы отсутствует, возвращается пустой массив.</returns>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован.</exception>
		// Token: 0x0600489F RID: 18591 RVA: 0x00047226 File Offset: 0x00045426
		public virtual MethodInfo[] GetOtherMethods(bool nonPublic)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodInfo" /> для метода <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> события, включая методы, не являющиеся открытыми.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" /> для метода <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" />.</returns>
		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x060048A0 RID: 18592 RVA: 0x000EE280 File Offset: 0x000EC480
		public virtual MethodInfo AddMethod
		{
			get
			{
				return this.GetAddMethod(true);
			}
		}

		/// <summary>Получает объект <see langword="MethodInfo" /> для удаления метода события, включая методы, не являющиеся открытыми.</summary>
		/// <returns>Объект <see langword="MethodInfo" /> для удаления метода события.</returns>
		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x000EE289 File Offset: 0x000EC489
		public virtual MethodInfo RemoveMethod
		{
			get
			{
				return this.GetRemoveMethod(true);
			}
		}

		/// <summary>Получает метод, вызываемый при возникновении события, включая неоткрытые методы.</summary>
		/// <returns>Метод, вызываемый при возникновении события.</returns>
		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x060048A2 RID: 18594 RVA: 0x000EE292 File Offset: 0x000EC492
		public virtual MethodInfo RaiseMethod
		{
			get
			{
				return this.GetRaiseMethod(true);
			}
		}

		/// <summary>Возвращает метод, используемый для добавления делегата обработчика событий для источника событий.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый, чтобы добавить делегат обработчика событий для источника событий.</returns>
		// Token: 0x060048A3 RID: 18595 RVA: 0x000EE29B File Offset: 0x000EC49B
		public MethodInfo GetAddMethod()
		{
			return this.GetAddMethod(false);
		}

		/// <summary>Возвращает метод, используемый для удаления делегата обработчика событий из списка вызова источника событий.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый для удаления делегата обработчика событий из источника событий.</returns>
		// Token: 0x060048A4 RID: 18596 RVA: 0x000EE2A4 File Offset: 0x000EC4A4
		public MethodInfo GetRemoveMethod()
		{
			return this.GetRemoveMethod(false);
		}

		/// <summary>Возвращает метод, вызываемый при возникновении события.</summary>
		/// <returns>Метод, вызываемый при возникновении события.</returns>
		// Token: 0x060048A5 RID: 18597 RVA: 0x000EE2AD File Offset: 0x000EC4AD
		public MethodInfo GetRaiseMethod()
		{
			return this.GetRaiseMethod(false);
		}

		/// <summary>Если переопределен в производном классе, то возвращает объект <see langword="MethodInfo" /> для метода <see cref="M:System.Reflection.EventInfo.AddEventHandler(System.Object,System.Delegate)" /> события, указывая, нужно ли возвращать методы, не являющиеся открытыми.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, если методы, не являющиеся открытыми, могут быть возвращены, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый, чтобы добавить делегат обработчика событий для источника событий.</returns>
		/// <exception cref="T:System.MethodAccessException">Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, метод, используемый для добавления делегата обработчика событий, не является открытым, и вызывающий оператор не обладает разрешением на отражение для методов, не являющихся открытыми.</exception>
		// Token: 0x060048A6 RID: 18598
		public abstract MethodInfo GetAddMethod(bool nonPublic);

		/// <summary>При переопределении в производном классе возвращает объект <see langword="MethodInfo" /> для удаления метода события, определяя, нужно ли возвращать методы, не являющиеся открытыми.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, если методы, не являющиеся открытыми, могут быть возвращены, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, используемый для удаления делегата обработчика событий из источника событий.</returns>
		/// <exception cref="T:System.MethodAccessException">Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, метод, используемый для добавления делегата обработчика событий, не является открытым, и вызывающий оператор не обладает разрешением на отражение для методов, не являющихся открытыми.</exception>
		// Token: 0x060048A7 RID: 18599
		public abstract MethodInfo GetRemoveMethod(bool nonPublic);

		/// <summary>При переопределении в производном классе возвращает метод, вызываемый при возникновении события, указывая, нужно ли возвращать методы, не являющиеся открытыми.</summary>
		/// <param name="nonPublic">Значение <see langword="true" />, если методы, не являющиеся открытыми, могут быть возвращены, в обратном случае — значение <see langword="false" />.</param>
		/// <returns>Объект <see langword="MethodInfo" />, вызванный при возникновении события.</returns>
		/// <exception cref="T:System.MethodAccessException">Параметр <paramref name="nonPublic" /> имеет значение <see langword="true" />, метод, используемый для добавления делегата обработчика событий, не является открытым, и вызывающий оператор не обладает разрешением на отражение для методов, не являющихся открытыми.</exception>
		// Token: 0x060048A8 RID: 18600
		public abstract MethodInfo GetRaiseMethod(bool nonPublic);

		/// <summary>Возвращает значение, показывающее, является ли событие многоадресным.</summary>
		/// <returns>Значение <see langword="true" />, если делегат является многоадресным. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x000EE2B8 File Offset: 0x000EC4B8
		public virtual bool IsMulticast
		{
			get
			{
				Type eventHandlerType = this.EventHandlerType;
				return typeof(MulticastDelegate).IsAssignableFrom(eventHandlerType);
			}
		}

		/// <summary>Получает объект <see langword="Type" /> базового делегата обработчика событий, связанного с данным событием.</summary>
		/// <returns>Объект <see langword="Type" /> с доступом только для чтения, представляющий обработчик событий делегата.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x000EE2DC File Offset: 0x000EC4DC
		public virtual Type EventHandlerType
		{
			get
			{
				ParameterInfo[] parametersInternal = this.GetAddMethod(true).GetParametersInternal();
				Type typeFromHandle = typeof(Delegate);
				for (int i = 0; i < parametersInternal.Length; i++)
				{
					Type parameterType = parametersInternal[i].ParameterType;
					if (parameterType.IsSubclassOf(typeFromHandle))
					{
						return parameterType;
					}
				}
				return null;
			}
		}

		/// <summary>Удаляет обработчик событий из источника событий.</summary>
		/// <param name="target">Источник события.</param>
		/// <param name="handler">Делегат, связь которого с событиями, вызываемыми целевым объектом, должна быть разорвана.</param>
		/// <exception cref="T:System.InvalidOperationException">Для этого события не предусмотрен открытый метод доступа <see langword="remove" />.</exception>
		/// <exception cref="T:System.ArgumentException">Переданный обработчик нельзя использовать.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений из Магазина Windows или в переносимой библиотеке классов перехватите <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Параметр <paramref name="target" /> имеет значение <see langword="null" /> и событие не является статическим.  
		/// -или- 
		/// Объект <see cref="T:System.Reflection.EventInfo" /> не объявлен для целевого объекта.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений из Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий оператор не имеет разрешения на доступ к данному члену.</exception>
		// Token: 0x060048AB RID: 18603 RVA: 0x000EE324 File Offset: 0x000EC524
		[DebuggerStepThrough]
		[DebuggerHidden]
		public virtual void RemoveEventHandler(object target, Delegate handler)
		{
			MethodInfo removeMethod = this.GetRemoveMethod(false);
			if (removeMethod == null)
			{
				throw new InvalidOperationException("Cannot remove the event handler since no public remove method exists for the event.");
			}
			if (removeMethod.GetParametersNoCopy()[0].ParameterType == typeof(EventRegistrationToken))
			{
				throw new InvalidOperationException("Adding or removing event handlers dynamically is not supported on WinRT events.");
			}
			removeMethod.Invoke(target, new object[]
			{
				handler
			});
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048AC RID: 18604 RVA: 0x000EE386 File Offset: 0x000EC586
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		// Token: 0x060048AD RID: 18605 RVA: 0x000EE38F File Offset: 0x000EC58F
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.EventInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048AE RID: 18606 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(EventInfo left, EventInfo right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.EventInfo" />.</summary>
		/// <param name="left">Первый сравниваемый объект.</param>
		/// <param name="right">Второй сравниваемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060048AF RID: 18607 RVA: 0x000EE397 File Offset: 0x000EC597
		public static bool operator !=(EventInfo left, EventInfo right)
		{
			return !(left == right);
		}

		/// <summary>Добавляет обработчик событий к источнику событий.</summary>
		/// <param name="target">Источник события.</param>
		/// <param name="handler">Инкапсулирует метод или методы, вызываемые, когда событие вызывается целевым объектом.</param>
		/// <exception cref="T:System.InvalidOperationException">Для этого события не предусмотрен открытый метод доступа <see langword="add" />.</exception>
		/// <exception cref="T:System.ArgumentException">Переданный обработчик нельзя использовать.</exception>
		/// <exception cref="T:System.MethodAccessException">Вместо этого в .NET для приложений из Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.  
		///
		///
		///
		///
		///  Вызывающий оператор не имеет разрешения на доступ к данному члену.</exception>
		/// <exception cref="T:System.Reflection.TargetException">Вместо этого в .NET для приложений из Магазина Windows или в переносимой библиотеке классов перехватите <see cref="T:System.Exception" />.  
		///
		///
		///
		///
		///  Параметр <paramref name="target" /> имеет значение <see langword="null" /> и событие не является статическим.  
		/// -или- 
		/// Объект <see cref="T:System.Reflection.EventInfo" /> не объявлен для целевого объекта.</exception>
		// Token: 0x060048B0 RID: 18608 RVA: 0x000EE3A4 File Offset: 0x000EC5A4
		[DebuggerStepThrough]
		[DebuggerHidden]
		public virtual void AddEventHandler(object target, Delegate handler)
		{
			if (this.cached_add_event == null)
			{
				MethodInfo addMethod = this.GetAddMethod();
				if (addMethod == null)
				{
					throw new InvalidOperationException("Cannot add the event handler since no public add method exists for the event.");
				}
				if (addMethod.DeclaringType.IsValueType)
				{
					if (target == null && !addMethod.IsStatic)
					{
						throw new TargetException("Cannot add a handler to a non static event with a null target");
					}
					addMethod.Invoke(target, new object[]
					{
						handler
					});
					return;
				}
				else
				{
					this.cached_add_event = EventInfo.CreateAddEventDelegate(addMethod);
				}
			}
			this.cached_add_event(target, handler);
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x000EE424 File Offset: 0x000EC624
		private static void AddEventFrame<T, D>(EventInfo.AddEvent<T, D> addEvent, object obj, object dele)
		{
			if (obj == null)
			{
				throw new TargetException("Cannot add a handler to a non static event with a null target");
			}
			if (!(obj is T))
			{
				throw new TargetException("Object doesn't match target");
			}
			if (!(dele is D))
			{
				throw new ArgumentException(string.Format("Object of type {0} cannot be converted to type {1}.", dele.GetType(), typeof(D)));
			}
			addEvent((T)((object)obj), (D)((object)dele));
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x000EE48C File Offset: 0x000EC68C
		private static void StaticAddEventAdapterFrame<D>(EventInfo.StaticAddEvent<D> addEvent, object obj, object dele)
		{
			addEvent((D)((object)dele));
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x000EE49C File Offset: 0x000EC69C
		private static EventInfo.AddEventAdapter CreateAddEventDelegate(MethodInfo method)
		{
			Type[] typeArguments;
			Type typeFromHandle;
			string name;
			if (method.IsStatic)
			{
				typeArguments = new Type[]
				{
					method.GetParametersInternal()[0].ParameterType
				};
				typeFromHandle = typeof(EventInfo.StaticAddEvent<>);
				name = "StaticAddEventAdapterFrame";
			}
			else
			{
				typeArguments = new Type[]
				{
					method.DeclaringType,
					method.GetParametersInternal()[0].ParameterType
				};
				typeFromHandle = typeof(EventInfo.AddEvent<, >);
				name = "AddEventFrame";
			}
			object firstArgument = Delegate.CreateDelegate(typeFromHandle.MakeGenericType(typeArguments), method);
			MethodInfo methodInfo = typeof(EventInfo).GetMethod(name, BindingFlags.Static | BindingFlags.NonPublic);
			methodInfo = methodInfo.MakeGenericMethod(typeArguments);
			return (EventInfo.AddEventAdapter)Delegate.CreateDelegate(typeof(EventInfo.AddEventAdapter), firstArgument, methodInfo, true);
		}

		// Token: 0x060048B4 RID: 18612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle);

		// Token: 0x060048B5 RID: 18613 RVA: 0x000EE550 File Offset: 0x000EC750
		internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType)
		{
			if (handle.Value == IntPtr.Zero)
			{
				throw new ArgumentException("The handle is invalid.");
			}
			EventInfo eventInfo = EventInfo.internal_from_handle_type(handle.Value, reflectedType.Value);
			if (eventInfo == null)
			{
				throw new ArgumentException("The event handle and the type handle are incompatible.");
			}
			return eventInfo;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048B6 RID: 18614 RVA: 0x000173AD File Offset: 0x000155AD
		void _EventInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает объект T:System.Type, представляющий тип <see cref="T:System.Reflection.EventInfo" />.</summary>
		/// <returns>Объект T:System.Type, представляющий тип <see cref="T:System.Reflection.EventInfo" />.</returns>
		// Token: 0x060048B7 RID: 18615 RVA: 0x00052955 File Offset: 0x00050B55
		Type _EventInfo.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048B8 RID: 18616 RVA: 0x000173AD File Offset: 0x000155AD
		void _EventInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048B9 RID: 18617 RVA: 0x000173AD File Offset: 0x000155AD
		void _EventInfo.GetTypeInfoCount(out uint pcTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060048BA RID: 18618 RVA: 0x000173AD File Offset: 0x000155AD
		void _EventInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002E8B RID: 11915
		private EventInfo.AddEventAdapter cached_add_event;

		// Token: 0x0200089A RID: 2202
		// (Invoke) Token: 0x060048BC RID: 18620
		private delegate void AddEventAdapter(object _this, Delegate dele);

		// Token: 0x0200089B RID: 2203
		// (Invoke) Token: 0x060048C0 RID: 18624
		private delegate void AddEvent<T, D>(T _this, D dele);

		// Token: 0x0200089C RID: 2204
		// (Invoke) Token: 0x060048C4 RID: 18628
		private delegate void StaticAddEvent<D>(D dele);
	}
}
