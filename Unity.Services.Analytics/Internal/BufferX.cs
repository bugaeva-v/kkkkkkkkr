using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200002F RID: 47
	internal class BufferX : IBuffer, IBufferDebug
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00004910 File Offset: 0x00002B10
		public int Length
		{
			get
			{
				return (int)this.m_Buffer.Length;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000491E File Offset: 0x00002B1E
		internal int EventsRecorded
		{
			get
			{
				return this.m_EventSummaries.Count;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000492B File Offset: 0x00002B2B
		internal IReadOnlyList<EventSummary> EventSummaries
		{
			get
			{
				return this.m_EventSummaries;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00004933 File Offset: 0x00002B33
		internal byte[] RawContents
		{
			get
			{
				return this.m_Buffer.ToArray();
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000128 RID: 296 RVA: 0x00004940 File Offset: 0x00002B40
		// (remove) Token: 0x06000129 RID: 297 RVA: 0x00004978 File Offset: 0x00002B78
		public event Action<string, string, DateTime, byte[]> EventRecorded;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600012A RID: 298 RVA: 0x000049B0 File Offset: 0x00002BB0
		// (remove) Token: 0x0600012B RID: 299 RVA: 0x000049E8 File Offset: 0x00002BE8
		public event Action<HashSet<string>> EventsClearing;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600012C RID: 300 RVA: 0x00004A20 File Offset: 0x00002C20
		// (remove) Token: 0x0600012D RID: 301 RVA: 0x00004A58 File Offset: 0x00002C58
		public event Action<HashSet<string>> EventsCleared;

		// Token: 0x0600012E RID: 302 RVA: 0x00004A90 File Offset: 0x00002C90
		public BufferX(IBufferSystemCalls eventIdGenerator, IDiskCache diskCache, IIdentityManager userIdentity, ISessionManager session)
		{
			this.m_Buffer = new MemoryStream(4194304);
			this.m_SpareBuffer = new MemoryStream(4194304);
			this.m_EventSummaries = new List<EventSummary>();
			this.m_SystemCalls = eventIdGenerator;
			this.m_DiskCache = diskCache;
			this.m_UserIdentity = userIdentity;
			this.m_Session = session;
			this.k_WorkingBuffer = new byte[4194304L];
			this.k_WorkingCharacterBuffer = new char[4194304L];
			this.k_PayloadHeader = Encoding.UTF8.GetBytes("{\"eventList\":[");
			this.k_HeaderEventName = Encoding.UTF8.GetBytes("{\"eventName\":\"");
			this.k_HeaderUserName = Encoding.UTF8.GetBytes("\",\"userID\":\"");
			this.k_HeaderSessionID = Encoding.UTF8.GetBytes("\",\"sessionID\":\"");
			this.k_HeaderEventUUID = Encoding.UTF8.GetBytes("\",\"eventUUID\":\"");
			this.k_HeaderTimestamp = Encoding.UTF8.GetBytes("\",\"eventTimestamp\":\"");
			this.k_HeaderEventVersion = Encoding.UTF8.GetBytes("\"eventVersion\":");
			this.k_HeaderInstallationID = Encoding.UTF8.GetBytes("\"unityInstallationID\":\"");
			this.k_HeaderPlayerID = Encoding.UTF8.GetBytes("\"unityPlayerID\":\"");
			this.k_HeaderOpenEventParams = Encoding.UTF8.GetBytes("\"eventParams\":{");
			this.k_CloseEvent = Encoding.UTF8.GetBytes("}},");
			this.k_Quote = Encoding.UTF8.GetBytes("\"")[0];
			this.k_QuoteColon = Encoding.UTF8.GetBytes("\":");
			this.k_QuoteComma = Encoding.UTF8.GetBytes("\",");
			this.k_Comma = Encoding.UTF8.GetBytes(",");
			this.k_OpenBrace = Encoding.UTF8.GetBytes("{");
			this.k_CloseBraceComma = Encoding.UTF8.GetBytes("},");
			this.k_OpenBracket = Encoding.UTF8.GetBytes("[");
			this.k_CloseBracketComma = Encoding.UTF8.GetBytes("],");
			this.k_Colon = Encoding.UTF8.GetBytes(":")[0];
			this.k_Dash = Encoding.UTF8.GetBytes("-")[0];
			this.k_Space = Encoding.UTF8.GetBytes(" ")[0];
			this.k_Point = Encoding.UTF8.GetBytes(".")[0];
			this.k_Positive = Encoding.UTF8.GetBytes("+")[0];
			this.k_Negative = Encoding.UTF8.GetBytes("-")[0];
			this.k_True = Encoding.UTF8.GetBytes("true");
			this.k_False = Encoding.UTF8.GetBytes("false");
			this.k_Int2CharacterByte = new byte[]
			{
				48,
				49,
				50,
				51,
				52,
				53,
				54,
				55,
				56,
				57
			};
			this.k_Order = new long[]
			{
				1L,
				10L,
				100L,
				1000L,
				10000L,
				100000L,
				1000000L,
				10000000L,
				100000000L,
				1000000000L,
				10000000000L,
				100000000000L,
				1000000000000L,
				10000000000000L,
				100000000000000L,
				1000000000000000L,
				10000000000000000L,
				100000000000000000L,
				1000000000000000000L
			};
			this.ClearBuffer();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004D8C File Offset: 0x00002F8C
		private void WriteString(in string value)
		{
			int bytes = Encoding.UTF8.GetBytes(value, 0, Mathf.Min(value.Length, this.k_WorkingBuffer.Length), this.k_WorkingBuffer, 0);
			this.m_Buffer.Write(this.k_WorkingBuffer, 0, bytes);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004DD8 File Offset: 0x00002FD8
		private void WriteLong(in long value)
		{
			int num = 0;
			int num2 = 0;
			int count = this.SerializeLong(value, this.k_WorkingBuffer, num, num2);
			this.m_Buffer.Write(this.k_WorkingBuffer, 0, count);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004E0E File Offset: 0x0000300E
		private void WriteByte(in byte value)
		{
			this.m_Buffer.WriteByte(value);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004E1D File Offset: 0x0000301D
		private void WriteBytes(in byte[] bytes)
		{
			this.m_Buffer.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004E31 File Offset: 0x00003031
		private void WriteName(string name)
		{
			if (name != null)
			{
				this.WriteByte(this.k_Quote);
				this.WriteString(name);
				this.WriteBytes(this.k_QuoteColon);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004E58 File Offset: 0x00003058
		private void WriteDateTime(DateTime dateTime)
		{
			long num = (long)dateTime.Year;
			int num2 = 0;
			int num3 = 4;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[4] = this.k_Dash;
			num = (long)dateTime.Month;
			num2 = 5;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[7] = this.k_Dash;
			num = (long)dateTime.Day;
			num2 = 8;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[10] = this.k_Space;
			num = (long)dateTime.Hour;
			num2 = 11;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[13] = this.k_Colon;
			num = (long)dateTime.Minute;
			num2 = 14;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[16] = this.k_Colon;
			num = (long)dateTime.Second;
			num2 = 17;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[19] = this.k_Point;
			num = (long)dateTime.Millisecond;
			num2 = 20;
			num3 = 3;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[23] = this.k_Space;
			TimeSpan timeZoneUtcOffset = this.m_SystemCalls.GetTimeZoneUtcOffset(dateTime);
			this.k_WorkingBuffer[24] = ((timeZoneUtcOffset.Ticks < 0L) ? this.k_Negative : this.k_Positive);
			num = (long)Mathf.Abs(timeZoneUtcOffset.Hours);
			num2 = 25;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.k_WorkingBuffer[27] = this.k_Colon;
			num = (long)Mathf.Abs(timeZoneUtcOffset.Minutes);
			num2 = 28;
			num3 = 2;
			this.SerializeLong(num, this.k_WorkingBuffer, num2, num3);
			this.m_Buffer.Write(this.k_WorkingBuffer, 0, 30);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005050 File Offset: 0x00003250
		private int SerializeLong(in long number, in byte[] buffer, in int startIndex, in int minimumLength)
		{
			if (number == 0L)
			{
				for (int i = 0; i <= minimumLength; i++)
				{
					buffer[startIndex + i] = this.k_Int2CharacterByte[0];
				}
				return Mathf.Max(1, minimumLength);
			}
			long num = Math.Abs(number);
			int num2 = (int)(Math.Log10(Math.Max((double)num, 0.5)) + 1.0);
			num2 = Mathf.Max(minimumLength, num2);
			int num3 = startIndex;
			int num4 = num2;
			if (number < 0L)
			{
				buffer[num3] = this.k_Negative;
				num3++;
				num4++;
			}
			long num5 = num;
			for (int j = num2; j > 0; j--)
			{
				long num6 = num5 / this.k_Order[j - 1];
				num5 %= this.k_Order[j - 1];
				buffer[num3 + num2 - j] = this.k_Int2CharacterByte[(int)(checked((IntPtr)num6))];
			}
			return num4;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005120 File Offset: 0x00003320
		public void PushStandardEventStart(string name, int version)
		{
			this.PushCommonEventStart(name);
			this.WriteBytes(this.k_HeaderEventVersion);
			long num = (long)version;
			this.WriteLong(num);
			this.WriteBytes(this.k_Comma);
			this.WriteBytes(this.k_HeaderInstallationID);
			string text = this.m_UserIdentity.InstallId;
			this.WriteString(text);
			this.WriteBytes(this.k_QuoteComma);
			if (!string.IsNullOrEmpty(this.m_UserIdentity.PlayerId))
			{
				this.WriteBytes(this.k_HeaderPlayerID);
				text = this.m_UserIdentity.PlayerId;
				this.WriteString(text);
				this.WriteBytes(this.k_QuoteComma);
			}
			this.WriteBytes(this.k_HeaderOpenEventParams);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000051CD File Offset: 0x000033CD
		public void PushCustomEventStart(string name)
		{
			this.PushCommonEventStart(name);
			this.WriteBytes(this.k_HeaderOpenEventParams);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000051E4 File Offset: 0x000033E4
		private void PushCommonEventStart(string name)
		{
			this.m_CurrentEventTimestamp = this.m_SystemCalls.Now();
			this.m_CurrentEventId = this.m_SystemCalls.GenerateGuid();
			this.m_CurrentEventName = name;
			this.WriteBytes(this.k_HeaderEventName);
			this.WriteString(this.m_CurrentEventName);
			this.WriteBytes(this.k_HeaderUserName);
			string text = this.m_UserIdentity.UserId;
			this.WriteString(text);
			this.WriteBytes(this.k_HeaderSessionID);
			text = this.m_Session.SessionId;
			this.WriteString(text);
			this.WriteBytes(this.k_HeaderEventUUID);
			this.WriteString(this.m_CurrentEventId);
			this.WriteBytes(this.k_HeaderTimestamp);
			this.WriteDateTime(this.m_CurrentEventTimestamp);
			this.WriteBytes(this.k_QuoteComma);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000052B0 File Offset: 0x000034B0
		private void StripTrailingCommaIfNecessary()
		{
			this.m_Buffer.Seek(-1L, SeekOrigin.End);
			if ((ushort)this.m_Buffer.ReadByte() == 44)
			{
				this.m_Buffer.Seek(-1L, SeekOrigin.Current);
				this.m_Buffer.SetLength(this.m_Buffer.Length - 1L);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005304 File Offset: 0x00003504
		public void PushEndEvent()
		{
			this.StripTrailingCommaIfNecessary();
			this.WriteBytes(this.k_CloseEvent);
			int num = (int)this.m_Buffer.Length;
			int num2 = (this.m_EventSummaries.Count > 0) ? this.m_EventSummaries[this.m_EventSummaries.Count - 1].EndIndex : 0;
			int num3 = num;
			if ((long)(num3 - num2) > 4194304L)
			{
				Debug.LogWarning(string.Format("Detected event that would be too big to upload (greater than {0}KB in size), discarding it to prevent blockage.", 4096L));
				int num4 = (this.m_EventSummaries.Count > 0) ? this.m_EventSummaries[this.m_EventSummaries.Count - 1].EndIndex : 0;
				this.m_Buffer.SetLength((long)num4);
				this.m_Buffer.Position = (long)num4;
				return;
			}
			this.m_EventSummaries.Add(new EventSummary
			{
				StartIndex = num2,
				EndIndex = num3,
				Id = this.m_CurrentEventId
			});
			if (this.EventRecorded != null)
			{
				long position = this.m_Buffer.Position;
				this.m_Buffer.Seek((long)num2, SeekOrigin.Begin);
				int num5 = num3 - num2;
				byte[] array = new byte[num5];
				this.m_Buffer.Read(array, 0, num5);
				this.m_Buffer.Seek(position, SeekOrigin.Begin);
				this.EventRecorded(this.m_CurrentEventId, this.m_CurrentEventName, this.m_CurrentEventTimestamp, array);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005471 File Offset: 0x00003671
		public void PushObjectStart(string name)
		{
			this.WriteName(name);
			this.WriteBytes(this.k_OpenBrace);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00005486 File Offset: 0x00003686
		public void PushObjectEnd()
		{
			this.StripTrailingCommaIfNecessary();
			this.WriteBytes(this.k_CloseBraceComma);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000549A File Offset: 0x0000369A
		public void PushArrayStart(string name)
		{
			this.WriteName(name);
			this.WriteBytes(this.k_OpenBracket);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000054AF File Offset: 0x000036AF
		public void PushArrayEnd()
		{
			this.StripTrailingCommaIfNecessary();
			this.WriteBytes(this.k_CloseBracketComma);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000054C4 File Offset: 0x000036C4
		public void PushDouble(string name, double value)
		{
			this.WriteName(name);
			string text = value.ToString(CultureInfo.InvariantCulture);
			this.WriteString(text);
			this.WriteBytes(this.k_Comma);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000054FC File Offset: 0x000036FC
		public void PushFloat(string name, float value)
		{
			this.WriteName(name);
			string text = value.ToString(CultureInfo.InvariantCulture);
			this.WriteString(text);
			this.WriteBytes(this.k_Comma);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005534 File Offset: 0x00003734
		public void PushString(string name, string value)
		{
			if (Encoding.UTF8.GetByteCount(value) < this.k_WorkingBuffer.Length)
			{
				int num = 0;
				for (int i = 0; i < value.Length; i++)
				{
					num += this.ProcessCharacterOntoWorkingBuffer(num, value[i]);
					if (num >= this.k_WorkingCharacterBuffer.Length)
					{
						Debug.LogWarning(string.Concat(new string[]
						{
							"String value for field ",
							name,
							" is too long, it will not be recorded.\nValue:\n",
							value.Substring(0, 128),
							"..."
						}));
						break;
					}
				}
				if (num < this.k_WorkingCharacterBuffer.Length)
				{
					this.WriteName(name);
					this.WriteByte(this.k_Quote);
					int bytes = Encoding.UTF8.GetBytes(this.k_WorkingCharacterBuffer, 0, num, this.k_WorkingBuffer, 0);
					this.m_Buffer.Write(this.k_WorkingBuffer, 0, bytes);
					this.WriteBytes(this.k_QuoteComma);
					return;
				}
			}
			else
			{
				Debug.LogWarning(string.Concat(new string[]
				{
					"String value for field \"",
					name,
					"\" is too long, it will not be recorded.\nValue:\n",
					value.Substring(0, 128),
					"..."
				}));
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000565C File Offset: 0x0000385C
		private int ProcessCharacterOntoWorkingBuffer(int index, char character)
		{
			if (char.IsControl(character))
			{
				int num = 0;
				int num2 = Convert.ToInt32(character);
				string text = string.Format("\\U{0:X4}", num2);
				for (int i = 0; i < text.Length; i++)
				{
					this.k_WorkingCharacterBuffer[index + i] = text[i];
					num++;
				}
				return num;
			}
			if (character == '"' || character == '\\')
			{
				this.k_WorkingCharacterBuffer[index] = '\\';
				this.k_WorkingCharacterBuffer[index + 1] = character;
				return 2;
			}
			this.k_WorkingCharacterBuffer[index] = character;
			return 1;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000056DE File Offset: 0x000038DE
		public void PushInt64(string name, long value)
		{
			this.WriteName(name);
			this.WriteLong(value);
			this.WriteBytes(this.k_Comma);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000056FB File Offset: 0x000038FB
		public void PushInt(string name, int value)
		{
			this.PushInt64(name, (long)value);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005706 File Offset: 0x00003906
		public void PushBool(string name, bool value)
		{
			this.WriteName(name);
			if (value)
			{
				this.WriteBytes(this.k_True);
			}
			else
			{
				this.WriteBytes(this.k_False);
			}
			this.WriteBytes(this.k_Comma);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005738 File Offset: 0x00003938
		public void PushTimestamp(string name, DateTime value)
		{
			this.WriteName(name);
			this.WriteByte(this.k_Quote);
			this.WriteDateTime(value);
			this.WriteBytes(this.k_QuoteComma);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005760 File Offset: 0x00003960
		public void PushProduct(string name, TransactionRealCurrency realCurrency, List<TransactionVirtualCurrency> virtualCurrencies, List<TransactionItem> items)
		{
			this.PushObjectStart(name);
			if (realCurrency != null)
			{
				this.PushObjectStart("realCurrency");
				realCurrency.Serialize(this);
				this.PushObjectEnd();
			}
			if (virtualCurrencies.Count > 0)
			{
				this.PushArrayStart("virtualCurrencies");
				foreach (TransactionVirtualCurrency transactionVirtualCurrency in virtualCurrencies)
				{
					this.PushObjectStart(null);
					this.PushObjectStart("virtualCurrency");
					transactionVirtualCurrency.Serialize(this);
					this.PushObjectEnd();
					this.PushObjectEnd();
				}
				this.PushArrayEnd();
			}
			if (items.Count > 0)
			{
				this.PushArrayStart("items");
				foreach (TransactionItem transactionItem in items)
				{
					this.PushObjectStart(null);
					this.PushObjectStart("item");
					transactionItem.Serialize(this);
					this.PushObjectEnd();
					this.PushObjectEnd();
				}
				this.PushArrayEnd();
			}
			this.PushObjectEnd();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005884 File Offset: 0x00003A84
		public void PushObject(string name, object value)
		{
			if (value != null)
			{
				Type type = value.GetType();
				if (type == typeof(string))
				{
					this.PushString(name, (string)value);
					return;
				}
				if (type == typeof(int))
				{
					this.PushInt(name, (int)value);
					return;
				}
				if (type == typeof(long))
				{
					this.PushInt64(name, (long)value);
					return;
				}
				if (type == typeof(float))
				{
					this.PushFloat(name, (float)value);
					return;
				}
				if (type == typeof(double))
				{
					this.PushDouble(name, (double)value);
					return;
				}
				if (type == typeof(bool))
				{
					this.PushBool(name, (bool)value);
					return;
				}
				if (type == typeof(DateTime))
				{
					this.PushTimestamp(name, (DateTime)value);
					return;
				}
				Enum @enum = value as Enum;
				if (@enum != null)
				{
					this.PushString(name, @enum.ToString());
					return;
				}
				IDictionary<string, object> dictionary = value as IDictionary<string, object>;
				if (dictionary != null)
				{
					this.PushObjectStart(name);
					foreach (KeyValuePair<string, object> keyValuePair in dictionary)
					{
						this.PushObject(keyValuePair.Key, keyValuePair.Value);
					}
					this.PushObjectEnd();
					return;
				}
				IList<object> list = value as IList<object>;
				if (list != null && list.Count > 0)
				{
					this.PushArrayStart(name);
					for (int i = 0; i < list.Count; i++)
					{
						this.PushObject(null, list[i]);
					}
					this.PushArrayEnd();
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005A40 File Offset: 0x00003C40
		public byte[] Serialize()
		{
			if (this.m_EventSummaries.Count > 0)
			{
				long position = this.m_Buffer.Position;
				int endIndex = this.m_EventSummaries[0].EndIndex;
				int num = 0;
				while (num < this.m_EventSummaries.Count && (long)this.m_EventSummaries[num].EndIndex < 4194304L)
				{
					endIndex = this.m_EventSummaries[num].EndIndex;
					num++;
				}
				if (this.EventsClearing != null)
				{
					HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
					for (int i = 0; i < num; i++)
					{
						hashSet.Add(this.m_EventSummaries[i].Id);
					}
					this.EventsClearing(hashSet);
				}
				byte[] array = new byte[this.k_PayloadHeader.Length + endIndex + 1];
				this.k_PayloadHeader.CopyTo(array, 0);
				this.m_Buffer.Position = 0L;
				this.m_Buffer.Read(array, this.k_PayloadHeader.Length, endIndex);
				byte[] bytes = Encoding.UTF8.GetBytes("]}");
				array[this.k_PayloadHeader.Length + endIndex - 1] = bytes[0];
				array[this.k_PayloadHeader.Length + endIndex] = bytes[1];
				this.m_Buffer.Position = position;
				return array;
			}
			return null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005B8D File Offset: 0x00003D8D
		public void ClearBuffer()
		{
			this.m_Buffer.SetLength(0L);
			this.m_Buffer.Position = 0L;
			this.m_EventSummaries.Clear();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public void ClearBuffer(long upTo)
		{
			if (this.m_EventSummaries.Count > 0)
			{
				MemoryStream buffer = this.m_Buffer;
				this.m_Buffer = this.m_SpareBuffer;
				this.m_SpareBuffer = buffer;
				int num = 0;
				int num2 = (int)upTo;
				for (int i = 0; i < this.m_EventSummaries.Count; i++)
				{
					EventSummary value = this.m_EventSummaries[i];
					value.StartIndex -= num2;
					value.EndIndex -= num2;
					this.m_EventSummaries[i] = value;
					if (this.m_EventSummaries[i].EndIndex <= 0)
					{
						num = i;
					}
				}
				if (this.EventsCleared != null)
				{
					HashSet<string> hashSet = new HashSet<string>(StringComparer.Ordinal);
					for (int j = 0; j <= num; j++)
					{
						hashSet.Add(this.m_EventSummaries[j].Id);
					}
					this.EventsCleared(hashSet);
				}
				this.m_EventSummaries.RemoveRange(0, num + 1);
				this.m_Buffer.SetLength(0L);
				this.m_Buffer.Position = 0L;
				this.m_SpareBuffer.Position = upTo;
				for (long num3 = upTo; num3 < this.m_SpareBuffer.Length; num3 += 1L)
				{
					byte value2 = (byte)this.m_SpareBuffer.ReadByte();
					this.m_Buffer.WriteByte(value2);
				}
				this.m_SpareBuffer.SetLength(0L);
				this.m_SpareBuffer.Position = 0L;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005D21 File Offset: 0x00003F21
		public void FlushToDisk()
		{
			this.m_DiskCache.Write(this.m_EventSummaries, this.m_Buffer);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005D3A File Offset: 0x00003F3A
		public void ClearDiskCache()
		{
			this.m_DiskCache.Clear();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005D47 File Offset: 0x00003F47
		public void LoadFromDisk()
		{
			if (!this.m_DiskCache.Read(this.m_EventSummaries, this.m_Buffer))
			{
				this.ClearBuffer();
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005D68 File Offset: 0x00003F68
		internal static string SerializeDateTime(DateTime dateTime)
		{
			return dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff zzz", CultureInfo.InvariantCulture);
		}

		// Token: 0x0400008A RID: 138
		private const long k_UploadBatchMaximumSizeInBytes = 4194304L;

		// Token: 0x0400008B RID: 139
		private const string k_MillisecondDateFormat = "yyyy-MM-dd HH:mm:ss.fff zzz";

		// Token: 0x0400008C RID: 140
		private readonly byte[] k_WorkingBuffer;

		// Token: 0x0400008D RID: 141
		private readonly char[] k_WorkingCharacterBuffer;

		// Token: 0x0400008E RID: 142
		private readonly byte[] k_PayloadHeader;

		// Token: 0x0400008F RID: 143
		private readonly byte[] k_HeaderEventName;

		// Token: 0x04000090 RID: 144
		private readonly byte[] k_HeaderUserName;

		// Token: 0x04000091 RID: 145
		private readonly byte[] k_HeaderSessionID;

		// Token: 0x04000092 RID: 146
		private readonly byte[] k_HeaderEventUUID;

		// Token: 0x04000093 RID: 147
		private readonly byte[] k_HeaderTimestamp;

		// Token: 0x04000094 RID: 148
		private readonly byte[] k_HeaderEventVersion;

		// Token: 0x04000095 RID: 149
		private readonly byte[] k_HeaderInstallationID;

		// Token: 0x04000096 RID: 150
		private readonly byte[] k_HeaderPlayerID;

		// Token: 0x04000097 RID: 151
		private readonly byte[] k_HeaderOpenEventParams;

		// Token: 0x04000098 RID: 152
		private readonly byte[] k_CloseEvent;

		// Token: 0x04000099 RID: 153
		private readonly byte k_Quote;

		// Token: 0x0400009A RID: 154
		private readonly byte[] k_QuoteColon;

		// Token: 0x0400009B RID: 155
		private readonly byte[] k_QuoteComma;

		// Token: 0x0400009C RID: 156
		private readonly byte[] k_Comma;

		// Token: 0x0400009D RID: 157
		private readonly byte[] k_OpenBrace;

		// Token: 0x0400009E RID: 158
		private readonly byte[] k_CloseBraceComma;

		// Token: 0x0400009F RID: 159
		private readonly byte[] k_OpenBracket;

		// Token: 0x040000A0 RID: 160
		private readonly byte[] k_CloseBracketComma;

		// Token: 0x040000A1 RID: 161
		private readonly byte k_Colon;

		// Token: 0x040000A2 RID: 162
		private readonly byte k_Dash;

		// Token: 0x040000A3 RID: 163
		private readonly byte k_Space;

		// Token: 0x040000A4 RID: 164
		private readonly byte k_Point;

		// Token: 0x040000A5 RID: 165
		private readonly byte k_Positive;

		// Token: 0x040000A6 RID: 166
		private readonly byte k_Negative;

		// Token: 0x040000A7 RID: 167
		private readonly byte[] k_True;

		// Token: 0x040000A8 RID: 168
		private readonly byte[] k_False;

		// Token: 0x040000A9 RID: 169
		private readonly byte[] k_Int2CharacterByte;

		// Token: 0x040000AA RID: 170
		private readonly long[] k_Order;

		// Token: 0x040000AB RID: 171
		private readonly IBufferSystemCalls m_SystemCalls;

		// Token: 0x040000AC RID: 172
		private readonly IDiskCache m_DiskCache;

		// Token: 0x040000AD RID: 173
		private readonly IIdentityManager m_UserIdentity;

		// Token: 0x040000AE RID: 174
		private readonly ISessionManager m_Session;

		// Token: 0x040000AF RID: 175
		private readonly List<EventSummary> m_EventSummaries;

		// Token: 0x040000B0 RID: 176
		private string m_CurrentEventId;

		// Token: 0x040000B1 RID: 177
		private string m_CurrentEventName;

		// Token: 0x040000B2 RID: 178
		private DateTime m_CurrentEventTimestamp;

		// Token: 0x040000B3 RID: 179
		private MemoryStream m_SpareBuffer;

		// Token: 0x040000B4 RID: 180
		private MemoryStream m_Buffer;
	}
}
