using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System
{
	/// <summary>Представляет групповой делегат, то есть делегат, имеющий в своем списке вызовов более одного элемента.</summary>
	// Token: 0x02000243 RID: 579
	[ComVisible(true)]
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class MulticastDelegate : Delegate
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MulticastDelegate" />.</summary>
		/// <param name="target">Объект, для которого определен метод <paramref name="method" />.</param>
		/// <param name="method">Имя метода, для которого создается делегат.</param>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A4E RID: 6734 RVA: 0x0006107C File Offset: 0x0005F27C
		protected MulticastDelegate(object target, string method) : base(target, method)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.MulticastDelegate" />.</summary>
		/// <param name="target">Объект, для которого определен метод <paramref name="method" />.</param>
		/// <param name="method">Имя статического метода, для которого создается делегат.</param>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A4F RID: 6735 RVA: 0x00061086 File Offset: 0x0005F286
		protected MulticastDelegate(Type target, string method) : base(target, method)
		{
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> всеми данными, необходимыми для сериализации данного экземпляра.</summary>
		/// <param name="info">Объект, который содержит все данные, необходимые для сериализации и десериализации данного экземпляра.</param>
		/// <param name="context">(Зарезервировано.) Область, где хранятся и откуда извлекаются сериализованные данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Произошла ошибка сериализации.</exception>
		// Token: 0x06001A50 RID: 6736 RVA: 0x00061090 File Offset: 0x0005F290
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0006109C File Offset: 0x0005F29C
		protected sealed override object DynamicInvokeImpl(object[] args)
		{
			if (this.delegates == null)
			{
				return base.DynamicInvokeImpl(args);
			}
			int num = 0;
			int num2 = this.delegates.Length;
			object result;
			do
			{
				result = this.delegates[num].DynamicInvoke(args);
			}
			while (++num < num2);
			return result;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000610DC File Offset: 0x0005F2DC
		internal bool HasSingleTarget
		{
			get
			{
				return this.delegates == null;
			}
		}

		/// <summary>Определяет, равны ли этот групповой делегат и указанный объект.</summary>
		/// <param name="obj">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> и данный экземпляр имеют одинаковые списки вызовов; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A53 RID: 6739 RVA: 0x000610E8 File Offset: 0x0005F2E8
		public sealed override bool Equals(object obj)
		{
			if (!base.Equals(obj))
			{
				return false;
			}
			MulticastDelegate multicastDelegate = obj as MulticastDelegate;
			if (multicastDelegate == null)
			{
				return false;
			}
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				return true;
			}
			if (this.delegates == null ^ multicastDelegate.delegates == null)
			{
				return false;
			}
			if (this.delegates.Length != multicastDelegate.delegates.Length)
			{
				return false;
			}
			for (int i = 0; i < this.delegates.Length; i++)
			{
				if (!this.delegates[i].Equals(multicastDelegate.delegates[i]))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A54 RID: 6740 RVA: 0x00061176 File Offset: 0x0005F376
		public sealed override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Возвращает статический метод, представленный текущим <see cref="T:System.MulticastDelegate" />.</summary>
		/// <returns>Статический метод, представленный текущим <see cref="T:System.MulticastDelegate" />.</returns>
		// Token: 0x06001A55 RID: 6741 RVA: 0x0006117E File Offset: 0x0005F37E
		protected override MethodInfo GetMethodImpl()
		{
			if (this.delegates != null)
			{
				return this.delegates[this.delegates.Length - 1].Method;
			}
			return base.GetMethodImpl();
		}

		/// <summary>Возвращает список вызовов данного группового делегата в порядке вызова.</summary>
		/// <returns>Массив делегатов, списки вызовов которых совпадают со списком вызовов данного экземпляра.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A56 RID: 6742 RVA: 0x000611A5 File Offset: 0x0005F3A5
		public sealed override Delegate[] GetInvocationList()
		{
			if (this.delegates != null)
			{
				return (Delegate[])this.delegates.Clone();
			}
			return new Delegate[]
			{
				this
			};
		}

		/// <summary>Объединяет данный делегат <see cref="T:System.Delegate" /> с указанным делегатом <see cref="T:System.Delegate" /> для формирования нового делегата.</summary>
		/// <param name="follow">Делегат для комбинирования с данным делегатом.</param>
		/// <returns>Делегат, являющийся новым корнем списка вызовов <see cref="T:System.MulticastDelegate" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="follow" /> имеет не тот тип, что данный экземпляр.</exception>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A57 RID: 6743 RVA: 0x000611CC File Offset: 0x0005F3CC
		protected sealed override Delegate CombineImpl(Delegate follow)
		{
			if (follow == null)
			{
				return this;
			}
			MulticastDelegate multicastDelegate = (MulticastDelegate)follow;
			MulticastDelegate multicastDelegate2 = Delegate.AllocDelegateLike_internal(this);
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[]
				{
					this,
					multicastDelegate
				};
			}
			else if (this.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[1 + multicastDelegate.delegates.Length];
				multicastDelegate2.delegates[0] = this;
				Array.Copy(multicastDelegate.delegates, 0, multicastDelegate2.delegates, 1, multicastDelegate.delegates.Length);
			}
			else if (multicastDelegate.delegates == null)
			{
				multicastDelegate2.delegates = new Delegate[this.delegates.Length + 1];
				Array.Copy(this.delegates, 0, multicastDelegate2.delegates, 0, this.delegates.Length);
				multicastDelegate2.delegates[multicastDelegate2.delegates.Length - 1] = multicastDelegate;
			}
			else
			{
				multicastDelegate2.delegates = new Delegate[this.delegates.Length + multicastDelegate.delegates.Length];
				Array.Copy(this.delegates, 0, multicastDelegate2.delegates, 0, this.delegates.Length);
				Array.Copy(multicastDelegate.delegates, 0, multicastDelegate2.delegates, this.delegates.Length, multicastDelegate.delegates.Length);
			}
			return multicastDelegate2;
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00061304 File Offset: 0x0005F504
		private int LastIndexOf(Delegate[] haystack, Delegate[] needle)
		{
			if (haystack.Length < needle.Length)
			{
				return -1;
			}
			if (haystack.Length == needle.Length)
			{
				for (int i = 0; i < haystack.Length; i++)
				{
					if (!haystack[i].Equals(needle[i]))
					{
						return -1;
					}
				}
				return 0;
			}
			int num;
			for (int j = haystack.Length - needle.Length; j >= 0; j -= num + 1)
			{
				num = 0;
				while (needle[num].Equals(haystack[j]))
				{
					if (num == needle.Length - 1)
					{
						return j - num;
					}
					j++;
					num++;
				}
			}
			return -1;
		}

		/// <summary>Удаляет элемент, равный указанному делегату, из списка вызовов данного <see cref="T:System.MulticastDelegate" />.</summary>
		/// <param name="value">Делегат, который нужно найти в списке вызовов.</param>
		/// <returns>Если <paramref name="value" /> обнаружен в списке вызовов данного экземпляра, то новый <see cref="T:System.Delegate" /> без <paramref name="value" /> в списке вызовов; в противном случае — данный экземпляр со своим исходным списком вызовов.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A59 RID: 6745 RVA: 0x0006137C File Offset: 0x0005F57C
		protected sealed override Delegate RemoveImpl(Delegate value)
		{
			if (value == null)
			{
				return this;
			}
			MulticastDelegate multicastDelegate = (MulticastDelegate)value;
			if (this.delegates == null && multicastDelegate.delegates == null)
			{
				if (!this.Equals(multicastDelegate))
				{
					return this;
				}
				return null;
			}
			else
			{
				if (this.delegates == null)
				{
					foreach (Delegate obj in multicastDelegate.delegates)
					{
						if (this.Equals(obj))
						{
							return null;
						}
					}
					return this;
				}
				if (multicastDelegate.delegates == null)
				{
					int num = Array.LastIndexOf<Delegate>(this.delegates, multicastDelegate);
					if (num == -1)
					{
						return this;
					}
					if (this.delegates.Length <= 1)
					{
						throw new InvalidOperationException();
					}
					if (this.delegates.Length == 2)
					{
						return this.delegates[(num == 0) ? 1 : 0];
					}
					MulticastDelegate multicastDelegate2 = Delegate.AllocDelegateLike_internal(this);
					multicastDelegate2.delegates = new Delegate[this.delegates.Length - 1];
					Array.Copy(this.delegates, multicastDelegate2.delegates, num);
					Array.Copy(this.delegates, num + 1, multicastDelegate2.delegates, num, this.delegates.Length - num - 1);
					return multicastDelegate2;
				}
				else
				{
					if (this.delegates.Equals(multicastDelegate.delegates))
					{
						return null;
					}
					int num2 = this.LastIndexOf(this.delegates, multicastDelegate.delegates);
					if (num2 == -1)
					{
						return this;
					}
					MulticastDelegate multicastDelegate3 = Delegate.AllocDelegateLike_internal(this);
					multicastDelegate3.delegates = new Delegate[this.delegates.Length - multicastDelegate.delegates.Length];
					Array.Copy(this.delegates, multicastDelegate3.delegates, num2);
					Array.Copy(this.delegates, num2 + multicastDelegate.delegates.Length, multicastDelegate3.delegates, num2, this.delegates.Length - num2 - multicastDelegate.delegates.Length);
					return multicastDelegate3;
				}
			}
		}

		/// <summary>Определяет равенство двух объектов <see cref="T:System.MulticastDelegate" />.</summary>
		/// <param name="d1">Левый операнд.</param>
		/// <param name="d2">Правый операнд.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="d1" /> и <paramref name="d2" /> имеют одинаковые списки вызовов; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A5A RID: 6746 RVA: 0x00061524 File Offset: 0x0005F724
		public static bool operator ==(MulticastDelegate d1, MulticastDelegate d2)
		{
			if (d1 == null)
			{
				return d2 == null;
			}
			return d1.Equals(d2);
		}

		/// <summary>Определяет, отличаются ли два объекта <see cref="T:System.MulticastDelegate" />.</summary>
		/// <param name="d1">Левый операнд.</param>
		/// <param name="d2">Правый операнд.</param>
		/// <returns>
		///   <see langword="true" />, если списки вызовов <paramref name="d1" /> и <paramref name="d2" /> различаются; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.MemberAccessException">Невозможно создать экземпляр абстрактного класса, или этот элемент был вызван с помощь механизма позднего связывания.</exception>
		// Token: 0x06001A5B RID: 6747 RVA: 0x00061535 File Offset: 0x0005F735
		public static bool operator !=(MulticastDelegate d1, MulticastDelegate d2)
		{
			if (d1 == null)
			{
				return d2 != null;
			}
			return !d1.Equals(d2);
		}

		// Token: 0x04001732 RID: 5938
		private Delegate[] delegates;
	}
}
