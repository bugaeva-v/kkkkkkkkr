using System;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Обрабатывает подэлементы <see cref="T:System.Security.Cryptography.Xml.KeyInfo" />, для которых на компьютере не зарегистрировано конкретных реализаций или обработчиков.</summary>
	// Token: 0x02000044 RID: 68
	public class KeyInfoNode : KeyInfoClause
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</summary>
		// Token: 0x060001BE RID: 446 RVA: 0x00008215 File Offset: 0x00006415
		public KeyInfoNode()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" /> содержимым, полученным из указанного объекта <see cref="T:System.Xml.XmlElement" />.</summary>
		/// <param name="node">XML-элемент, из которого следует получить содержимое, используемое для создания нового экземпляра класса <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</param>
		// Token: 0x060001BF RID: 447 RVA: 0x00008342 File Offset: 0x00006542
		public KeyInfoNode(XmlElement node)
		{
			this._node = node;
		}

		/// <summary>Получает или задает XML-содержимое текущего объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</summary>
		/// <returns>XML-содержимое текущего объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</returns>
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00008351 File Offset: 0x00006551
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00008359 File Offset: 0x00006559
		public XmlElement Value
		{
			get
			{
				return this._node;
			}
			set
			{
				this._node = value;
			}
		}

		/// <summary>Возвращает XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</summary>
		/// <returns>XML-представление объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</returns>
		// Token: 0x060001C2 RID: 450 RVA: 0x00008364 File Offset: 0x00006564
		public override XmlElement GetXml()
		{
			return this.GetXml(new XmlDocument
			{
				PreserveWhitespace = true
			});
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008385 File Offset: 0x00006585
		internal override XmlElement GetXml(XmlDocument xmlDocument)
		{
			return xmlDocument.ImportNode(this._node, true) as XmlElement;
		}

		/// <summary>Выполняет синтаксический анализ входного объекта <see cref="T:System.Xml.XmlElement" /> и настраивает внутреннее состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" /> таким образом, чтобы оно совпадало с состоянием проанализированного объекта.</summary>
		/// <param name="value">Объект <see cref="T:System.Xml.XmlElement" />, указывающий состояние объекта <see cref="T:System.Security.Cryptography.Xml.KeyInfoNode" />.</param>
		// Token: 0x060001C4 RID: 452 RVA: 0x00008359 File Offset: 0x00006559
		public override void LoadXml(XmlElement value)
		{
			this._node = value;
		}

		// Token: 0x040001A8 RID: 424
		private XmlElement _node;
	}
}
