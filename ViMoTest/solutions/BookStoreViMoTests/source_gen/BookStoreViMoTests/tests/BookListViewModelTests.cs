/// <filename>
///     BookListViewModelTests.cs
/// </filename>
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

[ Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class BookListViewModelTests
{
    private BookListViewModel sut;
 
    private BookListViewModelTestSetup testSetup;
 
  [ Microsoft.VisualStudio.TestTools.UnitTesting.TestInitialize]
  public void SetUp()
  {
    this.testSetup = new BookListViewModelTestSetupImpl();
    this.testSetup.Init();
  }
 
  [ Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
  public void Load_two_books_given_isbn_345_123_name_Book1_author_Max_Mustermann_price_5_stock_10_isbn_555_678_name_Book2_author_Alice_Wonderland_price_7_stock_4_when_LoadView_then_BookList_has_2_rows()
  {
    this.given_isbn_345_123_name_Book1_author_Max_Mustermann_price_5_stock_10_isbn_555_678_name_Book2_author_Alice_Wonderland_price_7_stock_4();
    this.BuildSut();
    this.when_LoadView();
    this.then_BookList_has_2_rows();
  }
 
    protected   virtual void BuildSut()
  {
    this.sut = this.testSetup.BuildSut();
  }
 
    private string isbn_345_123_name_Book1_author_Max_Mustermann_price_5_stock_10_isbn_555_678_name_Book2_author_Alice_Wonderland_price_7_stock_4 = @"| isbn | name | author | price | stock |
| 345-123 | Book1 | Max Mustermann | 5 | 10 |
| 555-678 | Book2 | Alice Wonderland | 7 | 4 |";
 
    public   virtual void given_isbn_345_123_name_Book1_author_Max_Mustermann_price_5_stock_10_isbn_555_678_name_Book2_author_Alice_Wonderland_price_7_stock_4()
  {
    this.testSetup.SetDataTableString(this.isbn_345_123_name_Book1_author_Max_Mustermann_price_5_stock_10_isbn_555_678_name_Book2_author_Alice_Wonderland_price_7_stock_4);
  }
 
    public   virtual void when_LoadView()
  {
    this.sut.loadView();
  }
 
    public   virtual void then_BookList_has_2_rows()
  {
    var actualRows = this.sut.getBookListTableRows();
    Assert.AreEqual(2, actualRows.Count);
    
    {
      var row0 = actualRows[0];
      Assert.IsFalse(row0.getIsSelectedCheckBoxChecked());
      Assert.AreEqual("Book1.png", row0.getPreviewImageName());
      Assert.AreEqual("Book1", row0.getTitleLabelText());
      Assert.AreEqual("Book1", row0.getTitleLabelText());
      Assert.AreEqual("Max Mustermann", row0.getAuthorLabelText());
      Assert.AreEqual("12345678", row0.getISBNLabelText());
      Assert.AreEqual("5.00 €", row0.getPriceLabelText());
      Assert.AreEqual("x10", row0.getStockLabelText());
    }
    
    {
      var row1 = actualRows[1];
      Assert.IsFalse(row1.getIsSelectedCheckBoxChecked());
      Assert.AreEqual("Book2.png", row1.getPreviewImageName());
      Assert.AreEqual("Book2", row1.getTitleLabelText());
      Assert.AreEqual("Alice Wonderland", row1.getAuthorLabelText());
      Assert.AreEqual("555-678", row1.getISBNLabelText());
      Assert.AreEqual("7.00 €", row1.getPriceLabelText());
      Assert.AreEqual("x4", row1.getStockLabelText());
    }
  }
}
