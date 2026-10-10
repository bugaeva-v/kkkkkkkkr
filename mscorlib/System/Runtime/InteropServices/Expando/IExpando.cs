using System;
using System.Reflection;

namespace System.Runtime.InteropServices.Expando
{
	/// <summary>Позволяет вносить в объект изменения, добавляя и удаляя его элементы, представленные объектом <see cref="T:System.Reflection.MemberInfo" />.</summary>
	// Token: 0x0200079B RID: 1947
	[ComVisible(true)]
	[Guid("AFBF15E6-C37C-11d2-B88E-00A0C9B471B8")]
	public interface IExpando : IReflect
	{
		/// <summary>Добавляет именованное поле к объекту Reflection.</summary>
		/// <param name="name">Имя поля.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий добавленное поле.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see langword="IExpando" /> не поддерживает данный метод.</exception>
		// Token: 0x060044F0 RID: 17648
		FieldInfo AddField(string name);

		/// <summary>Добавляет именованное свойство к объекту Reflection.</summary>
		/// <param name="name">Имя свойства.</param>
		/// <returns>Объект <see langword="PropertyInfo" />, представляющий добавленное свойство.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see langword="IExpando" /> не поддерживает данный метод.</exception>
		// Token: 0x060044F1 RID: 17649
		PropertyInfo AddProperty(string name);

		/// <summary>Добавляет именованный метод к объекту Reflection.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="method">Делегат для метода.</param>
		/// <returns>Объект <see langword="MethodInfo" />, представляющий добавленный метод.</returns>
		/// <exception cref="T:System.NotSupportedException">Объект <see langword="IExpando" /> не поддерживает данный метод.</exception>
		// Token: 0x060044F2 RID: 17650
		MethodInfo AddMethod(string name, Delegate method);

		/// <summary>Удаляет указанный элемент.</summary>
		/// <param name="m">Удаляемый элемент.</param>
		/// <exception cref="T:System.NotSupportedException">Объект <see langword="IExpando" /> не поддерживает данный метод.</exception>
		// Token: 0x060044F3 RID: 17651
		void RemoveMember(MemberInfo m);
	}
}
