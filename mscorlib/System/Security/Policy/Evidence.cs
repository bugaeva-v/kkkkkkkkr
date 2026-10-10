using System;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using Unity;

namespace System.Security.Policy
{
	/// <summary>Определяет набор сведений, но основе которого принимаются решения политикой безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200040B RID: 1035
	[MonoTODO("Serialization format not compatible with .NET")]
	[ComVisible(true)]
	[Serializable]
	public sealed class Evidence : ICollection, IEnumerable
	{
		/// <summary>Выполняет инициализацию нового, пустого экземпляра класса <see cref="T:System.Security.Policy.Evidence" />.</summary>
		// Token: 0x06002A54 RID: 10836 RVA: 0x0000259F File Offset: 0x0000079F
		public Evidence()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Evidence" />, используя неполную копию существующего класса.</summary>
		/// <param name="evidence">Экземпляр <see cref="T:System.Security.Policy.Evidence" />, используемый для создания нового экземпляра. Этот экземпляр получен не методом глубокого копирования.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="evidence" /> — это недопустимый экземпляр <see cref="T:System.Security.Policy.Evidence" />.</exception>
		// Token: 0x06002A55 RID: 10837 RVA: 0x000996A2 File Offset: 0x000978A2
		public Evidence(Evidence evidence)
		{
			if (evidence != null)
			{
				this.Merge(evidence);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Evidence" />, используя несколько наборов свидетельств сайта и сборки.</summary>
		/// <param name="hostEvidence">Свидетельство сайта, которое используется для создания нового экземпляра.</param>
		/// <param name="assemblyEvidence">Свидетельство сборки, которое используется для создания нового экземпляра.</param>
		// Token: 0x06002A56 RID: 10838 RVA: 0x000996B4 File Offset: 0x000978B4
		public Evidence(EvidenceBase[] hostEvidence, EvidenceBase[] assemblyEvidence)
		{
			if (hostEvidence != null)
			{
				this.HostEvidenceList.AddRange(hostEvidence);
			}
			if (assemblyEvidence != null)
			{
				this.AssemblyEvidenceList.AddRange(assemblyEvidence);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.Evidence" />, используя несколько наборов свидетельств сайта и сборки.</summary>
		/// <param name="hostEvidence">Свидетельство сайта, которое используется для создания нового экземпляра.</param>
		/// <param name="assemblyEvidence">Свидетельство сборки, которое используется для создания нового экземпляра.</param>
		// Token: 0x06002A57 RID: 10839 RVA: 0x000996B4 File Offset: 0x000978B4
		[Obsolete]
		public Evidence(object[] hostEvidence, object[] assemblyEvidence)
		{
			if (hostEvidence != null)
			{
				this.HostEvidenceList.AddRange(hostEvidence);
			}
			if (assemblyEvidence != null)
			{
				this.AssemblyEvidenceList.AddRange(assemblyEvidence);
			}
		}

		/// <summary>Получает число объектов свидетельств в наборе свидетельств.</summary>
		/// <returns>Число объектов свидетельств в наборе свидетельств.</returns>
		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000996DC File Offset: 0x000978DC
		[Obsolete]
		public int Count
		{
			get
			{
				int num = 0;
				if (this.hostEvidenceList != null)
				{
					num += this.hostEvidenceList.Count;
				}
				if (this.assemblyEvidenceList != null)
				{
					num += this.assemblyEvidenceList.Count;
				}
				return num;
			}
		}

		/// <summary>Получает значение, указывающее, доступен ли набор свидетельств только для чтения.</summary>
		/// <returns>Всегда имеет значение <see langword="false" />, поскольку свидетельства, доступные только для чтения, не поддерживаются.</returns>
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Получает значение, указывающее, является ли набор свидетельств потокобезопасным.</summary>
		/// <returns>Всегда значение <see langword="false" />, потому что потокобезопасные свидетельства не поддерживаются.</returns>
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, заблокировано ли свидетельство.</summary>
		/// <returns>Значение <see langword="true" />, если свидетельство заблокировано; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x00099718 File Offset: 0x00097918
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x00099720 File Offset: 0x00097920
		public bool Locked
		{
			get
			{
				return this._locked;
			}
			[SecurityPermission(SecurityAction.Demand, ControlEvidence = true)]
			set
			{
				this._locked = value;
			}
		}

		/// <summary>Получает корень синхронизации.</summary>
		/// <returns>Всегда имеет значение <see langword="this" /> (<see langword="Me" /> — в Visual Basic), так как синхронизация наборов свидетельств не поддерживается.</returns>
		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x0000270D File Offset: 0x0000090D
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00099729 File Offset: 0x00097929
		internal ArrayList HostEvidenceList
		{
			get
			{
				if (this.hostEvidenceList == null)
				{
					this.hostEvidenceList = ArrayList.Synchronized(new ArrayList());
				}
				return this.hostEvidenceList;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x00099749 File Offset: 0x00097949
		internal ArrayList AssemblyEvidenceList
		{
			get
			{
				if (this.assemblyEvidenceList == null)
				{
					this.assemblyEvidenceList = ArrayList.Synchronized(new ArrayList());
				}
				return this.assemblyEvidenceList;
			}
		}

		/// <summary>Добавляет указанное свидетельство сборки к набору свидетельств.</summary>
		/// <param name="id">Любой объект свидетельства.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="id" /> имеет значение null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="id" /> не поддерживает сериализацию.</exception>
		// Token: 0x06002A60 RID: 10848 RVA: 0x00099769 File Offset: 0x00097969
		[Obsolete]
		public void AddAssembly(object id)
		{
			this.AssemblyEvidenceList.Add(id);
		}

		/// <summary>Добавляет заданное свидетельство, предоставляемое сайтом, к набору свидетельств.</summary>
		/// <param name="id">Любой объект свидетельства.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="id" /> имеет значение null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="id" /> не поддерживает сериализацию.</exception>
		// Token: 0x06002A61 RID: 10849 RVA: 0x00099778 File Offset: 0x00097978
		[Obsolete]
		public void AddHost(object id)
		{
			if (this._locked && SecurityManager.SecurityEnabled)
			{
				new SecurityPermission(SecurityPermissionFlag.ControlEvidence).Demand();
			}
			this.HostEvidenceList.Add(id);
		}

		/// <summary>Удаляет из набора свидетельств свидетельство сайта и сборки.</summary>
		// Token: 0x06002A62 RID: 10850 RVA: 0x000997A2 File Offset: 0x000979A2
		[ComVisible(false)]
		public void Clear()
		{
			if (this.hostEvidenceList != null)
			{
				this.hostEvidenceList.Clear();
			}
			if (this.assemblyEvidenceList != null)
			{
				this.assemblyEvidenceList.Clear();
			}
		}

		/// <summary>Возвращает копию данного объекта свидетельства.</summary>
		/// <returns>Копия данного объекта свидетельства.</returns>
		// Token: 0x06002A63 RID: 10851 RVA: 0x000997CA File Offset: 0x000979CA
		[ComVisible(false)]
		public Evidence Clone()
		{
			return new Evidence(this);
		}

		/// <summary>Копирует объекты свидетельств в массив <see cref="T:System.Array" />.</summary>
		/// <param name="array">Массив назначения, в который копируются объекты свидетельств.</param>
		/// <param name="index">Позиция в массиве, с которой начинается копирование объектов свидетельств в массив (индексация ведется с нуля).</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="array" /> имеет значение null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> выходит за границы диапазона конечного массива.</exception>
		// Token: 0x06002A64 RID: 10852 RVA: 0x000997D4 File Offset: 0x000979D4
		[Obsolete]
		public void CopyTo(Array array, int index)
		{
			int num = 0;
			if (this.hostEvidenceList != null)
			{
				num = this.hostEvidenceList.Count;
				if (num > 0)
				{
					this.hostEvidenceList.CopyTo(array, index);
				}
			}
			if (this.assemblyEvidenceList != null && this.assemblyEvidenceList.Count > 0)
			{
				this.assemblyEvidenceList.CopyTo(array, index + num);
			}
		}

		/// <summary>Осуществляет нумерацию всех свидетельств в наборе: как свидетельств, предоставленных сайтом, так и свидетельств, предоставленных сборкой.</summary>
		/// <returns>Перечислитель для свидетельства, добавленного методом <see cref="M:System.Security.Policy.Evidence.AddHost(System.Object)" /> или <see cref="M:System.Security.Policy.Evidence.AddAssembly(System.Object)" />.</returns>
		// Token: 0x06002A65 RID: 10853 RVA: 0x00099830 File Offset: 0x00097A30
		[Obsolete]
		public IEnumerator GetEnumerator()
		{
			IEnumerator hostenum = null;
			if (this.hostEvidenceList != null)
			{
				hostenum = this.hostEvidenceList.GetEnumerator();
			}
			IEnumerator assemblyenum = null;
			if (this.assemblyEvidenceList != null)
			{
				assemblyenum = this.assemblyEvidenceList.GetEnumerator();
			}
			return new Evidence.EvidenceEnumerator(hostenum, assemblyenum);
		}

		/// <summary>Осуществляет нумерацию свидетельств, предоставленных сборкой.</summary>
		/// <returns>Перечислитель для свидетельства, добавленного методом <see cref="M:System.Security.Policy.Evidence.AddAssembly(System.Object)" />.</returns>
		// Token: 0x06002A66 RID: 10854 RVA: 0x00099870 File Offset: 0x00097A70
		public IEnumerator GetAssemblyEnumerator()
		{
			return this.AssemblyEvidenceList.GetEnumerator();
		}

		/// <summary>Осуществляет нумерацию свидетельства, предоставляемого сайтом.</summary>
		/// <returns>Перечислитель для свидетельства, добавленного методом <see cref="M:System.Security.Policy.Evidence.AddHost(System.Object)" />.</returns>
		// Token: 0x06002A67 RID: 10855 RVA: 0x0009987D File Offset: 0x00097A7D
		public IEnumerator GetHostEnumerator()
		{
			return this.HostEvidenceList.GetEnumerator();
		}

		/// <summary>Осуществляет слияние указанного набора свидетельств и текущего набора свидетельств.</summary>
		/// <param name="evidence">Набор свидетельств для слияния с текущим набором свидетельств.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="evidence" /> — это недопустимый экземпляр <see cref="T:System.Security.Policy.Evidence" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Объект <see cref="P:System.Security.Policy.Evidence.Locked" /> имеет значение <see langword="true" />, код, вызывающий этот метод, не имеет разрешения <see cref="F:System.Security.Permissions.SecurityPermissionFlag.ControlEvidence" />, а параметр <paramref name="evidence" /> имеет непустой список узлов.</exception>
		// Token: 0x06002A68 RID: 10856 RVA: 0x0009988C File Offset: 0x00097A8C
		public void Merge(Evidence evidence)
		{
			if (evidence != null && evidence.Count > 0)
			{
				if (evidence.hostEvidenceList != null)
				{
					foreach (object id in evidence.hostEvidenceList)
					{
						this.AddHost(id);
					}
				}
				if (evidence.assemblyEvidenceList != null)
				{
					foreach (object id2 in evidence.assemblyEvidenceList)
					{
						this.AddAssembly(id2);
					}
				}
			}
		}

		/// <summary>Удаляет свидетельство для данного типа из перечислителей сайта и сборки.</summary>
		/// <param name="t">Тип удаляемого свидетельства.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="t" /> имеет значение null.</exception>
		// Token: 0x06002A69 RID: 10857 RVA: 0x00099944 File Offset: 0x00097B44
		[ComVisible(false)]
		public void RemoveType(Type t)
		{
			for (int i = this.hostEvidenceList.Count; i >= 0; i--)
			{
				if (this.hostEvidenceList.GetType() == t)
				{
					this.hostEvidenceList.RemoveAt(i);
				}
			}
			for (int j = this.assemblyEvidenceList.Count; j >= 0; j--)
			{
				if (this.assemblyEvidenceList.GetType() == t)
				{
					this.assemblyEvidenceList.RemoveAt(j);
				}
			}
		}

		// Token: 0x06002A6A RID: 10858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsAuthenticodePresent(Assembly a);

		// Token: 0x06002A6B RID: 10859 RVA: 0x000999BC File Offset: 0x00097BBC
		[FileIOPermission(SecurityAction.Assert, Unrestricted = true)]
		internal static Evidence GetDefaultHostEvidence(Assembly a)
		{
			Evidence evidence = new Evidence();
			string escapedCodeBase = a.EscapedCodeBase;
			evidence.AddHost(Zone.CreateFromUrl(escapedCodeBase));
			evidence.AddHost(new Url(escapedCodeBase));
			evidence.AddHost(new Hash(a));
			if (string.Compare("FILE://", 0, escapedCodeBase, 0, 7, true, CultureInfo.InvariantCulture) != 0)
			{
				evidence.AddHost(Site.CreateFromUrl(escapedCodeBase));
			}
			AssemblyName name = a.GetName();
			byte[] publicKey = name.GetPublicKey();
			if (publicKey != null && publicKey.Length != 0)
			{
				StrongNamePublicKeyBlob blob = new StrongNamePublicKeyBlob(publicKey);
				evidence.AddHost(new StrongName(blob, name.Name, name.Version));
			}
			if (Evidence.IsAuthenticodePresent(a))
			{
				try
				{
					X509Certificate cert = X509Certificate.CreateFromSignedFile(a.Location);
					evidence.AddHost(new Publisher(cert));
				}
				catch (CryptographicException)
				{
				}
			}
			if (a.GlobalAssemblyCache)
			{
				evidence.AddHost(new GacInstalled());
			}
			AppDomainManager domainManager = AppDomain.CurrentDomain.DomainManager;
			if (domainManager != null && (domainManager.HostSecurityManager.Flags & HostSecurityManagerOptions.HostAssemblyEvidence) == HostSecurityManagerOptions.HostAssemblyEvidence)
			{
				evidence = domainManager.HostSecurityManager.ProvideAssemblyEvidence(a, evidence);
			}
			return evidence;
		}

		/// <summary>Добавляет объект свидетельства указанного типа в список свидетельств, предоставляемых сборкой.</summary>
		/// <param name="evidence">Добавляемое свидетельство.</param>
		/// <typeparam name="T">Тип объекта в параметре <paramref name="evidence" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свидетельство типа <paramref name="T" /> уже содержится в списке.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="evidence" /> не поддерживает сериализацию.</exception>
		// Token: 0x06002A6C RID: 10860 RVA: 0x000173AD File Offset: 0x000155AD
		[ComVisible(false)]
		public void AddAssemblyEvidence<T>(T evidence)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Добавляет свидетельство узла определенного типа в коллекцию свидетельств узла.</summary>
		/// <param name="evidence">Добавляемое свидетельство узла.</param>
		/// <typeparam name="T">Тип объекта в параметре <paramref name="evidence" />.</typeparam>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="evidence" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Свидетельство типа <paramref name="T" /> уже содержится в списке.</exception>
		// Token: 0x06002A6D RID: 10861 RVA: 0x000173AD File Offset: 0x000155AD
		[ComVisible(false)]
		public void AddHostEvidence<T>(T evidence)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Получает свидетельство сборки указанного типа из коллекции.</summary>
		/// <typeparam name="T">Тип получаемого свидетельства.</typeparam>
		/// <returns>Свидетельство типа <paramref name="T" /> в коллекции свидетельств сборки.</returns>
		// Token: 0x06002A6E RID: 10862 RVA: 0x00099AD0 File Offset: 0x00097CD0
		[ComVisible(false)]
		public T GetAssemblyEvidence<T>()
		{
			ThrowStub.ThrowNotSupportedException();
			return default(T);
		}

		/// <summary>Получает свидетельство узла указанного типа из коллекции.</summary>
		/// <typeparam name="T">Тип получаемого свидетельства.</typeparam>
		/// <returns>Свидетельство типа <paramref name="T" /> в коллекции свидетельств узла.</returns>
		// Token: 0x06002A6F RID: 10863 RVA: 0x00099AEC File Offset: 0x00097CEC
		[ComVisible(false)]
		public T GetHostEvidence<T>()
		{
			ThrowStub.ThrowNotSupportedException();
			return default(T);
		}

		// Token: 0x04001F90 RID: 8080
		private bool _locked;

		// Token: 0x04001F91 RID: 8081
		private ArrayList hostEvidenceList;

		// Token: 0x04001F92 RID: 8082
		private ArrayList assemblyEvidenceList;

		// Token: 0x0200040C RID: 1036
		private class EvidenceEnumerator : IEnumerator
		{
			// Token: 0x06002A70 RID: 10864 RVA: 0x00099B07 File Offset: 0x00097D07
			public EvidenceEnumerator(IEnumerator hostenum, IEnumerator assemblyenum)
			{
				this.hostEnum = hostenum;
				this.assemblyEnum = assemblyenum;
				this.currentEnum = this.hostEnum;
			}

			// Token: 0x06002A71 RID: 10865 RVA: 0x00099B2C File Offset: 0x00097D2C
			public bool MoveNext()
			{
				if (this.currentEnum == null)
				{
					return false;
				}
				bool flag = this.currentEnum.MoveNext();
				if (!flag && this.hostEnum == this.currentEnum && this.assemblyEnum != null)
				{
					this.currentEnum = this.assemblyEnum;
					flag = this.assemblyEnum.MoveNext();
				}
				return flag;
			}

			// Token: 0x06002A72 RID: 10866 RVA: 0x00099B84 File Offset: 0x00097D84
			public void Reset()
			{
				if (this.hostEnum != null)
				{
					this.hostEnum.Reset();
					this.currentEnum = this.hostEnum;
				}
				else
				{
					this.currentEnum = this.assemblyEnum;
				}
				if (this.assemblyEnum != null)
				{
					this.assemblyEnum.Reset();
				}
			}

			// Token: 0x1700054B RID: 1355
			// (get) Token: 0x06002A73 RID: 10867 RVA: 0x00099BD1 File Offset: 0x00097DD1
			public object Current
			{
				get
				{
					return this.currentEnum.Current;
				}
			}

			// Token: 0x04001F93 RID: 8083
			private IEnumerator currentEnum;

			// Token: 0x04001F94 RID: 8084
			private IEnumerator hostEnum;

			// Token: 0x04001F95 RID: 8085
			private IEnumerator assemblyEnum;
		}
	}
}
