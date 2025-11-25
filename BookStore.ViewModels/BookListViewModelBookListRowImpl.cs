using CommunityToolkit.Mvvm.ComponentModel;

namespace BookStore.ViewModels
{
    /// <summary>
    /// Implementation of BookListViewModelBookListRow following the Presentation-Ready ViewModel rule.
    /// Exposes only primitive types (string, bool) for data binding.
    /// </summary>
    [ObservableObject]
    internal partial class BookListViewModelBookListRowImpl : BookListViewModelBookListRow
    {
        private bool _isSelected;
        private string _previewImageName = string.Empty;
        private string _titleLabelText = string.Empty;
        private string _authorLabelText = string.Empty;
        private string _isbnLabelText = string.Empty;
        private string _priceLabelText = string.Empty;
        private string _stockLabelText = string.Empty;
        private string _rowHandle = string.Empty;

        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }

        public string PreviewImageName
        {
            get => _previewImageName;
            set => SetProperty(ref _previewImageName, value);
        }

        public string TitleLabelText
        {
            get => _titleLabelText;
            set => SetProperty(ref _titleLabelText, value);
        }

        public string AuthorLabelText
        {
            get => _authorLabelText;
            set => SetProperty(ref _authorLabelText, value);
        }

        public string IsbnLabelText
        {
            get => _isbnLabelText;
            set => SetProperty(ref _isbnLabelText, value);
        }

        public string PriceLabelText
        {
            get => _priceLabelText;
            set => SetProperty(ref _priceLabelText, value);
        }

        public string StockLabelText
        {
            get => _stockLabelText;
            set => SetProperty(ref _stockLabelText, value);
        }

        public string RowHandle
        {
            get => _rowHandle;
            set => SetProperty(ref _rowHandle, value);
        }

        public override bool getIsSelectedCheckBoxChecked()
        {
            return IsSelected;
        }

        public override string getPreviewImageName()
        {
            return PreviewImageName;
        }

        public override string getTitleLabelText()
        {
            return TitleLabelText;
        }

        public override string getAuthorLabelText()
        {
            return AuthorLabelText;
        }

        public override string getISBNLabelText()
        {
            return IsbnLabelText;
        }

        public override string getPriceLabelText()
        {
            return PriceLabelText;
        }

        public override string getStockLabelText()
        {
            return StockLabelText;
        }

        public override string getRowHandle()
        {
            return RowHandle;
        }
    }
}
