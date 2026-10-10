using System;
using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design.Serialization
{
	/// <summary>Предоставляет необходимые сведения для создания экземпляра объекта. Этот класс не наследуется.</summary>
	// Token: 0x0200048C RID: 1164
	public sealed class InstanceDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />, используя сведения и аргументы указанного элемента.</summary>
		/// <param name="member">Сведения элемента для дескриптора. Это может быть класс <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" />. Если это класс — <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" />, представляется элемент <see langword="static" />.</param>
		/// <param name="arguments">Коллекция аргументов, передаваемый элементу. Параметр принимает значение <see langword="null" /> или является пустой коллекцией, если аргументы отсутствуют. Коллекция может также содержать другие экземпляры класса <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" /> и не представляет участника <see langword="static" />.  
		/// -или- 
		/// Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.PropertyInfo" /> и не является считываемым.  
		/// -или- 
		/// Параметр <paramref name="member" /> имеет тип <see cref="T:System.Reflection.MethodInfo" /> или <see cref="T:System.Reflection.ConstructorInfo" />, а число аргументов в <paramref name="arguments" /> не соответствует сигнатуре объекта <paramref name="member" />.
		/// -или-
		/// Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.ConstructorInfo" /> и представляет участника <see langword="static" />.  
		/// -или- 
		/// Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.FieldInfo" />, а число аргументов в <paramref name="arguments" /> не равно нулю.</exception>
		// Token: 0x06002533 RID: 9523 RVA: 0x00082C83 File Offset: 0x00080E83
		public InstanceDescriptor(MemberInfo member, ICollection arguments) : this(member, arguments, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />, используя сведения указанного элемента, аргументы и значение, показывающее полноту описания экземпляра указанными сведениями.</summary>
		/// <param name="member">Сведения элемента для дескриптора. Это может быть класс <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" />. Если это класс — <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" />, представляется элемент <see langword="static" />.</param>
		/// <param name="arguments">Коллекция аргументов, передаваемый элементу. Параметр принимает значение <see langword="null" /> или является пустой коллекцией, если аргументы отсутствуют. Коллекция может также содержать другие экземпляры класса <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />.</param>
		/// <param name="isComplete">Значение <see langword="true" />, если указанные сведения полностью описывают экземпляр; в противном случае — <see langword="false" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" /> или <see cref="T:System.Reflection.PropertyInfo" /> и не представляет участника <see langword="static" /> 
		///  Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.PropertyInfo" /> и не является считываемым.  
		///  Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.MethodInfo" /> или <see cref="T:System.Reflection.ConstructorInfo" />, а число аргументов в <paramref name="arguments" /> не соответствует подписи параметра <paramref name="member" />.  
		///  Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.ConstructorInfo" /> и представляет участника <see langword="static" /> 
		///  Параметр <paramref name="member" /> является типом класса <see cref="T:System.Reflection.FieldInfo" />, а число аргументов в <paramref name="arguments" /> не равно нулю.</exception>
		// Token: 0x06002534 RID: 9524 RVA: 0x00082C90 File Offset: 0x00080E90
		public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
		{
			this.MemberInfo = member;
			this.IsComplete = isComplete;
			if (arguments == null)
			{
				this.Arguments = Array.Empty<object>();
			}
			else
			{
				object[] array = new object[arguments.Count];
				arguments.CopyTo(array, 0);
				this.Arguments = array;
			}
			if (member is FieldInfo)
			{
				if (!((FieldInfo)member).IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
				if (this.Arguments.Count != 0)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is ConstructorInfo)
			{
				ConstructorInfo constructorInfo = (ConstructorInfo)member;
				if (constructorInfo.IsStatic)
				{
					throw new ArgumentException("Parameter cannot be static.");
				}
				if (this.Arguments.Count != constructorInfo.GetParameters().Length)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is MethodInfo)
			{
				MethodInfo methodInfo = (MethodInfo)member;
				if (!methodInfo.IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
				if (this.Arguments.Count != methodInfo.GetParameters().Length)
				{
					throw new ArgumentException("Length mismatch.");
				}
			}
			else if (member is PropertyInfo)
			{
				PropertyInfo propertyInfo = (PropertyInfo)member;
				if (!propertyInfo.CanRead)
				{
					throw new ArgumentException("Parameter must be readable.");
				}
				MethodInfo getMethod = propertyInfo.GetGetMethod();
				if (getMethod != null && !getMethod.IsStatic)
				{
					throw new ArgumentException("Parameter must be static.");
				}
			}
		}

		/// <summary>Возвращает коллекцию аргументов, который можно использовать для восстановления экземпляра объекта, представляемого данным дескриптором экземпляра.</summary>
		/// <returns>Коллекция аргументов <see cref="T:System.Collections.ICollection" />, используемый для создания объекта.</returns>
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002535 RID: 9525 RVA: 0x00082DE1 File Offset: 0x00080FE1
		public ICollection Arguments { get; }

		/// <summary>Возвращает значение, показывающее полноту определения экземпляра содержимым класса <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />.</summary>
		/// <returns>Значение <see langword="true" />, если описание экземпляра полное; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x00082DE9 File Offset: 0x00080FE9
		public bool IsComplete { get; }

		/// <summary>Возвращает сведения элемента, описывающие экземпляр, с которым связан данный дескриптор.</summary>
		/// <returns>Класс <see cref="T:System.Reflection.MemberInfo" />, описывающий экземпляр, с которым связан данный объект.</returns>
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002537 RID: 9527 RVA: 0x00082DF1 File Offset: 0x00080FF1
		public MemberInfo MemberInfo { get; }

		/// <summary>Вызывает дескриптор экземпляра и возвращает объект, который он описывает.</summary>
		/// <returns>Объект, который описывается дескриптором данного экземпляра.</returns>
		// Token: 0x06002538 RID: 9528 RVA: 0x00082DFC File Offset: 0x00080FFC
		public object Invoke()
		{
			object[] array = new object[this.Arguments.Count];
			this.Arguments.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] is InstanceDescriptor)
				{
					array[i] = ((InstanceDescriptor)array[i]).Invoke();
				}
			}
			if (this.MemberInfo is ConstructorInfo)
			{
				return ((ConstructorInfo)this.MemberInfo).Invoke(array);
			}
			if (this.MemberInfo is MethodInfo)
			{
				return ((MethodInfo)this.MemberInfo).Invoke(null, array);
			}
			if (this.MemberInfo is PropertyInfo)
			{
				return ((PropertyInfo)this.MemberInfo).GetValue(null, array);
			}
			if (this.MemberInfo is FieldInfo)
			{
				return ((FieldInfo)this.MemberInfo).GetValue(null);
			}
			return null;
		}
	}
}
