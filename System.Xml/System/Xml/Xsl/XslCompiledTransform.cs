using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Security;
using System.Security.Permissions;
using System.Xml.XmlConfiguration;
using System.Xml.XPath;
using System.Xml.Xsl.Qil;
using System.Xml.Xsl.Runtime;
using System.Xml.Xsl.Xslt;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Преобразует данные XML с помощью таблицы стилей XSLT.
	///       </summary>
	// Token: 0x02000343 RID: 835
	public sealed class XslCompiledTransform
	{
		// Token: 0x06002266 RID: 8806 RVA: 0x000D9664 File Offset: 0x000D7864
		static XslCompiledTransform()
		{
			XslCompiledTransform.MemberAccessPermissionSet.AddPermission(new ReflectionPermission(ReflectionPermissionFlag.MemberAccess));
			XslCompiledTransform.ReaderSettings = new XmlReaderSettings();
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XslCompiledTransform" />.
		///       </summary>
		// Token: 0x06002267 RID: 8807 RVA: 0x0000216B File Offset: 0x0000036B
		public XslCompiledTransform()
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Xsl.XslCompiledTransform" /> класса с указанными параметрами отладки.
		///       </summary>
		/// <param name="enableDebug">
		///           <see langword="true" /> для создания отладочной информации; в противном случае <see langword="false" />.
		///            Этому параметру <see langword="true" /> позволяет выполнить отладку таблицы стилей с помощью отладчика Microsoft Visual Studio.
		///         </param>
		// Token: 0x06002268 RID: 8808 RVA: 0x000D968C File Offset: 0x000D788C
		public XslCompiledTransform(bool enableDebug)
		{
			this.enableDebug = enableDebug;
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x000D969B File Offset: 0x000D789B
		private void Reset()
		{
			this.compilerResults = null;
			this.outputSettings = null;
			this.qil = null;
			this.command = null;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000D96B9 File Offset: 0x000D78B9
		internal CompilerErrorCollection Errors
		{
			get
			{
				if (this.compilerResults == null)
				{
					return null;
				}
				return this.compilerResults.Errors;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlWriterSettings" /> содержит выходные данные, полученные из xsl:output элемент таблицы стилей.
		///       </summary>
		/// <returns>
		///         Только для чтения <see cref="T:System.Xml.XmlWriterSettings" /> содержащий выходные данные, полученные из xsl:output элемент таблицы стилей.
		///          Это значение может быть равно <see langword="null" />.
		///       </returns>
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x000D96D0 File Offset: 0x000D78D0
		public XmlWriterSettings OutputSettings
		{
			get
			{
				return this.outputSettings;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> содержит временные файлы, созданные на диске после успешного вызова <see cref="Overload:System.Xml.Xsl.XslCompiledTransform.Load" /> метод.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.CodeDom.Compiler.TempFileCollection" /> Содержащий временные файлы, созданные на диске.
		///          Это значение равно <see langword="null" /> при <see cref="Overload:System.Xml.Xsl.XslCompiledTransform.Load" /> не был успешно вызван метод, или если не была включена отладка.
		///       </returns>
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000D96D8 File Offset: 0x000D78D8
		public TempFileCollection TemporaryFiles
		{
			[PermissionSet(SecurityAction.LinkDemand, Name = "FullTrust")]
			get
			{
				if (this.compilerResults == null)
				{
					return null;
				}
				return this.compilerResults.TempFiles;
			}
		}

		/// <summary>
		///         Компилирует таблицу стилей, содержащихся в <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="stylesheet">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий таблицу стилей.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheet" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		// Token: 0x0600226D RID: 8813 RVA: 0x000D96EF File Offset: 0x000D78EF
		public void Load(XmlReader stylesheet)
		{
			this.Reset();
			this.LoadInternal(stylesheet, XsltSettings.Default, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Компилирует таблицу стилей XSLT, содержащихся в <see cref="T:System.Xml.XmlReader" />.
		///         <see cref="T:System.Xml.XmlResolver" /> Разрешает любой элемент XSLT import или include элементы и параметры XSLT определяют разрешения для таблицы стилей.
		///       </summary>
		/// <param name="stylesheet">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий таблицу стилей.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.Xsl.XsltSettings" /> Для применения к таблице стилей.
		///            Если это <see langword="null" />,  <see cref="P:System.Xml.Xsl.XsltSettings.Default" /> применяется политика.
		///         </param>
		/// <param name="stylesheetResolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для разрешения любых таблиц стилей XSLT на который ссылается import и include элементы.
		///            Если это <see langword="null" />, внешние ресурсы не разрешаются.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheet" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		// Token: 0x0600226E RID: 8814 RVA: 0x000D9709 File Offset: 0x000D7909
		public void Load(XmlReader stylesheet, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			this.Reset();
			this.LoadInternal(stylesheet, settings, stylesheetResolver);
		}

		/// <summary>
		///         Компилирует таблицу стилей, содержащихся в <see cref="T:System.Xml.XPath.IXPathNavigable" /> объекта.
		///       </summary>
		/// <param name="stylesheet">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий таблицу стилей.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheet" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		// Token: 0x0600226F RID: 8815 RVA: 0x000D96EF File Offset: 0x000D78EF
		public void Load(IXPathNavigable stylesheet)
		{
			this.Reset();
			this.LoadInternal(stylesheet, XsltSettings.Default, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Компилирует таблицу стилей XSLT, содержащихся в <see cref="T:System.Xml.XPath.IXPathNavigable" />.
		///         <see cref="T:System.Xml.XmlResolver" /> Разрешает любой элемент XSLT import или include элементы и параметры XSLT определяют разрешения для таблицы стилей.
		///       </summary>
		/// <param name="stylesheet">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий таблицу стилей.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.Xsl.XsltSettings" /> Для применения к таблице стилей.
		///            Если это <see langword="null" />,  <see cref="P:System.Xml.Xsl.XsltSettings.Default" /> применяется политика.
		///         </param>
		/// <param name="stylesheetResolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для разрешения любых таблиц стилей XSLT на который ссылается import и include элементы.
		///            Если это <see langword="null" />, внешние ресурсы не разрешаются.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheet" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		// Token: 0x06002270 RID: 8816 RVA: 0x000D9709 File Offset: 0x000D7909
		public void Load(IXPathNavigable stylesheet, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			this.Reset();
			this.LoadInternal(stylesheet, settings, stylesheetResolver);
		}

		/// <summary>
		///         Загружает и компилирует таблицу стилей, расположенную по указанному URI.
		///       </summary>
		/// <param name="stylesheetUri">
		///           URI таблицы стилей.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheetUri" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти таблицу стилей.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="stylesheetUri" /> Значение включает имя файла или каталога, который не удается найти.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="stylesheetUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="stylesheetUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке таблицы стилей.
		///           </exception>
		// Token: 0x06002271 RID: 8817 RVA: 0x000D971B File Offset: 0x000D791B
		public void Load(string stylesheetUri)
		{
			this.Reset();
			if (stylesheetUri == null)
			{
				throw new ArgumentNullException("stylesheetUri");
			}
			this.LoadInternal(stylesheetUri, XsltSettings.Default, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Загружает и компилирует таблицу стилей XSLT, указанную по URI.
		///         <see cref="T:System.Xml.XmlResolver" /> Разрешает любой элемент XSLT import или include элементы и параметры XSLT определяют разрешения для таблицы стилей.
		///       </summary>
		/// <param name="stylesheetUri">
		///           URI таблицы стилей.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.Xsl.XsltSettings" /> Для применения к таблице стилей.
		///            Если это <see langword="null" />,  <see cref="P:System.Xml.Xsl.XsltSettings.Default" /> применяется политика.
		///         </param>
		/// <param name="stylesheetResolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для разрешения URI таблицы стилей и стилей, на которые ссылается XSLT import и include элементы.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="stylesheetUri" /> Или <paramref name="stylesheetResolver" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Таблица стилей содержит ошибку.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти таблицу стилей.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="stylesheetUri" /> Значение включает имя файла или каталога, который не удается найти.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="stylesheetUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="stylesheetUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке таблицы стилей.
		///           </exception>
		// Token: 0x06002272 RID: 8818 RVA: 0x000D9743 File Offset: 0x000D7943
		public void Load(string stylesheetUri, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			this.Reset();
			if (stylesheetUri == null)
			{
				throw new ArgumentNullException("stylesheetUri");
			}
			this.LoadInternal(stylesheetUri, settings, stylesheetResolver);
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x000D9764 File Offset: 0x000D7964
		private CompilerResults LoadInternal(object stylesheet, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			if (stylesheet == null)
			{
				throw new ArgumentNullException("stylesheet");
			}
			if (settings == null)
			{
				settings = XsltSettings.Default;
			}
			this.CompileXsltToQil(stylesheet, settings, stylesheetResolver);
			CompilerError firstError = this.GetFirstError();
			if (firstError != null)
			{
				throw new XslLoadException(firstError);
			}
			if (!settings.CheckOnly)
			{
				this.CompileQilToMsil(settings);
			}
			return this.compilerResults;
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x000D97B8 File Offset: 0x000D79B8
		private void CompileXsltToQil(object stylesheet, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			this.compilerResults = new Compiler(settings, this.enableDebug, null).Compile(stylesheet, stylesheetResolver, out this.qil);
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x000D97DC File Offset: 0x000D79DC
		private CompilerError GetFirstError()
		{
			foreach (object obj in this.compilerResults.Errors)
			{
				CompilerError compilerError = (CompilerError)obj;
				if (!compilerError.IsWarning)
				{
					return compilerError;
				}
			}
			return null;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000D9844 File Offset: 0x000D7A44
		private void CompileQilToMsil(XsltSettings settings)
		{
			this.command = new XmlILGenerator().Generate(this.qil, null);
			this.outputSettings = this.command.StaticData.DefaultWriterSettings;
			this.qil = null;
		}

		/// <summary>
		///         Компилирует таблицу стилей XSLT в указанный тип.
		///       </summary>
		/// <param name="stylesheet">
		///           <see cref="T:System.Xml.XmlReader" /> Позиционируется в начале таблице стилей для компиляции.
		///         </param>
		/// <param name="settings">
		///           <see cref="T:System.Xml.Xsl.XsltSettings" /> Для применения к таблице стилей.
		///            Если это <see langword="null" />,  <see cref="P:System.Xml.Xsl.XsltSettings.Default" /> будут применены.
		///         </param>
		/// <param name="stylesheetResolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Для разрешения модулей таблиц стилей в <see langword="xsl:import" /> и <see langword="xsl:include" /> элементы.
		///            Если это <see langword="null" />, внешние ресурсы не будет устранена.
		///         </param>
		/// <param name="debug">
		///           Этому параметру <see langword="true" /> включает отладку таблицы стилей с помощью отладчика.
		///         </param>
		/// <param name="typeBuilder">
		///           <see cref="T:System.Reflection.Emit.TypeBuilder" /> Используется для компиляции таблицы стилей.
		///            Предоставленный TypeBuilder используется для создания результирующего типа.
		///         </param>
		/// <param name="scriptAssemblyPath">
		///           Базовый путь для сборок, созданных для <see langword="msxsl:script" /> элементов.
		///            Если создается только одна сборка скриптов, в этом параметре указывается путь к этой сборке.
		///            В случае нескольких сборок скриптов к имени файла будет добавлен специальный суффикс, обеспечивающий уникальность имен сборок.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.CodeDom.Compiler.CompilerErrorCollection" /> объект, содержащий ошибок и предупреждений, которые указывают на результат компиляции компилятора.
		///       </returns>
		// Token: 0x06002277 RID: 8823 RVA: 0x000D987C File Offset: 0x000D7A7C
		public static CompilerErrorCollection CompileToType(XmlReader stylesheet, XsltSettings settings, XmlResolver stylesheetResolver, bool debug, TypeBuilder typeBuilder, string scriptAssemblyPath)
		{
			if (stylesheet == null)
			{
				throw new ArgumentNullException("stylesheet");
			}
			if (typeBuilder == null)
			{
				throw new ArgumentNullException("typeBuilder");
			}
			if (settings == null)
			{
				settings = XsltSettings.Default;
			}
			if (settings.EnableScript && scriptAssemblyPath == null)
			{
				throw new ArgumentNullException("scriptAssemblyPath");
			}
			if (scriptAssemblyPath != null)
			{
				scriptAssemblyPath = Path.GetFullPath(scriptAssemblyPath);
			}
			QilExpression query;
			CompilerErrorCollection errors = new Compiler(settings, debug, scriptAssemblyPath).Compile(stylesheet, stylesheetResolver, out query).Errors;
			if (!errors.HasErrors)
			{
				if (XslCompiledTransform.GeneratedCodeCtor == null)
				{
					XslCompiledTransform.GeneratedCodeCtor = typeof(GeneratedCodeAttribute).GetConstructor(new Type[]
					{
						typeof(string),
						typeof(string)
					});
				}
				typeBuilder.SetCustomAttribute(new CustomAttributeBuilder(XslCompiledTransform.GeneratedCodeCtor, new object[]
				{
					typeof(XslCompiledTransform).FullName,
					"4.0.0.0"
				}));
				new XmlILGenerator().Generate(query, typeBuilder);
			}
			return errors;
		}

		/// <summary>
		///         Загружает скомпилированную таблицу стилей, созданную с помощью XSLT-компилятор (xsltc.exe).
		///       </summary>
		/// <param name="compiledStylesheet">
		///           Имя класса, содержащего скомпилированную таблицу стилей.
		///
		///           Как правило, это имя таблицы стилей.
		///            Если иное не указано, средство xsltc.exe использует имя таблицы стилей в именах классов и сборок.
		///         </param>
		// Token: 0x06002278 RID: 8824 RVA: 0x000D9984 File Offset: 0x000D7B84
		public void Load(Type compiledStylesheet)
		{
			this.Reset();
			if (compiledStylesheet == null)
			{
				throw new ArgumentNullException("compiledStylesheet");
			}
			object[] customAttributes = compiledStylesheet.GetCustomAttributes(typeof(GeneratedCodeAttribute), false);
			GeneratedCodeAttribute generatedCodeAttribute = (customAttributes.Length != 0) ? ((GeneratedCodeAttribute)customAttributes[0]) : null;
			if (generatedCodeAttribute != null && generatedCodeAttribute.Tool == typeof(XslCompiledTransform).FullName)
			{
				if (new Version("4.0.0.0").CompareTo(new Version(generatedCodeAttribute.Version)) < 0)
				{
					throw new ArgumentException(Res.GetString("Executing a stylesheet that was compiled using a later version of the framework is not supported. Stylesheet Version: {0}. Current Framework Version: {1}.", new object[]
					{
						generatedCodeAttribute.Version,
						"4.0.0.0"
					}), "compiledStylesheet");
				}
				FieldInfo field = compiledStylesheet.GetField("staticData", BindingFlags.Static | BindingFlags.NonPublic);
				FieldInfo field2 = compiledStylesheet.GetField("ebTypes", BindingFlags.Static | BindingFlags.NonPublic);
				if (field != null && field2 != null)
				{
					if (XsltConfigSection.EnableMemberAccessForXslCompiledTransform)
					{
						new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Assert();
					}
					byte[] array = field.GetValue(null) as byte[];
					if (array != null)
					{
						MethodInfo method = compiledStylesheet.GetMethod("Execute", BindingFlags.Static | BindingFlags.NonPublic);
						Type[] earlyBoundTypes = (Type[])field2.GetValue(null);
						this.Load(method, array, earlyBoundTypes);
						return;
					}
				}
			}
			if (this.command == null)
			{
				throw new ArgumentException(Res.GetString("Type '{0}' is not a compiled stylesheet class.", new object[]
				{
					compiledStylesheet.FullName
				}), "compiledStylesheet");
			}
		}

		/// <summary>
		///         Загружает метод из таблицы стилей, скомпилированной с помощью <see langword="XSLTC.exe" /> программы.
		///       </summary>
		/// <param name="executeMethod">
		///           Объект <see cref="T:System.Reflection.MethodInfo" /> объект, представляющий созданный компилятором <paramref name="execute" /> метод скомпилированную таблицу стилей.
		///         </param>
		/// <param name="queryData">
		///           Массив байтов сериализованных данных структуры в <paramref name="staticData" /> поле скомпилированную таблицу стилей, создаваемый методом <see cref="M:System.Xml.Xsl.XslCompiledTransform.CompileToType(System.Xml.XmlReader,System.Xml.Xsl.XsltSettings,System.Xml.XmlResolver,System.Boolean,System.Reflection.Emit.TypeBuilder,System.String)" /> метод.
		///         </param>
		/// <param name="earlyBoundTypes">
		///           Массив типов, хранящихся в созданном компилятором <paramref name="ebTypes" /> поле скомпилированную таблицу стилей.
		///         </param>
		// Token: 0x06002279 RID: 8825 RVA: 0x000D9AE4 File Offset: 0x000D7CE4
		public void Load(MethodInfo executeMethod, byte[] queryData, Type[] earlyBoundTypes)
		{
			this.Reset();
			if (executeMethod == null)
			{
				throw new ArgumentNullException("executeMethod");
			}
			if (queryData == null)
			{
				throw new ArgumentNullException("queryData");
			}
			if (!XsltConfigSection.EnableMemberAccessForXslCompiledTransform && executeMethod.DeclaringType != null && !executeMethod.DeclaringType.IsVisible)
			{
				new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
			}
			DynamicMethod dynamicMethod = executeMethod as DynamicMethod;
			Delegate @delegate = (dynamicMethod != null) ? dynamicMethod.CreateDelegate(typeof(ExecuteDelegate)) : Delegate.CreateDelegate(typeof(ExecuteDelegate), executeMethod);
			this.command = new XmlILCommand((ExecuteDelegate)@delegate, new XmlQueryStaticData(queryData, earlyBoundTypes));
			this.outputSettings = this.command.StaticData.DefaultWriterSettings;
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XPath.IXPathNavigable" /> объекта и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="input">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий преобразуемые данные.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227A RID: 8826 RVA: 0x000D9BA7 File Offset: 0x000D7DA7
		public void Transform(IXPathNavigable input, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.Transform(input, null, results, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XPath.IXPathNavigable" /> объекта и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="input">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий преобразуемые данные.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227B RID: 8827 RVA: 0x000D9BBE File Offset: 0x000D7DBE
		public void Transform(IXPathNavigable input, XsltArgumentList arguments, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.Transform(input, arguments, results, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XPath.IXPathNavigable" /> объекта и выводит результат в <see cref="T:System.IO.TextWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="input">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий преобразуемые данные.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.IO.TextWriter" />, в который нужно направить выход.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227C RID: 8828 RVA: 0x000D9BD8 File Offset: 0x000D7DD8
		public void Transform(IXPathNavigable input, XsltArgumentList arguments, TextWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
			{
				this.Transform(input, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
				xmlWriter.Close();
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XPath.IXPathNavigable" /> объекта и выводит результат в поток.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет аргументы дополнительных среды выполнения.
		///       </summary>
		/// <param name="input">
		///           Объект, реализующий <see cref="T:System.Xml.XPath.IXPathNavigable" /> интерфейса.
		///            В Microsoft .NET Framework, это может быть либо <see cref="T:System.Xml.XmlNode" /> (обычно <see cref="T:System.Xml.XmlDocument" />), или <see cref="T:System.Xml.XPath.XPathDocument" /> содержащий преобразуемые данные.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Поток, в который требуется направить вывод.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227D RID: 8829 RVA: 0x000D9C2C File Offset: 0x000D7E2C
		public void Transform(IXPathNavigable input, XsltArgumentList arguments, Stream results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
			{
				this.Transform(input, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
				xmlWriter.Close();
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XmlReader" /> объекта и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="input">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий входной документ.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227E RID: 8830 RVA: 0x000D9C80 File Offset: 0x000D7E80
		public void Transform(XmlReader input, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.Transform(input, null, results, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XmlReader" /> объекта и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="input">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий входной документ.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x0600227F RID: 8831 RVA: 0x000D9C97 File Offset: 0x000D7E97
		public void Transform(XmlReader input, XsltArgumentList arguments, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.Transform(input, arguments, results, XsltConfigSection.CreateDefaultResolver());
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XmlReader" /> объекта и выводит результат в <see cref="T:System.IO.TextWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="input">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий входной документ.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.IO.TextWriter" />, в который нужно направить выход.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x06002280 RID: 8832 RVA: 0x000D9CB0 File Offset: 0x000D7EB0
		public void Transform(XmlReader input, XsltArgumentList arguments, TextWriter results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
			{
				this.Transform(input, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
				xmlWriter.Close();
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XmlReader" /> объекта и выводит результат в поток.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="input">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий входной документ.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Поток, в который требуется направить вывод.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x06002281 RID: 8833 RVA: 0x000D9D04 File Offset: 0x000D7F04
		public void Transform(XmlReader input, XsltArgumentList arguments, Stream results)
		{
			XslCompiledTransform.CheckArguments(input, results);
			using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
			{
				this.Transform(input, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
				xmlWriter.Close();
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в URI и выводит результаты в <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="inputUri">
		///           URI входного документа.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="inputUri" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="inputUri" /> Значение включает имя файла или каталог не найден.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="inputUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="inputUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке входного документа.
		///           </exception>
		// Token: 0x06002282 RID: 8834 RVA: 0x000D9D58 File Offset: 0x000D7F58
		public void Transform(string inputUri, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(inputUri, results);
			using (XmlReader xmlReader = XmlReader.Create(inputUri, XslCompiledTransform.ReaderSettings))
			{
				this.Transform(xmlReader, null, results, XsltConfigSection.CreateDefaultResolver());
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в URI и выводит результаты в <see cref="T:System.Xml.XmlWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="inputUri">
		///           URI входного документа.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="inputUri" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="inputtUri" /> Значение включает имя файла или каталог не найден.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="inputUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="inputUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке входного документа.
		///           </exception>
		// Token: 0x06002283 RID: 8835 RVA: 0x000D9DA4 File Offset: 0x000D7FA4
		public void Transform(string inputUri, XsltArgumentList arguments, XmlWriter results)
		{
			XslCompiledTransform.CheckArguments(inputUri, results);
			using (XmlReader xmlReader = XmlReader.Create(inputUri, XslCompiledTransform.ReaderSettings))
			{
				this.Transform(xmlReader, arguments, results, XsltConfigSection.CreateDefaultResolver());
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в URI и выводит результаты в <see cref="T:System.IO.TextWriter" />.
		///       </summary>
		/// <param name="inputUri">
		///           URI входного документа.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.IO.TextWriter" />, в который нужно направить выход.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="inputUri" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="inputUri" /> Значение включает имя файла или каталог не найден.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="inputUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             Произошла ошибка при обработке запроса
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="inputUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке входного документа.
		///           </exception>
		// Token: 0x06002284 RID: 8836 RVA: 0x000D9DF0 File Offset: 0x000D7FF0
		public void Transform(string inputUri, XsltArgumentList arguments, TextWriter results)
		{
			XslCompiledTransform.CheckArguments(inputUri, results);
			using (XmlReader xmlReader = XmlReader.Create(inputUri, XslCompiledTransform.ReaderSettings))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
				{
					this.Transform(xmlReader, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
					xmlWriter.Close();
				}
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного по URI, и выводит результат в поток.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения.
		///       </summary>
		/// <param name="inputUri">
		///           URI входного документа.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Поток, в который требуется направить вывод.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="inputUri" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="inputUri" /> Значение включает имя файла или каталог не найден.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="inputUri" /> Значение не может быть разрешена.
		///
		///             -или-
		///
		///             Произошла ошибка при обработке запроса
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="inputUri" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке входного документа.
		///           </exception>
		// Token: 0x06002285 RID: 8837 RVA: 0x000D9E64 File Offset: 0x000D8064
		public void Transform(string inputUri, XsltArgumentList arguments, Stream results)
		{
			XslCompiledTransform.CheckArguments(inputUri, results);
			using (XmlReader xmlReader = XmlReader.Create(inputUri, XslCompiledTransform.ReaderSettings))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(results, this.OutputSettings))
				{
					this.Transform(xmlReader, arguments, xmlWriter, XsltConfigSection.CreateDefaultResolver());
					xmlWriter.Close();
				}
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного по URI, и выводит результат в файл.
		///       </summary>
		/// <param name="inputUri">
		///           URI входного документа.
		///         </param>
		/// <param name="resultsFile">
		///           URI выходного файла.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="inputUri" /> Или <paramref name="resultsFile" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти входной документ.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             <paramref name="inputUri" /> Или <paramref name="resultsFile" /> значение включает имя файла или каталог не найден.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             <paramref name="inputUri" /> Или <paramref name="resultsFile" /> значение не может быть разрешена.
		///
		///             -или-
		///
		///             Произошла ошибка при обработке запроса
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="inputUri" /> или <paramref name="resultsFile" /> не является допустимым URI.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка анализа при загрузке входного документа.
		///           </exception>
		// Token: 0x06002286 RID: 8838 RVA: 0x000D9ED8 File Offset: 0x000D80D8
		public void Transform(string inputUri, string resultsFile)
		{
			if (inputUri == null)
			{
				throw new ArgumentNullException("inputUri");
			}
			if (resultsFile == null)
			{
				throw new ArgumentNullException("resultsFile");
			}
			using (XmlReader xmlReader = XmlReader.Create(inputUri, XslCompiledTransform.ReaderSettings))
			{
				using (XmlWriter xmlWriter = XmlWriter.Create(resultsFile, this.OutputSettings))
				{
					this.Transform(xmlReader, null, xmlWriter, XsltConfigSection.CreateDefaultResolver());
					xmlWriter.Close();
				}
			}
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в <see cref="T:System.Xml.XmlReader" /> объекта и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> Предоставляет дополнительные аргументы времени выполнения, а XmlResolver разрешает XSLT document() функции.
		///       </summary>
		/// <param name="input">
		///           <see cref="T:System.Xml.XmlReader" /> Содержащий входной документ.
		///         </param>
		/// <param name="arguments">
		///           <see cref="T:System.Xml.Xsl.XsltArgumentList" /> С аргументами, уточненное пространством имен, используется в качестве входных данных для преобразования.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит xsl:output элемент, следует создать <see cref="T:System.Xml.XmlWriter" /> с помощью <see cref="T:System.Xml.XmlWriterSettings" /> объект, возвращенный из <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" /> свойство.
		///            Это гарантирует, что <see cref="T:System.Xml.XmlWriter" /> имеет правильные выходные параметры.
		///         </param>
		/// <param name="documentResolver">
		///           <see cref="T:System.Xml.XmlResolver" /> Используется для обработки XSLT document() функции.
		///            Если это <see langword="null" />,  document() функция не разрешается.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="input" /> Или <paramref name="results" /> значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Xml.Xsl.XsltException">
		///             Ошибка при выполнении преобразования XSLT.
		///           </exception>
		// Token: 0x06002287 RID: 8839 RVA: 0x000D9F60 File Offset: 0x000D8160
		public void Transform(XmlReader input, XsltArgumentList arguments, XmlWriter results, XmlResolver documentResolver)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.CheckCommand();
			this.command.Execute(input, documentResolver, arguments, results);
		}

		/// <summary>
		///         Выполняет преобразование с помощью входного документа, указанного в объекте <see cref="T:System.Xml.XPath.IXPathNavigable" />, и выводит результат в <see cref="T:System.Xml.XmlWriter" />.
		///         <see cref="T:System.Xml.Xsl.XsltArgumentList" /> содержит дополнительные аргументы для работы во время выполнения, а <see cref="T:System.Xml.XmlResolver" /> разрешает функцию XSLT <see langword="document()" />.
		///       </summary>
		/// <param name="input">
		///           Документ для преобразования, заданный в объекте <see cref="T:System.Xml.XPath.IXPathNavigable" />.
		///         </param>
		/// <param name="arguments">
		///           Список аргументов в виде <see cref="T:System.Xml.Xsl.XsltArgumentList" />.
		///         </param>
		/// <param name="results">
		///           Модуль записи <see cref="T:System.Xml.XmlWriter" />, в который нужно направить выход.
		///
		///           Если таблица стилей содержит элемент <see langword="xsl:output" />, необходимо создать <see cref="T:System.Xml.XmlWriter" /> с использованием объекта <see cref="T:System.Xml.XmlWriterSettings" />, возвращенного из свойства <see cref="P:System.Xml.Xsl.XslCompiledTransform.OutputSettings" />.
		///            Это гарантирует правильность параметров выходных данных для объекта <see cref="T:System.Xml.XmlWriter" />.
		///         </param>
		/// <param name="documentResolver">
		///           Объект <see cref="T:System.Xml.XmlResolver" />, используемый для разрешения функции XSLT <see langword="document()" />.
		///            Если значение равно <see langword="null" />, функция <see langword="document()" /> не разрешается.
		///         </param>
		// Token: 0x06002288 RID: 8840 RVA: 0x000D9F7F File Offset: 0x000D817F
		public void Transform(IXPathNavigable input, XsltArgumentList arguments, XmlWriter results, XmlResolver documentResolver)
		{
			XslCompiledTransform.CheckArguments(input, results);
			this.CheckCommand();
			this.command.Execute(input.CreateNavigator(), documentResolver, arguments, results);
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x000D9FA3 File Offset: 0x000D81A3
		private static void CheckArguments(object input, object results)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x000D9FC1 File Offset: 0x000D81C1
		private static void CheckArguments(string inputUri, object results)
		{
			if (inputUri == null)
			{
				throw new ArgumentNullException("inputUri");
			}
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x000D9FDF File Offset: 0x000D81DF
		private void CheckCommand()
		{
			if (this.command == null)
			{
				throw new InvalidOperationException(Res.GetString("No stylesheet was loaded."));
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000D9FF9 File Offset: 0x000D81F9
		private QilExpression TestCompile(object stylesheet, XsltSettings settings, XmlResolver stylesheetResolver)
		{
			this.Reset();
			this.CompileXsltToQil(stylesheet, settings, stylesheetResolver);
			return this.qil;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x000DA010 File Offset: 0x000D8210
		private void TestGenerate(XsltSettings settings)
		{
			this.CompileQilToMsil(settings);
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x000DA019 File Offset: 0x000D8219
		private void Transform(string inputUri, XsltArgumentList arguments, XmlWriter results, XmlResolver documentResolver)
		{
			this.command.Execute(inputUri, documentResolver, arguments, results);
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x000DA02C File Offset: 0x000D822C
		internal static void PrintQil(object qil, XmlWriter xw, bool printComments, bool printTypes, bool printLineInfo)
		{
			QilExpression node = (QilExpression)qil;
			QilXmlWriter.Options options = QilXmlWriter.Options.None;
			if (printComments)
			{
				options |= QilXmlWriter.Options.Annotations;
			}
			if (printTypes)
			{
				options |= QilXmlWriter.Options.TypeInfo;
			}
			if (printLineInfo)
			{
				options |= QilXmlWriter.Options.LineInfo;
			}
			new QilXmlWriter(xw, options).ToXml(node);
			xw.Flush();
		}

		// Token: 0x04001C3C RID: 7228
		private static readonly XmlReaderSettings ReaderSettings;

		// Token: 0x04001C3D RID: 7229
		private static readonly PermissionSet MemberAccessPermissionSet = new PermissionSet(PermissionState.None);

		// Token: 0x04001C3E RID: 7230
		private const string Version = "4.0.0.0";

		// Token: 0x04001C3F RID: 7231
		private bool enableDebug;

		// Token: 0x04001C40 RID: 7232
		private CompilerResults compilerResults;

		// Token: 0x04001C41 RID: 7233
		private XmlWriterSettings outputSettings;

		// Token: 0x04001C42 RID: 7234
		private QilExpression qil;

		// Token: 0x04001C43 RID: 7235
		private XmlILCommand command;

		// Token: 0x04001C44 RID: 7236
		private static volatile ConstructorInfo GeneratedCodeCtor;
	}
}
