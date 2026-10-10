using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity;

namespace System.Reflection
{
	/// <summary>Получает сведения об атрибутах компонента и обеспечивает доступ к метаданным его членов.</summary>
	// Token: 0x020008AA RID: 2218
	[Serializable]
	public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo
	{
		/// <summary>При переопределении в производном классе получает значение <see cref="T:System.Reflection.MemberTypes" />, определяющее тип члена: метод, конструктор, событие и так далее.</summary>
		/// <returns>Значение <see cref="T:System.Reflection.MemberTypes" />, показывающее тип элемента.</returns>
		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06004911 RID: 18705
		public abstract MemberTypes MemberType { get; }

		/// <summary>Возвращает имя текущего члена.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий имя данного элемента.</returns>
		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06004912 RID: 18706
		public abstract string Name { get; }

		/// <summary>Получает класс, объявляющий этот член.</summary>
		/// <returns>Объект <see langword="Type" /> для класса, объявляющего данный член.</returns>
		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06004913 RID: 18707
		public abstract Type DeclaringType { get; }

		/// <summary>Получает объект класса, который использовался для извлечения данного экземпляра объекта <see langword="MemberInfo" />.</summary>
		/// <returns>Объект <see langword="Type" />, через который был получен данный объект <see langword="MemberInfo" />.</returns>
		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06004914 RID: 18708
		public abstract Type ReflectedType { get; }

		/// <summary>Получает модуль, в котором определяется тип, объявляющий член, представленный текущим объектом <see cref="T:System.Reflection.MemberInfo" />.</summary>
		/// <returns>Модуль <see cref="T:System.Reflection.Module" />, определяющий тип, в котором объявляется член, представленный текущим объектом <see cref="T:System.Reflection.MemberInfo" />.</returns>
		/// <exception cref="T:System.NotImplementedException">Этот метод не реализован.</exception>
		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x000EE968 File Offset: 0x000ECB68
		public virtual Module Module
		{
			get
			{
				Type type = this as Type;
				if (type != null)
				{
					return type.Module;
				}
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool HasSameMetadataDefinitionAs(MemberInfo other)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>При переопределении в производном классе указывает, применяются ли для этого члена один или несколько атрибутов заданного типа или его производных типов.</summary>
		/// <param name="attributeType">Искомый тип настраиваемого атрибута. Поиск включает производные типы.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />. Этот параметр игнорируется для свойств и событий.</param>
		/// <returns>Значение <see langword="true" />, если один или несколько экземпляров типа <paramref name="attributeType" /> или его производных типов применяются к данному члену; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004917 RID: 18711
		public abstract bool IsDefined(Type attributeType, bool inherit);

		/// <summary>При переопределении в производном классе возвращает массив всех настраиваемых атрибутов, примененных к данному члену.</summary>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />. Этот параметр игнорируется для свойств и событий.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, примененные к данному члену, или массив с нулем элементов, если атрибуты не определены.</returns>
		/// <exception cref="T:System.InvalidOperationException">Этот член относится к типу, который загружается в контекст, используемый только для отражения. См. Практическое руководство. Загрузка сборок в контекст, предназначенный только для отражения.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x06004918 RID: 18712
		public abstract object[] GetCustomAttributes(bool inherit);

		/// <summary>При переопределении в производном классе возвращает массив всех настраиваемых атрибутов, примененных к данному члену и определенных типом <see cref="T:System.Type" />.</summary>
		/// <param name="attributeType">Искомый тип атрибута. Возвращаются только те атрибуты, которые можно назначить этому типу.</param>
		/// <param name="inherit">Значение <see langword="true" />, с целью поиска цепочки наследования этого члена для поиска атрибутов, в противном случае — значение <see langword="false" />. Этот параметр игнорируется для свойств и событий.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты, примененные к данному члену, или массив с нулем элементов, если атрибуты, которые могут быть присвоены типу <paramref name="attributeType" />, не применялись.</returns>
		/// <exception cref="T:System.TypeLoadException">Не удается загрузить тип настраиваемого атрибута.</exception>
		/// <exception cref="T:System.ArgumentNullException">Если <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Этот член относится к типу, который загружается в контекст, используемый только для отражения. См. Практическое руководство. Загрузка сборок в контекст, предназначенный только для отражения.</exception>
		// Token: 0x06004919 RID: 18713
		public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

		/// <summary>Получает коллекцию, содержащую пользовательские атрибуты этого члена.</summary>
		/// <returns>Коллекция, содержащая пользовательские атрибуты этого члена.</returns>
		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600491A RID: 18714 RVA: 0x000EE991 File Offset: 0x000ECB91
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, которые были применены к целевому члену.</summary>
		/// <returns>Универсальный список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, которые были применены к целевому члену.</returns>
		// Token: 0x0600491B RID: 18715 RVA: 0x00047226 File Offset: 0x00045426
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает значение, определяющее элемент метаданных.</summary>
		/// <returns>Значение, которое в сочетании со свойством <see cref="P:System.Reflection.MemberInfo.Module" /> уникальным образом определяет элемент метаданных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий объект <see cref="T:System.Reflection.MemberInfo" /> представляет метод массива, например <see langword="Address" />, для массива, тип элементов которого является динамическим типом, который не был завершен. Чтобы получить токен метаданных в этом случае, следует передать объект <see cref="T:System.Reflection.MemberInfo" /> в метод <see cref="M:System.Reflection.Emit.ModuleBuilder.GetMethodToken(System.Reflection.MethodInfo)" /> либо при помощи метода <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethodToken(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" /> получить токен напрямую, не вызывая предварительно метод <see cref="M:System.Reflection.Emit.ModuleBuilder.GetArrayMethod(System.Type,System.String,System.Reflection.CallingConventions,System.Type,System.Type[])" /> для получения объекта <see cref="T:System.Reflection.MethodInfo" />.</exception>
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600491C RID: 18716 RVA: 0x00084B8D File Offset: 0x00082D8D
		public virtual int MetadataToken
		{
			get
			{
				throw new InvalidOperationException();
			}
		}

		/// <summary>Возвращает значение, указывающее, равен ли этот экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект <paramref name="obj" /> типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600491D RID: 18717 RVA: 0x00097E2A File Offset: 0x0009602A
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		/// <summary>Возвращает хэш-код для данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битовым целым числом со знаком.</returns>
		// Token: 0x0600491E RID: 18718 RVA: 0x000930E8 File Offset: 0x000912E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.MemberInfo" />.</summary>
		/// <param name="left">Объект <see cref="T:System.Reflection.MemberInfo" />, используемый для сравнения с <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.Reflection.MemberInfo" />, используемый для сравнения с <paramref name="left" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="left" /> равен <paramref name="right" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600491F RID: 18719 RVA: 0x000EE99C File Offset: 0x000ECB9C
		public static bool operator ==(MemberInfo left, MemberInfo right)
		{
			if (left == right)
			{
				return true;
			}
			if (left == null || right == null)
			{
				return false;
			}
			Type left2;
			Type right2;
			if ((left2 = (left as Type)) != null && (right2 = (right as Type)) != null)
			{
				return left2 == right2;
			}
			MethodBase left3;
			MethodBase right3;
			if ((left3 = (left as MethodBase)) != null && (right3 = (right as MethodBase)) != null)
			{
				return left3 == right3;
			}
			FieldInfo left4;
			FieldInfo right4;
			if ((left4 = (left as FieldInfo)) != null && (right4 = (right as FieldInfo)) != null)
			{
				return left4 == right4;
			}
			EventInfo left5;
			EventInfo right5;
			if ((left5 = (left as EventInfo)) != null && (right5 = (right as EventInfo)) != null)
			{
				return left5 == right5;
			}
			PropertyInfo left6;
			PropertyInfo right6;
			return (left6 = (left as PropertyInfo)) != null && (right6 = (right as PropertyInfo)) != null && left6 == right6;
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.MemberInfo" />.</summary>
		/// <param name="left">Объект <see cref="T:System.Reflection.MemberInfo" />, используемый для сравнения с <paramref name="right" />.</param>
		/// <param name="right">Объект <see cref="T:System.Reflection.MemberInfo" />, используемый для сравнения с <paramref name="left" />.</param>
		/// <returns>Значение <see langword="true" />, если параметры <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004920 RID: 18720 RVA: 0x000EEA8C File Offset: 0x000ECC8C
		public static bool operator !=(MemberInfo left, MemberInfo right)
		{
			return !(left == right);
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual bool CacheEquals(object o)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x000EEA98 File Offset: 0x000ECC98
		internal bool HasSameMetadataDefinitionAsCore<TOther>(MemberInfo other) where TOther : MemberInfo
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			return other is TOther && this.MetadataToken == other.MetadataToken && this.Module.Equals(other.Module);
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для использования в будущем. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004923 RID: 18723 RVA: 0x000173AD File Offset: 0x000155AD
		void _MemberInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Reflection.MemberInfo" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий класс <see cref="T:System.Reflection.MemberInfo" />.</returns>
		// Token: 0x06004924 RID: 18724 RVA: 0x00052955 File Offset: 0x00050B55
		Type _MemberInfo.GetType()
		{
			ThrowStub.ThrowNotSupportedException();
			return null;
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004925 RID: 18725 RVA: 0x000173AD File Offset: 0x000155AD
		void _MemberInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004926 RID: 18726 RVA: 0x000173AD File Offset: 0x000155AD
		void _MemberInfo.GetTypeInfoCount(out uint pcTInfo)
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
		/// <exception cref="T:System.NotImplementedException">Этот метод вызывается с поздним связыванием с помощью COM-интерфейса IDispatch.</exception>
		// Token: 0x06004927 RID: 18727 RVA: 0x000173AD File Offset: 0x000155AD
		void _MemberInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}
	}
}
