using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Unity;

namespace System.Reflection
{
	/// <summary>Выполняет отражение для модуля.</summary>
	// Token: 0x020008B1 RID: 2225
	[Serializable]
	[StructLayout(LayoutKind.Sequential)]
	public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
	{
		/// <summary>Возвращает соответствующую сборку <see cref="T:System.Reflection.Assembly" /> для данного экземпляра <see cref="T:System.Reflection.Module" />.</summary>
		/// <returns>Объект <see langword="Assembly" />.</returns>
		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06004974 RID: 18804 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Assembly Assembly
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает строку, содержащую полное имя и путь к этому модулю.</summary>
		/// <returns>Полное имя модуля.</returns>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствуют необходимые разрешения.</exception>
		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06004975 RID: 18805 RVA: 0x00047226 File Offset: 0x00045426
		public virtual string FullyQualifiedName
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает строку <see langword="String" />, представляющую имя модуля без пути.</summary>
		/// <returns>Имя модуля без пути.</returns>
		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06004976 RID: 18806 RVA: 0x00047226 File Offset: 0x00045426
		public virtual string Name
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает версию потока метаданных.</summary>
		/// <returns>32-разрядное целое число, представляющее версию потока метаданных. Два байта старшего разряда представляют основной номер версии, а два байта младшего разряда — дополнительный.</returns>
		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06004977 RID: 18807 RVA: 0x00047226 File Offset: 0x00045426
		public virtual int MDStreamVersion
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает универсальный уникальный идентификатор (UUID), по которому можно различить две версии модуля.</summary>
		/// <returns>Значение свойства <see cref="T:System.Guid" />, по которому можно различить две версии модуля.</returns>
		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06004978 RID: 18808 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Guid ModuleVersionId
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает строку, представляющую имя модуля.</summary>
		/// <returns>Имя модуля.</returns>
		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06004979 RID: 18809 RVA: 0x00047226 File Offset: 0x00045426
		public virtual string ScopeName
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает дескриптор модуля.</summary>
		/// <returns>Структура <see cref="T:System.ModuleHandle" /> для текущего модуля.</returns>
		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x000EEEC6 File Offset: 0x000ED0C6
		public ModuleHandle ModuleHandle
		{
			get
			{
				return this.GetModuleHandleImpl();
			}
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x000EEECE File Offset: 0x000ED0CE
		internal virtual ModuleHandle GetModuleHandleImpl()
		{
			return ModuleHandle.EmptyHandle;
		}

		/// <summary>Возвращает пару значений, определяющих природу кода в модуле и платформе, на которой применяется этот модуль.</summary>
		/// <param name="peKind">Этот метод возвращает сочетание значений <see cref="T:System.Reflection.PortableExecutableKinds" />, определяющее характер кода в модуле.</param>
		/// <param name="machine">Этот метод возвращает одно из значений <see cref="T:System.Reflection.ImageFileMachine" />, определяющее платформу, на которой применяется модуль.</param>
		// Token: 0x0600497C RID: 18812 RVA: 0x00047226 File Offset: 0x00045426
		public virtual void GetPEKind(out PortableExecutableKinds peKind, out ImageFileMachine machine)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает значение, указывающее, является ли объект ресурсом.</summary>
		/// <returns>Значение <see langword="true" />, если объект является ресурсом; в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600497D RID: 18813 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsResource()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает значение, обозначающее, применен ли к этому модулю указанный тип атрибутов.</summary>
		/// <param name="attributeType">Тип настраиваемого атрибута для проверки.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Значение <see langword="true" />, если к этому модулю применен один или несколько экземпляров <paramref name="attributeType" />, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является объектом <see cref="T:System.Type" />, предоставляемым средой выполнения. Например, <paramref name="attributeType" /> является объектом <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x0600497E RID: 18814 RVA: 0x00047226 File Offset: 0x00045426
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Получает коллекцию, содержащая пользовательские атрибуты этого модуля.</summary>
		/// <returns>Коллекция, содержащая пользовательские атрибуты этого модуля.</returns>
		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x0600497F RID: 18815 RVA: 0x000EEED5 File Offset: 0x000ED0D5
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		/// <summary>Возвращает список объектов <see cref="T:System.Reflection.CustomAttributeData" /> для текущего модуля, который можно использовать в контексте, предназначенном только для отражения.</summary>
		/// <returns>Универсальный список объектов <see cref="T:System.Reflection.CustomAttributeData" />, представляющих данные об атрибутах, которые были применены к текущему модулю.</returns>
		// Token: 0x06004980 RID: 18816 RVA: 0x00047226 File Offset: 0x00045426
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает все настраиваемые атрибуты.</summary>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив типа <see langword="Object" />, содержащий все настраиваемые атрибуты.</returns>
		// Token: 0x06004981 RID: 18817 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает настраиваемые атрибуты заданного типа.</summary>
		/// <param name="attributeType">Тип возвращаемого атрибута.</param>
		/// <param name="inherit">Данный аргумент не учитывается для объектов этого типа.</param>
		/// <returns>Массив объектов типа <see langword="Object" />, содержащий все пользовательские атрибуты заданного типа.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="attributeType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="attributeType" /> не является объектом <see cref="T:System.Type" />, предоставляемым средой выполнения. Например, <paramref name="attributeType" /> является объектом <see cref="T:System.Reflection.Emit.TypeBuilder" />.</exception>
		// Token: 0x06004982 RID: 18818 RVA: 0x00047226 File Offset: 0x00045426
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает метод с указанным именем.</summary>
		/// <param name="name">Имя метода.</param>
		/// <returns>Объект <see langword="MethodInfo" /> с указанным именем или <see langword="null" />, если метод не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004983 RID: 18819 RVA: 0x000EEEDD File Offset: 0x000ED0DD
		public MethodInfo GetMethod(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			return this.GetMethodImpl(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, null, null);
		}

		/// <summary>Возвращает метод, имеющий указанные имя и типы параметров.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="types">Искомые типы параметров.</param>
		/// <returns>Объект <see langword="MethodInfo" /> в соответствии с указанными условиями или <see langword="null" />, если метод не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> имеет значение <see langword="null" />, <paramref name="types" /> имеет значение <see langword="null" /> или <paramref name="types" /> (i) имеет значение <see langword="null" />.</exception>
		// Token: 0x06004984 RID: 18820 RVA: 0x000EEEFA File Offset: 0x000ED0FA
		public MethodInfo GetMethod(string name, Type[] types)
		{
			return this.GetMethod(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public, null, CallingConventions.Any, types, null);
		}

		/// <summary>Возвращает метод, имеющий заданное имя, сведения о привязке, соглашение о вызовах и типы и модификаторы параметров.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="bindingAttr">Один из битовых флагов <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <param name="binder">Объект, реализующий <see langword="Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="callConvention">Соглашение о вызовах для метода.</param>
		/// <param name="types">Искомые типы параметров.</param>
		/// <param name="modifiers">Массив модификаторов параметров, используемый для работы привязки с подписями параметров, в которых были изменены типы.</param>
		/// <returns>Объект <see langword="MethodInfo" /> в соответствии с указанными условиями или <see langword="null" />, если метод не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> имеет значение <see langword="null" />, <paramref name="types" /> имеет значение <see langword="null" /> или <paramref name="types" /> (i) имеет значение <see langword="null" />.</exception>
		// Token: 0x06004985 RID: 18821 RVA: 0x000EEF0C File Offset: 0x000ED10C
		public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (types == null)
			{
				throw new ArgumentNullException("types");
			}
			for (int i = 0; i < types.Length; i++)
			{
				if (types[i] == null)
				{
					throw new ArgumentNullException("types");
				}
			}
			return this.GetMethodImpl(name, bindingAttr, binder, callConvention, types, modifiers);
		}

		/// <summary>Возвращает реализацию метода в соответствии с заданными критериями.</summary>
		/// <param name="name">Имя метода.</param>
		/// <param name="bindingAttr">Один из битовых флагов <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <param name="binder">Объект, реализующий <see langword="Binder" />, содержащий свойства, связанные с этим методом.</param>
		/// <param name="callConvention">Соглашение о вызовах для метода.</param>
		/// <param name="types">Искомые типы параметров.</param>
		/// <param name="modifiers">Массив модификаторов параметров, используемый для работы привязки с подписями параметров, в которых были изменены типы.</param>
		/// <returns>Объект <see langword="MethodInfo" />, содержащий заданные сведения о реализации, или <see langword="null" />, если метод не существует.</returns>
		/// <exception cref="T:System.Reflection.AmbiguousMatchException">Свойство <paramref name="types" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004986 RID: 18822 RVA: 0x00047226 File Offset: 0x00045426
		protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает глобальные методы, определенные в модуле.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.MethodInfo" />, представляющих все глобальные методы, определенные в модуле. Если глобальные методы отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x06004987 RID: 18823 RVA: 0x000EEF6B File Offset: 0x000ED16B
		public MethodInfo[] GetMethods()
		{
			return this.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Возвращает глобальные методы, определенные в модуле, которые соответствуют заданным флагам привязки.</summary>
		/// <param name="bindingFlags">Битовая комбинация значений <see cref="T:System.Reflection.BindingFlags" />, которая определяет границы поиска.</param>
		/// <returns>Массив типа <see cref="T:System.Reflection.MethodInfo" /> — представляет глобальные методы, определенные в модуле, который соответствует указанным флагам связывания. Если глобальные методы не соответствуют флагам привязки, возвращается пустой массив.</returns>
		// Token: 0x06004988 RID: 18824 RVA: 0x00047226 File Offset: 0x00045426
		public virtual MethodInfo[] GetMethods(BindingFlags bindingFlags)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает поле с указанным именем.</summary>
		/// <param name="name">Имя поля.</param>
		/// <returns>Объект <see langword="FieldInfo" /> с указанным именем или <see langword="null" />, если поле не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004989 RID: 18825 RVA: 0x000EEF75 File Offset: 0x000ED175
		public FieldInfo GetField(string name)
		{
			return this.GetField(name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Возвращает поле с указанным именем и атрибутами привязки.</summary>
		/// <param name="name">Имя поля.</param>
		/// <param name="bindingAttr">Один из битовых флагов <see langword="BindingFlags" />, используемых для управления поиском.</param>
		/// <returns>Объект <see langword="FieldInfo" /> с указанным именем и атрибутами привязки или <see langword="null" />, если поле не существует.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600498A RID: 18826 RVA: 0x00047226 File Offset: 0x00045426
		public virtual FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает глобальные поля, определенные в модуле.</summary>
		/// <returns>Массив объектов <see cref="T:System.Reflection.FieldInfo" />, представляющих глобальные поля, определенные в модуле. Если глобальные поля отсутствуют, возвращается пустой массив.</returns>
		// Token: 0x0600498B RID: 18827 RVA: 0x000EEF80 File Offset: 0x000ED180
		public FieldInfo[] GetFields()
		{
			return this.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
		}

		/// <summary>Возвращает глобальные поля, определенные в модуле, которые соответствуют заданным флагам привязки.</summary>
		/// <param name="bindingFlags">Битовая комбинация значений <see cref="T:System.Reflection.BindingFlags" />, которая определяет границы поиска.</param>
		/// <returns>Массив типа <see cref="T:System.Reflection.FieldInfo" />, представляющий глобальные поля, определенные в модуле, который соответствует указанным флагам привязки. Если глобальные поля не соответствуют флагам привязки, возвращается пустой массив.</returns>
		// Token: 0x0600498C RID: 18828 RVA: 0x00047226 File Offset: 0x00045426
		public virtual FieldInfo[] GetFields(BindingFlags bindingFlags)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает все типы, определенные в этом модуле.</summary>
		/// <returns>Массив типа <see langword="Type" />, содержащий типы, определенные в модуле, отраженном этим экземпляром.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Невозможно загрузить один или несколько классов в модуле.</exception>
		/// <exception cref="T:System.Security.SecurityException">У вызывающего объекта отсутствует необходимое разрешение.</exception>
		// Token: 0x0600498D RID: 18829 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type[] GetTypes()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает заданный тип (выполняет поиск с учетом регистра).</summary>
		/// <param name="className">Имя искомого типа. Имя должно содержать пространство имен.</param>
		/// <returns>Объект <see langword="Type" />, представляющий указанный тип, если тип находится в этом модуле. В противном случае возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываются инициализаторы класса и создается исключение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="className" /> представляет собой строку нулевой длины.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="className" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="className" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="className" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="className" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="className" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x0600498E RID: 18830 RVA: 0x000EEF8A File Offset: 0x000ED18A
		public virtual Type GetType(string className)
		{
			return this.GetType(className, false, false);
		}

		/// <summary>Возвращает указанный тип, выполняя поиск в модуле с заданным требованием к учету регистра.</summary>
		/// <param name="className">Имя искомого типа. Имя должно содержать пространство имен.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для поиска без учета регистра. В противном случае используется значение <see langword="false" />.</param>
		/// <returns>Объект <see langword="Type" />, представляющий указанный тип, если тип находится в этом модуле. В противном случае возвращается значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываются инициализаторы класса и создается исключение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="className" /> представляет собой строку нулевой длины.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="className" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="className" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="className" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="className" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="className" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x0600498F RID: 18831 RVA: 0x000EEF95 File Offset: 0x000ED195
		public virtual Type GetType(string className, bool ignoreCase)
		{
			return this.GetType(className, false, ignoreCase);
		}

		/// <summary>Возвращает указанный тип, определяя, следует ли учитывать регистр при поиске модуля и должно ли создаваться исключение, если не удалось обнаружить этот тип.</summary>
		/// <param name="className">Имя искомого типа. Имя должно содержать пространство имен.</param>
		/// <param name="throwOnError">Значение <see langword="true" />, чтобы создать исключение, если тип не удается найти; значение <see langword="false" />, чтобы вернуть значение <see langword="null" />.</param>
		/// <param name="ignoreCase">Значение <see langword="true" /> для поиска без учета регистра. В противном случае используется значение <see langword="false" />.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий указанный тип, если тип был объявлен в этом модуле; в противном случае — <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="className" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Reflection.TargetInvocationException">Вызываются инициализаторы класса и создается исключение.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="className" /> представляет собой строку нулевой длины.</exception>
		/// <exception cref="T:System.TypeLoadException">
		///   <paramref name="throwOnError" /> является <see langword="true" />, не удается найти тип.</exception>
		/// <exception cref="T:System.IO.FileNotFoundException">Для <paramref name="className" /> требуется зависимая сборка, которую не удается найти.</exception>
		/// <exception cref="T:System.IO.FileLoadException">Для <paramref name="className" /> требуется зависимая сборка, которая была найдена, но ее не удалось загрузить.  
		///
		/// или - 
		/// Текущая сборка была загружена в контекст только для отражения, а для <paramref name="className" /> требуется зависимая сборка, которая не была предварительно загружена.</exception>
		/// <exception cref="T:System.BadImageFormatException">Для <paramref name="className" /> требуется зависимая сборка, однако файл не является допустимой сборкой.  
		///
		/// или - 
		/// Для <paramref name="className" /> требуется зависимая сборка, которая была скомпилирована для версии среды выполнения более поздней, чем текущая загруженная версия.</exception>
		// Token: 0x06004990 RID: 18832 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type GetType(string className, bool throwOnError, bool ignoreCase)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает массив классов, удовлетворяющих указанному фильтру и критериям фильтра.</summary>
		/// <param name="filter">Делегат, который используется для фильтрования классов.</param>
		/// <param name="filterCriteria">Объект, который используется для фильтрования классов.</param>
		/// <returns>Массив типа <see langword="Type" />, который содержит классы, удовлетворяющие критериям фильтра.</returns>
		/// <exception cref="T:System.Reflection.ReflectionTypeLoadException">Невозможно загрузить один или несколько классов в модуле.</exception>
		// Token: 0x06004991 RID: 18833 RVA: 0x000EEFA0 File Offset: 0x000ED1A0
		public virtual Type[] FindTypes(TypeFilter filter, object filterCriteria)
		{
			Type[] types = this.GetTypes();
			int num = 0;
			for (int i = 0; i < types.Length; i++)
			{
				if (filter != null && !filter(types[i], filterCriteria))
				{
					types[i] = null;
				}
				else
				{
					num++;
				}
			}
			if (num == types.Length)
			{
				return types;
			}
			Type[] array = new Type[num];
			num = 0;
			for (int j = 0; j < types.Length; j++)
			{
				if (types[j] != null)
				{
					array[num++] = types[j];
				}
			}
			return array;
		}

		/// <summary>Возвращает токен, который определяет модуль в метаданных.</summary>
		/// <returns>Целочисленный токен, который идентифицирует текущий модуль в метаданных.</returns>
		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06004992 RID: 18834 RVA: 0x00047226 File Offset: 0x00045426
		public virtual int MetadataToken
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		/// <summary>Возвращает поле, определенное заданным токеном метаданных.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий поле в модуле.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, которое определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет поле, родительская спецификация <see langword="TypeSpec" /> которого имеет подпись, содержащую сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004993 RID: 18835 RVA: 0x000EF018 File Offset: 0x000ED218
		public FieldInfo ResolveField(int metadataToken)
		{
			return this.ResolveField(metadataToken, null, null);
		}

		/// <summary>Возвращает поле, определенное заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий поле в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.FieldInfo" />, представляющий поле, которое определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для поля в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет поле, родительская спецификация <see langword="TypeSpec" /> которого имеет подпись, содержащую сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для метода <paramref name="genericTypeArguments" /> или <paramref name="genericMethodArguments" /> не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004994 RID: 18836 RVA: 0x00047226 File Offset: 0x00045426
		public virtual FieldInfo ResolveField(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает тип члена, определенный заданным токеном метаданных.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий тип или член в модуле.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MemberInfo" />, представляющий тип члена, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа или члена в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> содержит объект <see langword="MethodSpec" /> или <see langword="TypeSpec" />, чья подпись содержит тип элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода).  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет свойство или событие.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004995 RID: 18837 RVA: 0x000EF023 File Offset: 0x000ED223
		public MemberInfo ResolveMember(int metadataToken)
		{
			return this.ResolveMember(metadataToken, null, null);
		}

		/// <summary>Возвращает тип или член, которые определены заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий тип или член в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MemberInfo" />, представляющий тип члена, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа или члена в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="MethodSpec" /> или <see langword="TypeSpec" />, подпись которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для метода <paramref name="genericTypeArguments" /> или <paramref name="genericMethodArguments" /> не предоставлены необходимые аргументы типа.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> определяет свойство или событие.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004996 RID: 18838 RVA: 0x00047226 File Offset: 0x00045426
		public virtual MemberInfo ResolveMember(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает метод или конструктор, определенный заданным токеном метаданных.</summary>
		/// <param name="metadataToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" />, представляющий метод или конструктор, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для метода или конструктора в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="MethodSpec" />, сигнатура которого содержит тип элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004997 RID: 18839 RVA: 0x000EF02E File Offset: 0x000ED22E
		public MethodBase ResolveMethod(int metadataToken)
		{
			return this.ResolveMethod(metadataToken, null, null);
		}

		/// <summary>Возвращает метод или конструктор, определенный заданным маркером метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">маркер метаданных, определяющий метод или конструктор в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" />, представляющий метод, определенный заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для метода или конструктора в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="MethodSpec" />, сигнатура которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для <paramref name="genericTypeArguments" />, <paramref name="genericMethodArguments" /> или обоих параметров не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004998 RID: 18840 RVA: 0x00047226 File Offset: 0x00045426
		public virtual MethodBase ResolveMethod(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает большой двоичный объект подписи, определенный токеном метаданных.</summary>
		/// <param name="metadataToken">токен метаданных, определяющий подпись в модуле.</param>
		/// <returns>Массив байтов, представляющий большой двоичный объект подписи.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является допустимым объектом <see langword="MemberRef" />, <see langword="MethodDef" />, <see langword="TypeSpec" />, сигнатурой или маркером <see langword="FieldDef" /> в области видимости текущего модуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x06004999 RID: 18841 RVA: 0x00047226 File Offset: 0x00045426
		public virtual byte[] ResolveSignature(int metadataToken)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает строку, определенную заданным маркером метаданных.</summary>
		/// <param name="metadataToken">маркер метаданных, определяющий строку в куче строк модуля.</param>
		/// <returns>Объект <see cref="T:System.String" />, содержащий строковое значение из кучи строк метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для строки в области текущего модуля.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x0600499A RID: 18842 RVA: 0x00047226 File Offset: 0x00045426
		public virtual string ResolveString(int metadataToken)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Возвращает тип, определенный заданным токеном метаданных.</summary>
		/// <param name="metadataToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="TypeSpec" />, сигнатура которого содержит тип элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода).</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x0600499B RID: 18843 RVA: 0x000EF039 File Offset: 0x000ED239
		public Type ResolveType(int metadataToken)
		{
			return this.ResolveType(metadataToken, null, null);
		}

		/// <summary>Возвращает тип, определенный заданным токеном метаданных, в контексте, определенном заданными параметрами универсального типа.</summary>
		/// <param name="metadataToken">Маркер метаданных, который определяет тип в модуле.</param>
		/// <param name="genericTypeArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для данного типа, если токен находится в области, либо значение <see langword="null" />, если этот тип не является универсальным.</param>
		/// <param name="genericMethodArguments">Массив объектов <see cref="T:System.Type" />, представляющих аргументы типа для метода, если токен находится в области, либо значение <see langword="null" />, если этот метод не является универсальным.</param>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип, который определяется заданным токеном метаданных.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="metadataToken" /> не является маркером для типа в области текущего модуля.  
		///
		/// или - 
		/// Параметр <paramref name="metadataToken" /> является объектом <see langword="TypeSpec" />, сигнатура которого содержит сведения о типе элемента <see langword="var" /> (параметр типа для универсального типа) или <see langword="mvar" /> (параметр типа для универсального метода), а для <paramref name="genericTypeArguments" />, <paramref name="genericMethodArguments" /> или обоих параметров не предоставлены необходимые аргументы типа.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Параметр <paramref name="metadataToken" /> не является допустимым маркером для поля в области текущего модуля.</exception>
		// Token: 0x0600499C RID: 18844 RVA: 0x00047226 File Offset: 0x00045426
		public virtual Type ResolveType(int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Обеспечивает реализацию класса <see cref="T:System.Runtime.Serialization.ISerializable" /> для сериализованных объектов.</summary>
		/// <param name="info">Сведения и данные, необходимые для выполнения сериализации и десериализации объекта.</param>
		/// <param name="context">Контекст для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600499D RID: 18845 RVA: 0x00047226 File Offset: 0x00045426
		[SecurityCritical]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Определяет, равны ли этот модуль и заданный объект.</summary>
		/// <param name="o">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="o" /> равно данному экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600499E RID: 18846 RVA: 0x00097E2A File Offset: 0x0009602A
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код в виде 32-разрядного целого числа со знаком.</returns>
		// Token: 0x0600499F RID: 18847 RVA: 0x000930E8 File Offset: 0x000912E8
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определение равенства двух объектов <see cref="T:System.Reflection.Module" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060049A0 RID: 18848 RVA: 0x00064560 File Offset: 0x00062760
		public static bool operator ==(Module left, Module right)
		{
			return left == right || (left != null && right != null && left.Equals(right));
		}

		/// <summary>Определяет неравенство двух объектов <see cref="T:System.Reflection.Module" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060049A1 RID: 18849 RVA: 0x000EF044 File Offset: 0x000ED244
		public static bool operator !=(Module left, Module right)
		{
			return !(left == right);
		}

		/// <summary>Возвращает имя модуля.</summary>
		/// <returns>Строка <see langword="String" />, представляющая имя этого модуля.</returns>
		// Token: 0x060049A2 RID: 18850 RVA: 0x000EF050 File Offset: 0x000ED250
		public override string ToString()
		{
			return this.ScopeName;
		}

		// Token: 0x060049A3 RID: 18851 RVA: 0x000EF058 File Offset: 0x000ED258
		private static bool FilterTypeNameImpl(Type cls, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				return cls.Name.StartsWith(text, StringComparison.Ordinal);
			}
			return cls.Name.Equals(text);
		}

		// Token: 0x060049A4 RID: 18852 RVA: 0x000EF0C8 File Offset: 0x000ED2C8
		private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria)
		{
			if (filterCriteria == null || !(filterCriteria is string))
			{
				throw new InvalidFilterCriteriaException("A String must be provided for the filter criteria.");
			}
			string text = (string)filterCriteria;
			if (text.Length > 0 && text[text.Length - 1] == '*')
			{
				text = text.Substring(0, text.Length - 1);
				string name = cls.Name;
				return name.Length >= text.Length && string.Compare(name, 0, text, 0, text.Length, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return string.Compare(text, cls.Name, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000EF158 File Offset: 0x000ED358
		internal Guid MvId
		{
			get
			{
				return this.GetModuleVersionId();
			}
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x000EF158 File Offset: 0x000ED358
		internal static Guid Mono_GetGuid(Module module)
		{
			return module.GetModuleVersionId();
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x000479F8 File Offset: 0x00045BF8
		internal virtual Guid GetModuleVersionId()
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает объект <see langword="X509Certificate" />, соответствующий сертификату, включаемому в подпись Authenticode сборки, которой принадлежит этот модуль. Если сборка не имеет подписи Authenticode, возвращается значение <see langword="null" />.</summary>
		/// <returns>Объект <see langword="X509Certificate" /> или значение <see langword="null" />, если сборка, содержащая этот модуль, не имеет подписи Authenticode.</returns>
		// Token: 0x060049A8 RID: 18856 RVA: 0x00047226 File Offset: 0x00045426
		public virtual X509Certificate GetSignerCertificate()
		{
			throw NotImplemented.ByDesign;
		}

		/// <summary>Сопоставляет набор имен соответствующему набору идентификаторов диспетчеризации.</summary>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="rgszNames">Переданный массив имен, которые необходимо сопоставить.</param>
		/// <param name="cNames">Количество сопоставляемых имен.</param>
		/// <param name="lcid">Контекст языкового стандарта для интерпретации имен.</param>
		/// <param name="rgDispId">Массив, зарезервированный вызывающим объектом, куда помещаются идентификаторы, соответствующие именам.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049AA RID: 18858 RVA: 0x000173AD File Offset: 0x000155AD
		void _Module.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает сведения о типе объекта, которые затем могут использоваться для получения сведений о типе интерфейса.</summary>
		/// <param name="iTInfo">Возвращаемые сведения о типе.</param>
		/// <param name="lcid">Идентификатор языкового стандарта для сведений о типе.</param>
		/// <param name="ppTInfo">Получает указатель на объект с запрошенными сведениями о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049AB RID: 18859 RVA: 0x000173AD File Offset: 0x000155AD
		void _Module.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Возвращает количество предоставляемых объектом интерфейсов для доступа к сведениям о типе (0 или 1).</summary>
		/// <param name="pcTInfo">Указатель, по которому записывается число предоставляемых объектом интерфейсов, предназначенных для получения сведений о типе.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049AC RID: 18860 RVA: 0x000173AD File Offset: 0x000155AD
		void _Module.GetTypeInfoCount(out uint pcTInfo)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Предоставляет доступ к открытым свойствам и методам объекта.</summary>
		/// <param name="dispIdMember">Идентифицирует член.</param>
		/// <param name="riid">Зарезервировано для будущего использования. Должно быть равным IID_NULL.</param>
		/// <param name="lcid">Контекст языкового стандарта, в котором следует интерпретировать аргументы.</param>
		/// <param name="wFlags">Флаги, описывающие контекст вызова.</param>
		/// <param name="pDispParams">Указатель на структуру, содержащую массив аргументов, массив DISPID для именованных аргументов, а также счетчики количества элементов в массивах.</param>
		/// <param name="pVarResult">Указатель, по которому будет сохранен результат.</param>
		/// <param name="pExcepInfo">Указатель на структуру, содержащую сведения об исключении.</param>
		/// <param name="puArgErr">Индекс первого аргумента, вызвавшего ошибку.</param>
		/// <exception cref="T:System.NotImplementedException">Доступ с поздним связыванием с помощью COM-интерфейса IDispatch не поддерживается.</exception>
		// Token: 0x060049AD RID: 18861 RVA: 0x000173AD File Offset: 0x000155AD
		void _Module.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>Объект <see langword="TypeFilter" />, который фильтрует список типов, определенных в этом модуле на основе имени. Это поле учитывает регистр и доступно только для чтения.</summary>
		// Token: 0x04002EF0 RID: 12016
		public static readonly TypeFilter FilterTypeName = new TypeFilter(Module.FilterTypeNameImpl);

		/// <summary>Объект <see langword="TypeFilter" />, который фильтрует список типов, определенных в этом модуле на основе имени. Это поле доступно только для чтения. В нем не учитывается регистр.</summary>
		// Token: 0x04002EF1 RID: 12017
		public static readonly TypeFilter FilterTypeNameIgnoreCase = new TypeFilter(Module.FilterTypeNameIgnoreCaseImpl);

		// Token: 0x04002EF2 RID: 12018
		private const BindingFlags DefaultLookup = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
	}
}
