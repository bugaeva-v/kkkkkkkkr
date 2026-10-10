using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;

namespace System.Runtime.Serialization
{
	/// <summary>Содержит все данные, необходимые для сериализации или десериализации объекта. Этот класс не наследуется.</summary>
	// Token: 0x02000672 RID: 1650
	[ComVisible(true)]
	public sealed class SerializationInfo
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> сериализуемого объекта.</param>
		/// <param name="converter">Тип <see cref="T:System.Runtime.Serialization.IFormatterConverter" />, используемый во время десериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> или <paramref name="converter" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003D7D RID: 15741 RVA: 0x000D4C22 File Offset: 0x000D2E22
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter) : this(type, converter, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> сериализуемого объекта.</param>
		/// <param name="converter">Тип <see cref="T:System.Runtime.Serialization.IFormatterConverter" />, используемый во время десериализации.</param>
		/// <param name="requireSameTokenInPartialTrust">Указывает, требует ли объект того же токена в режиме частичного доверия.</param>
		// Token: 0x06003D7E RID: 15742 RVA: 0x000D4C30 File Offset: 0x000D2E30
		[CLSCompliant(false)]
		public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (converter == null)
			{
				throw new ArgumentNullException("converter");
			}
			this.objectType = type;
			this.m_fullTypeName = type.FullName;
			this.m_assemName = type.Module.Assembly.FullName;
			this.m_members = new string[4];
			this.m_data = new object[4];
			this.m_types = new Type[4];
			this.m_nameToIndex = new Dictionary<string, int>();
			this.m_converter = converter;
			this.requireSameTokenInPartialTrust = requireSameTokenInPartialTrust;
		}

		/// <summary>Возвращает или задает полное имя <see cref="T:System.Type" /> для сериализации.</summary>
		/// <returns>Полное имя типа для сериализации.</returns>
		/// <exception cref="T:System.ArgumentNullException">Это свойство устанавливает значение <see langword="null" />.</exception>
		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06003D7F RID: 15743 RVA: 0x000D4CC5 File Offset: 0x000D2EC5
		// (set) Token: 0x06003D80 RID: 15744 RVA: 0x000D4CCD File Offset: 0x000D2ECD
		public string FullTypeName
		{
			get
			{
				return this.m_fullTypeName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.m_fullTypeName = value;
				this.isFullTypeNameSetExplicit = true;
			}
		}

		/// <summary>Возвращает или задает имя сборки типа для сериализации только во время сериализации.</summary>
		/// <returns>Полное имя сборки типа для сериализации.</returns>
		/// <exception cref="T:System.ArgumentNullException">Данное свойство устанавливает значение <see langword="null" />.</exception>
		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x000D4CEB File Offset: 0x000D2EEB
		// (set) Token: 0x06003D82 RID: 15746 RVA: 0x000D4CF3 File Offset: 0x000D2EF3
		public string AssemblyName
		{
			get
			{
				return this.m_assemName;
			}
			[SecuritySafeCritical]
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (this.requireSameTokenInPartialTrust)
				{
					SerializationInfo.DemandForUnsafeAssemblyNameAssignments(this.m_assemName, value);
				}
				this.m_assemName = value;
				this.isAssemblyNameSetExplicit = true;
			}
		}

		/// <summary>Устанавливает <see cref="T:System.Type" /> объекта для сериализации.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" /> сериализуемого объекта.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003D83 RID: 15747 RVA: 0x000D4D28 File Offset: 0x000D2F28
		[SecuritySafeCritical]
		public void SetType(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (this.requireSameTokenInPartialTrust)
			{
				SerializationInfo.DemandForUnsafeAssemblyNameAssignments(this.ObjectType.Assembly.FullName, type.Assembly.FullName);
			}
			if (this.objectType != type)
			{
				this.objectType = type;
				this.m_fullTypeName = type.FullName;
				this.m_assemName = type.Module.Assembly.FullName;
				this.isFullTypeNameSetExplicit = false;
				this.isAssemblyNameSetExplicit = false;
			}
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x000D4DAC File Offset: 0x000D2FAC
		private static bool Compare(byte[] a, byte[] b)
		{
			if (a == null || b == null || a.Length == 0 || b.Length == 0 || a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000D4DEA File Offset: 0x000D2FEA
		[SecuritySafeCritical]
		internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
		{
			SerializationInfo.IsAssemblyNameAssignmentSafe(originalAssemblyName, newAssemblyName);
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000D4DF4 File Offset: 0x000D2FF4
		internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
		{
			if (originalAssemblyName == newAssemblyName)
			{
				return true;
			}
			AssemblyName assemblyName = new AssemblyName(originalAssemblyName);
			AssemblyName assemblyName2 = new AssemblyName(newAssemblyName);
			return !string.Equals(assemblyName2.Name, "mscorlib", StringComparison.OrdinalIgnoreCase) && !string.Equals(assemblyName2.Name, "mscorlib.dll", StringComparison.OrdinalIgnoreCase) && SerializationInfo.Compare(assemblyName.GetPublicKeyToken(), assemblyName2.GetPublicKeyToken());
		}

		/// <summary>Возвращает число элементов, добавляемых в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <returns>Число элементов, добавляемых в текущий <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003D87 RID: 15751 RVA: 0x000D4E53 File Offset: 0x000D3053
		public int MemberCount
		{
			get
			{
				return this.m_currMember;
			}
		}

		/// <summary>Возвращает тип объекта для сериализации.</summary>
		/// <returns>Тип сериализуемого объекта.</returns>
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003D88 RID: 15752 RVA: 0x000D4E5B File Offset: 0x000D305B
		public Type ObjectType
		{
			get
			{
				return this.objectType;
			}
		}

		/// <summary>Получает значение, указывающее, задано ли полное имя типа явно.</summary>
		/// <returns>
		///   <see langword="true" /> Если полное имя типа было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003D89 RID: 15753 RVA: 0x000D4E63 File Offset: 0x000D3063
		public bool IsFullTypeNameSetExplicit
		{
			get
			{
				return this.isFullTypeNameSetExplicit;
			}
		}

		/// <summary>Получает значение, указывающее, явно ли задано имя сборки.</summary>
		/// <returns>
		///   <see langword="true" /> Если имя сборки было задано явно; в противном случае <see langword="false" />.</returns>
		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003D8A RID: 15754 RVA: 0x000D4E6B File Offset: 0x000D306B
		public bool IsAssemblyNameSetExplicit
		{
			get
			{
				return this.isAssemblyNameSetExplicit;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" />, используемое для перебора пар имя-значение в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" /> для анализа пар "имя-значение", содержащихся в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
		// Token: 0x06003D8B RID: 15755 RVA: 0x000D4E73 File Offset: 0x000D3073
		public SerializationInfoEnumerator GetEnumerator()
		{
			return new SerializationInfoEnumerator(this.m_members, this.m_data, this.m_types, this.m_currMember);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x000D4E94 File Offset: 0x000D3094
		private void ExpandArrays()
		{
			int num = this.m_currMember * 2;
			if (num < this.m_currMember && 2147483647 > this.m_currMember)
			{
				num = int.MaxValue;
			}
			string[] array = new string[num];
			object[] array2 = new object[num];
			Type[] array3 = new Type[num];
			Array.Copy(this.m_members, array, this.m_currMember);
			Array.Copy(this.m_data, array2, this.m_currMember);
			Array.Copy(this.m_types, array3, this.m_currMember);
			this.m_members = array;
			this.m_data = array2;
			this.m_types = array3;
		}

		/// <summary>Добавляет значение в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />, где <paramref name="value" /> связывается с <paramref name="name" /> и сериализуется как <see cref="T:System.Type" /><paramref name="type" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Сериализуемое значение. Любой потомок этого объекта автоматически реализуется.</param>
		/// <param name="type">
		///   <see cref="T:System.Type" /> для связи с текущим объектом. Этот параметр всегда должен являться типом самого объекта или одним из его базовых классов.</param>
		/// <exception cref="T:System.ArgumentNullException">Если <paramref name="name" /> или <paramref name="type" /> равны <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D8D RID: 15757 RVA: 0x000D4F26 File Offset: 0x000D3126
		public void AddValue(string name, object value, Type type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.AddValueInternal(name, value, type);
		}

		/// <summary>Добавляет заданный объект в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />, где он связывается с заданным именем.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Сериализуемое значение. Любой потомок этого объекта автоматически реализуется.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D8E RID: 15758 RVA: 0x000D4F4D File Offset: 0x000D314D
		public void AddValue(string name, object value)
		{
			if (value == null)
			{
				this.AddValue(name, value, typeof(object));
				return;
			}
			this.AddValue(name, value, value.GetType());
		}

		/// <summary>Добавляет логическое значение в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Логическое значение для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D8F RID: 15759 RVA: 0x000D4F73 File Offset: 0x000D3173
		public void AddValue(string name, bool value)
		{
			this.AddValue(name, value, typeof(bool));
		}

		/// <summary>Добавляет значение символа Юникода в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение символа для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D90 RID: 15760 RVA: 0x000D4F8C File Offset: 0x000D318C
		public void AddValue(string name, char value)
		{
			this.AddValue(name, value, typeof(char));
		}

		/// <summary>Добавляет значение 8-битового целого числа со знаком в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="Sbyte" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D91 RID: 15761 RVA: 0x000D4FA5 File Offset: 0x000D31A5
		[CLSCompliant(false)]
		public void AddValue(string name, sbyte value)
		{
			this.AddValue(name, value, typeof(sbyte));
		}

		/// <summary>Добавляет значение 8-битового целого числа без знака в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение байта для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D92 RID: 15762 RVA: 0x000D4FBE File Offset: 0x000D31BE
		public void AddValue(string name, byte value)
		{
			this.AddValue(name, value, typeof(byte));
		}

		/// <summary>Добавляет значение 16-битового целого числа со знаком в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="Int16" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D93 RID: 15763 RVA: 0x000D4FD7 File Offset: 0x000D31D7
		public void AddValue(string name, short value)
		{
			this.AddValue(name, value, typeof(short));
		}

		/// <summary>Добавляет значение 16-битового целого числа без знака в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="UInt16" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D94 RID: 15764 RVA: 0x000D4FF0 File Offset: 0x000D31F0
		[CLSCompliant(false)]
		public void AddValue(string name, ushort value)
		{
			this.AddValue(name, value, typeof(ushort));
		}

		/// <summary>Добавляет значение 32-битового целого числа со знаком в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="Int32" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D95 RID: 15765 RVA: 0x000D5009 File Offset: 0x000D3209
		public void AddValue(string name, int value)
		{
			this.AddValue(name, value, typeof(int));
		}

		/// <summary>Добавляет значение 32-битового целого числа без знака в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="UInt32" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D96 RID: 15766 RVA: 0x000D5022 File Offset: 0x000D3222
		[CLSCompliant(false)]
		public void AddValue(string name, uint value)
		{
			this.AddValue(name, value, typeof(uint));
		}

		/// <summary>Добавляет значение 64-битового целого числа со знаком в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение Int64 для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D97 RID: 15767 RVA: 0x000D503B File Offset: 0x000D323B
		public void AddValue(string name, long value)
		{
			this.AddValue(name, value, typeof(long));
		}

		/// <summary>Добавляет значение 64-битового целого числа без знака в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see langword="UInt64" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D98 RID: 15768 RVA: 0x000D5054 File Offset: 0x000D3254
		[CLSCompliant(false)]
		public void AddValue(string name, ulong value)
		{
			this.AddValue(name, value, typeof(ulong));
		}

		/// <summary>Добавляет значение одинарной точности с плавающей запятой в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение Single для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D99 RID: 15769 RVA: 0x000D506D File Offset: 0x000D326D
		public void AddValue(string name, float value)
		{
			this.AddValue(name, value, typeof(float));
		}

		/// <summary>Добавляет значение удвоенной точности с плавающей запятой в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Двойное значение для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D9A RID: 15770 RVA: 0x000D5086 File Offset: 0x000D3286
		public void AddValue(string name, double value)
		{
			this.AddValue(name, value, typeof(double));
		}

		/// <summary>Добавляет десятичное логическое значение в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Десятичное значение для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Если значение параметра <paramref name="name" /> — <see langword="null" />,</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Если значение уже связано с <paramref name="name" />.</exception>
		// Token: 0x06003D9B RID: 15771 RVA: 0x000D509F File Offset: 0x000D329F
		public void AddValue(string name, decimal value)
		{
			this.AddValue(name, value, typeof(decimal));
		}

		/// <summary>Добавляет значение <see cref="T:System.DateTime" /> в хранилище <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя для связи со значением, которое можно десериализовать позже.</param>
		/// <param name="value">Значение <see cref="T:System.DateTime" /> для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">С параметром <paramref name="name" /> уже связано значение.</exception>
		// Token: 0x06003D9C RID: 15772 RVA: 0x000D50B8 File Offset: 0x000D32B8
		public void AddValue(string name, DateTime value)
		{
			this.AddValue(name, value, typeof(DateTime));
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x000D50D4 File Offset: 0x000D32D4
		internal void AddValueInternal(string name, object value, Type type)
		{
			if (this.m_nameToIndex.ContainsKey(name))
			{
				throw new SerializationException(Environment.GetResourceString("Cannot add the same member twice to a SerializationInfo object."));
			}
			this.m_nameToIndex.Add(name, this.m_currMember);
			if (this.m_currMember >= this.m_members.Length)
			{
				this.ExpandArrays();
			}
			this.m_members[this.m_currMember] = name;
			this.m_data[this.m_currMember] = value;
			this.m_types[this.m_currMember] = type;
			this.m_currMember++;
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x000D5160 File Offset: 0x000D3360
		internal void UpdateValue(string name, object value, Type type)
		{
			int num = this.FindElement(name);
			if (num < 0)
			{
				this.AddValueInternal(name, value, type);
				return;
			}
			this.m_data[num] = value;
			this.m_types[num] = type;
		}

		// Token: 0x06003D9F RID: 15775 RVA: 0x000D5198 File Offset: 0x000D3398
		private int FindElement(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			int result;
			if (this.m_nameToIndex.TryGetValue(name, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x06003DA0 RID: 15776 RVA: 0x000D51C8 File Offset: 0x000D33C8
		private object GetElement(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				throw new SerializationException(Environment.GetResourceString("Member '{0}' was not found.", new object[]
				{
					name
				}));
			}
			foundType = this.m_types[num];
			return this.m_data[num];
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x000D5210 File Offset: 0x000D3410
		[ComVisible(true)]
		private object GetElementNoThrow(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				foundType = null;
				return null;
			}
			foundType = this.m_types[num];
			return this.m_data[num];
		}

		/// <summary>Извлекает значение из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <param name="type">Тип <see cref="T:System.Type" /> значения, которое требуется извлечь. Если сохраненное значение невозможно преобразовать в этот тип, система выдает <see cref="T:System.InvalidCastException" />.</param>
		/// <returns>Объект заданного <see cref="T:System.Type" />, связанного с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> или <paramref name="type" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в <paramref name="type" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA2 RID: 15778 RVA: 0x000D5240 File Offset: 0x000D3440
		[SecuritySafeCritical]
		public object GetValue(string name, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			RuntimeType runtimeType = type as RuntimeType;
			if (runtimeType == null)
			{
				throw new ArgumentException(Environment.GetResourceString("Type must be a runtime Type object."));
			}
			Type type2;
			object element = this.GetElement(name, out type2);
			if (RemotingServices.IsTransparentProxy(element))
			{
				if (RemotingServices.ProxyCheckCast(RemotingServices.GetRealProxy(element), runtimeType))
				{
					return element;
				}
			}
			else if (type2 == type || type.IsAssignableFrom(type2) || element == null)
			{
				return element;
			}
			return this.m_converter.Convert(element, type);
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x000D52BC File Offset: 0x000D34BC
		[SecuritySafeCritical]
		[ComVisible(true)]
		internal object GetValueNoThrow(string name, Type type)
		{
			Type type2;
			object elementNoThrow = this.GetElementNoThrow(name, out type2);
			if (elementNoThrow == null)
			{
				return null;
			}
			if (RemotingServices.IsTransparentProxy(elementNoThrow))
			{
				if (RemotingServices.ProxyCheckCast(RemotingServices.GetRealProxy(elementNoThrow), (RuntimeType)type))
				{
					return elementNoThrow;
				}
			}
			else if (type2 == type || type.IsAssignableFrom(type2) || elementNoThrow == null)
			{
				return elementNoThrow;
			}
			return this.m_converter.Convert(elementNoThrow, type);
		}

		/// <summary>Извлекает логическое значение из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Логическое значение, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в логическое значение.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA4 RID: 15780 RVA: 0x000D5314 File Offset: 0x000D3514
		public bool GetBoolean(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(bool))
			{
				return (bool)element;
			}
			return this.m_converter.ToBoolean(element);
		}

		/// <summary>Извлекает значение символа Юникода из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Символ Юникода, связанный с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в символ Юникода.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA5 RID: 15781 RVA: 0x000D534C File Offset: 0x000D354C
		public char GetChar(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(char))
			{
				return (char)element;
			}
			return this.m_converter.ToChar(element);
		}

		/// <summary>Извлекает значение 8-битового целого числа без знака из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>8-битовое целое число со знаком, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 8-битовое целое число со знаком.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA6 RID: 15782 RVA: 0x000D5384 File Offset: 0x000D3584
		[CLSCompliant(false)]
		public sbyte GetSByte(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(sbyte))
			{
				return (sbyte)element;
			}
			return this.m_converter.ToSByte(element);
		}

		/// <summary>Извлекает значение 8-битового целого числа без знака из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>8-битовое целое число без знака, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 8-битовое целое число без знака.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA7 RID: 15783 RVA: 0x000D53BC File Offset: 0x000D35BC
		public byte GetByte(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(byte))
			{
				return (byte)element;
			}
			return this.m_converter.ToByte(element);
		}

		/// <summary>Извлекает значение 16-битового целого числа со знаком из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>16-битовое целое число со знаком, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 16-битовое целое число со знаком.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA8 RID: 15784 RVA: 0x000D53F4 File Offset: 0x000D35F4
		public short GetInt16(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(short))
			{
				return (short)element;
			}
			return this.m_converter.ToInt16(element);
		}

		/// <summary>Извлекает значение 16-битового целого числа без знака из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>16-битовое целое число без знака, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 16-битовое целое число без знака.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DA9 RID: 15785 RVA: 0x000D542C File Offset: 0x000D362C
		[CLSCompliant(false)]
		public ushort GetUInt16(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(ushort))
			{
				return (ushort)element;
			}
			return this.m_converter.ToUInt16(element);
		}

		/// <summary>Извлекает значение 32-битового целого числа со знаком из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя извлекаемого значения.</param>
		/// <returns>32-битовое целое число со знаком, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 32-битовое целое число со знаком.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAA RID: 15786 RVA: 0x000D5464 File Offset: 0x000D3664
		public int GetInt32(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(int))
			{
				return (int)element;
			}
			return this.m_converter.ToInt32(element);
		}

		/// <summary>Извлекает значение 32-битового целого числа без знака из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>32-битовое целое число без знака, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 32-битовое целое число без знака.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAB RID: 15787 RVA: 0x000D549C File Offset: 0x000D369C
		[CLSCompliant(false)]
		public uint GetUInt32(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(uint))
			{
				return (uint)element;
			}
			return this.m_converter.ToUInt32(element);
		}

		/// <summary>Извлекает значение 64-битового целого числа со знаком из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>64-битовое целое число со знаком, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 64-битовое целое число со знаком.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAC RID: 15788 RVA: 0x000D54D4 File Offset: 0x000D36D4
		public long GetInt64(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(long))
			{
				return (long)element;
			}
			return this.m_converter.ToInt64(element);
		}

		/// <summary>Извлекает значение 64-битового целого числа без знака из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>64-битовое целое число без знака, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в 64-битовое целое число без знака.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAD RID: 15789 RVA: 0x000D550C File Offset: 0x000D370C
		[CLSCompliant(false)]
		public ulong GetUInt64(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(ulong))
			{
				return (ulong)element;
			}
			return this.m_converter.ToUInt64(element);
		}

		/// <summary>Извлекает значение одиночной точности с плавающей запятой из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя извлекаемого значения.</param>
		/// <returns>Значение одиночной точности с плавающей запятой, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в значение обычной точности с плавающей запятой.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAE RID: 15790 RVA: 0x000D5544 File Offset: 0x000D3744
		public float GetSingle(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(float))
			{
				return (float)element;
			}
			return this.m_converter.ToSingle(element);
		}

		/// <summary>Извлекает значение удвоенной точности с плавающей запятой из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Значение удвоенной точности с плавающей запятой, связанное с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в значение удвоенной точности с плавающей запятой.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DAF RID: 15791 RVA: 0x000D557C File Offset: 0x000D377C
		public double GetDouble(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(double))
			{
				return (double)element;
			}
			return this.m_converter.ToDouble(element);
		}

		/// <summary>Извлекает десятичное значение из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Десятичное значение из <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в десятичное.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DB0 RID: 15792 RVA: 0x000D55B4 File Offset: 0x000D37B4
		public decimal GetDecimal(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(decimal))
			{
				return (decimal)element;
			}
			return this.m_converter.ToDecimal(element);
		}

		/// <summary>Извлекает значение <see cref="T:System.DateTime" /> из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Значение объекта <see cref="T:System.DateTime" />, сопоставленное объекту <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в значение <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DB1 RID: 15793 RVA: 0x000D55EC File Offset: 0x000D37EC
		public DateTime GetDateTime(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(DateTime))
			{
				return (DateTime)element;
			}
			return this.m_converter.ToDateTime(element);
		}

		/// <summary>Извлекает значение <see cref="T:System.String" /> из хранилища <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="name">Имя, связанное с извлекаемым значением.</param>
		/// <returns>Класс <see cref="T:System.String" />, связанный с <paramref name="name" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidCastException">Значение, связанное с <paramref name="name" />, невозможно преобразовать в <see cref="T:System.String" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Элемент с указанным именем не найден в текущем экземпляре.</exception>
		// Token: 0x06003DB2 RID: 15794 RVA: 0x000D5624 File Offset: 0x000D3824
		public string GetString(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type == typeof(string) || element == null)
			{
				return (string)element;
			}
			return this.m_converter.ToString(element);
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003DB3 RID: 15795 RVA: 0x000D565E File Offset: 0x000D385E
		internal string[] MemberNames
		{
			get
			{
				return this.m_members;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x000D5666 File Offset: 0x000D3866
		internal object[] MemberValues
		{
			get
			{
				return this.m_data;
			}
		}

		// Token: 0x04002786 RID: 10118
		private const int defaultSize = 4;

		// Token: 0x04002787 RID: 10119
		private const string s_mscorlibAssemblySimpleName = "mscorlib";

		// Token: 0x04002788 RID: 10120
		private const string s_mscorlibFileName = "mscorlib.dll";

		// Token: 0x04002789 RID: 10121
		internal string[] m_members;

		// Token: 0x0400278A RID: 10122
		internal object[] m_data;

		// Token: 0x0400278B RID: 10123
		internal Type[] m_types;

		// Token: 0x0400278C RID: 10124
		private Dictionary<string, int> m_nameToIndex;

		// Token: 0x0400278D RID: 10125
		internal int m_currMember;

		// Token: 0x0400278E RID: 10126
		internal IFormatterConverter m_converter;

		// Token: 0x0400278F RID: 10127
		private string m_fullTypeName;

		// Token: 0x04002790 RID: 10128
		private string m_assemName;

		// Token: 0x04002791 RID: 10129
		private Type objectType;

		// Token: 0x04002792 RID: 10130
		private bool isFullTypeNameSetExplicit;

		// Token: 0x04002793 RID: 10131
		private bool isAssemblyNameSetExplicit;

		// Token: 0x04002794 RID: 10132
		private bool requireSameTokenInPartialTrust;
	}
}
