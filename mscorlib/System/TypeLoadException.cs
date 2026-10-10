using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Исключение, которое выдается в случае сбоя при загрузке типа.</summary>
	// Token: 0x02000210 RID: 528
	[ComVisible(true)]
	[Serializable]
	public class TypeLoadException : SystemException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeLoadException" />.</summary>
		// Token: 0x06001740 RID: 5952 RVA: 0x0005A90E File Offset: 0x00058B0E
		public TypeLoadException() : base(Environment.GetResourceString("Failure has occurred while loading a type."))
		{
			base.SetErrorCode(-2146233054);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeLoadException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06001741 RID: 5953 RVA: 0x0005A92B File Offset: 0x00058B2B
		public TypeLoadException(string message) : base(message)
		{
			base.SetErrorCode(-2146233054);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeLoadException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001742 RID: 5954 RVA: 0x0005A93F File Offset: 0x00058B3F
		public TypeLoadException(string message, Exception inner) : base(message, inner)
		{
			base.SetErrorCode(-2146233054);
		}

		/// <summary>Получает сообщение об ошибке для данного исключения.</summary>
		/// <returns>Строка сообщения об ошибке.</returns>
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0005A954 File Offset: 0x00058B54
		public override string Message
		{
			[SecuritySafeCritical]
			get
			{
				this.SetMessageField();
				return this._message;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x0005A964 File Offset: 0x00058B64
		[SecurityCritical]
		private void SetMessageField()
		{
			if (this._message == null)
			{
				if (this.ClassName == null && this.ResourceId == 0)
				{
					this._message = Environment.GetResourceString("Failure has occurred while loading a type.");
					return;
				}
				if (this.AssemblyName == null)
				{
					this.AssemblyName = Environment.GetResourceString("[Unknown]");
				}
				if (this.ClassName == null)
				{
					this.ClassName = Environment.GetResourceString("[Unknown]");
				}
				string format = "Could not load type '{0}' from assembly '{1}'.";
				this._message = string.Format(CultureInfo.CurrentCulture, format, this.ClassName, this.AssemblyName, this.MessageArg);
			}
		}

		/// <summary>Получает полное имя типа, вызвавшего исключение.</summary>
		/// <returns>Полное имя типа.</returns>
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x0005A9F5 File Offset: 0x00058BF5
		public string TypeName
		{
			get
			{
				if (this.ClassName == null)
				{
					return string.Empty;
				}
				return this.ClassName;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0005AA0B File Offset: 0x00058C0B
		private TypeLoadException(string className, string assemblyName) : this(className, assemblyName, null, 0)
		{
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0005AA17 File Offset: 0x00058C17
		[SecurityCritical]
		private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId) : base(null)
		{
			base.SetErrorCode(-2146233054);
			this.ClassName = className;
			this.AssemblyName = assemblyName;
			this.MessageArg = messageArg;
			this.ResourceId = resourceId;
			this.SetMessageField();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TypeLoadException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001748 RID: 5960 RVA: 0x0005AA50 File Offset: 0x00058C50
		protected TypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.ClassName = info.GetString("TypeLoadClassName");
			this.AssemblyName = info.GetString("TypeLoadAssemblyName");
			this.MessageArg = info.GetString("TypeLoadMessageArg");
			this.ResourceId = info.GetInt32("TypeLoadResourceID");
		}

		/// <summary>Устанавливает объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> с именем класса, именем метода, идентификатором ресурса и дополнительными сведениями об исключении.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Объект <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001749 RID: 5961 RVA: 0x0005AAB8 File Offset: 0x00058CB8
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			base.GetObjectData(info, context);
			info.AddValue("TypeLoadClassName", this.ClassName, typeof(string));
			info.AddValue("TypeLoadAssemblyName", this.AssemblyName, typeof(string));
			info.AddValue("TypeLoadMessageArg", this.MessageArg, typeof(string));
			info.AddValue("TypeLoadResourceID", this.ResourceId);
		}

		// Token: 0x0400162F RID: 5679
		private string ClassName;

		// Token: 0x04001630 RID: 5680
		private string AssemblyName;

		// Token: 0x04001631 RID: 5681
		private string MessageArg;

		// Token: 0x04001632 RID: 5682
		internal int ResourceId;
	}
}
