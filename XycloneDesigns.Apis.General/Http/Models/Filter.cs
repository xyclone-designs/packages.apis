using System;
using System.Collections.Generic;
using System.Linq;

using XycloneDesigns.Apis.General.Http.Enums;

namespace XycloneDesigns.Apis.General.Http.Models
{
	public class Filter(string key, object? value, Operations operation = Operations.Equal) : IParsable<Filter>
	{
		private byte? _ValueByte;
		private DateTime? _ValueDateTime;
		private decimal? _ValueDecimal;
		private double? _ValueDouble;
		private int? _ValueInt;
		private long? _ValueLong;
		private string? _ValueString;

		public string Key { get; set; } = key;
		public Operations Operation { get; set; } = operation;

		public object? Value { get; set; } = value;
		public byte? ValueByte
		{
			set => Value = _ValueByte = value;
			get => _ValueByte ??= byte.TryParse((Value as string) ?? Value?.ToString(), out byte _valuebyte) ? _valuebyte : new byte?();
		}
		public DateTime? ValueDateTime
		{
			set => Value = _ValueDateTime = value;
			get => _ValueDateTime ??= DateTime.TryParse((Value as string) ?? Value?.ToString(), out DateTime _valuedatetime) ? _valuedatetime : new DateTime?();
		}
		public decimal? ValueDecimal
		{
			set => Value = _ValueDecimal = value;
			get => _ValueDecimal ??= decimal.TryParse((Value as string) ?? Value?.ToString(), out decimal _valuedecimal) ? _valuedecimal : new decimal?();
		}
		public double? ValueDouble
		{
			set => Value = _ValueDouble = value;
			get => _ValueDouble ??= double.TryParse((Value as string) ?? Value?.ToString(), out double _valuedouble) ? _valuedouble : new double?();
		}
		public int? ValueInt
		{
			set => Value = _ValueInt = value;
			get => _ValueInt ??= int.TryParse((Value as string) ?? Value?.ToString(), out int _valueint) ? _valueint : new int?();
		}
		public long? ValueLong
		{
			set => Value = _ValueLong = value;
			get => _ValueLong ??= long.TryParse((Value as string) ?? Value?.ToString(), out long _valuelong) ? _valuelong : new long?();
		}
		public string? ValueString
		{
			get => _ValueString ??= Value as string;
			set => Value = value;
		}

		public virtual string AsString()
		{
			return string.Format("{0}|{1}|{2}", Key, Value?.ToString() ?? "null", Operation);
		}

		public bool Passes<T>(T? value)
		{
			return Operation switch
			{
				Operations.Equal => true switch
				{
					true when value is byte _byte => _byte == ValueByte,
					true when value is DateTime _DateTime => _DateTime == ValueDateTime,
					true when value is decimal _decimal => _decimal == ValueDecimal,
					true when value is double _double => _double == ValueDouble,
					true when value is int _int => _int == ValueInt,
					true when value is long _long => _long == ValueLong,
					true when value is string _string => string.Equals(_string, ValueString, StringComparison.OrdinalIgnoreCase),

					_ => false
				},

				Operations.NotEqual => true switch
				{
					true when value is byte _byte => _byte != ValueByte,
					true when value is DateTime _DateTime => _DateTime != ValueDateTime,
					true when value is decimal _decimal => _decimal != ValueDecimal,
					true when value is double _double => _double != ValueDouble,
					true when value is int _int => _int != ValueInt,
					true when value is long _long => _long != ValueLong,
					true when value is string _string => string.Equals(_string, ValueString, StringComparison.OrdinalIgnoreCase) is false,

					_ => false
				},

				Operations.LessThan => true switch
				{
					true when value is byte _byte => _byte < ValueByte,
					true when value is DateTime _DateTime => _DateTime < ValueDateTime,
					true when value is decimal _decimal => _decimal < ValueDecimal,
					true when value is double _double => _double < ValueDouble,
					true when value is int _int => _int < ValueInt,
					true when value is long _long => _long < ValueLong,
					true when value is string _string => Comparer<string>.Default.Compare(_string, ValueString) < 0,

					_ => false
				},

				Operations.LessThanOrEqual => true switch
				{
					true when value is byte _byte => _byte <= ValueByte,
					true when value is DateTime _DateTime => _DateTime <= ValueDateTime,
					true when value is decimal _decimal => _decimal <= ValueDecimal,
					true when value is double _double => _double <= ValueDouble,
					true when value is int _int => _int <= ValueInt,
					true when value is long _long => _long <= ValueLong,
					true when value is string _string => Comparer<string>.Default.Compare(_string, ValueString) <= 0,

					_ => false
				},

				Operations.GreaterThan => true switch
				{
					true when value is byte _byte => _byte > ValueByte,
					true when value is DateTime _DateTime => _DateTime > ValueDateTime,
					true when value is decimal _decimal => _decimal > ValueDecimal,
					true when value is double _double => _double > ValueDouble,
					true when value is int _int => _int > ValueInt,
					true when value is long _long => _long > ValueLong,
					true when value is string _string => Comparer<string>.Default.Compare(_string, ValueString) > 0,

					_ => false
				},

				Operations.GreaterThanOrEqual => true switch
				{
					true when value is byte _byte => _byte >= ValueByte,
					true when value is DateTime _DateTime => _DateTime >= ValueDateTime,
					true when value is decimal _decimal => _decimal >= ValueDecimal,
					true when value is double _double => _double >= ValueDouble,
					true when value is int _int => _int >= ValueInt,
					true when value is long _long => _long >= ValueLong,
					true when value is string _string => Comparer<string>.Default.Compare(_string, ValueString) >= 0,

					_ => false
				},

				_ => false
			};
		}
		public bool Equals<T>(Filter filter)
		{
			return
				Operation == filter.Operation &&
				string.Equals(Key, filter.Key, StringComparison.OrdinalIgnoreCase) &&
				true switch
				{
					true when typeof(T) == typeof(byte) => filter.ValueByte == ValueByte,
					true when typeof(T) == typeof(DateTime) => filter.ValueDateTime == ValueDateTime,
					true when typeof(T) == typeof(decimal) => filter.ValueDecimal == ValueDecimal,
					true when typeof(T) == typeof(double) => filter.ValueDouble == ValueDouble,
					true when typeof(T) == typeof(int) => filter.ValueInt == ValueInt,
					true when typeof(T) == typeof(long) => filter.ValueLong == ValueLong,
					true when typeof(T) == typeof(string) => string.Equals(filter.ValueString, ValueString, StringComparison.OrdinalIgnoreCase),

					_ => Equals(filter.Value, Value)
				};
		}

		public static Filter Parse<T>(string value)
		{
			string[] _str = value.Split('|', 3, StringSplitOptions.TrimEntries);

			string? key = _str.ElementAtOrDefault(0);
			Operations? operation = Enum.TryParse(_str.ElementAtOrDefault(2), true, out Operations _operation) ? _operation : new Operations?();
			object? val = _str.ElementAtOrDefault(1) is not string _value || string.Equals(_value, "null", StringComparison.OrdinalIgnoreCase)
				? default
				: true switch
				{
					true when typeof(T) == typeof(byte) => byte.TryParse(_value, out byte _byte) ? _byte : null,
					true when typeof(T) == typeof(DateTime) => DateTime.TryParse(_value, out DateTime _DateTime) ? _DateTime : null,
					true when typeof(T) == typeof(decimal) => decimal.TryParse(_value, out decimal _decimal) ? _decimal : null,
					true when typeof(T) == typeof(double) => double.TryParse(_value, out double _double) ? _double : null,
					true when typeof(T) == typeof(int) => int.TryParse(_value, out int _int) ? _int : null,
					true when typeof(T) == typeof(long) => long.TryParse(_value, out long _long) ? _long : null,
					true when typeof(T) == typeof(string) => _value,

					_ => _value
				};

			return new Filter(key ?? string.Empty, val, operation ?? Operations.Equal);
		}
		public static Filter Parse(string value, IFormatProvider? provider)
		{
			if (TryParse(value, provider, out Filter filter))
				return filter;

			return Parse<object>(value);
		}
		public static bool TryParse(string? value, IFormatProvider? provider, out Filter filter)
		{
			filter = null;

			if (value?.Split('|', 3, StringSplitOptions.TrimEntries) is not string[] str)
				return false;

			if (str.ElementAtOrDefault(0) is not string key)
				return false;

			if (str.ElementAtOrDefault(1) is not string val)
				return false;

			if (Enum.TryParse(str.ElementAtOrDefault(2), true, out Operations operation) is false)
				return false;

			filter = new Filter(key, val, operation);

			return true;
		}
	}

	public static class FilterExtensions
	{
		public static IEnumerable<Filter>? FromOperations(this IEnumerable<Filter> filters, params Operations[] operations)
		{
			IEnumerable<Filter> _filters = filters.Where(_ => operations.Contains(_.Operation));

			return _filters.Any() ? null : _filters;
		}
		public static IEnumerable<Filter>? FromOperationsNot(this IEnumerable<Filter> filters, params Operations[] operations)
		{
			IEnumerable<Filter> _filters = filters.Where(_ => operations.Contains(_.Operation) is false);

			return _filters.Any() ? null : _filters;
		}
	}		
}
