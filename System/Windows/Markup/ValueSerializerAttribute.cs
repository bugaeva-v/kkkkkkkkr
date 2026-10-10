using System;
using System.Runtime.CompilerServices;

namespace System.Windows.Markup
{
	/// <summary>Идентифицирует класс <see cref="T:System.Windows.Markup.ValueSerializer" />, который тип или свойство должны использовать при сериализации.</summary>
	// Token: 0x0200017B RID: 379
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
	[TypeForwardedFrom("WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public sealed class ValueSerializerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Windows.Markup.ValueSerializerAttribute" />, используя указанный тип.</summary>
		/// <param name="valueSerializerType">Тип, представляющий тип класса <see cref="T:System.Windows.Markup.ValueSerializer" />.</param>
		// Token: 0x06000A1C RID: 2588 RVA: 0x0002C388 File Offset: 0x0002A588
		public ValueSerializerAttribute(Type valueSerializerType)
		{
			this._valueSerializerType = valueSerializerType;
		}

		/// <summary>Инициализирует новый экземпляр <see cref="T:System.Windows.Markup.ValueSerializerAttribute" />, используя строку имени типа с указанием сборки.</summary>
		/// <param name="valueSerializerTypeName">Строка имени типа с указанием сборки для использования классом <see cref="T:System.Windows.Markup.ValueSerializer" />.</param>
		// Token: 0x06000A1D RID: 2589 RVA: 0x0002C397 File Offset: 0x0002A597
		public ValueSerializerAttribute(string valueSerializerTypeName)
		{
			this._valueSerializerTypeName = valueSerializerTypeName;
		}

		/// <summary>Получает тип класса <see cref="T:System.Windows.Markup.ValueSerializer" />, данные о котором передает этот атрибут.</summary>
		/// <returns>Тип <see cref="T:System.Windows.Markup.ValueSerializer" />.</returns>
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002C3A6 File Offset: 0x0002A5A6
		public Type ValueSerializerType
		{
			get
			{
				if (this._valueSerializerType == null && this._valueSerializerTypeName != null)
				{
					this._valueSerializerType = Type.GetType(this._valueSerializerTypeName);
				}
				return this._valueSerializerType;
			}
		}

		/// <summary>Возвращает имя типа с указанием сборки <see cref="T:System.Windows.Markup.ValueSerializer" /> для этого типа или свойства.</summary>
		/// <returns>Возвращает имя типа с указанием сборки.</returns>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002C3D5 File Offset: 0x0002A5D5
		public string ValueSerializerTypeName
		{
			get
			{
				if (this._valueSerializerType != null)
				{
					return this._valueSerializerType.AssemblyQualifiedName;
				}
				return this._valueSerializerTypeName;
			}
		}

		// Token: 0x040006C6 RID: 1734
		private Type _valueSerializerType;

		// Token: 0x040006C7 RID: 1735
		private string _valueSerializerTypeName;
	}
}
