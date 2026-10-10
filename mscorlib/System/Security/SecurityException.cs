using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;

namespace System.Security
{
	/// <summary>Исключение, которое возникает при обнаружении ошибки безопасности.</summary>
	// Token: 0x020003E8 RID: 1000
	[ComVisible(true)]
	[Serializable]
	public class SecurityException : SystemException
	{
		/// <summary>Возвращает или задает действие по обеспечению безопасности, вызвавшее исключение.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</returns>
		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002936 RID: 10550 RVA: 0x00095AA4 File Offset: 0x00093CA4
		// (set) Token: 0x06002937 RID: 10551 RVA: 0x00095AAC File Offset: 0x00093CAC
		[ComVisible(false)]
		public SecurityAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		/// <summary>Возвращает или задает отклоненные разрешения, наборы разрешений или коллекции наборов разрешений, ставшие причиной несоблюдения требований безопасности.</summary>
		/// <returns>Разрешение, набор разрешений или объект коллекции наборов разрешений.</returns>
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00095AB5 File Offset: 0x00093CB5
		// (set) Token: 0x06002939 RID: 10553 RVA: 0x00095ABD File Offset: 0x00093CBD
		[ComVisible(false)]
		public object DenySetInstance
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._denyset;
			}
			set
			{
				this._denyset = value;
			}
		}

		/// <summary>Получает или задает сведения о сборке, вызвавшей сбой.</summary>
		/// <returns>Имя <see cref="T:System.Reflection.AssemblyName" />, определяющее сборку, вызвавшую сбой.</returns>
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600293A RID: 10554 RVA: 0x00095AC6 File Offset: 0x00093CC6
		// (set) Token: 0x0600293B RID: 10555 RVA: 0x00095ACE File Offset: 0x00093CCE
		[ComVisible(false)]
		public AssemblyName FailedAssemblyInfo
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._assembly;
			}
			set
			{
				this._assembly = value;
			}
		}

		/// <summary>Возвращает или задает сведения о методе, связанном с исключением.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodInfo" />, описывающий метод.</returns>
		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x00095AD7 File Offset: 0x00093CD7
		// (set) Token: 0x0600293D RID: 10557 RVA: 0x00095ADF File Offset: 0x00093CDF
		[ComVisible(false)]
		public MethodInfo Method
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._method;
			}
			set
			{
				this._method = value;
			}
		}

		/// <summary>Получает или задает разрешение, набор разрешений или коллекцию наборов разрешений, которые являются частью кадра стека ограничения разрешений PermitOnly, вызвавшего сбой проверки безопасности.</summary>
		/// <returns>Разрешение, набор разрешений или объект коллекции наборов разрешений.</returns>
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600293E RID: 10558 RVA: 0x00095AE8 File Offset: 0x00093CE8
		// (set) Token: 0x0600293F RID: 10559 RVA: 0x00095AF0 File Offset: 0x00093CF0
		[ComVisible(false)]
		public object PermitOnlySetInstance
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._permitset;
			}
			set
			{
				this._permitset = value;
			}
		}

		/// <summary>Получает или задает задает URL-адрес сборки, вызвавшей исключение.</summary>
		/// <returns>URL-адрес, определяющий расположение сборки.</returns>
		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x00095AF9 File Offset: 0x00093CF9
		// (set) Token: 0x06002941 RID: 10561 RVA: 0x00095B01 File Offset: 0x00093D01
		public string Url
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}

		/// <summary>Получает или задает зону сборки, вызвавшую исключение.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.SecurityZone" />, которое определяет зону сборки, вызвавшую исключение.</returns>
		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x00095B0A File Offset: 0x00093D0A
		// (set) Token: 0x06002943 RID: 10563 RVA: 0x00095B12 File Offset: 0x00093D12
		public SecurityZone Zone
		{
			get
			{
				return this._zone;
			}
			set
			{
				this._zone = value;
			}
		}

		/// <summary>Возвращает или задает затребованное разрешение безопасности, набор разрешений или коллекцию наборов разрешений, вызвавших сбой.</summary>
		/// <returns>Разрешение, набор разрешений или объект коллекции наборов разрешений.</returns>
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002944 RID: 10564 RVA: 0x00095B1B File Offset: 0x00093D1B
		// (set) Token: 0x06002945 RID: 10565 RVA: 0x00095B23 File Offset: 0x00093D23
		[ComVisible(false)]
		public object Demanded
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._demanded;
			}
			set
			{
				this._demanded = value;
			}
		}

		/// <summary>Получает или задает первое разрешение в наборе разрешений или коллекции наборов разрешений, вызвавшее сбой требования.</summary>
		/// <returns>Объект <see cref="T:System.Security.IPermission" />, представляющий первое разрешение, которое завершилось ошибкой.</returns>
		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x00095B2C File Offset: 0x00093D2C
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x00095B34 File Offset: 0x00093D34
		public IPermission FirstPermissionThatFailed
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._firstperm;
			}
			set
			{
				this._firstperm = value;
			}
		}

		/// <summary>Возвращает или задает состояние разрешения, вызывающее исключение.</summary>
		/// <returns>Состояние разрешения на момент возникновения этого исключения.</returns>
		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x00095B3D File Offset: 0x00093D3D
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x00095B45 File Offset: 0x00093D45
		public string PermissionState
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this.permissionState;
			}
			set
			{
				this.permissionState = value;
			}
		}

		/// <summary>Возвращает или задает тип разрешения, вызвавшего сбой.</summary>
		/// <returns>Тип разрешения, вызвавшего сбой.</returns>
		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x00095B4E File Offset: 0x00093D4E
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x00095B56 File Offset: 0x00093D56
		public Type PermissionType
		{
			get
			{
				return this.permissionType;
			}
			set
			{
				this.permissionType = value;
			}
		}

		/// <summary>Получает или задает набор предоставленных разрешений сборки, вызвавшей <see cref="T:System.Security.SecurityException" />.</summary>
		/// <returns>XML-представление набора предоставленных разрешений для сборки.</returns>
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x00095B5F File Offset: 0x00093D5F
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x00095B67 File Offset: 0x00093D67
		public string GrantedSet
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._granted;
			}
			set
			{
				this._granted = value;
			}
		}

		/// <summary>Возвращает или задает отклоненный набор разрешений сборки, вызвавшей <see cref="T:System.Security.SecurityException" />.</summary>
		/// <returns>XML-представление отклоненного набора разрешений сборки.</returns>
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x00095B70 File Offset: 0x00093D70
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x00095B78 File Offset: 0x00093D78
		public string RefusedSet
		{
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true, ControlPolicy = true)]
			get
			{
				return this._refused;
			}
			set
			{
				this._refused = value;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> стандартными свойствами.</summary>
		// Token: 0x06002950 RID: 10576 RVA: 0x00095B81 File Offset: 0x00093D81
		public SecurityException() : this(Locale.GetText("A security error has been detected."))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002951 RID: 10577 RVA: 0x00095B93 File Offset: 0x00093D93
		public SecurityException(string message) : base(message)
		{
			base.HResult = -2146233078;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002952 RID: 10578 RVA: 0x00095BA8 File Offset: 0x00093DA8
		protected SecurityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			base.HResult = -2146233078;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (enumerator.Name == "PermissionState")
				{
					this.permissionState = (string)enumerator.Value;
					return;
				}
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002953 RID: 10579 RVA: 0x00095BFD File Offset: 0x00093DFD
		public SecurityException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233078;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> с указанным сообщением об ошибке и типом разрешения, которое стало причиной текущего исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="type">Тип разрешения, вызвавшего исключение.</param>
		// Token: 0x06002954 RID: 10580 RVA: 0x00095C12 File Offset: 0x00093E12
		public SecurityException(string message, Type type) : base(message)
		{
			base.HResult = -2146233078;
			this.permissionType = type;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> с указанным сообщением об ошибке, типом разрешения, которое стало причиной текущего исключения, и состоянием разрешения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="type">Тип разрешения, вызвавшего исключение.</param>
		/// <param name="state">Состояние разрешения, вызвавшего исключение.</param>
		// Token: 0x06002955 RID: 10581 RVA: 0x00095C2D File Offset: 0x00093E2D
		public SecurityException(string message, Type type, string state) : base(message)
		{
			base.HResult = -2146233078;
			this.permissionType = type;
			this.permissionState = state;
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00095C4F File Offset: 0x00093E4F
		internal SecurityException(string message, PermissionSet granted, PermissionSet refused) : base(message)
		{
			base.HResult = -2146233078;
			this._granted = granted.ToString();
			this._refused = refused.ToString();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> для исключения, вызванного отказом в стеке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="deny">Отклоненное разрешение или набор разрешений.</param>
		/// <param name="permitOnly">Разрешение "только на разрешение" или набор разрешений.</param>
		/// <param name="method">Объект <see cref="T:System.Reflection.MethodInfo" />, определяющий метод, который обнаружил исключение.</param>
		/// <param name="demanded">Затребованное разрешение, набор разрешений или коллекция наборов разрешений.</param>
		/// <param name="permThatFailed">
		///   <see cref="T:System.Security.IPermission" />, определяющий разрешение, которое вызвало сбой.</param>
		// Token: 0x06002957 RID: 10583 RVA: 0x00095C7B File Offset: 0x00093E7B
		public SecurityException(string message, object deny, object permitOnly, MethodInfo method, object demanded, IPermission permThatFailed) : base(message)
		{
			base.HResult = -2146233078;
			this._denyset = deny;
			this._permitset = permitOnly;
			this._method = method;
			this._demanded = demanded;
			this._firstperm = permThatFailed;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.SecurityException" /> для исключения, вызванного недостаточным набором прав.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="assemblyName">Объект <see cref="T:System.Reflection.AssemblyName" />, указывающий зону сборки, вызвавшую исключение.</param>
		/// <param name="grant">Объект <see cref="T:System.Security.PermissionSet" />, представляющий разрешения, предоставленные сборке.</param>
		/// <param name="refused">Объект <see cref="T:System.Security.PermissionSet" />, представляющий отклоненные разрешения или набор разрешений.</param>
		/// <param name="method">Объект <see cref="T:System.Reflection.MethodInfo" />, представляющий метод, который обнаружил исключение.</param>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <param name="demanded">Затребованное разрешение, набор разрешений или коллекция наборов разрешений.</param>
		/// <param name="permThatFailed">Объект <see cref="T:System.Security.IPermission" />, представляющий разрешение, которое вызвало сбой.</param>
		/// <param name="evidence">
		///   <see cref="T:System.Security.Policy.Evidence" /> для сборки, вызвавшей исключение.</param>
		// Token: 0x06002958 RID: 10584 RVA: 0x00095CB8 File Offset: 0x00093EB8
		public SecurityException(string message, AssemblyName assemblyName, PermissionSet grant, PermissionSet refused, MethodInfo method, SecurityAction action, object demanded, IPermission permThatFailed, Evidence evidence) : base(message)
		{
			base.HResult = -2146233078;
			this._assembly = assemblyName;
			this._granted = ((grant == null) ? string.Empty : grant.ToString());
			this._refused = ((refused == null) ? string.Empty : refused.ToString());
			this._method = method;
			this._action = action;
			this._demanded = demanded;
			this._firstperm = permThatFailed;
			if (this._firstperm != null)
			{
				this.permissionType = this._firstperm.GetType();
			}
			this._evidence = evidence;
		}

		/// <summary>Заполняет <see cref="T:System.Runtime.Serialization.SerializationInfo" /> сведениями об исключении <see cref="T:System.Security.SecurityException" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002959 RID: 10585 RVA: 0x00095D50 File Offset: 0x00093F50
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			try
			{
				info.AddValue("PermissionState", this.permissionState);
			}
			catch (SecurityException)
			{
			}
		}

		/// <summary>Возвращает представление текущего <see cref="T:System.Security.SecurityException" />.</summary>
		/// <returns>Строковое представление текущего <see cref="T:System.Security.SecurityException" />.</returns>
		// Token: 0x0600295A RID: 10586 RVA: 0x00095D8C File Offset: 0x00093F8C
		[SecuritySafeCritical]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(base.ToString());
			try
			{
				if (this.permissionType != null)
				{
					stringBuilder.AppendFormat("{0}Type: {1}", Environment.NewLine, this.PermissionType);
				}
				if (this._method != null)
				{
					string text = this._method.ToString();
					int startIndex = text.IndexOf(" ") + 1;
					stringBuilder.AppendFormat("{0}Method: {1} {2}.{3}", new object[]
					{
						Environment.NewLine,
						this._method.ReturnType.Name,
						this._method.ReflectedType,
						text.Substring(startIndex)
					});
				}
				if (this.permissionState != null)
				{
					stringBuilder.AppendFormat("{0}State: {1}", Environment.NewLine, this.PermissionState);
				}
				if (this._granted != null && this._granted.Length > 0)
				{
					stringBuilder.AppendFormat("{0}Granted: {1}", Environment.NewLine, this.GrantedSet);
				}
				if (this._refused != null && this._refused.Length > 0)
				{
					stringBuilder.AppendFormat("{0}Refused: {1}", Environment.NewLine, this.RefusedSet);
				}
				if (this._demanded != null)
				{
					stringBuilder.AppendFormat("{0}Demanded: {1}", Environment.NewLine, this.Demanded);
				}
				if (this._firstperm != null)
				{
					stringBuilder.AppendFormat("{0}Failed Permission: {1}", Environment.NewLine, this.FirstPermissionThatFailed);
				}
				if (this._evidence != null)
				{
					stringBuilder.AppendFormat("{0}Evidences:", Environment.NewLine);
					foreach (object obj in this._evidence)
					{
						if (!(obj is Hash))
						{
							stringBuilder.AppendFormat("{0}\t{1}", Environment.NewLine, obj);
						}
					}
				}
			}
			catch (SecurityException)
			{
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001EE1 RID: 7905
		private string permissionState;

		// Token: 0x04001EE2 RID: 7906
		private Type permissionType;

		// Token: 0x04001EE3 RID: 7907
		private string _granted;

		// Token: 0x04001EE4 RID: 7908
		private string _refused;

		// Token: 0x04001EE5 RID: 7909
		private object _demanded;

		// Token: 0x04001EE6 RID: 7910
		private IPermission _firstperm;

		// Token: 0x04001EE7 RID: 7911
		private MethodInfo _method;

		// Token: 0x04001EE8 RID: 7912
		private Evidence _evidence;

		// Token: 0x04001EE9 RID: 7913
		private SecurityAction _action;

		// Token: 0x04001EEA RID: 7914
		private object _denyset;

		// Token: 0x04001EEB RID: 7915
		private object _permitset;

		// Token: 0x04001EEC RID: 7916
		private AssemblyName _assembly;

		// Token: 0x04001EED RID: 7917
		private string _url;

		// Token: 0x04001EEE RID: 7918
		private SecurityZone _zone;
	}
}
