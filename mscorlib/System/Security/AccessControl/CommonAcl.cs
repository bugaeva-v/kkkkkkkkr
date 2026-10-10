using System;
using System.Security.Principal;
using Unity;

namespace System.Security.AccessControl
{
	/// <summary>Представляет список управления доступом и является базовым классом для классов <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> и <see cref="T:System.Security.AccessControl.SystemAcl" />.</summary>
	// Token: 0x0200050F RID: 1295
	public abstract class CommonAcl : GenericAcl
	{
		// Token: 0x06003365 RID: 13157 RVA: 0x000BCCD4 File Offset: 0x000BAED4
		internal CommonAcl(bool isContainer, bool isDS, RawAcl rawAcl)
		{
			if (rawAcl == null)
			{
				rawAcl = new RawAcl(isDS ? GenericAcl.AclRevisionDS : GenericAcl.AclRevision, 10);
			}
			else
			{
				byte[] binaryForm = new byte[rawAcl.BinaryLength];
				rawAcl.GetBinaryForm(binaryForm, 0);
				rawAcl = new RawAcl(binaryForm, 0);
			}
			this.Init(isContainer, isDS, rawAcl);
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x000BCD2A File Offset: 0x000BAF2A
		internal CommonAcl(bool isContainer, bool isDS, byte revision, int capacity)
		{
			this.Init(isContainer, isDS, new RawAcl(revision, capacity));
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x000BCD42 File Offset: 0x000BAF42
		internal CommonAcl(bool isContainer, bool isDS, int capacity) : this(isContainer, isDS, isDS ? GenericAcl.AclRevisionDS : GenericAcl.AclRevision, capacity)
		{
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x000BCD5C File Offset: 0x000BAF5C
		private void Init(bool isContainer, bool isDS, RawAcl rawAcl)
		{
			this.is_container = isContainer;
			this.is_ds = isDS;
			this.raw_acl = rawAcl;
			this.CanonicalizeAndClearAefa();
		}

		/// <summary>Возвращает длину в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CommonAcl" />. Эта длина должна использоваться перед маршалингом списка управления доступом в двоичный массив с помощью метода <see cref="M:System.Security.AccessControl.CommonAcl.GetBinaryForm(System.Byte[],System.Int32)" />.</summary>
		/// <returns>Длина в байтах двоичного представления текущего объекта <see cref="T:System.Security.AccessControl.CommonAcl" />.</returns>
		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06003369 RID: 13161 RVA: 0x000BCD79 File Offset: 0x000BAF79
		public sealed override int BinaryLength
		{
			get
			{
				return this.raw_acl.BinaryLength;
			}
		}

		/// <summary>Возвращает количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.CommonAcl" />.</summary>
		/// <returns>Количество элементов управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.CommonAcl" />.</returns>
		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600336A RID: 13162 RVA: 0x000BCD86 File Offset: 0x000BAF86
		public sealed override int Count
		{
			get
			{
				return this.raw_acl.Count;
			}
		}

		/// <summary>Возвращает логическое значение, которое указывает, расположены ли элементы управления доступом в текущем объекте <see cref="T:System.Security.AccessControl.CommonAcl" /> в каноническом порядке.</summary>
		/// <returns>Значение <see langword="true" />, если элементы управления доступом в текущем текущем объекте <see cref="T:System.Security.AccessControl.CommonAcl" /> расположены в каноническом порядке; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x0600336B RID: 13163 RVA: 0x000BCD93 File Offset: 0x000BAF93
		public bool IsCanonical
		{
			get
			{
				return this.is_canonical;
			}
		}

		/// <summary>Определяет, является ли объект <see cref="T:System.Security.AccessControl.CommonAcl" /> контейнером.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Security.AccessControl.CommonAcl" /> является контейнером.</returns>
		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600336C RID: 13164 RVA: 0x000BCD9B File Offset: 0x000BAF9B
		public bool IsContainer
		{
			get
			{
				return this.is_container;
			}
		}

		/// <summary>Определяет, является ли текущий объект <see cref="T:System.Security.AccessControl.CommonAcl" /> списком управления доступом объекта каталога.</summary>
		/// <returns>Значение <see langword="true" />, если текущий объект <see cref="T:System.Security.AccessControl.CommonAcl" /> является списком управления доступом объекта каталога.</returns>
		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600336D RID: 13165 RVA: 0x000BCDA3 File Offset: 0x000BAFA3
		public bool IsDS
		{
			get
			{
				return this.is_ds;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600336E RID: 13166 RVA: 0x000BCDAB File Offset: 0x000BAFAB
		// (set) Token: 0x0600336F RID: 13167 RVA: 0x000BCDB3 File Offset: 0x000BAFB3
		internal bool IsAefa
		{
			get
			{
				return this.is_aefa;
			}
			set
			{
				this.is_aefa = value;
			}
		}

		/// <summary>Возвращает уровень редакции объекта <see cref="T:System.Security.AccessControl.CommonAcl" />.</summary>
		/// <returns>Байтовое значение, определяющее уровень редакции объекта <see cref="T:System.Security.AccessControl.CommonAcl" />.</returns>
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06003370 RID: 13168 RVA: 0x000BCDBC File Offset: 0x000BAFBC
		public sealed override byte Revision
		{
			get
			{
				return this.raw_acl.Revision;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Security.AccessControl.CommonAce" /> с заданным индексом.</summary>
		/// <param name="index">Индекс (с нуля) возвращаемого или задаваемого <see cref="T:System.Security.AccessControl.CommonAce" />.</param>
		/// <returns>Параметр <see cref="T:System.Security.AccessControl.CommonAce" /> по указанному индексу.</returns>
		// Token: 0x17000701 RID: 1793
		public sealed override GenericAce this[int index]
		{
			get
			{
				return CommonAcl.CopyAce(this.raw_acl[index]);
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		/// <summary>Маршалирует содержимое объекта <see cref="T:System.Security.AccessControl.CommonAcl" /> в указанный массив байтов, начиная с указанной позиции.</summary>
		/// <param name="binaryForm">Массив байтов, в который маршалируется содержимое объекта <see cref="T:System.Security.AccessControl.CommonAcl" />.</param>
		/// <param name="offset">Позиция, с которой начинается маршалинг.</param>
		// Token: 0x06003373 RID: 13171 RVA: 0x000BCDDC File Offset: 0x000BAFDC
		public sealed override void GetBinaryForm(byte[] binaryForm, int offset)
		{
			this.raw_acl.GetBinaryForm(binaryForm, offset);
		}

		/// <summary>Удаляет все элементы управления доступом, содержащиеся в данном объекте <see cref="T:System.Security.AccessControl.CommonAcl" /> и связанные с объектом <see cref="T:System.Security.Principal.SecurityIdentifier" />.</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" /> для проверки.</param>
		// Token: 0x06003374 RID: 13172 RVA: 0x000BCDEC File Offset: 0x000BAFEC
		public void Purge(SecurityIdentifier sid)
		{
			this.RequireCanonicity();
			this.RemoveAces<KnownAce>((KnownAce ace) => ace.SecurityIdentifier == sid);
		}

		/// <summary>Удаляет все наследуемые элементы управления доступом из данного объекта <see cref="T:System.Security.AccessControl.CommonAcl" />.</summary>
		// Token: 0x06003375 RID: 13173 RVA: 0x000BCE1E File Offset: 0x000BB01E
		public void RemoveInheritedAces()
		{
			this.RequireCanonicity();
			this.RemoveAces<GenericAce>((GenericAce ace) => ace.IsInherited);
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x000BCE4B File Offset: 0x000BB04B
		internal void RequireCanonicity()
		{
			if (!this.IsCanonical)
			{
				throw new InvalidOperationException("ACL is not canonical.");
			}
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000BCE60 File Offset: 0x000BB060
		internal void CanonicalizeAndClearAefa()
		{
			this.RemoveAces<GenericAce>(new CommonAcl.RemoveAcesCallback<GenericAce>(this.IsAceMeaningless));
			this.is_canonical = this.TestCanonicity();
			if (this.IsCanonical)
			{
				this.ApplyCanonicalSortToExplicitAces();
				this.MergeExplicitAces();
			}
			this.IsAefa = false;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000BCE9C File Offset: 0x000BB09C
		internal virtual bool IsAceMeaningless(GenericAce ace)
		{
			AceFlags aceFlags = ace.AceFlags;
			KnownAce knownAce = ace as KnownAce;
			if (knownAce != null)
			{
				if (knownAce.AccessMask == 0)
				{
					return true;
				}
				if ((aceFlags & AceFlags.InheritOnly) != AceFlags.None)
				{
					if (knownAce is ObjectAce)
					{
						return true;
					}
					if (!this.IsContainer)
					{
						return true;
					}
					if ((aceFlags & (AceFlags.ObjectInherit | AceFlags.ContainerInherit)) == AceFlags.None)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000BCEEC File Offset: 0x000BB0EC
		private bool TestCanonicity()
		{
			AceEnumerator enumerator = base.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (!(enumerator.Current is QualifiedAce))
				{
					return false;
				}
			}
			bool flag = false;
			enumerator = base.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((QualifiedAce)enumerator.Current).IsInherited)
				{
					flag = true;
				}
				else if (flag)
				{
					return false;
				}
			}
			bool flag2 = false;
			foreach (GenericAce genericAce in this)
			{
				QualifiedAce qualifiedAce = (QualifiedAce)genericAce;
				if (qualifiedAce.IsInherited)
				{
					break;
				}
				if (qualifiedAce.AceQualifier == AceQualifier.AccessAllowed)
				{
					flag2 = true;
				}
				else if (AceQualifier.AccessDenied == qualifiedAce.AceQualifier && flag2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000BCF8C File Offset: 0x000BB18C
		internal int GetCanonicalExplicitDenyAceCount()
		{
			int num = 0;
			while (num < this.Count && !this.raw_acl[num].IsInherited)
			{
				QualifiedAce qualifiedAce = this.raw_acl[num] as QualifiedAce;
				if (qualifiedAce == null || qualifiedAce.AceQualifier != AceQualifier.AccessDenied)
				{
					break;
				}
				num++;
			}
			return num;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000BCFE4 File Offset: 0x000BB1E4
		internal int GetCanonicalExplicitAceCount()
		{
			int num = 0;
			while (num < this.Count && !this.raw_acl[num].IsInherited)
			{
				num++;
			}
			return num;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000BD018 File Offset: 0x000BB218
		private void MergeExplicitAces()
		{
			int num = this.GetCanonicalExplicitAceCount();
			int i = 0;
			while (i < num - 1)
			{
				GenericAce genericAce = this.MergeExplicitAcePair(this.raw_acl[i], this.raw_acl[i + 1]);
				if (null != genericAce)
				{
					this.raw_acl[i] = genericAce;
					this.raw_acl.RemoveAce(i + 1);
					num--;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000BD088 File Offset: 0x000BB288
		private GenericAce MergeExplicitAcePair(GenericAce ace1, GenericAce ace2)
		{
			QualifiedAce qualifiedAce = ace1 as QualifiedAce;
			QualifiedAce qualifiedAce2 = ace2 as QualifiedAce;
			if (!(null != qualifiedAce) || !(null != qualifiedAce2))
			{
				return null;
			}
			if (qualifiedAce.AceQualifier != qualifiedAce2.AceQualifier)
			{
				return null;
			}
			if (!(qualifiedAce.SecurityIdentifier == qualifiedAce2.SecurityIdentifier))
			{
				return null;
			}
			AceFlags aceFlags = qualifiedAce.AceFlags;
			AceFlags aceFlags2 = qualifiedAce2.AceFlags;
			int accessMask = qualifiedAce.AccessMask;
			int accessMask2 = qualifiedAce2.AccessMask;
			if (!this.IsContainer)
			{
				aceFlags &= ~(AceFlags.ObjectInherit | AceFlags.ContainerInherit | AceFlags.NoPropagateInherit | AceFlags.InheritOnly);
				aceFlags2 &= ~(AceFlags.ObjectInherit | AceFlags.ContainerInherit | AceFlags.NoPropagateInherit | AceFlags.InheritOnly);
			}
			AceFlags aceFlags3;
			int accessMask3;
			if (aceFlags != aceFlags2)
			{
				if (accessMask != accessMask2)
				{
					return null;
				}
				if ((aceFlags & ~(AceFlags.ObjectInherit | AceFlags.ContainerInherit)) == (aceFlags2 & ~(AceFlags.ObjectInherit | AceFlags.ContainerInherit)))
				{
					aceFlags3 = (aceFlags | aceFlags2);
					accessMask3 = accessMask;
				}
				else
				{
					if ((aceFlags & ~(AceFlags.SuccessfulAccess | AceFlags.FailedAccess)) != (aceFlags2 & ~(AceFlags.SuccessfulAccess | AceFlags.FailedAccess)))
					{
						return null;
					}
					aceFlags3 = (aceFlags | aceFlags2);
					accessMask3 = accessMask;
				}
			}
			else
			{
				aceFlags3 = aceFlags;
				accessMask3 = (accessMask | accessMask2);
			}
			CommonAce commonAce = ace1 as CommonAce;
			CommonAce right = ace2 as CommonAce;
			if (null != commonAce && null != right)
			{
				return new CommonAce(aceFlags3, commonAce.AceQualifier, accessMask3, commonAce.SecurityIdentifier, commonAce.IsCallback, commonAce.GetOpaque());
			}
			ObjectAce objectAce = ace1 as ObjectAce;
			ObjectAce objectAce2 = ace2 as ObjectAce;
			if (null != objectAce && null != objectAce2)
			{
				Guid a;
				Guid a2;
				CommonAcl.GetObjectAceTypeGuids(objectAce, out a, out a2);
				Guid b;
				Guid b2;
				CommonAcl.GetObjectAceTypeGuids(objectAce2, out b, out b2);
				if (a == b && a2 == b2)
				{
					return new ObjectAce(aceFlags3, objectAce.AceQualifier, accessMask3, objectAce.SecurityIdentifier, objectAce.ObjectAceFlags, objectAce.ObjectAceType, objectAce.InheritedObjectAceType, objectAce.IsCallback, objectAce.GetOpaque());
				}
			}
			return null;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000BD230 File Offset: 0x000BB430
		private static void GetObjectAceTypeGuids(ObjectAce ace, out Guid type, out Guid inheritedType)
		{
			type = Guid.Empty;
			inheritedType = Guid.Empty;
			if ((ace.ObjectAceFlags & ObjectAceFlags.ObjectAceTypePresent) != ObjectAceFlags.None)
			{
				type = ace.ObjectAceType;
			}
			if ((ace.ObjectAceFlags & ObjectAceFlags.InheritedObjectAceTypePresent) != ObjectAceFlags.None)
			{
				inheritedType = ace.InheritedObjectAceType;
			}
		}

		// Token: 0x0600337F RID: 13183
		internal abstract void ApplyCanonicalSortToExplicitAces();

		// Token: 0x06003380 RID: 13184 RVA: 0x000BD280 File Offset: 0x000BB480
		internal void ApplyCanonicalSortToExplicitAces(int start, int count)
		{
			for (int i = start + 1; i < start + count; i++)
			{
				KnownAce knownAce = (KnownAce)this.raw_acl[i];
				SecurityIdentifier securityIdentifier = knownAce.SecurityIdentifier;
				int num = i;
				while (num > start && ((KnownAce)this.raw_acl[num - 1]).SecurityIdentifier.CompareTo(securityIdentifier) > 0)
				{
					this.raw_acl[num] = this.raw_acl[num - 1];
					num--;
				}
				this.raw_acl[num] = knownAce;
			}
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000BD30A File Offset: 0x000BB50A
		internal override string GetSddlForm(ControlFlags sdFlags, bool isDacl)
		{
			return this.raw_acl.GetSddlForm(sdFlags, isDacl);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000BD31C File Offset: 0x000BB51C
		internal void RemoveAces<T>(CommonAcl.RemoveAcesCallback<T> callback) where T : GenericAce
		{
			int i = 0;
			while (i < this.raw_acl.Count)
			{
				if (this.raw_acl[i] is T && callback((T)((object)this.raw_acl[i])))
				{
					this.raw_acl.RemoveAce(i);
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000BD37C File Offset: 0x000BB57C
		internal void AddAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			QualifiedAce newAce = this.AddAceGetQualifiedAce(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
			this.AddAce(newAce);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000BD3A0 File Offset: 0x000BB5A0
		internal void AddAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			QualifiedAce newAce = this.AddAceGetQualifiedAce(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags, objectFlags, objectType, inheritedObjectType);
			this.AddAce(newAce);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000BD3CC File Offset: 0x000BB5CC
		private QualifiedAce AddAceGetQualifiedAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			if (!this.IsDS)
			{
				throw new InvalidOperationException("For this overload, IsDS must be true.");
			}
			if (objectFlags == ObjectAceFlags.None)
			{
				return this.AddAceGetQualifiedAce(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
			}
			return new ObjectAce(this.GetAceFlags(inheritanceFlags, propagationFlags, auditFlags), aceQualifier, accessMask, sid, objectFlags, objectType, inheritedObjectType, false, null);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x000BD41C File Offset: 0x000BB61C
		private QualifiedAce AddAceGetQualifiedAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			return new CommonAce(this.GetAceFlags(inheritanceFlags, propagationFlags, auditFlags), aceQualifier, accessMask, sid, false, null);
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x000BD434 File Offset: 0x000BB634
		private void AddAce(QualifiedAce newAce)
		{
			this.RequireCanonicity();
			int aceInsertPosition = this.GetAceInsertPosition(newAce.AceQualifier);
			this.raw_acl.InsertAce(aceInsertPosition, CommonAcl.CopyAce(newAce));
			this.CanonicalizeAndClearAefa();
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x000BD46C File Offset: 0x000BB66C
		private static GenericAce CopyAce(GenericAce ace)
		{
			byte[] binaryForm = new byte[ace.BinaryLength];
			ace.GetBinaryForm(binaryForm, 0);
			return GenericAce.CreateFromBinaryForm(binaryForm, 0);
		}

		// Token: 0x06003389 RID: 13193
		internal abstract int GetAceInsertPosition(AceQualifier aceQualifier);

		// Token: 0x0600338A RID: 13194 RVA: 0x000BD494 File Offset: 0x000BB694
		private AceFlags GetAceFlags(InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			if (inheritanceFlags != InheritanceFlags.None && !this.IsContainer)
			{
				throw new ArgumentException("Flags only work with containers.", "inheritanceFlags");
			}
			if (inheritanceFlags == InheritanceFlags.None && propagationFlags != PropagationFlags.None)
			{
				throw new ArgumentException("Propagation flags need inheritance flags.", "propagationFlags");
			}
			AceFlags aceFlags = AceFlags.None;
			if ((InheritanceFlags.ContainerInherit & inheritanceFlags) != InheritanceFlags.None)
			{
				aceFlags |= AceFlags.ContainerInherit;
			}
			if ((InheritanceFlags.ObjectInherit & inheritanceFlags) != InheritanceFlags.None)
			{
				aceFlags |= AceFlags.ObjectInherit;
			}
			if ((PropagationFlags.InheritOnly & propagationFlags) != PropagationFlags.None)
			{
				aceFlags |= AceFlags.InheritOnly;
			}
			if ((PropagationFlags.NoPropagateInherit & propagationFlags) != PropagationFlags.None)
			{
				aceFlags |= AceFlags.NoPropagateInherit;
			}
			if ((AuditFlags.Success & auditFlags) != AuditFlags.None)
			{
				aceFlags |= AceFlags.SuccessfulAccess;
			}
			if ((AuditFlags.Failure & auditFlags) != AuditFlags.None)
			{
				aceFlags |= AceFlags.FailedAccess;
			}
			return aceFlags;
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x000BD510 File Offset: 0x000BB710
		internal void RemoveAceSpecific(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			this.RequireCanonicity();
			this.RemoveAces<CommonAce>((CommonAce ace) => ace.AccessMask == accessMask && ace.AceQualifier == aceQualifier && !(ace.SecurityIdentifier != sid) && ace.InheritanceFlags == inheritanceFlags && (inheritanceFlags == InheritanceFlags.None || ace.PropagationFlags == propagationFlags) && ace.AuditFlags == auditFlags);
			this.CanonicalizeAndClearAefa();
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000BD570 File Offset: 0x000BB770
		internal void RemoveAceSpecific(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			if (!this.IsDS)
			{
				throw new InvalidOperationException("For this overload, IsDS must be true.");
			}
			if (objectFlags == ObjectAceFlags.None)
			{
				this.RemoveAceSpecific(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
				return;
			}
			this.RequireCanonicity();
			this.RemoveAces<ObjectAce>((ObjectAce ace) => ace.AccessMask == accessMask && ace.AceQualifier == aceQualifier && !(ace.SecurityIdentifier != sid) && ace.InheritanceFlags == inheritanceFlags && (inheritanceFlags == InheritanceFlags.None || ace.PropagationFlags == propagationFlags) && ace.AuditFlags == auditFlags && ace.ObjectAceFlags == objectFlags && ((objectFlags & ObjectAceFlags.ObjectAceTypePresent) == ObjectAceFlags.None || !(ace.ObjectAceType != objectType)) && ((objectFlags & ObjectAceFlags.InheritedObjectAceTypePresent) == ObjectAceFlags.None || !(ace.InheritedObjectAceType != objectType)));
			this.CanonicalizeAndClearAefa();
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000BD624 File Offset: 0x000BB824
		internal void SetAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			QualifiedAce ace = this.AddAceGetQualifiedAce(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags);
			this.SetAce(ace);
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000BD648 File Offset: 0x000BB848
		internal void SetAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags, ObjectAceFlags objectFlags, Guid objectType, Guid inheritedObjectType)
		{
			QualifiedAce ace = this.AddAceGetQualifiedAce(aceQualifier, sid, accessMask, inheritanceFlags, propagationFlags, auditFlags, objectFlags, objectType, inheritedObjectType);
			this.SetAce(ace);
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x000BD674 File Offset: 0x000BB874
		private void SetAce(QualifiedAce newAce)
		{
			this.RequireCanonicity();
			this.RemoveAces<QualifiedAce>((QualifiedAce oldAce) => oldAce.AceQualifier == newAce.AceQualifier && oldAce.SecurityIdentifier == newAce.SecurityIdentifier);
			this.CanonicalizeAndClearAefa();
			this.AddAce(newAce);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x000173AD File Offset: 0x000155AD
		internal CommonAcl()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400243E RID: 9278
		private const int default_capacity = 10;

		// Token: 0x0400243F RID: 9279
		private bool is_aefa;

		// Token: 0x04002440 RID: 9280
		private bool is_canonical;

		// Token: 0x04002441 RID: 9281
		private bool is_container;

		// Token: 0x04002442 RID: 9282
		private bool is_ds;

		// Token: 0x04002443 RID: 9283
		internal RawAcl raw_acl;

		// Token: 0x02000510 RID: 1296
		// (Invoke) Token: 0x06003392 RID: 13202
		internal delegate bool RemoveAcesCallback<T>(T ace);
	}
}
