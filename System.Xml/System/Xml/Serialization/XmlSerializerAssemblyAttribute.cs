using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Применяется к прокси клиента веб-службы, можно указать сборку, содержащую клиентские сериализаторы.
	///       </summary>
	// Token: 0x02000304 RID: 772
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class XmlSerializerAssemblyAttribute : Attribute
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlSerializerAssemblyAttribute" />.
		///       </summary>
		// Token: 0x06002025 RID: 8229 RVA: 0x000D06E0 File Offset: 0x000CE8E0
		public XmlSerializerAssemblyAttribute() : this(null, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializerAssemblyAttribute" /> класса с помощью указанного имени сборки.
		///       </summary>
		/// <param name="assemblyName">
		///           Простое, нешифрованное имя сборки.
		///         </param>
		// Token: 0x06002026 RID: 8230 RVA: 0x000D06EA File Offset: 0x000CE8EA
		public XmlSerializerAssemblyAttribute(string assemblyName) : this(assemblyName, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlSerializerAssemblyAttribute" /> класс с именем указанной сборки и расположение сборки.
		///       </summary>
		/// <param name="assemblyName">
		///           Простое, нешифрованное имя сборки.
		///         </param>
		/// <param name="codeBase">
		///           Строка, представляющая URL-адрес сборки.
		///         </param>
		// Token: 0x06002027 RID: 8231 RVA: 0x000D06F4 File Offset: 0x000CE8F4
		public XmlSerializerAssemblyAttribute(string assemblyName, string codeBase)
		{
			this.assemblyName = assemblyName;
			this.codeBase = codeBase;
		}

		/// <summary>
		///         Возвращает или задает расположение сборки, содержащей сериализаторы.
		///       </summary>
		/// <returns>
		///         Расположение, например, путь или URI, указывающий на сборку.
		///       </returns>
		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x000D070A File Offset: 0x000CE90A
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x000D0712 File Offset: 0x000CE912
		public string CodeBase
		{
			get
			{
				return this.codeBase;
			}
			set
			{
				this.codeBase = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя сборки, содержащей сериализаторы для определенного набора типов.
		///       </summary>
		/// <returns>
		///         Простое, нешифрованное имя сборки.
		///       </returns>
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x000D071B File Offset: 0x000CE91B
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x000D0723 File Offset: 0x000CE923
		public string AssemblyName
		{
			get
			{
				return this.assemblyName;
			}
			set
			{
				this.assemblyName = value;
			}
		}

		// Token: 0x04001B1D RID: 6941
		private string assemblyName;

		// Token: 0x04001B1E RID: 6942
		private string codeBase;
	}
}
