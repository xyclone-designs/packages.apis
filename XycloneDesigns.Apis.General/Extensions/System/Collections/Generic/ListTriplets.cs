
namespace System.Collections.Generic
{
	public interface IListTriplets<T1, T2, T3> : IList<Tuple<T1, T2, T3>> { }
	public class ListTriplets<T1, T2, T3> : List<Tuple<T1, T2, T3>>, IListTriplets<T1, T2, T3> { }
}