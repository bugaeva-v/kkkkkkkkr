using System;
using System.Resources;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Xml.XPath
{
	/// <summary>
	///         Предоставляет исключение при возникновении ошибки во время обработки выражения XPath.
	///       </summary>
	// Token: 0x02000251 RID: 593
	[Serializable]
	public class XPathException : SystemException
	{
		/// <summary>
		///         Использует эти сведения в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" /> объектов для инициализации нового экземпляра <see cref="T:System.Xml.XPath.XPathException" /> класса.
		///       </summary>
		/// <param name="info">
		///           <see cref="T:System.Runtime.Serialization.SerializationInfo" /> Объект, который содержит все свойства <see cref="T:System.Xml.XPath.XPathException" />.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///         </param>
		// Token: 0x060015E0 RID: 5600 RVA: 0x000853D0 File Offset: 0x000835D0
		protected XPathException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.res = (string)info.GetValue("res", typeof(string));
			this.args = (string[])info.GetValue("args", typeof(string[]));
			string text = null;
			foreach (SerializationEntry serializationEntry in info)
			{
				if (serializationEntry.Name == "version")
				{
					text = (string)serializationEntry.Value;
				}
			}
			if (text == null)
			{
				this.message = XPathException.CreateMessage(this.res, this.args);
				return;
			}
			this.message = null;
		}

		/// <summary>
		///         Объединяет все <see cref="T:System.Xml.XPath.XPathException" /> Свойства в <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для указанного <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///       </summary>
		/// <param name="info">
		///           Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.
		///         </param>
		/// <param name="context">
		///           Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />.
		///         </param>
		// Token: 0x060015E1 RID: 5601 RVA: 0x00085481 File Offset: 0x00083681
		[SecurityPermission(SecurityAction.LinkDemand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("res", this.res);
			info.AddValue("args", this.args);
			info.AddValue("version", "2.0");
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XPath.XPathException" />.
		///       </summary>
		// Token: 0x060015E2 RID: 5602 RVA: 0x000854BD File Offset: 0x000836BD
		public XPathException() : this(string.Empty, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.XPath.XPathException" /> класса с указанным сообщением об исключении.
		///       </summary>
		/// <param name="message">
		///           Описание условия ошибки.
		///         </param>
		// Token: 0x060015E3 RID: 5603 RVA: 0x000854CB File Offset: 0x000836CB
		public XPathException(string message) : this(message, null)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.XPath.XPathException" /> с использованием указанным сообщением об исключении и <see cref="T:System.Exception" /> объекта.
		///       </summary>
		/// <param name="message">
		///           Описание условия ошибки.
		///         </param>
		/// <param name="innerException">
		///           <see cref="T:System.Exception" /> Вызвавший <see cref="T:System.Xml.XPath.XPathException" />, если таковые имеются.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		// Token: 0x060015E4 RID: 5604 RVA: 0x000854D5 File Offset: 0x000836D5
		public XPathException(string message, Exception innerException) : this("{0}", new string[]
		{
			message
		}, innerException)
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000854ED File Offset: 0x000836ED
		internal static XPathException Create(string res)
		{
			return new XPathException(res, null);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000854F6 File Offset: 0x000836F6
		internal static XPathException Create(string res, string arg)
		{
			return new XPathException(res, new string[]
			{
				arg
			});
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00085508 File Offset: 0x00083708
		internal static XPathException Create(string res, string arg, string arg2)
		{
			return new XPathException(res, new string[]
			{
				arg,
				arg2
			});
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0008551E File Offset: 0x0008371E
		internal static XPathException Create(string res, string arg, Exception innerException)
		{
			return new XPathException(res, new string[]
			{
				arg
			}, innerException);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00085531 File Offset: 0x00083731
		private XPathException(string res, string[] args) : this(res, args, null)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0008553C File Offset: 0x0008373C
		private XPathException(string res, string[] args, Exception inner) : base(XPathException.CreateMessage(res, args), inner)
		{
			base.HResult = -2146231997;
			this.res = res;
			this.args = args;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00085568 File Offset: 0x00083768
		private static string CreateMessage(string res, string[] args)
		{
			string result;
			try
			{
				string text = Res.GetString(res, args);
				if (text == null)
				{
					text = "UNKNOWN(" + res + ")";
				}
				result = text;
			}
			catch (MissingManifestResourceException)
			{
				result = "UNKNOWN(" + res + ")";
			}
			return result;
		}

		/// <summary>
		///         Возвращает описание ошибки для этого исключения.
		///       </summary>
		/// <returns>
		///         <see langword="string" /> Описание условия ошибки для этого исключения.
		///       </returns>
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x000855BC File Offset: 0x000837BC
		public override string Message
		{
			get
			{
				if (this.message != null)
				{
					return this.message;
				}
				return base.Message;
			}
		}

		// Token: 0x040017E8 RID: 6120
		private string res;

		// Token: 0x040017E9 RID: 6121
		private string[] args;

		// Token: 0x040017EA RID: 6122
		private string message;
	}
}
