using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Указывает редактор, используемый для изменения свойства. Этот класс не наследуется.</summary>
	// Token: 0x020003A5 RID: 933
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorAttribute" />, используя редактор по умолчанию, который не является редактором.</summary>
		// Token: 0x06001E7A RID: 7802 RVA: 0x0006C1A1 File Offset: 0x0006A3A1
		public EditorAttribute()
		{
			this.EditorTypeName = string.Empty;
			this.EditorBaseTypeName = string.Empty;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorAttribute" />, используя имя типа и имя базового типа редактора.</summary>
		/// <param name="typeName">Полное имя типа редактора.</param>
		/// <param name="baseTypeName">Полное имя типа базового класса или интерфейса, используемого в качестве ключа для поиска редактора. Это должен быть класс <see cref="T:System.Drawing.Design.UITypeEditor" /> или класс, производный от этого класса.</param>
		// Token: 0x06001E7B RID: 7803 RVA: 0x0006C1BF File Offset: 0x0006A3BF
		public EditorAttribute(string typeName, string baseTypeName)
		{
			typeName.ToUpper(CultureInfo.InvariantCulture);
			this.EditorTypeName = typeName;
			this.EditorBaseTypeName = baseTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorAttribute" />, используя имя типа и базовый тип.</summary>
		/// <param name="typeName">Полное имя типа редактора.</param>
		/// <param name="baseType">Тип <see cref="T:System.Type" /> базового класса или интерфейса, используемого в качестве ключа для поиска редактора. Это должен быть класс <see cref="T:System.Drawing.Design.UITypeEditor" /> или класс, производный от этого класса.</param>
		// Token: 0x06001E7C RID: 7804 RVA: 0x0006C1E1 File Offset: 0x0006A3E1
		public EditorAttribute(string typeName, Type baseType)
		{
			typeName.ToUpper(CultureInfo.InvariantCulture);
			this.EditorTypeName = typeName;
			this.EditorBaseTypeName = baseType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.EditorAttribute" />, используя тип и базовый тип.</summary>
		/// <param name="type">Объект <see cref="T:System.Type" />, представляющий тип редактора.</param>
		/// <param name="baseType">Тип <see cref="T:System.Type" /> базового класса или интерфейса, используемого в качестве ключа для поиска редактора. Это должен быть класс <see cref="T:System.Drawing.Design.UITypeEditor" /> или класс, производный от этого класса.</param>
		// Token: 0x06001E7D RID: 7805 RVA: 0x0006C208 File Offset: 0x0006A408
		public EditorAttribute(Type type, Type baseType)
		{
			this.EditorTypeName = type.AssemblyQualifiedName;
			this.EditorBaseTypeName = baseType.AssemblyQualifiedName;
		}

		/// <summary>Возвращает имя базового класса или интерфейса, используемого в качестве ключа для поиска этого редактора.</summary>
		/// <returns>Имя базового класса или интерфейса, используемого в качестве ключа для поиска этого редактора.</returns>
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0006C228 File Offset: 0x0006A428
		public string EditorBaseTypeName { get; }

		/// <summary>Возвращает имя класса редактора в формате <see cref="P:System.Type.AssemblyQualifiedName" />.</summary>
		/// <returns>Получает имя класса редактора в формате<see cref="P:System.Type.AssemblyQualifiedName" />.</returns>
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0006C230 File Offset: 0x0006A430
		public string EditorTypeName { get; }

		/// <summary>Получает уникальный идентификатор для атрибута данного типа.</summary>
		/// <returns>Уникальный идентификатор для атрибута данного типа.</returns>
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0006C238 File Offset: 0x0006A438
		public override object TypeId
		{
			get
			{
				if (this._typeId == null)
				{
					string text = this.EditorBaseTypeName;
					int num = text.IndexOf(',');
					if (num != -1)
					{
						text = text.Substring(0, num);
					}
					this._typeId = base.GetType().FullName + text;
				}
				return this._typeId;
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.EditorAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего объекта; в противном случае — значение <see langword="false" />, если нет.</returns>
		// Token: 0x06001E81 RID: 7809 RVA: 0x0006C288 File Offset: 0x0006A488
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			EditorAttribute editorAttribute = obj as EditorAttribute;
			return editorAttribute != null && editorAttribute.EditorTypeName == this.EditorTypeName && editorAttribute.EditorBaseTypeName == this.EditorBaseTypeName;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x06001E82 RID: 7810 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000F36 RID: 3894
		private string _typeId;
	}
}
