using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет параметры конфигурации для поставщика языка. Этот класс не наследуется.</summary>
	// Token: 0x0200034B RID: 843
	public sealed class CompilerInfo
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x000662B8 File Offset: 0x000644B8
		private CompilerInfo()
		{
		}

		/// <summary>Получает имена языков, поддерживаемые поставщиком языка.</summary>
		/// <returns>Массив имен языков, поддерживаемых поставщиком языка.</returns>
		// Token: 0x06001BCA RID: 7114 RVA: 0x000662CB File Offset: 0x000644CB
		public string[] GetLanguages()
		{
			return this.CloneCompilerLanguages();
		}

		/// <summary>Возвращает расширения имен файлов, поддерживаемые поставщиком языка.</summary>
		/// <returns>Массив расширений имен файлов, поддерживаемых поставщиком языка.</returns>
		// Token: 0x06001BCB RID: 7115 RVA: 0x000662D3 File Offset: 0x000644D3
		public string[] GetExtensions()
		{
			return this.CloneCompilerExtensions();
		}

		/// <summary>Получает тип настроенной реализации <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</summary>
		/// <returns>Доступный только для чтения экземпляр <see cref="T:System.Type" />, представляющий настроенный тип поставщика языка.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationException">На данном компьютере поставщик языка не настроен.</exception>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Не удается найти тип, поскольку он является значением <see langword="null" /> или пустой строкой.  
		/// -или- 
		/// Не удается найти тип, поскольку в файле конфигурации не найдено имя <see cref="T:System.CodeDom.Compiler.CodeDomProvider" />.</exception>
		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x000662DC File Offset: 0x000644DC
		public Type CodeDomProviderType
		{
			get
			{
				if (this._type == null)
				{
					lock (this)
					{
						if (this._type == null)
						{
							this._type = Type.GetType(this._codeDomProviderTypeName);
						}
					}
				}
				return this._type;
			}
		}

		/// <summary>Возвращает значение, указывающее, настроена ли на данном компьютере реализация поставщика языка.</summary>
		/// <returns>
		///   <see langword="true" />, если на данном компьютере настроена реализация поставщика языка; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00066344 File Offset: 0x00064544
		public bool IsCodeDomProviderTypeValid
		{
			get
			{
				return Type.GetType(this._codeDomProviderTypeName) != null;
			}
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> для параметров поставщика текущего языка.</summary>
		/// <returns>Поставщик CodeDOM, связанный с конфигурацией поставщика языка.</returns>
		// Token: 0x06001BCE RID: 7118 RVA: 0x00066358 File Offset: 0x00064558
		public CodeDomProvider CreateProvider()
		{
			if (this._providerOptions.Count > 0)
			{
				ConstructorInfo constructor = this.CodeDomProviderType.GetConstructor(new Type[]
				{
					typeof(IDictionary<string, string>)
				});
				if (constructor != null)
				{
					return (CodeDomProvider)constructor.Invoke(new object[]
					{
						this._providerOptions
					});
				}
			}
			return (CodeDomProvider)Activator.CreateInstance(this.CodeDomProviderType);
		}

		/// <summary>Возвращает экземпляр <see cref="T:System.CodeDom.Compiler.CodeDomProvider" /> для параметров поставщика текущего языка и заданных параметров.</summary>
		/// <param name="providerOptions">Коллекция параметров поставщика из файла конфигурации.</param>
		/// <returns>Поставщик CodeDOM, связанный с конфигурацией поставщика языка и заданными параметрами.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="providerOptions" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Поставщик не поддерживает параметры.</exception>
		// Token: 0x06001BCF RID: 7119 RVA: 0x000663C8 File Offset: 0x000645C8
		public CodeDomProvider CreateProvider(IDictionary<string, string> providerOptions)
		{
			if (providerOptions == null)
			{
				throw new ArgumentNullException("providerOptions");
			}
			ConstructorInfo constructor = this.CodeDomProviderType.GetConstructor(new Type[]
			{
				typeof(IDictionary<string, string>)
			});
			if (constructor != null)
			{
				return (CodeDomProvider)constructor.Invoke(new object[]
				{
					providerOptions
				});
			}
			throw new InvalidOperationException(SR.Format("This CodeDomProvider type does not have a constructor that takes providerOptions - \"{0}\"", this.CodeDomProviderType.ToString()));
		}

		/// <summary>Получает настроенные параметры компилятора для реализации поставщика и языка.</summary>
		/// <returns>Доступный только для чтения экземпляр <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, содержащий параметры компилятора и установки, настроенные для поставщика языка.</returns>
		// Token: 0x06001BD0 RID: 7120 RVA: 0x0006643B File Offset: 0x0006463B
		public CompilerParameters CreateDefaultCompilerParameters()
		{
			return this.CloneCompilerParameters();
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00066443 File Offset: 0x00064643
		internal CompilerInfo(CompilerParameters compilerParams, string codeDomProviderTypeName, string[] compilerLanguages, string[] compilerExtensions)
		{
			this._compilerLanguages = compilerLanguages;
			this._compilerExtensions = compilerExtensions;
			this._codeDomProviderTypeName = codeDomProviderTypeName;
			this._compilerParams = (compilerParams ?? new CompilerParameters());
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0006647C File Offset: 0x0006467C
		internal CompilerInfo(CompilerParameters compilerParams, string codeDomProviderTypeName)
		{
			this._codeDomProviderTypeName = codeDomProviderTypeName;
			this._compilerParams = (compilerParams ?? new CompilerParameters());
		}

		/// <summary>Возвращает хэш-код текущего экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-битового целого числа со знаком для текущего экземпляра <see cref="T:System.CodeDom.Compiler.CompilerInfo" /> который можно использовать в алгоритмах и структурах данных хэширования, например в хэш-таблице.</returns>
		// Token: 0x06001BD3 RID: 7123 RVA: 0x000664A6 File Offset: 0x000646A6
		public override int GetHashCode()
		{
			return this._codeDomProviderTypeName.GetHashCode();
		}

		/// <summary>Определяет, представляет ли указанный объект тот же поставщик языка и те же параметры компилятора, что и текущий объект <see cref="T:System.CodeDom.Compiler.CompilerInfo" />.</summary>
		/// <param name="o">Объект, который требуется сравнить с текущим объектом <see cref="T:System.CodeDom.Compiler.CompilerInfo" />.</param>
		/// <returns>Значение <see langword="true" />, если параметр <paramref name="o" /> является объектом <see cref="T:System.CodeDom.Compiler.CompilerInfo" />, а его значение совпадает с данным экземпляром; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001BD4 RID: 7124 RVA: 0x000664B4 File Offset: 0x000646B4
		public override bool Equals(object o)
		{
			CompilerInfo compilerInfo = o as CompilerInfo;
			return compilerInfo != null && (this.CodeDomProviderType == compilerInfo.CodeDomProviderType && this.CompilerParams.WarningLevel == compilerInfo.CompilerParams.WarningLevel && this.CompilerParams.IncludeDebugInformation == compilerInfo.CompilerParams.IncludeDebugInformation) && this.CompilerParams.CompilerOptions == compilerInfo.CompilerParams.CompilerOptions;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00066530 File Offset: 0x00064730
		private CompilerParameters CloneCompilerParameters()
		{
			return new CompilerParameters
			{
				IncludeDebugInformation = this._compilerParams.IncludeDebugInformation,
				TreatWarningsAsErrors = this._compilerParams.TreatWarningsAsErrors,
				WarningLevel = this._compilerParams.WarningLevel,
				CompilerOptions = this._compilerParams.CompilerOptions
			};
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x00066586 File Offset: 0x00064786
		private string[] CloneCompilerLanguages()
		{
			return (string[])this._compilerLanguages.Clone();
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00066598 File Offset: 0x00064798
		private string[] CloneCompilerExtensions()
		{
			return (string[])this._compilerExtensions.Clone();
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x000665AA File Offset: 0x000647AA
		internal CompilerParameters CompilerParams
		{
			get
			{
				return this._compilerParams;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x000665B2 File Offset: 0x000647B2
		internal IDictionary<string, string> ProviderOptions
		{
			get
			{
				return this._providerOptions;
			}
		}

		// Token: 0x04000E2F RID: 3631
		internal readonly IDictionary<string, string> _providerOptions = new Dictionary<string, string>();

		// Token: 0x04000E30 RID: 3632
		internal string _codeDomProviderTypeName;

		// Token: 0x04000E31 RID: 3633
		internal CompilerParameters _compilerParams;

		// Token: 0x04000E32 RID: 3634
		internal string[] _compilerLanguages;

		// Token: 0x04000E33 RID: 3635
		internal string[] _compilerExtensions;

		// Token: 0x04000E34 RID: 3636
		private Type _type;
	}
}
