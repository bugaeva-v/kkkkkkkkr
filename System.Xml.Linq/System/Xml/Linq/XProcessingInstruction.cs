using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Xml.Linq
{
	/// <summary>Представляет инструкцию обработки XML-кода.</summary>
	// Token: 0x0200005F RID: 95
	public class XProcessingInstruction : XNode
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</summary>
		/// <param name="target">
		///   <see cref="T:System.String" />, содержащий конечное приложение для <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
		/// <param name="data">Строковые данные для этого <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="target" /> или параметра <paramref name="data" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не соответствует ограничениям имени XML.</exception>
		// Token: 0x0600038C RID: 908 RVA: 0x000101A4 File Offset: 0x0000E3A4
		public XProcessingInstruction(string target, string data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			XProcessingInstruction.ValidateName(target);
			this.target = target;
			this.data = data;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Xml.Linq.XProcessingInstruction" />.</summary>
		/// <param name="other">Узел <see cref="T:System.Xml.Linq.XProcessingInstruction" />, из которого следует выполнить копирование.</param>
		// Token: 0x0600038D RID: 909 RVA: 0x000101CE File Offset: 0x0000E3CE
		public XProcessingInstruction(XProcessingInstruction other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			this.target = other.target;
			this.data = other.data;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000101FC File Offset: 0x0000E3FC
		internal XProcessingInstruction(XmlReader r)
		{
			this.target = r.Name;
			this.data = r.Value;
			r.Read();
		}

		/// <summary>Получает или задает строковое значение инструкции по обработке.</summary>
		/// <returns>
		///   <see cref="T:System.String" /> содержит строковое значение инструкции по обработке.</returns>
		/// <exception cref="T:System.ArgumentNullException">Строка <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00010223 File Offset: 0x0000E423
		// (set) Token: 0x06000390 RID: 912 RVA: 0x0001022B File Offset: 0x0000E42B
		public string Data
		{
			get
			{
				return this.data;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Value);
				this.data = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Value);
				}
			}
		}

		/// <summary>Возвращает тип узла для этого узла.</summary>
		/// <returns>Тип узла. Для объектов <see cref="T:System.Xml.Linq.XProcessingInstruction" /> это значение равно <see cref="F:System.Xml.XmlNodeType.ProcessingInstruction" />.</returns>
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0001025D File Offset: 0x0000E45D
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.ProcessingInstruction;
			}
		}

		/// <summary>Получает или задает строку, содержащую конечное приложение для инструкции по обработке.</summary>
		/// <returns>
		///   <see cref="T:System.String" />, содержащий конечное приложение для инструкции по обработке.</returns>
		/// <exception cref="T:System.ArgumentNullException">Строка <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не соответствует ограничениям имени XML.</exception>
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00010260 File Offset: 0x0000E460
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00010268 File Offset: 0x0000E468
		public string Target
		{
			get
			{
				return this.target;
			}
			set
			{
				XProcessingInstruction.ValidateName(value);
				bool flag = base.NotifyChanging(this, XObjectChangeEventArgs.Name);
				this.target = value;
				if (flag)
				{
					base.NotifyChanged(this, XObjectChangeEventArgs.Name);
				}
			}
		}

		/// <summary>Запись инструкции по обработке в <see cref="T:System.Xml.XmlWriter" />.</summary>
		/// <param name="writer">
		///   <see cref="T:System.Xml.XmlWriter" /> для записи этой инструкции по обработке.</param>
		// Token: 0x06000394 RID: 916 RVA: 0x00010292 File Offset: 0x0000E492
		public override void WriteTo(XmlWriter writer)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			writer.WriteProcessingInstruction(this.target, this.data);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000102B4 File Offset: 0x0000E4B4
		public override Task WriteToAsync(XmlWriter writer, CancellationToken cancellationToken)
		{
			if (writer == null)
			{
				throw new ArgumentNullException("writer");
			}
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			return writer.WriteProcessingInstructionAsync(this.target, this.data);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000102E6 File Offset: 0x0000E4E6
		internal override XNode CloneNode()
		{
			return new XProcessingInstruction(this);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000102F0 File Offset: 0x0000E4F0
		internal override bool DeepEquals(XNode node)
		{
			XProcessingInstruction xprocessingInstruction = node as XProcessingInstruction;
			return xprocessingInstruction != null && this.target == xprocessingInstruction.target && this.data == xprocessingInstruction.data;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0001032D File Offset: 0x0000E52D
		internal override int GetDeepHashCode()
		{
			return this.target.GetHashCode() ^ this.data.GetHashCode();
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00010346 File Offset: 0x0000E546
		private static void ValidateName(string name)
		{
			XmlConvert.VerifyNCName(name);
			if (string.Equals(name, "xml", StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(SR.Format("'{0}' is an invalid name for a processing instruction.", name));
			}
		}

		// Token: 0x040001DE RID: 478
		internal string target;

		// Token: 0x040001DF RID: 479
		internal string data;
	}
}
