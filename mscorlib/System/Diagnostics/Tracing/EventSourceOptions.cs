using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Задает переопределения параметров события по умолчанию, таких как уровень ведения журнала, ключевые слова и код операции, при вызове метода <see cref="M:System.Diagnostics.Tracing.EventSource.Write``1(System.String,System.Diagnostics.Tracing.EventSourceOptions,``0)" />.</summary>
	// Token: 0x020009E5 RID: 2533
	public struct EventSourceOptions
	{
		/// <summary>Возвращает или задает уровень, применяемый к событию.</summary>
		/// <returns>Уровень события. Если значение не задано, по умолчанию используется значение Verbose (5).</returns>
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06005A94 RID: 23188 RVA: 0x001342EB File Offset: 0x001324EB
		// (set) Token: 0x06005A95 RID: 23189 RVA: 0x001342F3 File Offset: 0x001324F3
		public EventLevel Level
		{
			get
			{
				return (EventLevel)this.level;
			}
			set
			{
				this.level = checked((byte)value);
				this.valuesSet |= 4;
			}
		}

		/// <summary>Возвращает или задает код операции для указанного события.</summary>
		/// <returns>Код операции для указанного события. Если значение не задано, по умолчанию используется значение <see langword="Info" /> (0).</returns>
		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06005A96 RID: 23190 RVA: 0x0013430C File Offset: 0x0013250C
		// (set) Token: 0x06005A97 RID: 23191 RVA: 0x00134314 File Offset: 0x00132514
		public EventOpcode Opcode
		{
			get
			{
				return (EventOpcode)this.opcode;
			}
			set
			{
				this.opcode = checked((byte)value);
				this.valuesSet |= 8;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06005A98 RID: 23192 RVA: 0x0013432D File Offset: 0x0013252D
		internal bool IsOpcodeSet
		{
			get
			{
				return (this.valuesSet & 8) > 0;
			}
		}

		/// <summary>Возвращает или задает ключевые слова, применяемые к событию. Если это свойство не задано, используется значение <see langword="None" />.</summary>
		/// <returns>Ключевые слова, применяемые к событию, или <see langword="None" />, если ключевые слова не заданы.</returns>
		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x0013433A File Offset: 0x0013253A
		// (set) Token: 0x06005A9A RID: 23194 RVA: 0x00134342 File Offset: 0x00132542
		public EventKeywords Keywords
		{
			get
			{
				return this.keywords;
			}
			set
			{
				this.keywords = value;
				this.valuesSet |= 1;
			}
		}

		/// <summary>Теги событий, определенные для этого источника событий.</summary>
		/// <returns>Возвращает <see cref="T:System.Diagnostics.Tracing.EventTags" />.</returns>
		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x0013435A File Offset: 0x0013255A
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x00134362 File Offset: 0x00132562
		public EventTags Tags
		{
			get
			{
				return this.tags;
			}
			set
			{
				this.tags = value;
				this.valuesSet |= 2;
			}
		}

		/// <summary>Параметры действий, определенные для данного источника событий.</summary>
		/// <returns>Возвращает <see cref="T:System.Diagnostics.Tracing.EventActivityOptions" />.</returns>
		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x0013437A File Offset: 0x0013257A
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x00134382 File Offset: 0x00132582
		public EventActivityOptions ActivityOptions
		{
			get
			{
				return this.activityOptions;
			}
			set
			{
				this.activityOptions = value;
				this.valuesSet |= 16;
			}
		}

		// Token: 0x040037DB RID: 14299
		internal EventKeywords keywords;

		// Token: 0x040037DC RID: 14300
		internal EventTags tags;

		// Token: 0x040037DD RID: 14301
		internal EventActivityOptions activityOptions;

		// Token: 0x040037DE RID: 14302
		internal byte level;

		// Token: 0x040037DF RID: 14303
		internal byte opcode;

		// Token: 0x040037E0 RID: 14304
		internal byte valuesSet;

		// Token: 0x040037E1 RID: 14305
		internal const byte keywordsSet = 1;

		// Token: 0x040037E2 RID: 14306
		internal const byte tagsSet = 2;

		// Token: 0x040037E3 RID: 14307
		internal const byte levelSet = 4;

		// Token: 0x040037E4 RID: 14308
		internal const byte opcodeSet = 8;

		// Token: 0x040037E5 RID: 14309
		internal const byte activityOptionsSet = 16;
	}
}
