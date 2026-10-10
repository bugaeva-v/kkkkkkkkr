using System;

namespace System.Diagnostics.CodeAnalysis
{
	/// <summary>Подавляет создание отчетов о нарушении правил определенного средства статического анализа, допуская применение нескольких операций подавления к одному артефакту кода.</summary>
	// Token: 0x02000A02 RID: 2562
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
	[Conditional("CODE_ANALYSIS")]
	public sealed class SuppressMessageAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.CodeAnalysis.SuppressMessageAttribute" /> с указанными категорией инструмента статического анализа и идентификатором правила анализа.</summary>
		/// <param name="category">Категория атрибута.</param>
		/// <param name="checkId">Идентификатор правила инструмента анализа, к которому относится атрибут.</param>
		// Token: 0x06005B4E RID: 23374 RVA: 0x0013493D File Offset: 0x00132B3D
		public SuppressMessageAttribute(string category, string checkId)
		{
			this.Category = category;
			this.CheckId = checkId;
		}

		/// <summary>Возвращает категорию, определяющую классификацию атрибута.</summary>
		/// <returns>Категория, определяющая атрибут.</returns>
		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06005B4F RID: 23375 RVA: 0x00134953 File Offset: 0x00132B53
		public string Category { get; }

		/// <summary>Возвращает идентификатор подавляемого правила инструмента анализа.</summary>
		/// <returns>Идентификатор подавляемого правила инструмента анализа.</returns>
		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x0013495B File Offset: 0x00132B5B
		public string CheckId { get; }

		/// <summary>Возвращает или задает область кода, к которой относится атрибут.</summary>
		/// <returns>Область кода, к которой относится атрибут.</returns>
		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06005B51 RID: 23377 RVA: 0x00134963 File Offset: 0x00132B63
		// (set) Token: 0x06005B52 RID: 23378 RVA: 0x0013496B File Offset: 0x00132B6B
		public string Scope { get; set; }

		/// <summary>Возвращает или задает полный путь, представляющий целевой элемент атрибута.</summary>
		/// <returns>Полный путь, представляющий целевой элемент атрибута.</returns>
		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06005B53 RID: 23379 RVA: 0x00134974 File Offset: 0x00132B74
		// (set) Token: 0x06005B54 RID: 23380 RVA: 0x0013497C File Offset: 0x00132B7C
		public string Target { get; set; }

		/// <summary>Возвращает или устанавливает необязательное расширение аргумента для критерия исключения.</summary>
		/// <returns>Строка, содержащая расширенный критерий исключения.</returns>
		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06005B55 RID: 23381 RVA: 0x00134985 File Offset: 0x00132B85
		// (set) Token: 0x06005B56 RID: 23382 RVA: 0x0013498D File Offset: 0x00132B8D
		public string MessageId { get; set; }

		/// <summary>Возвращает или определяет причину подавления сообщения анализа кода.</summary>
		/// <returns>Причина подавления сообщения.</returns>
		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06005B57 RID: 23383 RVA: 0x00134996 File Offset: 0x00132B96
		// (set) Token: 0x06005B58 RID: 23384 RVA: 0x0013499E File Offset: 0x00132B9E
		public string Justification { get; set; }
	}
}
