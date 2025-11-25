/// <filename>
///     BookListViewModelBookListRow.cs
/// </filename>


public class BookListViewModelBookListRow
{
    private bool isSelectedCheckBoxChecked;
 
    public   virtual bool getIsSelectedCheckBoxChecked()
  {
    return this.isSelectedCheckBoxChecked;
  }
 
    private string PreviewImageName;
 
    public   virtual string getPreviewImageName()
  {
    return this.PreviewImageName;
  }
 
    private string TitleLabelText;
 
    public   virtual string getTitleLabelText()
  {
    return this.TitleLabelText;
  }
 
    private string AuthorLabelText;
 
    public   virtual string getAuthorLabelText()
  {
    return this.AuthorLabelText;
  }
 
    private string ISBNLabelText;
 
    public   virtual string getISBNLabelText()
  {
    return this.ISBNLabelText;
  }
 
    private string PriceLabelText;
 
    public   virtual string getPriceLabelText()
  {
    return this.PriceLabelText;
  }
 
    private string StockLabelText;
 
    public   virtual string getStockLabelText()
  {
    return this.StockLabelText;
  }
 
    private string RowHandle;
 
    public   virtual string getRowHandle()
  {
    return this.RowHandle;
  }
}
