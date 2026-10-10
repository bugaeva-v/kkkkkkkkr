using System;

namespace System.Diagnostics
{
	/// <summary>Указывает, должны ли прослушиватели осуществлять трассировку сообщений на основе источника трассировки.</summary>
	// Token: 0x02000221 RID: 545
	public class SourceFilter : TraceFilter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.SourceFilter" />, задающего имя источника трассировки.</summary>
		/// <param name="source">Имя источника трассировки.</param>
		// Token: 0x06000FDC RID: 4060 RVA: 0x00046415 File Offset: 0x00044615
		public SourceFilter(string source)
		{
			this.Source = source;
		}

		/// <summary>Определяет, должен ли прослушиватель трассировки осуществлять трассировку события.</summary>
		/// <param name="cache">Объект, представляющий кэш данных для события трассировки.</param>
		/// <param name="source">Имя источника.</param>
		/// <param name="eventType">Одно из значений перечисления, которое задает тип события.</param>
		/// <param name="id">Номер идентификатора трассировки.</param>
		/// <param name="formatOrMessage">Формат, используемый для записи массива аргументов или записи сообщения.</param>
		/// <param name="args">Массив объектов аргумента.</param>
		/// <param name="data1">Объект данных трассировки.</param>
		/// <param name="data">Массив объектов данных трассировки.</param>
		/// <returns>Значение <see langword="true" />, если трассировка должна быть осуществлена; в противном случае значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="source" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000FDD RID: 4061 RVA: 0x00046424 File Offset: 0x00044624
		public override bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			return string.Equals(this.src, source);
		}

		/// <summary>Возвращает или задает название источника трассировки.</summary>
		/// <returns>Имя источника трассировки.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение — <see langword="null" />.</exception>
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x00046440 File Offset: 0x00044640
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x00046448 File Offset: 0x00044648
		public string Source
		{
			get
			{
				return this.src;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("source");
				}
				this.src = value;
			}
		}

		// Token: 0x040009AB RID: 2475
		private string src;
	}
}
