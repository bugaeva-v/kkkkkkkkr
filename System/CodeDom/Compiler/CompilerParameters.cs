using System;
using System.Collections.Specialized;
using System.Security.Policy;

namespace System.CodeDom.Compiler
{
	/// <summary>Представляет параметры, используемые для вызова компилятора.</summary>
	// Token: 0x0200034C RID: 844
	[Serializable]
	public class CompilerParameters
	{
		/// <summary>Указывает объект свидетельства, представляющий разрешения политики безопасности для предоставления компилируемой сборке.</summary>
		/// <returns>Объект, представляющий разрешения политики безопасности для предоставления компилируемой сборке.</returns>
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001BDA RID: 7130 RVA: 0x000665BA File Offset: 0x000647BA
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x000665CD File Offset: 0x000647CD
		[Obsolete("CAS policy is obsolete and will be removed in a future release of the .NET Framework. Please see http://go2.microsoft.com/fwlink/?LinkId=131738 for more information.")]
		public Evidence Evidence
		{
			get
			{
				Evidence evidence = this._evidence;
				if (evidence == null)
				{
					return null;
				}
				return evidence.Clone();
			}
			set
			{
				this._evidence = ((value != null) ? value.Clone() : null);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerParameters" />.</summary>
		// Token: 0x06001BDC RID: 7132 RVA: 0x000665E1 File Offset: 0x000647E1
		public CompilerParameters() : this(null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerParameters" /> с использованием указанных имен сборок.</summary>
		/// <param name="assemblyNames">Имя сборок для ссылки.</param>
		// Token: 0x06001BDD RID: 7133 RVA: 0x000665EB File Offset: 0x000647EB
		public CompilerParameters(string[] assemblyNames) : this(assemblyNames, null, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, используя указанные имена сборок и имя выходного файла.</summary>
		/// <param name="assemblyNames">Имя сборок для ссылки.</param>
		/// <param name="outputName">Имя выходного файла.</param>
		// Token: 0x06001BDE RID: 7134 RVA: 0x000665F6 File Offset: 0x000647F6
		public CompilerParameters(string[] assemblyNames, string outputName) : this(assemblyNames, outputName, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.CodeDom.Compiler.CompilerParameters" />, используя указанные имена сборок, имя выходного файла и значение, показывающее, следует ли включать сведения об отладке.</summary>
		/// <param name="assemblyNames">Имя сборок для ссылки.</param>
		/// <param name="outputName">Имя выходного файла.</param>
		/// <param name="includeDebugInformation">Значение <see langword="true" />, чтобы включить отладочные данные; значение <see langword="false" />, чтобы исключить отладочные данные.</param>
		// Token: 0x06001BDF RID: 7135 RVA: 0x00066604 File Offset: 0x00064804
		public CompilerParameters(string[] assemblyNames, string outputName, bool includeDebugInformation)
		{
			if (assemblyNames != null)
			{
				this.ReferencedAssemblies.AddRange(assemblyNames);
			}
			this.OutputAssembly = outputName;
			this.IncludeDebugInformation = includeDebugInformation;
		}

		/// <summary>Получает или задает имя основной или стандартной сборки, которая содержит базовые типы, такие как <see cref="T:System.Object" />, <see cref="T:System.String" /> или <see cref="T:System.Int32" />.</summary>
		/// <returns>Имя основной сборки, содержащей базовые типы.</returns>
		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00066667 File Offset: 0x00064867
		// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x0006666F File Offset: 0x0006486F
		public string CoreAssemblyFileName { get; set; } = string.Empty;

		/// <summary>Получает или задает значение, показывающее, следует ли создавать исполняемый файл.</summary>
		/// <returns>
		///   <see langword="true" />, если следует создавать исполняемый файл; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00066678 File Offset: 0x00064878
		// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00066680 File Offset: 0x00064880
		public bool GenerateExecutable { get; set; }

		/// <summary>Получает или задает значение, показывающее, следует ли создавать выходной файл в памяти.</summary>
		/// <returns>
		///   <see langword="true" />, если компилятор должен создавать выходной файл в памяти; в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00066689 File Offset: 0x00064889
		// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00066691 File Offset: 0x00064891
		public bool GenerateInMemory { get; set; }

		/// <summary>Получает или задает сборки, на которые ссылается текущий проект.</summary>
		/// <returns>Коллекция, содержащая имена сборок, на которые ссылается источник, для компиляции.</returns>
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x0006669A File Offset: 0x0006489A
		public StringCollection ReferencedAssemblies
		{
			get
			{
				return this._assemblyNames;
			}
		}

		/// <summary>Получает или задает имя главного класса.</summary>
		/// <returns>Имя главного класса.</returns>
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x000666A2 File Offset: 0x000648A2
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x000666AA File Offset: 0x000648AA
		public string MainClass { get; set; }

		/// <summary>Получает или задает имя выходной сборки.</summary>
		/// <returns>Имя выходной сборки.</returns>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x000666B3 File Offset: 0x000648B3
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x000666BB File Offset: 0x000648BB
		public string OutputAssembly { get; set; }

		/// <summary>Получает или задает коллекцию временных файлов.</summary>
		/// <returns>Коллекция, содержащая временные файлы.</returns>
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x000666C4 File Offset: 0x000648C4
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x000666E9 File Offset: 0x000648E9
		public TempFileCollection TempFiles
		{
			get
			{
				TempFileCollection result;
				if ((result = this._tempFiles) == null)
				{
					result = (this._tempFiles = new TempFileCollection());
				}
				return result;
			}
			set
			{
				this._tempFiles = value;
			}
		}

		/// <summary>Получает или задает значение, показывающее, следует ли включать сведения об отладке в компилируемый исполняемый файл.</summary>
		/// <returns>
		///   <see langword="true" />, если следует создавать сведения об отладке; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x000666F2 File Offset: 0x000648F2
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x000666FA File Offset: 0x000648FA
		public bool IncludeDebugInformation { get; set; }

		/// <summary>Получает или задает значение, указывающее, следует ли интерпретировать предупреждения как ошибки.</summary>
		/// <returns>
		///   <see langword="true" />, если следует интерпретировать предупреждения как ошибки; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x00066703 File Offset: 0x00064903
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0006670B File Offset: 0x0006490B
		public bool TreatWarningsAsErrors { get; set; }

		/// <summary>Получает или задает уровень предупреждения, на котором компилятор прекращает компиляцию.</summary>
		/// <returns>Уровень предупреждения, на котором компилятор прекращает компиляцию.</returns>
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001BF1 RID: 7153 RVA: 0x00066714 File Offset: 0x00064914
		// (set) Token: 0x06001BF2 RID: 7154 RVA: 0x0006671C File Offset: 0x0006491C
		public int WarningLevel { get; set; } = -1;

		/// <summary>Получает или задает необязательный аргументы командной строки для использования при вызове компилятора.</summary>
		/// <returns>Аргументы дополнительной командной строки для компилятора.</returns>
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001BF3 RID: 7155 RVA: 0x00066725 File Offset: 0x00064925
		// (set) Token: 0x06001BF4 RID: 7156 RVA: 0x0006672D File Offset: 0x0006492D
		public string CompilerOptions { get; set; }

		/// <summary>Получает или задает имя файла ресурса Win32 для связывания с компилируемой сборкой.</summary>
		/// <returns>Файл ресурса Win32, который будет связан с компилируемой сборкой.</returns>
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001BF5 RID: 7157 RVA: 0x00066736 File Offset: 0x00064936
		// (set) Token: 0x06001BF6 RID: 7158 RVA: 0x0006673E File Offset: 0x0006493E
		public string Win32Resource { get; set; }

		/// <summary>Получает файлы ресурсов платформы .NET Framework для включения при компиляции вывода сборки.</summary>
		/// <returns>Коллекция, содержащая пути к файлам ресурсов платформы .NET Framework для включения в созданную сборку.</returns>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00066747 File Offset: 0x00064947
		public StringCollection EmbeddedResources
		{
			get
			{
				return this._embeddedResources;
			}
		}

		/// <summary>Получает файлы ресурсов платформы .NET Framework, на которые имеются ссылки в текущем источнике.</summary>
		/// <returns>Коллекция, содержащая пути к файлам ресурсов платформы .NET Framework, на которые имеются ссылки в данном источнике.</returns>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x0006674F File Offset: 0x0006494F
		public StringCollection LinkedResources
		{
			get
			{
				return this._linkedResources;
			}
		}

		/// <summary>Получает или задает пользовательский токен, используемый при создании процесса компилятора.</summary>
		/// <returns>Пользовательский токен для использования.</returns>
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x00066757 File Offset: 0x00064957
		// (set) Token: 0x06001BFA RID: 7162 RVA: 0x0006675F File Offset: 0x0006495F
		public IntPtr UserToken { get; set; }

		// Token: 0x04000E35 RID: 3637
		private Evidence _evidence;

		// Token: 0x04000E36 RID: 3638
		private readonly StringCollection _assemblyNames = new StringCollection();

		// Token: 0x04000E37 RID: 3639
		private readonly StringCollection _embeddedResources = new StringCollection();

		// Token: 0x04000E38 RID: 3640
		private readonly StringCollection _linkedResources = new StringCollection();

		// Token: 0x04000E39 RID: 3641
		private TempFileCollection _tempFiles;
	}
}
