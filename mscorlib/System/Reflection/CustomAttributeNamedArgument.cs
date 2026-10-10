using System;
using System.Globalization;
using Internal.Runtime.Augments;

namespace System.Reflection
{
	/// <summary>Представляет именованный аргумент настраиваемого атрибута в контексте только для отражения.</summary>
	// Token: 0x020008DD RID: 2269
	public struct CustomAttributeNamedArgument
	{
		// Token: 0x06004B8F RID: 19343 RVA: 0x000F0A3D File Offset: 0x000EEC3D
		internal CustomAttributeNamedArgument(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
		{
			this.IsField = isField;
			this.MemberName = memberName;
			this.TypedValue = typedValue;
			this._attributeType = attributeType;
			this._lazyMemberInfo = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeNamedArgument" />, представляющего указанное поле или свойство настраиваемого атрибута, и задает значение поля или свойства.</summary>
		/// <param name="memberInfo">Поле или свойство настраиваемого атрибута. Новый объект <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> представляет этот элемент и его значение.</param>
		/// <param name="value">Значение поля или свойства настраиваемого атрибута.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="memberInfo" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="memberInfo" /> не является полем или свойством настраиваемого атрибута.</exception>
		// Token: 0x06004B90 RID: 19344 RVA: 0x000F0A68 File Offset: 0x000EEC68
		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
			if (memberInfo == null)
			{
				throw new ArgumentNullException("memberInfo");
			}
			FieldInfo fieldInfo = memberInfo as FieldInfo;
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			Type argumentType;
			if (fieldInfo != null)
			{
				argumentType = fieldInfo.FieldType;
			}
			else
			{
				if (!(propertyInfo != null))
				{
					throw new ArgumentException("The member must be either a field or a property.");
				}
				argumentType = propertyInfo.PropertyType;
			}
			this._lazyMemberInfo = memberInfo;
			this._attributeType = memberInfo.DeclaringType;
			if (value is CustomAttributeTypedArgument)
			{
				CustomAttributeTypedArgument customAttributeTypedArgument = (CustomAttributeTypedArgument)value;
				this.TypedValue = customAttributeTypedArgument;
			}
			else
			{
				this.TypedValue = new CustomAttributeTypedArgument(argumentType, value);
			}
			this.IsField = (fieldInfo != null);
			this.MemberName = memberInfo.Name;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.CustomAttributeNamedArgument" />, представляющего указанное поле или свойство настраиваемого атрибута, и задает объект <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, описывающий тип и значение поля или свойства.</summary>
		/// <param name="memberInfo">Поле или свойство настраиваемого атрибута. Новый объект <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> представляет этот элемент и его значение.</param>
		/// <param name="typedArgument">Объект, описывающий тип и значение поля или свойства.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="memberInfo" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004B91 RID: 19345 RVA: 0x000F0B1C File Offset: 0x000EED1C
		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
			if (memberInfo == null)
			{
				throw new ArgumentNullException("memberInfo");
			}
			this._lazyMemberInfo = memberInfo;
			this._attributeType = memberInfo.DeclaringType;
			this.TypedValue = typedArgument;
			this.IsField = (memberInfo is FieldInfo);
			this.MemberName = memberInfo.Name;
		}

		/// <summary>Возвращает структуру <see cref="T:System.Reflection.CustomAttributeTypedArgument" />, которая может использоваться для получения типа и значения текущего именованного аргумента.</summary>
		/// <returns>Структура, которая может использоваться для получения типа и значения текущего именованного аргумента.</returns>
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06004B92 RID: 19346 RVA: 0x000F0B74 File Offset: 0x000EED74
		public readonly CustomAttributeTypedArgument TypedValue { get; }

		/// <summary>Получает значение, указывающее, является ли именованный аргумент полем.</summary>
		/// <returns>Значение <see langword="true" />, если именованный аргумент является полем; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x000F0B7C File Offset: 0x000EED7C
		public readonly bool IsField { get; }

		/// <summary>Получает имя члена атрибута, который должен использоваться для задания именованного аргумента.</summary>
		/// <returns>Имя члена атрибута, который должен использоваться для задания именованного аргумента.</returns>
		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06004B94 RID: 19348 RVA: 0x000F0B84 File Offset: 0x000EED84
		public readonly string MemberName { get; }

		/// <summary>Возвращает член атрибута, который должен использоваться для установки значения именованного аргумента.</summary>
		/// <returns>Член атрибута, который должен использоваться для установки значения именованного аргумента.</returns>
		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06004B95 RID: 19349 RVA: 0x000F0B8C File Offset: 0x000EED8C
		public MemberInfo MemberInfo
		{
			get
			{
				MemberInfo memberInfo = this._lazyMemberInfo;
				if (memberInfo == null)
				{
					if (this.IsField)
					{
						memberInfo = this._attributeType.GetField(this.MemberName, BindingFlags.Instance | BindingFlags.Public);
					}
					else
					{
						memberInfo = this._attributeType.GetProperty(this.MemberName, BindingFlags.Instance | BindingFlags.Public);
					}
					if (memberInfo == null)
					{
						throw RuntimeAugments.Callbacks.CreateMissingMetadataException(this._attributeType);
					}
					this._lazyMemberInfo = memberInfo;
				}
				return memberInfo;
			}
		}

		/// <summary>Возвращает значение, показывающее, равен ли экземпляр указанному объекту.</summary>
		/// <param name="obj">Объект, сравниваемый с этим экземпляром, или значение <see langword="null" />.</param>
		/// <returns>
		///   <see langword="true" />, если значение параметра <paramref name="obj" /> равно типу и значению данного экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004B96 RID: 19350 RVA: 0x000F0C01 File Offset: 0x000EEE01
		public override bool Equals(object obj)
		{
			return obj == this;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06004B97 RID: 19351 RVA: 0x000F0C11 File Offset: 0x000EEE11
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Проверяет равенство двух структур <see cref="T:System.Reflection.CustomAttributeNamedArgument" />.</summary>
		/// <param name="left">Структура, которая находится слева от оператора равенства.</param>
		/// <param name="right">Структура, которая находится справа от оператора равенства.</param>
		/// <returns>
		///   <see langword="true" />, если обе структуры <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004B98 RID: 19352 RVA: 0x000F0C23 File Offset: 0x000EEE23
		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.CustomAttributeNamedArgument" />.</summary>
		/// <param name="left">Структура, которая находится слева от оператора неравенства.</param>
		/// <param name="right">Структура, которая находится справа от оператора неравенства.</param>
		/// <returns>
		///   <see langword="true" />, если две структуры <see cref="T:System.Reflection.CustomAttributeNamedArgument" /> различаются; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06004B99 RID: 19353 RVA: 0x000F0C38 File Offset: 0x000EEE38
		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return !left.Equals(right);
		}

		/// <summary>Возвращает строку, состоящую из имени аргумента, знака равенства и строкового представления значения аргумента.</summary>
		/// <returns>Строка, состоящая из имени аргумента, знака равенства и строкового представления значения аргумента.</returns>
		// Token: 0x06004B9A RID: 19354 RVA: 0x000F0C50 File Offset: 0x000EEE50
		public override string ToString()
		{
			if (this._attributeType == null)
			{
				return base.ToString();
			}
			string result;
			try
			{
				bool typed = this._lazyMemberInfo == null || (this.IsField ? ((FieldInfo)this._lazyMemberInfo).FieldType : ((PropertyInfo)this._lazyMemberInfo).PropertyType) != typeof(object);
				result = string.Format(CultureInfo.CurrentCulture, "{0} = {1}", this.MemberName, this.TypedValue.ToString(typed));
			}
			catch (MissingMetadataException)
			{
				result = base.ToString();
			}
			return result;
		}

		// Token: 0x04002F6A RID: 12138
		private readonly Type _attributeType;

		// Token: 0x04002F6B RID: 12139
		private volatile MemberInfo _lazyMemberInfo;
	}
}
