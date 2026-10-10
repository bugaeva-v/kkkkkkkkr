using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using Unity;

namespace System.Reflection
{
	/// <summary>Обнаруживает атрибуты параметра и обеспечивает доступ к его метаданным.</summary>
	// Token: 0x020008B6 RID: 2230
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="ParameterInfo" />.</summary>
		// Token: 0x060049BF RID: 18879 RVA: 0x0000259F File Offset: 0x0000079F
		protected ParameterInfo()
		{
		}

		/// <summary>Получает атрибуты этого параметра.</summary>
		/// <returns>Объект <see langword="ParameterAttributes" />, который представляет атрибуты этого параметра.</returns>
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060049C0 RID: 18880 RVA: 0x000EF21F File Offset: 0x000ED41F
		public virtual ParameterAttributes Attributes
		{
			get
			{
				return this.AttrsImpl;
			}
		}

		/// <summary>Возвращает значение, указывающее член, в котором реализован данный параметр.</summary>
		/// <returns>Элемент, вставивший параметр, который представлен этим объектом <see cref="T:System.Reflection.ParameterInfo" />.</returns>
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060049C1 RID: 18881 RVA: 0x000EF227 File Offset: 0x000ED427
		public virtual MemberInfo Member
		{
			get
			{
				return this.MemberImpl;
			}
		}

		/// <summary>Возвращает имя параметра.</summary>
		/// <returns>Простое имя параметра.</returns>
		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060049C2 RID: 18882 RVA: 0x000EF22F File Offset: 0x000ED42F
		public virtual string Name
		{
			get
			{
				return this.NameImpl;
			}
		}

		/// <summary>Получает тип <see langword="Type" /> данного параметра.</summary>
		/// <returns>Объект <see langword="Type" />, который представляет тип <see langword="Type" /> данного параметра.</returns>
		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060049C3 RID: 18883 RVA: 0x000EF237 File Offset: 0x000ED437
		public virtual Type ParameterType
		{
			get
			{
				return this.ClassImpl;
			}
		}

		/// <summary>Получает отсчитываемую от нуля позицию параметра в списке формальных параметров.</summary>
		/// <returns>Целое число, представляющее позицию, которую этот параметр занимает в списке параметров.</returns>
		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060049C4 RID: 18884 RVA: 0x000EF23F File Offset: 0x000ED43F
		public virtual int Position
		{
			get
			{
				return this.PositionImpl;
			}
		}

		/// <summary>Получает значение, указывающее, является ли этот параметр входным.</summary>
		/// <returns>Значение <see langword="true" />, если параметр является входным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x000EF247 File Offset: 0x000ED447
		public bool IsIn
		{
			get
			{
				return (this.Attributes & ParameterAttributes.In) > ParameterAttributes.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот параметр идентификатором языка локализации (lcid).</summary>
		/// <returns>Значение <see langword="true" />, если параметр является идентификатором региональных стандартов; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060049C6 RID: 18886 RVA: 0x000EF254 File Offset: 0x000ED454
		public bool IsLcid
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Lcid) > ParameterAttributes.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот параметр необязательным.</summary>
		/// <returns>Значение <see langword="true" />, если параметр является необязательным; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x000EF261 File Offset: 0x000ED461
		public bool IsOptional
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Optional) > ParameterAttributes.None;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли этот параметр выходным.</summary>
		/// <returns>Значение <see langword="true" />, если параметр является выходным; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060049C8 RID: 18888 RVA: 0x000EF26F File Offset: 0x000ED46F
		public bool IsOut
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Out) > ParameterAttributes.None;
			}
		}

		/// <summary>Получает значение, показывающее, является ли этот параметр параметром <see langword="Retval" />.</summary>
		/// <returns>Значение <see langword="true" />, если параметр является значением <see langword="Retval" />; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060049C9 RID: 18889 RVA: 0x000EF27C File Offset: 0x000ED47C
		public bool IsRetval
		{
			get
			{
				return (this.Attributes & ParameterAttributes.Retval) > ParameterAttributes.None;
			}
		}

		/// <summary>Возвращает значение по умолчанию, если оно задано для параметра.</summary>
		/// <returns>Значение параметра по умолчанию или значение <see cref="F:System.DBNull.Value" />, если параметр не имеет значения по умолчанию.</returns>
		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060049CA RID: 18890 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object DefaultValue
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает значение по умолчанию, если оно задано для параметра.</summary>
		/// <returns>Значение параметра по умолчанию или значение <see cref="F:System.DBNull.Value" />, если параметр не имеет значения по умолчанию.</returns>
		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060049CB RID: 18891 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object RawDefaultValue
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Получает значение, указывающее, имеет ли данный параметр значение по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если этот параметр имеет значение по умолчанию; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060049CC RID: 18892 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool HasDefaultValue
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Определяет, применяется ли настраиваемый атрибут заданного типа или его производных типов к данному параметру.</summary>
		/// <param name="attributeType">Объект <see langword="Type" />, который требуется найти.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если к этому параметру применяется один или несколько экземпляров типа <paramref name="attributeType" /> или его производных типов; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="attributeType" /> не является объектом типа <see cref="T:System.Type" />, предоставленным средой CLR.</exception>
		// Token: 0x060049CD RID: 18893 RVA: 0x000EF289 File Offset: 0x000ED489
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return false;
		}

		/// <summary>Получает коллекцию, содержащую пользовательские атрибуты этого параметра.</summary>
		/// <returns>Коллекция, содержащая пользовательские атрибуты этого параметра.</returns>
		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060049CE RID: 18894 RVA: 0x000EF2A0 File Offset: 0x000ED4A0
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" /> для текущего параметра, который можно использовать в контексте, предназначенном только для отражения.</summary>
		/// <returns>Универсальный список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, которые были применены к текущему параметру.</returns>
		// Token: 0x060049CF RID: 18895 RVA: 0x00047226 File Offset: 0x00045426
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает все пользовательские атрибуты, определенные для этого параметра.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий все настраиваемые атрибуты, примененные к данному параметру.</returns>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x060049D0 RID: 18896 RVA: 0x000EF2A8 File Offset: 0x000ED4A8
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			return Array.Empty<object>();
		}

		/// <summary>Получает настраиваемые атрибуты заданного типа или его производных типов, примененные к данному параметру.</summary>
		/// <param name="attributeType">Пользовательские атрибуты, идентифицируемые по типу.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив, содержащий настраиваемые атрибуты указанного типа или его производных типов.</returns>
		/// <exception cref="T:System.ArgumentException">Тип должен быть типом, предоставленным базовой системой среды выполнения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.TypeLoadException">Не удалось загрузить тип настраиваемого атрибута.</exception>
		// Token: 0x060049D1 RID: 18897 RVA: 0x000EF2AF File Offset: 0x000ED4AF
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			if (attributeType == null)
			{
				throw new ArgumentNullException("attributeType");
			}
			return Array.Empty<object>();
		}

		/// <summary>Возвращает необязательные настраиваемые модификаторы параметра.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, указывающих дополнительные настраиваемые модификаторы для текущего параметра, такие как <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsImplicitlyDereferenced" />.</returns>
		// Token: 0x060049D2 RID: 18898 RVA: 0x000EF2CA File Offset: 0x000ED4CA
		public virtual Type[] GetOptionalCustomModifiers()
		{
			return Array.Empty<Type>();
		}

		/// <summary>Возвращает обязательные настраиваемые модификаторы параметра.</summary>
		/// <returns>Массив объектов <see cref="T:System.Type" />, которые указывают обязательные настраиваемые модификаторы для текущего параметра, например <see cref="T:System.Runtime.CompilerServices.IsConst" /> или <see cref="T:System.Runtime.CompilerServices.IsImplicitlyDereferenced" />.</returns>
		// Token: 0x060049D3 RID: 18899 RVA: 0x000EF2CA File Offset: 0x000ED4CA
		public virtual Type[] GetRequiredCustomModifiers()
		{
			return Array.Empty<Type>();
		}

		/// <summary>Возвращает значение, определяющее этот параметр в метаданных.</summary>
		/// <returns>Свойство, которое в сочетании с модулем уникально идентифицирует этот параметр в метаданных.</returns>
		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060049D4 RID: 18900 RVA: 0x000EF2D1 File Offset: 0x000ED4D1
		public virtual int MetadataToken
		{
			get
			{
				return 134217728;
			}
		}

		/// <summary>Возвращает реальный объект, который необходимо десериализовать, вместо объекта, задаваемого сериализованным потоком.</summary>
		/// <param name="context">Сериализованный поток, из которого десериализуется текущий объект.</param>
		/// <returns>Реальный объект, который помещается в граф.</returns>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Позиция параметра в списке параметров связанного с ним члена недопустима для типа этого члена.</exception>
		// Token: 0x060049D5 RID: 18901 RVA: 0x000EF2D8 File Offset: 0x000ED4D8
		[SecurityCritical]
		public object GetRealObject(StreamingContext context)
		{
			if (this.MemberImpl == null)
			{
				throw new SerializationException("Insufficient state to return the real object.");
			}
			MemberTypes memberType = this.MemberImpl.MemberType;
			if (memberType != MemberTypes.Constructor && memberType != MemberTypes.Method)
			{
				if (memberType != MemberTypes.Property)
				{
					throw new SerializationException("Serialized member does not have a ParameterInfo.");
				}
				ParameterInfo[] array = ((PropertyInfo)this.MemberImpl).GetIndexParameters();
				if (array != null && this.PositionImpl > -1 && this.PositionImpl < array.Length)
				{
					return array[this.PositionImpl];
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
			else if (this.PositionImpl == -1)
			{
				if (this.MemberImpl.MemberType == MemberTypes.Method)
				{
					return ((MethodInfo)this.MemberImpl).ReturnParameter;
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
			else
			{
				ParameterInfo[] array = ((MethodBase)this.MemberImpl).GetParametersNoCopy();
				if (array != null && this.PositionImpl < array.Length)
				{
					return array[this.PositionImpl];
				}
				throw new SerializationException("Non existent ParameterInfo. Position bigger than member's parameters length.");
			}
		}

		/// <summary>Возвращает тип и имя параметра, представленные в виде строки.</summary>
		/// <returns>Строка, содержащая имя типа и имя параметра.</returns>
		// Token: 0x060049D6 RID: 18902 RVA: 0x000EF3CA File Offset: 0x000ED5CA
		public override string ToString()
		{
			return this.ParameterType.FormatTypeName() + " " + this.Name;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049D7 RID: 18903 RVA: 0x000173AD File Offset: 0x000155AD
		void _ParameterInfo.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049D8 RID: 18904 RVA: 0x000173AD File Offset: 0x000155AD
		void _ParameterInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049D9 RID: 18905 RVA: 0x000173AD File Offset: 0x000155AD
		void _ParameterInfo.GetTypeInfoCount(out uint pcTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
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
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049DA RID: 18906 RVA: 0x000173AD File Offset: 0x000155AD
		void _ParameterInfo.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Атрибуты параметра.</summary>
		// Token: 0x04002F05 RID: 12037
		protected ParameterAttributes AttrsImpl;

		/// <summary>Тип <see langword="Type" /> параметра.</summary>
		// Token: 0x04002F06 RID: 12038
		protected Type ClassImpl;

		/// <summary>Значение параметра по умолчанию.</summary>
		// Token: 0x04002F07 RID: 12039
		protected object DefaultValueImpl;

		/// <summary>Член, в котором реализовано данное поле.</summary>
		// Token: 0x04002F08 RID: 12040
		protected MemberInfo MemberImpl;

		/// <summary>Имя параметра.</summary>
		// Token: 0x04002F09 RID: 12041
		protected string NameImpl;

		/// <summary>Отсчитываемая от нуля позиция параметра в списке параметров.</summary>
		// Token: 0x04002F0A RID: 12042
		protected int PositionImpl;

		// Token: 0x04002F0B RID: 12043
		private const int MetadataToken_ParamDef = 134217728;
	}
}
