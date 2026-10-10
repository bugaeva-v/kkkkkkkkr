using System;
using System.Collections;
using System.Runtime.InteropServices;
using Unity;

namespace System.Security.Permissions
{
	/// <summary>Представляет перечислитель для объектов <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> в <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryCollection" />.</summary>
	// Token: 0x02000448 RID: 1096
	[ComVisible(true)]
	[Serializable]
	public sealed class KeyContainerPermissionAccessEntryEnumerator : IEnumerator
	{
		// Token: 0x06002C78 RID: 11384 RVA: 0x0009FBC9 File Offset: 0x0009DDC9
		internal KeyContainerPermissionAccessEntryEnumerator(ArrayList list)
		{
			this.e = list.GetEnumerator();
		}

		/// <summary>Получает текущую запись в коллекции.</summary>
		/// <returns>Текущий объект <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> в коллекции.</returns>
		/// <exception cref="T:System.InvalidOperationException">Обращение к свойству <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator.Current" /> осуществляется перед первым вызовом метода <see cref="M:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator.MoveNext" />. Курсор располагается перед первым объектом в коллекции.  
		///
		/// или - 
		/// При обращении к свойству <see cref="P:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator.Current" /> после вызова метода <see cref="M:System.Security.Permissions.KeyContainerPermissionAccessEntryEnumerator.MoveNext" /> возвращается значение <see langword="false" />, указывающее, что курсор расположен после последнего объекта коллекции.</exception>
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x0009FBDD File Offset: 0x0009DDDD
		public KeyContainerPermissionAccessEntry Current
		{
			get
			{
				return (KeyContainerPermissionAccessEntry)this.e.Current;
			}
		}

		/// <summary>Возвращает текущий объект в коллекции.</summary>
		/// <returns>Текущий объект в коллекции.</returns>
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x0009FBEF File Offset: 0x0009DDEF
		object IEnumerator.Current
		{
			get
			{
				return this.e.Current;
			}
		}

		/// <summary>Переходит к следующему элементу в коллекции.</summary>
		/// <returns>Значение <see langword="true" />, если перечислитель был успешно перемещен к следующему элементу; значение <see langword="false" />, если перечислитель достиг конца коллекции.</returns>
		// Token: 0x06002C7B RID: 11387 RVA: 0x0009FBFC File Offset: 0x0009DDFC
		public bool MoveNext()
		{
			return this.e.MoveNext();
		}

		/// <summary>Устанавливает перечислитель в начало коллекции.</summary>
		// Token: 0x06002C7C RID: 11388 RVA: 0x0009FC09 File Offset: 0x0009DE09
		public void Reset()
		{
			this.e.Reset();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000173AD File Offset: 0x000155AD
		internal KeyContainerPermissionAccessEntryEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002054 RID: 8276
		private IEnumerator e;
	}
}
