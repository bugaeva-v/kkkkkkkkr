using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.ReflectionModel
{
	/// <summary>Представляет объект <see cref="T:System.Reflection.MemberInfo" />, который не загружает сборки и не создает объекты до запроса.</summary>
	// Token: 0x0200006B RID: 107
	public struct LazyMemberInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo" />, представляющий указанный член.</summary>
		/// <param name="member">Представляемый член.</param>
		// Token: 0x060002AC RID: 684 RVA: 0x000086B8 File Offset: 0x000068B8
		public LazyMemberInfo(MemberInfo member)
		{
			Requires.NotNull<MemberInfo>(member, "member");
			LazyMemberInfo.EnsureSupportedMemberType(member.MemberType, "member");
			this._accessorsCreator = null;
			this._memberType = member.MemberType;
			MemberTypes memberType = this._memberType;
			if (memberType == MemberTypes.Event)
			{
				EventInfo eventInfo = (EventInfo)member;
				this._accessors = new MemberInfo[]
				{
					eventInfo.GetRaiseMethod(true),
					eventInfo.GetAddMethod(true),
					eventInfo.GetRemoveMethod(true)
				};
				return;
			}
			if (memberType == MemberTypes.Property)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				Assumes.NotNull<PropertyInfo>(propertyInfo);
				this._accessors = new MemberInfo[]
				{
					propertyInfo.GetGetMethod(true),
					propertyInfo.GetSetMethod(true)
				};
				return;
			}
			this._accessors = new MemberInfo[]
			{
				member
			};
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo" /> для члена указанного типа с заданными методами доступа.</summary>
		/// <param name="memberType">Тип представляемого члена.</param>
		/// <param name="accessors">Массив методов доступа для представляемого члена.</param>
		/// <exception cref="T:System.ArgumentException">Один или несколько объектов в <paramref name="accessors" /> являются недопустимыми средствами доступа для этого элемента.</exception>
		// Token: 0x060002AD RID: 685 RVA: 0x00008774 File Offset: 0x00006974
		public LazyMemberInfo(MemberTypes memberType, params MemberInfo[] accessors)
		{
			LazyMemberInfo.EnsureSupportedMemberType(memberType, "memberType");
			Requires.NotNull<MemberInfo[]>(accessors, "accessors");
			string message;
			if (!LazyMemberInfo.AreAccessorsValid(memberType, accessors, out message))
			{
				throw new ArgumentException(message, "accessors");
			}
			this._memberType = memberType;
			this._accessors = accessors;
			this._accessorsCreator = null;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo" /> для члена указанного типа с заданными методами доступа.</summary>
		/// <param name="memberType">Тип представляемого члена.</param>
		/// <param name="accessorsCreator">Функция, возвращаемое значение которой является коллекцией методов доступа для представляемого члена.</param>
		// Token: 0x060002AE RID: 686 RVA: 0x000087C3 File Offset: 0x000069C3
		public LazyMemberInfo(MemberTypes memberType, Func<MemberInfo[]> accessorsCreator)
		{
			LazyMemberInfo.EnsureSupportedMemberType(memberType, "memberType");
			Requires.NotNull<Func<MemberInfo[]>>(accessorsCreator, "accessorsCreator");
			this._memberType = memberType;
			this._accessors = null;
			this._accessorsCreator = accessorsCreator;
		}

		/// <summary>Получает тип представляемого члена.</summary>
		/// <returns>Тип представляемого члена.</returns>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002AF RID: 687 RVA: 0x000087F0 File Offset: 0x000069F0
		public MemberTypes MemberType
		{
			get
			{
				return this._memberType;
			}
		}

		/// <summary>Получает массив методов доступа для представляемого члена.</summary>
		/// <returns>Массив методов доступа для представляемого члена.</returns>
		/// <exception cref="T:System.ArgumentException">Один или несколько методов доступа в этом объекте недействительны.</exception>
		// Token: 0x060002B0 RID: 688 RVA: 0x000087F8 File Offset: 0x000069F8
		public MemberInfo[] GetAccessors()
		{
			if (this._accessors == null && this._accessorsCreator != null)
			{
				MemberInfo[] accessors = this._accessorsCreator();
				string message;
				if (!LazyMemberInfo.AreAccessorsValid(this.MemberType, accessors, out message))
				{
					throw new InvalidOperationException(message);
				}
				this._accessors = accessors;
			}
			return this._accessors;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>32-разрядное целое число со знаком, являющееся хэш-кодом для данного экземпляра.</returns>
		// Token: 0x060002B1 RID: 689 RVA: 0x00008848 File Offset: 0x00006A48
		public override int GetHashCode()
		{
			if (this._accessorsCreator != null)
			{
				return this.MemberType.GetHashCode() ^ this._accessorsCreator.GetHashCode();
			}
			Assumes.NotNull<MemberInfo[]>(this._accessors);
			Assumes.NotNull<MemberInfo>(this._accessors[0]);
			return this.MemberType.GetHashCode() ^ this._accessors[0].GetHashCode();
		}

		/// <summary>Указывает, равен ли этот экземпляр заданному объекту.</summary>
		/// <param name="obj">Другой объект, подлежащий сравнению.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="obj" /> и данный экземпляр относятся к одному типу и представляют одинаковые значения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002B2 RID: 690 RVA: 0x000088B8 File Offset: 0x00006AB8
		public override bool Equals(object obj)
		{
			LazyMemberInfo lazyMemberInfo = (LazyMemberInfo)obj;
			if (this._memberType != lazyMemberInfo._memberType)
			{
				return false;
			}
			if (this._accessorsCreator != null || lazyMemberInfo._accessorsCreator != null)
			{
				return object.Equals(this._accessorsCreator, lazyMemberInfo._accessorsCreator);
			}
			Assumes.NotNull<MemberInfo[]>(this._accessors);
			Assumes.NotNull<MemberInfo[]>(lazyMemberInfo._accessors);
			return this._accessors.SequenceEqual(lazyMemberInfo._accessors);
		}

		/// <summary>Определяет, равны ли два указанных объекта <see cref="T:System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo" />.</summary>
		/// <param name="left">Первый проверяемый объект.</param>
		/// <param name="right">Второй проверяемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объекты равны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002B3 RID: 691 RVA: 0x00008925 File Offset: 0x00006B25
		public static bool operator ==(LazyMemberInfo left, LazyMemberInfo right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет, различаются ли два указанных объекта <see cref="T:System.ComponentModel.Composition.ReflectionModel.LazyMemberInfo" />.</summary>
		/// <param name="left">Первый проверяемый объект.</param>
		/// <param name="right">Второй проверяемый объект.</param>
		/// <returns>Значение <see langword="true" />, если объекты равны, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060002B4 RID: 692 RVA: 0x0000893A File Offset: 0x00006B3A
		public static bool operator !=(LazyMemberInfo left, LazyMemberInfo right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00008954 File Offset: 0x00006B54
		private static void EnsureSupportedMemberType(MemberTypes memberType, string argument)
		{
			MemberTypes enumFlagSet = MemberTypes.All;
			Requires.IsInMembertypeSet(memberType, argument, enumFlagSet);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00008970 File Offset: 0x00006B70
		private static bool AreAccessorsValid(MemberTypes memberType, MemberInfo[] accessors, out string errorMessage)
		{
			errorMessage = string.Empty;
			if (accessors == null)
			{
				errorMessage = Strings.LazyMemberInfo_AccessorsNull;
				return false;
			}
			if (accessors.All((MemberInfo accessor) => accessor == null))
			{
				errorMessage = Strings.LazyMemberInfo_NoAccessors;
				return false;
			}
			if (memberType != MemberTypes.Event)
			{
				if (memberType == MemberTypes.Property)
				{
					if (accessors.Length != 2)
					{
						errorMessage = Strings.LazyMemberInfo_InvalidPropertyAccessors_Cardinality;
						return false;
					}
					if ((from accessor in accessors
					where accessor != null && accessor.MemberType != MemberTypes.Method
					select accessor).Any<MemberInfo>())
					{
						errorMessage = Strings.LazyMemberinfo_InvalidPropertyAccessors_AccessorType;
						return false;
					}
				}
				else if (accessors.Length != 1 || (accessors.Length == 1 && accessors[0].MemberType != memberType))
				{
					errorMessage = string.Format(CultureInfo.CurrentCulture, Strings.LazyMemberInfo_InvalidAccessorOnSimpleMember, memberType);
					return false;
				}
			}
			else
			{
				if (accessors.Length != 3)
				{
					errorMessage = Strings.LazyMemberInfo_InvalidEventAccessors_Cardinality;
					return false;
				}
				if ((from accessor in accessors
				where accessor != null && accessor.MemberType != MemberTypes.Method
				select accessor).Any<MemberInfo>())
				{
					errorMessage = Strings.LazyMemberinfo_InvalidEventAccessors_AccessorType;
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000124 RID: 292
		private readonly MemberTypes _memberType;

		// Token: 0x04000125 RID: 293
		private MemberInfo[] _accessors;

		// Token: 0x04000126 RID: 294
		private readonly Func<MemberInfo[]> _accessorsCreator;
	}
}
