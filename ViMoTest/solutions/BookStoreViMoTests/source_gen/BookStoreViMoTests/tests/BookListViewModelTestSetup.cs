/// <filename>
///     BookListViewModelTestSetup.cs
/// </filename>


internal abstract class BookListViewModelTestSetup
{
    public   abstract void Init();
 
    public   abstract void SetDataTableString(string multiLineString);
 
    public   abstract BookListViewModel BuildSut();
}
