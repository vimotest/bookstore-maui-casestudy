/// <filename>
///     BookListViewModel.cs
/// </filename>
using System.Collections.Generic;

public class BookListViewModel
{
    private System.Collections.Generic.List<BookListViewModelBookListRow> BookListTableRows = new System.Collections.Generic.List<BookListViewModelBookListRow>();
 
    public   virtual System.Collections.Generic.List<BookListViewModelBookListRow> getBookListTableRows()
  {
    return this.BookListTableRows;
  }
 
    public   virtual void loadView()
  {
    
  }
 
    public   virtual void addClicked()
  {
    
  }
 
    public   virtual void deleteClicked()
  {
    
  }
 
    public   virtual void selectedChecked(int rowIndex, bool isChecked)
  {
    
  }
}
