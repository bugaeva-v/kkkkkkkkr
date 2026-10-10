using System;
using System.Collections;
using Unity;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Поддерживает простой перебор коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />. Этот класс не наследуется.</summary>
	// Token: 0x020002E4 RID: 740
	public sealed class X509ExtensionEnumerator : IEnumerator
	{
		// Token: 0x0600178B RID: 6027 RVA: 0x0005D527 File Offset: 0x0005B727
		internal X509ExtensionEnumerator(ArrayList list)
		{
			this.enumerator = list.GetEnumerator();
		}

		/// <summary>Получает текущий элемент в объекте <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Текущий элемент в коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель помещается перед первым элементом коллекции или после последнего элемента.</exception>
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0005D53B File Offset: 0x0005B73B
		public X509Extension Current
		{
			get
			{
				return (X509Extension)this.enumerator.Current;
			}
		}

		/// <summary>Получает объект из коллекции.</summary>
		/// <returns>Текущий элемент в коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Перечислитель помещается перед первым элементом коллекции или после последнего элемента.</exception>
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0005D54D File Offset: 0x0005B74D
		object IEnumerator.Current
		{
			get
			{
				return this.enumerator.Current;
			}
		}

		/// <summary>Перемещает перечислитель к следующему элементу в коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
		// Token: 0x0600178E RID: 6030 RVA: 0x0005D55A File Offset: 0x0005B75A
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>Устанавливает перечислитель в исходное положение перед первым элементом в коллекции <see cref="T:System.Security.Cryptography.X509Certificates.X509ExtensionCollection" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">Коллекция была изменена после создания перечислителя.</exception>
		// Token: 0x0600178F RID: 6031 RVA: 0x0005D567 File Offset: 0x0005B767
		public void Reset()
		{
			this.enumerator.Reset();
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal X509ExtensionEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04000D2B RID: 3371
		private IEnumerator enumerator;
	}
}
