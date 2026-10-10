using System;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Определяет вкладку свойств или вкладки, которые нужно отобразить для заданного класса или классов.</summary>
	// Token: 0x020003A0 RID: 928
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />.</summary>
		// Token: 0x06001E55 RID: 7765 RVA: 0x0006BBE2 File Offset: 0x00069DE2
		public PropertyTabAttribute()
		{
			this.TabScopes = Array.Empty<PropertyTabScope>();
			this._tabClassNames = Array.Empty<string>();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />, используя указанный тип вкладки.</summary>
		/// <param name="tabClass">Тип создаваемой вкладки.</param>
		// Token: 0x06001E56 RID: 7766 RVA: 0x0006BC00 File Offset: 0x00069E00
		public PropertyTabAttribute(Type tabClass) : this(tabClass, PropertyTabScope.Component)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />, используя заданное имя класса вкладок.</summary>
		/// <param name="tabClassName">Полное имя сборки для типа создаваемой вкладки. Пример применения этого формата см. в разделе <see cref="P:System.Type.AssemblyQualifiedName" />.</param>
		// Token: 0x06001E57 RID: 7767 RVA: 0x0006BC0A File Offset: 0x00069E0A
		public PropertyTabAttribute(string tabClassName) : this(tabClassName, PropertyTabScope.Component)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />, используя заданные тип и область видимости вкладки.</summary>
		/// <param name="tabClass">Тип создаваемой вкладки.</param>
		/// <param name="tabScope">Объект <see cref="T:System.ComponentModel.PropertyTabScope" />, показывающий область видимости вкладки. Если областью является <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, то она показывается только для компонентов с соответствующим атрибутом <see cref="T:System.ComponentModel.PropertyTabAttribute" />. Если областью видимости является <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, то вкладка видима для всех компонентов документа.</param>
		/// <exception cref="T:System.ArgumentException">Свойству <paramref name="tabScope" /> задано значение, отличное от <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> или <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		// Token: 0x06001E58 RID: 7768 RVA: 0x0006BC14 File Offset: 0x00069E14
		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
			this._tabClasses = new Type[]
			{
				tabClass
			};
			if (tabScope < PropertyTabScope.Document)
			{
				throw new ArgumentException(SR.Format("Scope must be PropertyTabScope.Document or PropertyTabScope.Component", Array.Empty<object>()), "tabScope");
			}
			this.TabScopes = new PropertyTabScope[]
			{
				tabScope
			};
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />, используя заданные имя класса вкладок и область видимости вкладки.</summary>
		/// <param name="tabClassName">Полное имя сборки для типа создаваемой вкладки. Пример применения этого формата см. в разделе <see cref="P:System.Type.AssemblyQualifiedName" />.</param>
		/// <param name="tabScope">Объект <see cref="T:System.ComponentModel.PropertyTabScope" />, показывающий область видимости вкладки. Если областью является <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, то она показывается только для компонентов с соответствующим атрибутом <see cref="T:System.ComponentModel.PropertyTabAttribute" />. Если областью видимости является <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, то вкладка видима для всех компонентов документа.</param>
		/// <exception cref="T:System.ArgumentException">Свойству <paramref name="tabScope" /> задано значение, отличное от <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> или <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.</exception>
		// Token: 0x06001E59 RID: 7769 RVA: 0x0006BC68 File Offset: 0x00069E68
		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
			this._tabClassNames = new string[]
			{
				tabClassName
			};
			if (tabScope < PropertyTabScope.Document)
			{
				throw new ArgumentException(SR.Format("Scope must be PropertyTabScope.Document or PropertyTabScope.Component", Array.Empty<object>()), "tabScope");
			}
			this.TabScopes = new PropertyTabScope[]
			{
				tabScope
			};
		}

		/// <summary>Возвращает типы вкладок, используемые данным атрибутом.</summary>
		/// <returns>Массив типов, показывающий типы вкладок, используемые данным атрибутом.</returns>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти типы, заданные свойством <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" />.</exception>
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0006BCBC File Offset: 0x00069EBC
		public Type[] TabClasses
		{
			get
			{
				if (this._tabClasses == null && this._tabClassNames != null)
				{
					this._tabClasses = new Type[this._tabClassNames.Length];
					for (int i = 0; i < this._tabClassNames.Length; i++)
					{
						int num = this._tabClassNames[i].IndexOf(',');
						string text = null;
						string text2;
						if (num != -1)
						{
							text2 = this._tabClassNames[i].Substring(0, num).Trim();
							text = this._tabClassNames[i].Substring(num + 1).Trim();
						}
						else
						{
							text2 = this._tabClassNames[i];
						}
						this._tabClasses[i] = Type.GetType(text2, false);
						if (this._tabClasses[i] == null)
						{
							if (text == null)
							{
								throw new TypeLoadException(SR.Format("Couldn't find type {0}", text2));
							}
							Assembly assembly = Assembly.Load(text);
							if (assembly != null)
							{
								this._tabClasses[i] = assembly.GetType(text2, true);
							}
						}
					}
				}
				return this._tabClasses;
			}
		}

		/// <summary>Возвращает имена классов вкладок, используемые данным атрибутом.</summary>
		/// <returns>Имена классов вкладок, используемые данным атрибутом.</returns>
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0006BDB7 File Offset: 0x00069FB7
		protected string[] TabClassNames
		{
			get
			{
				string[] tabClassNames = this._tabClassNames;
				return (string[])((tabClassNames != null) ? tabClassNames.Clone() : null);
			}
		}

		/// <summary>Возвращает массив областей видимости для каждой вкладки из класса <see cref="T:System.ComponentModel.PropertyTabAttribute" />.</summary>
		/// <returns>Массив объектов <see cref="T:System.ComponentModel.PropertyTabScope" />, который показывает области видимости вкладок.</returns>
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0006BDD0 File Offset: 0x00069FD0
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0006BDD8 File Offset: 0x00069FD8
		public PropertyTabScope[] TabScopes { get; private set; }

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="other">Объект, сравниваемый с этим экземпляром, или <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="other" /> ссылается на тот же экземпляр <see cref="T:System.ComponentModel.PropertyTabAttribute" />; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.TypeLoadException">Не удалось найти типы, заданные свойством <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> параметра <paramref name="other" />.</exception>
		// Token: 0x06001E5E RID: 7774 RVA: 0x0006BDE1 File Offset: 0x00069FE1
		public override bool Equals(object other)
		{
			return other is PropertyTabAttribute && this.Equals((PropertyTabAttribute)other);
		}

		/// <summary>Возвращает значение, показывающее, равен ли данный экземпляр заданному атрибуту.</summary>
		/// <param name="other">Атрибут <see cref="T:System.ComponentModel.PropertyTabAttribute" />, сравниваемый с данным экземпляром, или <see langword="null" />.</param>
		/// <returns>Значение <see langword="true" />, если экземпляры <see cref="T:System.ComponentModel.PropertyTabAttribute" /> равны; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.TypeLoadException">Невозможно найти типы, заданные свойством <see cref="P:System.ComponentModel.PropertyTabAttribute.TabClassNames" /> параметра <paramref name="other" />.</exception>
		// Token: 0x06001E5F RID: 7775 RVA: 0x0006BDFC File Offset: 0x00069FFC
		public bool Equals(PropertyTabAttribute other)
		{
			if (other == this)
			{
				return true;
			}
			if (other.TabClasses.Length != this.TabClasses.Length || other.TabScopes.Length != this.TabScopes.Length)
			{
				return false;
			}
			for (int i = 0; i < this.TabClasses.Length; i++)
			{
				if (this.TabClasses[i] != other.TabClasses[i] || this.TabScopes[i] != other.TabScopes[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Получает хэш-код для этого объекта.</summary>
		/// <returns>Хэш-код для объекта, которому принадлежит данный атрибут.</returns>
		// Token: 0x06001E60 RID: 7776 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Инициализирует данный атрибут, используя заданные имена классов вкладок и массив областей видимости вкладок.</summary>
		/// <param name="tabClassNames">Массив полных имен типов, создаваемых для вкладок в окне "Свойства".</param>
		/// <param name="tabScopes">Область видимости каждой вкладки. Если областью является <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, то она показывается только для компонентов с соответствующим атрибутом <see cref="T:System.ComponentModel.PropertyTabAttribute" />. Если областью видимости является <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, то вкладка видима для всех компонентов документа.</param>
		/// <exception cref="T:System.ArgumentException">Одно или несколько значений в параметре <paramref name="tabScopes" /> не равно <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> или <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.  
		///
		/// или - 
		/// Длины массивов <paramref name="tabClassNames" /> и <paramref name="tabScopes" /> не совпадают.  
		///
		/// или - 
		/// Параметр <paramref name="tabClassNames" /> или <paramref name="tabScopes" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001E61 RID: 7777 RVA: 0x0006BE74 File Offset: 0x0006A074
		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
			this.InitializeArrays(tabClassNames, null, tabScopes);
		}

		/// <summary>Инициализирует данный атрибут, используя заданные имена классов вкладок и массив областей видимости вкладок.</summary>
		/// <param name="tabClasses">Типы создаваемых вкладок.</param>
		/// <param name="tabScopes">Область видимости каждой вкладки. Если областью является <see cref="F:System.ComponentModel.PropertyTabScope.Component" />, то она показывается только для компонентов с соответствующим атрибутом <see cref="T:System.ComponentModel.PropertyTabAttribute" />. Если областью видимости является <see cref="F:System.ComponentModel.PropertyTabScope.Document" />, то вкладка видима для всех компонентов документа.</param>
		/// <exception cref="T:System.ArgumentException">Одно или несколько значений в параметре <paramref name="tabScopes" /> не равно <see cref="F:System.ComponentModel.PropertyTabScope.Document" /> или <see cref="F:System.ComponentModel.PropertyTabScope.Component" />.  
		///
		/// или - 
		/// Длины массивов <paramref name="tabClassNames" /> и <paramref name="tabScopes" /> не совпадают.  
		///
		/// или - 
		/// Параметр <paramref name="tabClassNames" /> или <paramref name="tabScopes" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001E62 RID: 7778 RVA: 0x0006BE7F File Offset: 0x0006A07F
		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			this.InitializeArrays(null, tabClasses, tabScopes);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0006BE8C File Offset: 0x0006A08C
		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
			if (tabClasses != null)
			{
				if (tabScopes != null && tabClasses.Length != tabScopes.Length)
				{
					throw new ArgumentException("tabClasses must have the same number of items as tabScopes");
				}
				this._tabClasses = (Type[])tabClasses.Clone();
			}
			else if (tabClassNames != null)
			{
				if (tabScopes != null && tabClassNames.Length != tabScopes.Length)
				{
					throw new ArgumentException("tabClasses must have the same number of items as tabScopes");
				}
				this._tabClassNames = (string[])tabClassNames.Clone();
				this._tabClasses = null;
			}
			else if (this._tabClasses == null && this._tabClassNames == null)
			{
				throw new ArgumentException("An array of tab type names or tab types must be specified");
			}
			if (tabScopes != null)
			{
				for (int i = 0; i < tabScopes.Length; i++)
				{
					if (tabScopes[i] < PropertyTabScope.Document)
					{
						throw new ArgumentException("Scope must be PropertyTabScope.Document or PropertyTabScope.Component");
					}
				}
				this.TabScopes = (PropertyTabScope[])tabScopes.Clone();
				return;
			}
			this.TabScopes = new PropertyTabScope[tabClasses.Length];
			for (int j = 0; j < this.TabScopes.Length; j++)
			{
				this.TabScopes[j] = PropertyTabScope.Component;
			}
		}

		// Token: 0x04000F26 RID: 3878
		private Type[] _tabClasses;

		// Token: 0x04000F27 RID: 3879
		private string[] _tabClassNames;
	}
}
