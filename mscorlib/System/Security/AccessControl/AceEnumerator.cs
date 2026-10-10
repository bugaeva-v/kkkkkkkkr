using System;
using System.Collections;
using Unity;

namespace System.Security.AccessControl
{
	/// <summary>Предоставляет возможность итерации по записям управления доступом (ACE) в списке управления доступом (ACL).</summary>
	// Token: 0x02000505 RID: 1285
	public sealed class AceEnumerator : IEnumerator
	{
		// Token: 0x06003343 RID: 13123 RVA: 0x000BC88A File Offset: 0x000BAA8A
		internal AceEnumerator(GenericAcl owner)
		{
			this.current = -1;
			base..ctor();
			this.owner = owner;
		}

		/// <summary>Получает текущий элемент в коллекции <see cref="T:System.Security.AccessControl.GenericAce" />. Это свойство получает версию объекта удобного типа.</summary>
		/// <returns>Текущий элемент коллекции <see cref="T:System.Security.AccessControl.GenericAce" />.</returns>
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003344 RID: 13124 RVA: 0x000BC8A0 File Offset: 0x000BAAA0
		public GenericAce Current
		{
			get
			{
				if (this.current >= 0)
				{
					return this.owner[this.current];
				}
				return null;
			}
		}

		/// <summary>Получает текущий элемент в коллекции.</summary>
		/// <returns>Текущий элемент в коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003345 RID: 13125 RVA: 0x000BC8BE File Offset: 0x000BAABE
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		/// <summary>Перемещает перечислитель к следующему элементу коллекции <see cref="T:System.Security.AccessControl.GenericAce" />.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x06003346 RID: 13126 RVA: 0x000BC8C6 File Offset: 0x000BAAC6
		public bool MoveNext()
		{
			if (this.current + 1 == this.owner.Count)
			{
				return false;
			}
			this.current++;
			return true;
		}

		/// <summary>Устанавливает перечислитель в исходное положение перед первым элементом коллекции <see cref="T:System.Security.AccessControl.GenericAce" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">После создания перечислителя семейство было изменено.</exception>
		// Token: 0x06003347 RID: 13127 RVA: 0x000BC8EE File Offset: 0x000BAAEE
		public void Reset()
		{
			this.current = -1;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000173AD File Offset: 0x000155AD
		internal AceEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400240F RID: 9231
		private GenericAcl owner;

		// Token: 0x04002410 RID: 9232
		private int current;
	}
}
