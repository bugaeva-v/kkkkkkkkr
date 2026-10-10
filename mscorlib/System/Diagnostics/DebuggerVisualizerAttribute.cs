using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Указывает, что у типа есть визуализатор. Этот класс не наследуется.</summary>
	// Token: 0x020009BE RID: 2494
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
	[ComVisible(true)]
	public sealed class DebuggerVisualizerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" />, задающего имя типа визуализатора.</summary>
		/// <param name="visualizerTypeName">Полное имя типа визуализатора.</param>
		// Token: 0x060059B5 RID: 22965 RVA: 0x00133158 File Offset: 0x00131358
		public DebuggerVisualizerAttribute(string visualizerTypeName)
		{
			this.visualizerName = visualizerTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" />, который задает имя типа визуализатора и имя типа источника объекта визуализатора.</summary>
		/// <param name="visualizerTypeName">Полное имя типа визуализатора.</param>
		/// <param name="visualizerObjectSourceTypeName">Полное имя источника объекта визуализатора.</param>
		// Token: 0x060059B6 RID: 22966 RVA: 0x00133167 File Offset: 0x00131367
		public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName)
		{
			this.visualizerName = visualizerTypeName;
			this.visualizerObjectSourceName = visualizerObjectSourceTypeName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" />, который задает имя типа визуализатора и тип источника объекта визуализатора.</summary>
		/// <param name="visualizerTypeName">Полное имя типа визуализатора.</param>
		/// <param name="visualizerObjectSource">Тип источника объекта визуализатора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="visualizerObjectSource" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060059B7 RID: 22967 RVA: 0x0013317D File Offset: 0x0013137D
		public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource)
		{
			if (visualizerObjectSource == null)
			{
				throw new ArgumentNullException("visualizerObjectSource");
			}
			this.visualizerName = visualizerTypeName;
			this.visualizerObjectSourceName = visualizerObjectSource.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" /> с указанием типа визуализатора.</summary>
		/// <param name="visualizer">Тип визуализатора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="visualizer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060059B8 RID: 22968 RVA: 0x001331AC File Offset: 0x001313AC
		public DebuggerVisualizerAttribute(Type visualizer)
		{
			if (visualizer == null)
			{
				throw new ArgumentNullException("visualizer");
			}
			this.visualizerName = visualizer.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" />, задающий тип визуализатора и тип источника объекта визуализатора.</summary>
		/// <param name="visualizer">Тип визуализатора.</param>
		/// <param name="visualizerObjectSource">Тип источника объекта визуализатора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="visualizerObjectSource" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060059B9 RID: 22969 RVA: 0x001331D4 File Offset: 0x001313D4
		public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource)
		{
			if (visualizer == null)
			{
				throw new ArgumentNullException("visualizer");
			}
			if (visualizerObjectSource == null)
			{
				throw new ArgumentNullException("visualizerObjectSource");
			}
			this.visualizerName = visualizer.AssemblyQualifiedName;
			this.visualizerObjectSourceName = visualizerObjectSource.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggerVisualizerAttribute" />, задающий тип визуализатора и имя типа источника объекта визуализатора.</summary>
		/// <param name="visualizer">Тип визуализатора.</param>
		/// <param name="visualizerObjectSourceTypeName">Полное имя источника объекта визуализатора.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="visualizer" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060059BA RID: 22970 RVA: 0x00133227 File Offset: 0x00131427
		public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName)
		{
			if (visualizer == null)
			{
				throw new ArgumentNullException("visualizer");
			}
			this.visualizerName = visualizer.AssemblyQualifiedName;
			this.visualizerObjectSourceName = visualizerObjectSourceTypeName;
		}

		/// <summary>Возвращает полное имя типа источника объекта визуализатора.</summary>
		/// <returns>Полное имя источника объекта визуализатора.</returns>
		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x060059BB RID: 22971 RVA: 0x00133256 File Offset: 0x00131456
		public string VisualizerObjectSourceTypeName
		{
			get
			{
				return this.visualizerObjectSourceName;
			}
		}

		/// <summary>Возвращает полное имя типа визуализатора.</summary>
		/// <returns>Полное имя типа визуализатора.</returns>
		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060059BC RID: 22972 RVA: 0x0013325E File Offset: 0x0013145E
		public string VisualizerTypeName
		{
			get
			{
				return this.visualizerName;
			}
		}

		/// <summary>Возвращает или задает описание визуализатора.</summary>
		/// <returns>Описание визуализатора.</returns>
		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060059BD RID: 22973 RVA: 0x00133266 File Offset: 0x00131466
		// (set) Token: 0x060059BE RID: 22974 RVA: 0x0013326E File Offset: 0x0013146E
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		/// <summary>Возвращает или задает тип целевого объекта, когда атрибут применяется на уровне сборки.</summary>
		/// <returns>Тип целевого объекта для визуализатора.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение не может быть установлено, т.к. равно <see langword="null" />.</exception>
		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060059C0 RID: 22976 RVA: 0x001332A0 File Offset: 0x001314A0
		// (set) Token: 0x060059BF RID: 22975 RVA: 0x00133277 File Offset: 0x00131477
		public Type Target
		{
			get
			{
				return this.target;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.targetName = value.AssemblyQualifiedName;
				this.target = value;
			}
		}

		/// <summary>Возвращает или задает полное имя типа целевого объекта, когда атрибут применяется на уровне сборки.</summary>
		/// <returns>Полное имя типа целевого объекта.</returns>
		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060059C2 RID: 22978 RVA: 0x001332B1 File Offset: 0x001314B1
		// (set) Token: 0x060059C1 RID: 22977 RVA: 0x001332A8 File Offset: 0x001314A8
		public string TargetTypeName
		{
			get
			{
				return this.targetName;
			}
			set
			{
				this.targetName = value;
			}
		}

		// Token: 0x04003788 RID: 14216
		private string visualizerObjectSourceName;

		// Token: 0x04003789 RID: 14217
		private string visualizerName;

		// Token: 0x0400378A RID: 14218
		private string description;

		// Token: 0x0400378B RID: 14219
		private string targetName;

		// Token: 0x0400378C RID: 14220
		private Type target;
	}
}
