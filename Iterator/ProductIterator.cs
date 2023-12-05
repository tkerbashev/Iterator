namespace Iterator
{
    public class ProductIterator( Product[ , ] products ) : IProductIterator
    {
        private readonly Product[ ,] _products = products;
        private int _currentRow, _currentColumn;
        private readonly int _totalRows = products.GetLength( 0 ), _totalColumns = products.GetLength( 1 );

        public bool IsFinished => _currentRow >= _totalRows;

        public Product CurrentProduct => _products[ _currentRow, _currentColumn ];

        public Product First( )
        {
            _currentRow = 0;
            _currentColumn = 0;
            return _products[ _currentRow, _currentColumn];
        }

        public Product? Next( )
        {
            _currentColumn++;
            if ( _currentColumn < _totalColumns )
            {
                return CurrentProduct;
            }
            _currentColumn = 0;
            _currentRow++;

            if (_currentRow < _totalRows)
            {
                return CurrentProduct;
            }

            return null;
        }
    }
}
