using System;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>
	///         Разрешает регистрацию позднего связывания для обработчика событий.
	///       </summary>
	// Token: 0x020002D4 RID: 724
	public class ComAwareEventInfo : EventInfo
	{
		/// <summary>
		///         Получает атрибуты для этого события.
		///       </summary>
		/// <returns>
		///         Атрибуты только для чтения для данного события.
		///       </returns>
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override EventAttributes Attributes
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает класс, объявивший этот член.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объект для класса, который объявляет этот член.
		///       </returns>
		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override Type DeclaringType
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Возвращает имя текущего элемента.
		///       </summary>
		/// <returns>
		///         Имя данного элемента.
		///       </returns>
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override string Name
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Runtime.InteropServices.ComAwareEventInfo" /> используя указанный тип и имя события типа.
		///       </summary>
		/// <param name="type">
		///           Тип объекта.
		///         </param>
		/// <param name="eventName">
		///           Имя события на <paramref name="type" />.
		///         </param>
		// Token: 0x06001610 RID: 5648 RVA: 0x0004A92D File Offset: 0x00048B2D
		[MonoTODO]
		public ComAwareEventInfo(Type type, string eventName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Присоединяет обработчик событий COM-объект.
		///       </summary>
		/// <param name="target">
		///           Целевой объект, которому должен привязываться делегат события.
		///         </param>
		/// <param name="handler">
		///           Делегат события.
		///         </param>
		// Token: 0x06001611 RID: 5649 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override void AddEventHandler(object target, Delegate handler)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Отсоединяет обработчик событий от COM-объекта.
		///       </summary>
		/// <param name="target">
		///           Целевой объект, к которому привязан делегат события.
		///         </param>
		/// <param name="handler">
		///           Делегат события.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             Это событие не поддерживает открытый метод доступа <see langword="remove" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Переданный обработчик нельзя использовать.
		///           </exception>
		/// <exception cref="T:System.Reflection.TargetException">
		///               Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение <see cref="T:System.Exception" />.
		///
		///             Параметр <paramref name="target" /> имеет значение <see langword="null" />, и событие не является статическим.
		///
		///             -или- 
		///
		///             Класс <see cref="T:System.Reflection.EventInfo" /> не объявлен для целевого объекта.
		///           </exception>
		/// <exception cref="T:System.MethodAccessException">
		///               Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.MemberAccessException" />.
		///
		///             Вызывающий объект не имеет разрешения на доступ к этому элементу.
		///           </exception>
		// Token: 0x06001612 RID: 5650 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override void RemoveEventHandler(object target, Delegate handler)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Возвращает метод, использованный для добавления делегата обработчика событий для источника событий.
		///       </summary>
		/// <param name="nonPublic">
		///           <see langword="true" /> для возврата закрытые методы; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Делегировать метод, который был использован для добавления обработчика событий для источника событий.
		///       </returns>
		/// <exception cref="T:System.MethodAccessException">
		///             <paramref name="nonPublic" /> — <see langword="true" /> метод, используемый для добавления делегата обработчика событий не является открытым, а вызывающий оператор не обладает разрешением на отражение на закрытые методы.
		///           </exception>
		// Token: 0x06001613 RID: 5651 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает метод, вызываемый при возникновении события.
		///       </summary>
		/// <param name="nonPublic">
		///           <see langword="true" /> для возврата закрытые методы; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Объект, вызванный при возникновении события.
		///       </returns>
		/// <exception cref="T:System.MethodAccessException">
		///             <paramref name="nonPublic" /> — <see langword="true" /> метод, используемый для добавления делегата обработчика событий не является открытым, а вызывающий оператор не обладает разрешением на отражение на закрытые методы.
		///           </exception>
		// Token: 0x06001614 RID: 5652 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         При переопределении в производном классе получает <see cref="T:System.Reflection.MethodInfo" /> объект для удаления метода события.
		///       </summary>
		/// <param name="nonPublic">
		///           <see langword="true" /> для возврата закрытые методы; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Делегат метода, который использовался для удаления обработчика событий из источника событий.
		///       </returns>
		/// <exception cref="T:System.MethodAccessException">
		///             <paramref name="nonPublic" /> — <see langword="true" /> метод, используемый для добавления делегата обработчика событий не является открытым, а вызывающий оператор не обладает разрешением на отражение на закрытые методы.
		///           </exception>
		// Token: 0x06001615 RID: 5653 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает массив, содержащий все настраиваемые атрибуты указанного типа, применяемых к этому члену.
		///       </summary>
		/// <param name="attributeType">
		///           Тип атрибута для поиска.
		///            Только те атрибуты, которые можно назначить для этого типа могут быть возвращены.
		///         </param>
		/// <param name="inherit">
		///           <see langword="true" /> для поиска цепочки наследования этого элемента для поиска атрибутов; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Массив, содержащий все настраиваемые атрибуты заданного типа, или массив, не содержащий элементов, если атрибуты не определены.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот член принадлежит к типу, который загружается в контекст, предназначенный только для отражения.
		///              См. раздел How to: Load Assemblies into the Reflection-Only Context.
		///           </exception>
		/// <exception cref="T:System.TypeLoadException">
		///             Не удалось загрузить тип настраиваемого атрибута.
		///           </exception>
		// Token: 0x06001616 RID: 5654 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         При переопределении в производном классе получает массив, содержащий настраиваемые атрибуты, применяемые к этому члену.
		///       </summary>
		/// <param name="inherit">
		///           <see langword="true" /> для поиска цепочки наследования этого элемента для поиска атрибутов; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         Массив, содержащий настраиваемые атрибуты, или массив, не содержащий элементов, если атрибуты не определены.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот член принадлежит к типу, который загружается в контекст, предназначенный только для отражения.
		///              См. раздел How to: Load Assemblies into the Reflection-Only Context.
		///           </exception>
		/// <exception cref="T:System.TypeLoadException">
		///             Не удалось загрузить тип настраиваемого атрибута.
		///           </exception>
		// Token: 0x06001617 RID: 5655 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Указывает, применяются ли для этого члена один или несколько экземпляров указанного атрибута.
		///       </summary>
		/// <param name="attributeType">
		///           Тип атрибута для поиска.
		///         </param>
		/// <param name="inherit">
		///           <see langword="true" /> для поиска цепочки наследования этого элемента для поиска атрибутов; в противном случае — <see langword="false" />.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если указанный атрибут применен к этому члену; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06001618 RID: 5656 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Получает объект класса, который использовался для инициализации данного экземпляра.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Type" /> Объект, который был использован для инициализации текущего объекта.
		///       </returns>
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x000023CA File Offset: 0x000005CA
		[MonoTODO]
		public override Type ReflectedType
		{
			get
			{
				throw new NotImplementedException();
			}
		}
	}
}
