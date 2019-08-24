# IComparable&lt;T> 與 IComparer&lt;T> 差異

* IComparable<T>是針對類別自己本身，當排序時 會默認CompareTo排序方式
* IComparer<T>是當你無法再修改類別本身排序的方式，可以透過 IComparer 的 Compare 來實現
