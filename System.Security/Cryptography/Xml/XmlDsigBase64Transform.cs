using System;
using System.IO;
using System.Text;
using System.Xml;

namespace System.Security.Cryptography.Xml
{
	/// <summary>Представляет преобразование из кодировки <see langword="Base64" /> в соответствии с определением раздела 6.6.2 спецификации XMLDSIG.</summary>
	// Token: 0x0200005F RID: 95
	public class XmlDsigBase64Transform : Transform
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</summary>
		// Token: 0x06000324 RID: 804 RVA: 0x0000F3C4 File Offset: 0x0000D5C4
		public XmlDsigBase64Transform()
		{
			base.Algorithm = "http://www.w3.org/2000/09/xmldsig#base64";
		}

		/// <summary>Возвращает массив типов, которые являются допустимыми входными значениями для метода <see cref="M:System.Security.Cryptography.Xml.XmlDsigBase64Transform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</summary>
		/// <returns>Массив допустимых входных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />; методу <see cref="M:System.Security.Cryptography.Xml.XmlDsigBase64Transform.LoadInput(System.Object)" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" /> можно передавать объекты только этих типов.</returns>
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000F42E File Offset: 0x0000D62E
		public override Type[] InputTypes
		{
			get
			{
				return this._inputTypes;
			}
		}

		/// <summary>Возвращает массив типов, которые являются возможными выходными значениями методов <see cref="M:System.Security.Cryptography.Xml.XmlDsigBase64Transform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</summary>
		/// <returns>Массив допустимых выходных типов для текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />; методы <see cref="M:System.Security.Cryptography.Xml.XmlDsigBase64Transform.GetOutput" /> текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" /> возвращают объекты только этих типов.</returns>
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000F436 File Offset: 0x0000D636
		public override Type[] OutputTypes
		{
			get
			{
				return this._outputTypes;
			}
		}

		/// <summary>Выполняет анализ указанного объекта <see cref="T:System.Xml.XmlNodeList" /> ка связанного с преобразованием содержимого элемента <see langword="&lt;Transform&gt;" />; данный метод не поддерживается, поскольку объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" /> не содержит внутренних XML-элементов.</summary>
		/// <param name="nodeList">Объект <see cref="T:System.Xml.XmlNodeList" />, загружаемый в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</param>
		// Token: 0x06000327 RID: 807 RVA: 0x0000C9F1 File Offset: 0x0000ABF1
		public override void LoadInnerXml(XmlNodeList nodeList)
		{
		}

		/// <summary>Возвращает XML-представление параметров объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />, которые подходят для включения в качестве подэлементов элемента <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</summary>
		/// <returns>Список XML-узлов, представляющих связанное с преобразованием содержимое, которое необходимо для описания текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" /> в элементе <see langword="&lt;Transform&gt;" /> подписи XMLDSIG.</returns>
		// Token: 0x06000328 RID: 808 RVA: 0x0000F43E File Offset: 0x0000D63E
		protected override XmlNodeList GetInnerXml()
		{
			return null;
		}

		/// <summary>Загружает указанные входные данные в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</summary>
		/// <param name="obj">Входные данные, загружаемые в текущий объект <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="obj" /> принадлежит типу <see cref="T:System.IO.Stream" /> и имеет значение <see langword="null" />.</exception>
		// Token: 0x06000329 RID: 809 RVA: 0x0000F444 File Offset: 0x0000D644
		public override void LoadInput(object obj)
		{
			if (obj is Stream)
			{
				this.LoadStreamInput((Stream)obj);
				return;
			}
			if (obj is XmlNodeList)
			{
				this.LoadXmlNodeListInput((XmlNodeList)obj);
				return;
			}
			if (obj is XmlDocument)
			{
				this.LoadXmlNodeListInput(((XmlDocument)obj).SelectNodes("//."));
				return;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000F49C File Offset: 0x0000D69C
		private void LoadStreamInput(Stream inputStream)
		{
			if (inputStream == null)
			{
				throw new ArgumentException("obj");
			}
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[1024];
			int num;
			do
			{
				num = inputStream.Read(array, 0, 1024);
				if (num > 0)
				{
					int i = 0;
					while (i < num && !char.IsWhiteSpace((char)array[i]))
					{
						i++;
					}
					int num2 = i;
					for (i++; i < num; i++)
					{
						if (!char.IsWhiteSpace((char)array[i]))
						{
							array[num2] = array[i];
							num2++;
						}
					}
					memoryStream.Write(array, 0, num2);
				}
			}
			while (num > 0);
			memoryStream.Position = 0L;
			this._cs = new CryptoStream(memoryStream, new FromBase64Transform(), CryptoStreamMode.Read);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000F54C File Offset: 0x0000D74C
		private void LoadXmlNodeListInput(XmlNodeList nodeList)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (object obj in nodeList)
			{
				XmlNode xmlNode = ((XmlNode)obj).SelectSingleNode("self::text()");
				if (xmlNode != null)
				{
					stringBuilder.Append(xmlNode.OuterXml);
				}
			}
			byte[] bytes = new UTF8Encoding(false).GetBytes(stringBuilder.ToString());
			int i = 0;
			while (i < bytes.Length && !char.IsWhiteSpace((char)bytes[i]))
			{
				i++;
			}
			int num = i;
			for (i++; i < bytes.Length; i++)
			{
				if (!char.IsWhiteSpace((char)bytes[i]))
				{
					bytes[num] = bytes[i];
					num++;
				}
			}
			MemoryStream stream = new MemoryStream(bytes, 0, num);
			this._cs = new CryptoStream(stream, new FromBase64Transform(), CryptoStreamMode.Read);
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</summary>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />.</returns>
		// Token: 0x0600032C RID: 812 RVA: 0x0000F634 File Offset: 0x0000D834
		public override object GetOutput()
		{
			return this._cs;
		}

		/// <summary>Возвращает выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</summary>
		/// <param name="type">Тип возвращаемых выходных данных. Для данного параметра допустимым является только тип <see cref="T:System.IO.Stream" />.</param>
		/// <returns>Выходные данные текущего объекта <see cref="T:System.Security.Cryptography.Xml.XmlDsigBase64Transform" />, принадлежащего к типу <see cref="T:System.IO.Stream" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="type" /> не является объектом <see cref="T:System.IO.Stream" />.</exception>
		// Token: 0x0600032D RID: 813 RVA: 0x0000F63C File Offset: 0x0000D83C
		public override object GetOutput(Type type)
		{
			if (type != typeof(Stream) && !type.IsSubclassOf(typeof(Stream)))
			{
				throw new ArgumentException("The input type was invalid for this transform.", "type");
			}
			return this._cs;
		}

		// Token: 0x0400023C RID: 572
		private Type[] _inputTypes = new Type[]
		{
			typeof(Stream),
			typeof(XmlNodeList),
			typeof(XmlDocument)
		};

		// Token: 0x0400023D RID: 573
		private Type[] _outputTypes = new Type[]
		{
			typeof(Stream)
		};

		// Token: 0x0400023E RID: 574
		private CryptoStream _cs;
	}
}
