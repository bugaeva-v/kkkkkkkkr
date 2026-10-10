using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace System.Security.Policy
{
	/// <summary>Определяет принадлежность сборки к группе кода путем проверки ее хэш-значения. Этот класс не наследуется.</summary>
	// Token: 0x02000413 RID: 1043
	[ComVisible(true)]
	[Serializable]
	public sealed class HashMembershipCondition : IMembershipCondition, ISecurityEncodable, ISecurityPolicyEncodable, IDeserializationCallback, ISerializable
	{
		// Token: 0x06002AAC RID: 10924 RVA: 0x0009A3EF File Offset: 0x000985EF
		internal HashMembershipCondition()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.HashMembershipCondition" /> с алгоритмом хэша и хэш-значением, определяющими членство.</summary>
		/// <param name="hashAlg">Алгоритм хэша, используемый при вычислении хэш-значений для сборки.</param>
		/// <param name="value">Хэш-значение, используемое при проверке.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="hashAlg" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="value" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="hashAlg" /> является недопустимым алгоритмом хэша.</exception>
		// Token: 0x06002AAD RID: 10925 RVA: 0x0009A400 File Offset: 0x00098600
		public HashMembershipCondition(HashAlgorithm hashAlg, byte[] value)
		{
			if (hashAlg == null)
			{
				throw new ArgumentNullException("hashAlg");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this.hash_algorithm = hashAlg;
			this.hash_value = (byte[])value.Clone();
		}

		/// <summary>Возвращает или задает алгоритм хэша, который используется для условия членства.</summary>
		/// <returns>Алгоритм хэша, который используется для условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> значение <see langword="null" />.</exception>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06002AAE RID: 10926 RVA: 0x0009A44E File Offset: 0x0009864E
		// (set) Token: 0x06002AAF RID: 10927 RVA: 0x0009A469 File Offset: 0x00098669
		public HashAlgorithm HashAlgorithm
		{
			get
			{
				if (this.hash_algorithm == null)
				{
					this.hash_algorithm = new SHA1Managed();
				}
				return this.hash_algorithm;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("HashAlgorithm");
				}
				this.hash_algorithm = value;
			}
		}

		/// <summary>Возвращает или задает хэш-значение, которое используется при проверке условия членства.</summary>
		/// <returns>Хэш-значение, используемое при проверке условия членства.</returns>
		/// <exception cref="T:System.ArgumentNullException">Предпринята попытка установить для параметра <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> значение <see langword="null" />.</exception>
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06002AB0 RID: 10928 RVA: 0x0009A480 File Offset: 0x00098680
		// (set) Token: 0x06002AB1 RID: 10929 RVA: 0x0009A4AA File Offset: 0x000986AA
		public byte[] HashValue
		{
			get
			{
				if (this.hash_value == null)
				{
					throw new ArgumentException(Locale.GetText("No HashValue available."));
				}
				return (byte[])this.hash_value.Clone();
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("HashValue");
				}
				this.hash_value = (byte[])value.Clone();
			}
		}

		/// <summary>Определяет, удовлетворяет ли указанное свидетельство условию членства.</summary>
		/// <param name="evidence">Набор свидетельств, в отношении которого производится проверка.</param>
		/// <returns>Значение <see langword="true" />, если указанное свидетельство удовлетворяет условию членства; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002AB2 RID: 10930 RVA: 0x0009A4CC File Offset: 0x000986CC
		public bool Check(Evidence evidence)
		{
			if (evidence == null)
			{
				return false;
			}
			IEnumerator hostEnumerator = evidence.GetHostEnumerator();
			while (hostEnumerator.MoveNext())
			{
				object obj = hostEnumerator.Current;
				Hash hash = obj as Hash;
				if (hash != null)
				{
					if (this.Compare(this.hash_value, hash.GenerateHash(this.hash_algorithm)))
					{
						return true;
					}
					break;
				}
			}
			return false;
		}

		/// <summary>Создает эквивалентную копию условия членства.</summary>
		/// <returns>Новая, идентичная копия текущего условия членства.</returns>
		// Token: 0x06002AB3 RID: 10931 RVA: 0x0009A51B File Offset: 0x0009871B
		public IMembershipCondition Copy()
		{
			return new HashMembershipCondition(this.hash_algorithm, this.hash_value);
		}

		/// <summary>Определяет, эквивалентны ли члены <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> и <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> указанного объекта членам <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> и <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" />, содержащимся в текущем объекте <see cref="T:System.Security.Policy.HashMembershipCondition" />.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Security.Policy.HashMembershipCondition" />.</param>
		/// <returns>Значение <see langword="true" />, если члены <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> и <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" /> указанного объекта эквивалентны членам <see cref="P:System.Security.Policy.HashMembershipCondition.HashValue" /> и <see cref="P:System.Security.Policy.HashMembershipCondition.HashAlgorithm" />, содержащимся в текущем объекте <see cref="T:System.Security.Policy.HashMembershipCondition" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002AB4 RID: 10932 RVA: 0x0009A530 File Offset: 0x00098730
		public override bool Equals(object o)
		{
			HashMembershipCondition hashMembershipCondition = o as HashMembershipCondition;
			return hashMembershipCondition != null && hashMembershipCondition.HashAlgorithm == this.hash_algorithm && this.Compare(this.hash_value, hashMembershipCondition.hash_value);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния.</summary>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002AB5 RID: 10933 RVA: 0x0009A56B File Offset: 0x0009876B
		public SecurityElement ToXml()
		{
			return this.ToXml(null);
		}

		/// <summary>Создает кодировку XML для объекта безопасности и его текущего состояния с заданным <see cref="T:System.Security.Policy.PolicyLevel" />.</summary>
		/// <param name="level">Контекст уровня политики для разрешения ссылок на именованные наборы разрешений.</param>
		/// <returns>Кодировка XML объекта безопасности, включающая сведения о состоянии.</returns>
		// Token: 0x06002AB6 RID: 10934 RVA: 0x0009A574 File Offset: 0x00098774
		public SecurityElement ToXml(PolicyLevel level)
		{
			SecurityElement securityElement = MembershipConditionHelper.Element(typeof(HashMembershipCondition), this.version);
			securityElement.AddAttribute("HashValue", CryptoConvert.ToHex(this.HashValue));
			securityElement.AddAttribute("HashAlgorithm", this.hash_algorithm.GetType().FullName);
			return securityElement;
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		// Token: 0x06002AB7 RID: 10935 RVA: 0x0009A5C7 File Offset: 0x000987C7
		public void FromXml(SecurityElement e)
		{
			this.FromXml(e, null);
		}

		/// <summary>Восстанавливает объект безопасности с указанным состоянием из кодировки XML.</summary>
		/// <param name="e">Кодировка XML, используемая для восстановления объекта безопасности.</param>
		/// <param name="level">Контекст уровня политики, используемый для разрешения ссылок на именованные наборы разрешений.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="e" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="e" /> — это недопустимый элемент условия членства.</exception>
		// Token: 0x06002AB8 RID: 10936 RVA: 0x0009A5D4 File Offset: 0x000987D4
		public void FromXml(SecurityElement e, PolicyLevel level)
		{
			MembershipConditionHelper.CheckSecurityElement(e, "e", this.version, this.version);
			this.hash_value = CryptoConvert.FromHex(e.Attribute("HashValue"));
			string text = e.Attribute("HashAlgorithm");
			this.hash_algorithm = ((text == null) ? null : HashAlgorithm.Create(text));
		}

		/// <summary>Получает хэш-код для текущего условия членства.</summary>
		/// <returns>Хэш-код для текущего условия членства.</returns>
		// Token: 0x06002AB9 RID: 10937 RVA: 0x0009A630 File Offset: 0x00098830
		public override int GetHashCode()
		{
			int num = this.hash_algorithm.GetType().GetHashCode();
			if (this.hash_value != null)
			{
				foreach (byte b in this.hash_value)
				{
					num ^= (int)b;
				}
			}
			return num;
		}

		/// <summary>Создает и возвращает строковое представление условия членства.</summary>
		/// <returns>Строковое представление состояния условия членства.</returns>
		// Token: 0x06002ABA RID: 10938 RVA: 0x0009A674 File Offset: 0x00098874
		public override string ToString()
		{
			Type type = this.HashAlgorithm.GetType();
			return string.Format("Hash - {0} {1} = {2}", type.FullName, type.Assembly, CryptoConvert.ToHex(this.HashValue));
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x0009A6B0 File Offset: 0x000988B0
		private bool Compare(byte[] expected, byte[] actual)
		{
			if (expected.Length != actual.Length)
			{
				return false;
			}
			int num = expected.Length;
			for (int i = 0; i < num; i++)
			{
				if (expected[i] != actual[i])
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Выполняется, когда полностью десериализован граф объектов.</summary>
		/// <param name="sender">Объект, который инициализирует обратный вызов. Данная функциональная возможность для этого параметра в настоящее время не реализуется.</param>
		// Token: 0x06002ABC RID: 10940 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[MonoTODO("fx 2.0")]
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Целевой объект <see cref="T:System.Runtime.Serialization.StreamingContext" /> для этой сериализации.</param>
		// Token: 0x06002ABD RID: 10941 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[MonoTODO("fx 2.0")]
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x04001F9C RID: 8092
		private readonly int version = 1;

		// Token: 0x04001F9D RID: 8093
		private HashAlgorithm hash_algorithm;

		// Token: 0x04001F9E RID: 8094
		private byte[] hash_value;
	}
}
