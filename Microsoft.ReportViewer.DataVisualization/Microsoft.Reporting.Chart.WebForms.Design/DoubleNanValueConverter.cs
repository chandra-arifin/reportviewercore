using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace Microsoft.Reporting.Chart.WebForms.Design
{
	internal class DoubleNanValueConverter : DoubleConverter
	{
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new StandardValuesCollection(new ArrayList
			{
				double.NaN
			});
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			double d = (double)value;
			if (destinationType == typeof(string) && double.IsNaN(d))
			{
				return "NotSet";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string && string.Compare((string)value, "NotSet", StringComparison.OrdinalIgnoreCase) == 0)
			{
				return double.NaN;
			}
			return base.ConvertFrom(context, culture, value);
		}
	}
}
