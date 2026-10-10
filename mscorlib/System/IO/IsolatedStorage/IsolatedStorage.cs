using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.IO.IsolatedStorage
{
	/// <summary>Представляет абстрактный базовый класс, от которого должны наследоваться все реализации изолированного хранения.</summary>
	// Token: 0x02000B71 RID: 2929
	[ComVisible(true)]
	public abstract class IsolatedStorage : MarshalByRefObject
	{
		/// <summary>Возвращает удостоверение приложения, которое ограничивает область действия изолированного хранения.</summary>
		/// <returns>Класс <see cref="T:System.Object" />, представляющий удостоверение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Application" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Для доступа к данному объекту коду необходим класс <see cref="T:System.Security.Permissions.SecurityPermission" />. Эти разрешения предоставляются средой выполнения на основе политики безопасности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> не изолирован приложением <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />.</exception>
		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06006A79 RID: 27257 RVA: 0x0016C834 File Offset: 0x0016AA34
		[ComVisible(false)]
		[MonoTODO("Does not currently use the manifest support")]
		public object ApplicationIdentity
		{
			[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
			get
			{
				if ((this.storage_scope & IsolatedStorageScope.Application) == IsolatedStorageScope.None)
				{
					throw new InvalidOperationException(Locale.GetText("Invalid Isolation Scope."));
				}
				if (this._applicationIdentity == null)
				{
					throw new InvalidOperationException(Locale.GetText("Identity unavailable."));
				}
				throw new NotImplementedException(Locale.GetText("CAS related"));
			}
		}

		/// <summary>Возвращает удостоверение сборки, используемое для ограничения области действия изолированного хранения.</summary>
		/// <returns>Класс <see cref="T:System.Object" />, представляющий удостоверение <see cref="T:System.Reflection.Assembly" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Для доступа к данному объекту коду необходим класс <see cref="T:System.Security.Permissions.SecurityPermission" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сборка не определена.</exception>
		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06006A7A RID: 27258 RVA: 0x0016C883 File Offset: 0x0016AA83
		public object AssemblyIdentity
		{
			[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
			get
			{
				if ((this.storage_scope & IsolatedStorageScope.Assembly) == IsolatedStorageScope.None)
				{
					throw new InvalidOperationException(Locale.GetText("Invalid Isolation Scope."));
				}
				if (this._assemblyIdentity == null)
				{
					throw new InvalidOperationException(Locale.GetText("Identity unavailable."));
				}
				return this._assemblyIdentity;
			}
		}

		/// <summary>Возвращает значение, показывающее текущий размер изолированного хранения.</summary>
		/// <returns>Число единиц хранилища, используемых в текущий момент в ограниченной области изолированного хранения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Текущий размер изолированного хранилища не определен.</exception>
		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06006A7B RID: 27259 RVA: 0x0016C8BD File Offset: 0x0016AABD
		[Obsolete]
		[CLSCompliant(false)]
		public virtual ulong CurrentSize
		{
			get
			{
				throw new InvalidOperationException(Locale.GetText("IsolatedStorage does not have a preset CurrentSize."));
			}
		}

		/// <summary>Возвращает удостоверение домена, которое ограничивает область действия изолированного хранения.</summary>
		/// <returns>Класс <see cref="T:System.Object" />, представляющий удостоверение <see cref="F:System.IO.IsolatedStorage.IsolatedStorageScope.Domain" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">Для доступа к данному объекту коду необходим класс <see cref="T:System.Security.Permissions.SecurityPermission" />. Эти разрешения предоставляются средой выполнения на основе политики безопасности.</exception>
		/// <exception cref="T:System.InvalidOperationException">Объект <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> не изолирован доменом <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />.</exception>
		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x0016C8CE File Offset: 0x0016AACE
		public object DomainIdentity
		{
			[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
			get
			{
				if ((this.storage_scope & IsolatedStorageScope.Domain) == IsolatedStorageScope.None)
				{
					throw new InvalidOperationException(Locale.GetText("Invalid Isolation Scope."));
				}
				if (this._domainIdentity == null)
				{
					throw new InvalidOperationException(Locale.GetText("Identity unavailable."));
				}
				return this._domainIdentity;
			}
		}

		/// <summary>Получает значение, показывающее максимальный размер области, доступной для изолированного хранения. При переопределении в производном классе это значение может принимать различные единицы измерения.</summary>
		/// <returns>Максимальный размер области изолированного хранения в байтах. Производные классы могут возвращать различные единицы измерения значения.</returns>
		/// <exception cref="T:System.InvalidOperationException">Квота не определена.</exception>
		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x06006A7D RID: 27261 RVA: 0x0016C908 File Offset: 0x0016AB08
		[Obsolete]
		[CLSCompliant(false)]
		public virtual ulong MaximumSize
		{
			get
			{
				throw new InvalidOperationException(Locale.GetText("IsolatedStorage does not have a preset MaximumSize."));
			}
		}

		/// <summary>Получает значение перечисления <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />, ограничивающее область, используемую для изоляции хранилища.</summary>
		/// <returns>Побитовая комбинация значений <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />, ограничивающих область, используемую для изоляции хранилища.</returns>
		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x06006A7E RID: 27262 RVA: 0x0016C919 File Offset: 0x0016AB19
		public IsolatedStorageScope Scope
		{
			get
			{
				return this.storage_scope;
			}
		}

		/// <summary>При переопределении в производном классе получает доступное свободное пространство для изолированного хранилища в байтах.</summary>
		/// <returns>Доступное свободное пространство для изолированного хранилища в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Выполнена операция, которой требуется доступ к <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.AvailableFreeSpace" />, но это свойство не определено для этого хранилища. Для хранилищ, полученных через перечисления, свойство <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.AvailableFreeSpace" /> четко не определено, так как для открытия хранилища используется неполное свидетельство.</exception>
		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x0016C921 File Offset: 0x0016AB21
		[ComVisible(false)]
		public virtual long AvailableFreeSpace
		{
			get
			{
				throw new InvalidOperationException("This property is not defined for this store.");
			}
		}

		/// <summary>При переопределении в производном классе получает значение, представляющее максимальный объем пространства, доступного для изолированной памяти.</summary>
		/// <returns>Ограничение объема изолированного хранилища в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Выполнена операция, которой требуется доступ к <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.Quota" />, но это свойство не определено для этого хранилища. Для хранилищ, полученных через перечисления, свойство <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.Quota" /> четко не определено, так как для открытия хранилища используется неполное свидетельство.</exception>
		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06006A80 RID: 27264 RVA: 0x0016C921 File Offset: 0x0016AB21
		[ComVisible(false)]
		public virtual long Quota
		{
			get
			{
				throw new InvalidOperationException("This property is not defined for this store.");
			}
		}

		/// <summary>При переопределении в производном классе получает значение, показывающее объем пространства, используемого под изолированное хранилище.</summary>
		/// <returns>Объем используемого под изолированное хранилище пространства в байтах.</returns>
		/// <exception cref="T:System.InvalidOperationException">Выполнена операция, которой требуется доступ к <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.UsedSize" />, но это свойство не определено для этого хранилища. Для хранилищ, полученных через перечисления, свойство <see cref="P:System.IO.IsolatedStorage.IsolatedStorage.UsedSize" /> четко не определено, так как для открытия хранилища используется неполное свидетельство.</exception>
		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06006A81 RID: 27265 RVA: 0x0016C921 File Offset: 0x0016AB21
		[ComVisible(false)]
		public virtual long UsedSize
		{
			get
			{
				throw new InvalidOperationException("This property is not defined for this store.");
			}
		}

		/// <summary>Возвращает знак обратной косой черты, который можно использовать в строке каталога. При переопределении в производном классе может быть возвращен другой знак.</summary>
		/// <returns>Реализация по умолчанию возвращает "\" (обратная косая черта).</returns>
		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06006A82 RID: 27266 RVA: 0x0016C92D File Offset: 0x0016AB2D
		protected virtual char SeparatorExternal
		{
			get
			{
				return Path.DirectorySeparatorChar;
			}
		}

		/// <summary>Возвращает знак точки, который можно использовать в строке каталога. При переопределении в производном классе может быть возвращен другой знак.</summary>
		/// <returns>Реализация по умолчанию возвращает "." (точка).</returns>
		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06006A83 RID: 27267 RVA: 0x0016C934 File Offset: 0x0016AB34
		protected virtual char SeparatorInternal
		{
			get
			{
				return '.';
			}
		}

		/// <summary>При реализации с помощью производного класса возвращает разрешение, представляющее доступ к изолированному хранению в наборе разрешений.</summary>
		/// <param name="ps">Объект <see cref="T:System.Security.PermissionSet" />, содержащий набор разрешений, предоставленных коду, выполняющему попытку использования изолированного хранения.</param>
		/// <returns>Объект <see cref="T:System.Security.Permissions.IsolatedStoragePermission" />.</returns>
		// Token: 0x06006A84 RID: 27268 RVA: 0x0000AF5E File Offset: 0x0000915E
		protected virtual IsolatedStoragePermission GetPermission(PermissionSet ps)
		{
			return null;
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" />.</summary>
		/// <param name="scope">Поразрядное сочетание значений <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />.</param>
		/// <param name="domainEvidenceType">Тип свидетельства <see cref="T:System.Security.Policy.Evidence" />, которое можно выбрать из списка свидетельств <see cref="T:System.Security.Policy.Evidence" />, присутствующих в домене вызывающего приложения. Значение <see langword="null" /> позволяет объекту <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> выбирать свидетельство.</param>
		/// <param name="assemblyEvidenceType">Тип свидетельства <see cref="T:System.Security.Policy.Evidence" />, которое можно выбрать из списка свидетельств <see cref="T:System.Security.Policy.Evidence" />, присутствующих в сборке вызывающего приложения. Значение <see langword="null" /> позволяет объекту <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> выбирать свидетельство.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Указанная сборка не имеет достаточно разрешений для создания изолированных хранилищ.</exception>
		// Token: 0x06006A85 RID: 27269 RVA: 0x0016C938 File Offset: 0x0016AB38
		protected void InitStore(IsolatedStorageScope scope, Type domainEvidenceType, Type assemblyEvidenceType)
		{
			if (scope == (IsolatedStorageScope.User | IsolatedStorageScope.Assembly) || scope == (IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly))
			{
				throw new NotImplementedException(scope.ToString());
			}
			throw new ArgumentException(scope.ToString());
		}

		/// <summary>Инициализирует новый объект <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" />.</summary>
		/// <param name="scope">Поразрядное сочетание значений <see cref="T:System.IO.IsolatedStorage.IsolatedStorageScope" />.</param>
		/// <param name="appEvidenceType">Тип свидетельства <see cref="T:System.Security.Policy.Evidence" />, которое можно выбрать из списка свидетельств <see cref="T:System.Security.Policy.Evidence" /> для вызывающего приложения. Значение <see langword="null" /> позволяет объекту <see cref="T:System.IO.IsolatedStorage.IsolatedStorage" /> выбирать свидетельство.</param>
		/// <exception cref="T:System.IO.IsolatedStorage.IsolatedStorageException">Указанная сборка не имеет достаточно разрешений для создания изолированных хранилищ.</exception>
		// Token: 0x06006A86 RID: 27270 RVA: 0x0016C967 File Offset: 0x0016AB67
		[MonoTODO("requires manifest support")]
		protected void InitStore(IsolatedStorageScope scope, Type appEvidenceType)
		{
			if (AppDomain.CurrentDomain.ApplicationIdentity == null)
			{
				throw new IsolatedStorageException(Locale.GetText("No ApplicationIdentity available for AppDomain."));
			}
			appEvidenceType == null;
			this.storage_scope = scope;
		}

		/// <summary>При переопределении в производном классе удаляет отдельное изолированное хранилище и все содержащиеся в нем данные.</summary>
		// Token: 0x06006A87 RID: 27271
		public abstract void Remove();

		/// <summary>При переопределении в производном классе запрашивает у пользователя утверждение большего размера квоты изолированного хранилища в байтах.</summary>
		/// <param name="newQuotaSize">Запрашиваемый новый размер квоты в байтах, который должен утвердить пользователь.</param>
		/// <returns>Значение <see langword="false" /> во всех случаях.</returns>
		// Token: 0x06006A88 RID: 27272 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[ComVisible(false)]
		public virtual bool IncreaseQuotaTo(long newQuotaSize)
		{
			return false;
		}

		// Token: 0x04003D95 RID: 15765
		internal IsolatedStorageScope storage_scope;

		// Token: 0x04003D96 RID: 15766
		internal object _assemblyIdentity;

		// Token: 0x04003D97 RID: 15767
		internal object _domainIdentity;

		// Token: 0x04003D98 RID: 15768
		internal object _applicationIdentity;
	}
}
