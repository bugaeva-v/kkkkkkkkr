using System;

namespace System.ComponentModel
{
	/// <summary>Задает объект <see cref="T:System.ComponentModel.LicenseProvider" />, используемый вместе с классом. Этот класс не наследуется.</summary>
	// Token: 0x020003CA RID: 970
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class LicenseProviderAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> без поставщика лицензий.</summary>
		// Token: 0x06001F64 RID: 8036 RVA: 0x0006D3C8 File Offset: 0x0006B5C8
		public LicenseProviderAttribute() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LicenseProviderAttribute" /> с указанным типом.</summary>
		/// <param name="typeName">Полное имя класса поставщика лицензий.</param>
		// Token: 0x06001F65 RID: 8037 RVA: 0x0006D3D1 File Offset: 0x0006B5D1
		public LicenseProviderAttribute(string typeName)
		{
			this._licenseProviderName = typeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.LicenseProviderAttribute" />, используя указанный тип поставщика лицензий.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, представляющий тип класса поставщика лицензий.</param>
		// Token: 0x06001F66 RID: 8038 RVA: 0x0006D3E0 File Offset: 0x0006B5E0
		public LicenseProviderAttribute(Type type)
		{
			this._licenseProviderType = type;
		}

		/// <summary>Возвращает поставщик лицензий, который должен использоваться вместе со связанным классом.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип поставщика лицензий. Значение по умолчанию — <see langword="null" />.</returns>
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001F67 RID: 8039 RVA: 0x0006D3EF File Offset: 0x0006B5EF
		public Type LicenseProvider
		{
			get
			{
				if (this._licenseProviderType == null && this._licenseProviderName != null)
				{
					this._licenseProviderType = Type.GetType(this._licenseProviderName);
				}
				return this._licenseProviderType;
			}
		}

		/// <summary>Указывает уникальный идентификатор для атрибута данного типа.</summary>
		/// <returns>Уникальный идентификатор для атрибута данного типа.</returns>
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x0006D420 File Offset: 0x0006B620
		public override object TypeId
		{
			get
			{
				string text = this._licenseProviderName;
				if (text == null && this._licenseProviderType != null)
				{
					text = this._licenseProviderType.FullName;
				}
				return base.GetType().FullName + text;
			}
		}

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="value">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="value" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F69 RID: 8041 RVA: 0x0006D464 File Offset: 0x0006B664
		public override bool Equals(object value)
		{
			if (value is LicenseProviderAttribute && value != null)
			{
				Type licenseProvider = ((LicenseProviderAttribute)value).LicenseProvider;
				if (licenseProvider == this.LicenseProvider)
				{
					return true;
				}
				if (licenseProvider != null && licenseProvider.Equals(this.LicenseProvider))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.LicenseProviderAttribute" />.</returns>
		// Token: 0x06001F6A RID: 8042 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет значение по умолчанию, не являющееся поставщиком. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000F53 RID: 3923
		public static readonly LicenseProviderAttribute Default = new LicenseProviderAttribute();

		// Token: 0x04000F54 RID: 3924
		private Type _licenseProviderType;

		// Token: 0x04000F55 RID: 3925
		private string _licenseProviderName;
	}
}
