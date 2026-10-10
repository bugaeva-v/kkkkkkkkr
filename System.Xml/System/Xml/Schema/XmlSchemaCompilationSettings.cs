using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Предоставляет параметры компиляции схемы для <see cref="T:System.Xml.Schema.XmlSchemaSet" /> класса, этот класс не наследуется.
	///       </summary>
	// Token: 0x0200059F RID: 1439
	public sealed class XmlSchemaCompilationSettings
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Schema.XmlSchemaCompilationSettings" />.
		///       </summary>
		// Token: 0x06003A38 RID: 14904 RVA: 0x0014C86B File Offset: 0x0014AA6B
		public XmlSchemaCompilationSettings()
		{
			this.enableUpaCheck = true;
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, является ли <see cref="T:System.Xml.Schema.XmlSchemaSet" /> должно проверять наличие нарушений уникальный примитив однозначного соответствия однозначного соответствия.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Schema.XmlSchemaSet" /> должно проверять наличие уникальных примитив однозначного соответствия однозначного соответствия нарушения; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x0014C87A File Offset: 0x0014AA7A
		// (set) Token: 0x06003A3A RID: 14906 RVA: 0x0014C882 File Offset: 0x0014AA82
		public bool EnableUpaCheck
		{
			get
			{
				return this.enableUpaCheck;
			}
			set
			{
				this.enableUpaCheck = value;
			}
		}

		// Token: 0x04002AF7 RID: 10999
		private bool enableUpaCheck;
	}
}
