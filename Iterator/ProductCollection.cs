namespace Iterator
{
    public class ProductCollection( Product[ , ] products ) : IProductCollection
    {
        private readonly Product[ ,] _products = products;

        public IProductIterator GetIterator( )
        {
            return new ProductIterator( _products );
        }
    }
}
