using System;
using System.Collections.Generic;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет базовый класс для соотношения элементов друг с другом.</summary>
	// Token: 0x0200048D RID: 1165
	public abstract class MemberRelationshipService
	{
		/// <summary>Устанавливает связь между источником и целевым объектом.</summary>
		/// <param name="source">Исходная связь. Это левая сторона при назначении связи.</param>
		/// <returns>Текущая связь соотносится со значением параметра <paramref name="source" /> или <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" />, если связь отсутствует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="source" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="source" /> пустое, или связь не поддерживается службой.</exception>
		// Token: 0x17000787 RID: 1927
		public MemberRelationship this[MemberRelationship source]
		{
			get
			{
				if (source.Owner == null)
				{
					throw new ArgumentNullException("Owner");
				}
				if (source.Member == null)
				{
					throw new ArgumentNullException("Member");
				}
				return this.GetRelationship(source);
			}
			set
			{
				if (source.Owner == null)
				{
					throw new ArgumentNullException("Owner");
				}
				if (source.Member == null)
				{
					throw new ArgumentNullException("Member");
				}
				this.SetRelationship(source, value);
			}
		}

		/// <summary>Устанавливает связь между источником и целевым объектом.</summary>
		/// <param name="sourceOwner">Владелец исходной связи.</param>
		/// <param name="sourceMember">Элемент исходной связи.</param>
		/// <returns>Структура <see cref="T:System.ComponentModel.Design.Serialization.MemberRelationship" />, инкапсулирующая связь между исходным и целевым объектом, или значение <see langword="null" />, если связь отсутствует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceOwner" /> или <paramref name="sourceMember" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="sourceOwner" /> или <paramref name="sourceMember" /> пустое, или связь не поддерживается службой.</exception>
		// Token: 0x17000788 RID: 1928
		public MemberRelationship this[object sourceOwner, MemberDescriptor sourceMember]
		{
			get
			{
				if (sourceOwner == null)
				{
					throw new ArgumentNullException("sourceOwner");
				}
				if (sourceMember == null)
				{
					throw new ArgumentNullException("sourceMember");
				}
				return this.GetRelationship(new MemberRelationship(sourceOwner, sourceMember));
			}
			set
			{
				if (sourceOwner == null)
				{
					throw new ArgumentNullException("sourceOwner");
				}
				if (sourceMember == null)
				{
					throw new ArgumentNullException("sourceMember");
				}
				this.SetRelationship(new MemberRelationship(sourceOwner, sourceMember), value);
			}
		}

		/// <summary>Устанавливает связь для заданной исходной связи.</summary>
		/// <param name="source">Исходная связь.</param>
		/// <returns>Связь с <paramref name="source" />, или <see cref="F:System.ComponentModel.Design.Serialization.MemberRelationship.Empty" />, если связи не существует.</returns>
		// Token: 0x0600253D RID: 9533 RVA: 0x00082F88 File Offset: 0x00081188
		protected virtual MemberRelationship GetRelationship(MemberRelationship source)
		{
			MemberRelationshipService.RelationshipEntry relationshipEntry;
			if (this._relationships != null && this._relationships.TryGetValue(new MemberRelationshipService.RelationshipEntry(source), out relationshipEntry) && relationshipEntry.Owner.IsAlive)
			{
				return new MemberRelationship(relationshipEntry.Owner.Target, relationshipEntry.Member);
			}
			return MemberRelationship.Empty;
		}

		/// <summary>Создает связь между исходным объектом и целевой связью.</summary>
		/// <param name="source">Исходная связь.</param>
		/// <param name="relationship">Связь для источника.</param>
		/// <exception cref="T:System.ArgumentException">Связь не поддерживается службой.</exception>
		// Token: 0x0600253E RID: 9534 RVA: 0x00082FDC File Offset: 0x000811DC
		protected virtual void SetRelationship(MemberRelationship source, MemberRelationship relationship)
		{
			if (!relationship.IsEmpty && !this.SupportsRelationship(source, relationship))
			{
				string text = TypeDescriptor.GetComponentName(source.Owner);
				string text2 = TypeDescriptor.GetComponentName(relationship.Owner);
				if (text == null)
				{
					text = source.Owner.ToString();
				}
				if (text2 == null)
				{
					text2 = relationship.Owner.ToString();
				}
				throw new ArgumentException(SR.Format("Relationships between {0}.{1} and {2}.{3} are not supported.", new object[]
				{
					text,
					source.Member.Name,
					text2,
					relationship.Member.Name
				}));
			}
			if (this._relationships == null)
			{
				this._relationships = new Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>();
			}
			this._relationships[new MemberRelationshipService.RelationshipEntry(source)] = new MemberRelationshipService.RelationshipEntry(relationship);
		}

		/// <summary>Возвращает значение, определяющее, поддерживается ли заданная связь.</summary>
		/// <param name="source">Исходная связь.</param>
		/// <param name="relationship">Связь для источника.</param>
		/// <returns>Значение <see langword="true" />, если поддерживается связь между двумя заданными объектами; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600253F RID: 9535
		public abstract bool SupportsRelationship(MemberRelationship source, MemberRelationship relationship);

		// Token: 0x0400149A RID: 5274
		private Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry> _relationships = new Dictionary<MemberRelationshipService.RelationshipEntry, MemberRelationshipService.RelationshipEntry>();

		// Token: 0x0200048E RID: 1166
		private struct RelationshipEntry
		{
			// Token: 0x06002541 RID: 9537 RVA: 0x000830B2 File Offset: 0x000812B2
			internal RelationshipEntry(MemberRelationship rel)
			{
				this.Owner = new WeakReference(rel.Owner);
				this.Member = rel.Member;
				this._hashCode = ((rel.Owner == null) ? 0 : rel.Owner.GetHashCode());
			}

			// Token: 0x06002542 RID: 9538 RVA: 0x000830F4 File Offset: 0x000812F4
			public override bool Equals(object o)
			{
				if (o is MemberRelationshipService.RelationshipEntry)
				{
					MemberRelationshipService.RelationshipEntry re = (MemberRelationshipService.RelationshipEntry)o;
					return this == re;
				}
				return false;
			}

			// Token: 0x06002543 RID: 9539 RVA: 0x00083120 File Offset: 0x00081320
			public static bool operator ==(MemberRelationshipService.RelationshipEntry re1, MemberRelationshipService.RelationshipEntry re2)
			{
				object obj = re1.Owner.IsAlive ? re1.Owner.Target : null;
				object obj2 = re2.Owner.IsAlive ? re2.Owner.Target : null;
				return obj == obj2 && re1.Member.Equals(re2.Member);
			}

			// Token: 0x06002544 RID: 9540 RVA: 0x0008317A File Offset: 0x0008137A
			public static bool operator !=(MemberRelationshipService.RelationshipEntry re1, MemberRelationshipService.RelationshipEntry re2)
			{
				return !(re1 == re2);
			}

			// Token: 0x06002545 RID: 9541 RVA: 0x00083186 File Offset: 0x00081386
			public override int GetHashCode()
			{
				return this._hashCode;
			}

			// Token: 0x0400149B RID: 5275
			internal WeakReference Owner;

			// Token: 0x0400149C RID: 5276
			internal MemberDescriptor Member;

			// Token: 0x0400149D RID: 5277
			private int _hashCode;
		}
	}
}
