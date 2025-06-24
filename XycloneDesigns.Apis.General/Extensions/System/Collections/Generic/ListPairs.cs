
namespace System.Collections.Generic
{
	public interface IListPairs<T1, T2> : IList<Tuple<T1, T2>> { }
	public class ListPairs<T1, T2> : List<Tuple<T1, T2>>, IListPairs<T1, T2> { }
}