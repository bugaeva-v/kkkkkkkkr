using System;

namespace UnityEngine.Analytics
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public class TriggerRule
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002B1C File Offset: 0x00000D1C
		public bool Test()
		{
			bool flag;
			string text;
			return this.Test(out flag, out text);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002B34 File Offset: 0x00000D34
		public bool Test(out bool error, out string message)
		{
			error = false;
			message = null;
			if (this.m_Target == null || this.m_Target.GetValue() == null)
			{
				error = true;
				message = "rule target is not set";
				return false;
			}
			if (this.m_Value == null || this.m_Value.target == null || this.m_Value.propertyValue == null)
			{
				error = true;
				message = "rule value is not set";
				return false;
			}
			object value = this.m_Target.GetValue();
			string valueType = this.m_Value.valueType;
			if (valueType == typeof(string).ToString())
			{
				return this.TestByString((string)value);
			}
			if (valueType == typeof(bool).ToString())
			{
				return this.TestByBool((bool)value);
			}
			if (valueType == typeof(float).ToString())
			{
				return this.TestByDouble((double)((float)value));
			}
			if (valueType == typeof(double).ToString())
			{
				return this.TestByDouble((double)value);
			}
			if (valueType == typeof(decimal).ToString())
			{
				return this.TestByDouble((double)((decimal)value));
			}
			if (valueType == typeof(int).ToString())
			{
				return this.TestByDouble((double)((int)value));
			}
			if (valueType == typeof(short).ToString())
			{
				return this.TestByDouble((double)((short)value));
			}
			if (valueType == typeof(long).ToString())
			{
				return this.TestByDouble((double)((long)value));
			}
			if (valueType == "enum")
			{
				return this.TestByEnum(((Enum)value).ToString().ToLower());
			}
			return this.TestByObject(value);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002D04 File Offset: 0x00000F04
		private bool TestByObject(object currentValue)
		{
			bool result = false;
			TriggerOperator @operator = this.m_Operator;
			if (@operator != TriggerOperator.Equals)
			{
				if (@operator == TriggerOperator.DoesNotEqual)
				{
					result = !currentValue.Equals(this.m_Value.propertyValue);
				}
			}
			else
			{
				result = currentValue.Equals(this.m_Value.propertyValue);
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002D50 File Offset: 0x00000F50
		private bool TestByEnum(string currentValue)
		{
			bool result = false;
			TriggerOperator @operator = this.m_Operator;
			if (@operator != TriggerOperator.Equals)
			{
				if (@operator == TriggerOperator.DoesNotEqual)
				{
					result = !currentValue.Equals(this.m_Value.propertyValue.ToString().ToLower());
				}
			}
			else
			{
				result = currentValue.Equals(this.m_Value.propertyValue.ToString().ToLower());
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002DB0 File Offset: 0x00000FB0
		private bool TestByString(string currentValue)
		{
			bool result = false;
			TriggerOperator @operator = this.m_Operator;
			if (@operator != TriggerOperator.Equals)
			{
				if (@operator == TriggerOperator.DoesNotEqual)
				{
					result = !currentValue.Equals(this.m_Value.propertyValue);
				}
			}
			else
			{
				result = currentValue.Equals(this.m_Value.propertyValue);
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002DFC File Offset: 0x00000FFC
		private bool TestByBool(bool currentValue)
		{
			bool result = false;
			bool obj = bool.Parse(this.m_Value.propertyValue);
			TriggerOperator @operator = this.m_Operator;
			if (@operator != TriggerOperator.Equals)
			{
				if (@operator == TriggerOperator.DoesNotEqual)
				{
					result = !currentValue.Equals(obj);
				}
			}
			else
			{
				result = currentValue.Equals(obj);
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002E44 File Offset: 0x00001044
		private bool TestByDouble(double currentValue)
		{
			bool result = false;
			double @double = this.GetDouble(this.m_Value.propertyValue);
			switch (this.m_Operator)
			{
			case TriggerOperator.Equals:
				result = this.SafeEquals(currentValue, @double);
				break;
			case TriggerOperator.DoesNotEqual:
				result = !this.SafeEquals(currentValue, @double);
				break;
			case TriggerOperator.IsGreaterThan:
				result = (currentValue > @double);
				break;
			case TriggerOperator.IsGreaterThanOrEqualTo:
				result = (currentValue > @double || this.SafeEquals(currentValue, @double));
				break;
			case TriggerOperator.IsLessThan:
				result = (currentValue < @double);
				break;
			case TriggerOperator.IsLessThanOrEqualTo:
				result = (currentValue < @double || this.SafeEquals(currentValue, @double));
				break;
			case TriggerOperator.IsBetween:
			{
				double double2 = this.GetDouble(this.m_Value2.propertyValue);
				result = (currentValue > @double && currentValue < double2);
				break;
			}
			case TriggerOperator.IsBetweenOrEqualTo:
			{
				double double3 = this.GetDouble(this.m_Value2.propertyValue);
				result = (this.SafeEquals(currentValue, @double) || this.SafeEquals(currentValue, double3) || (currentValue > @double && currentValue < double3));
				break;
			}
			}
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F43 File Offset: 0x00001143
		private bool SafeEquals(double double1, double double2)
		{
			return Math.Abs(double1 - double2) < 1E-07;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F58 File Offset: 0x00001158
		private double GetDouble(object value)
		{
			return double.Parse(value.ToString());
		}

		// Token: 0x04000052 RID: 82
		[SerializeField]
		private TrackableField m_Target;

		// Token: 0x04000053 RID: 83
		[SerializeField]
		private TriggerOperator m_Operator;

		// Token: 0x04000054 RID: 84
		[SerializeField]
		private ValueProperty m_Value;

		// Token: 0x04000055 RID: 85
		[SerializeField]
		private ValueProperty m_Value2;
	}
}
