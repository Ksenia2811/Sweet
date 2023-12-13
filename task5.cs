using System;

// Создаем собственное исключение
class PriceLessThanZeroException : Exception
{
    public PriceLessThanZeroException(string message) : base(message) { }
}

// Создаем класс "Товар"
class Product
{
    private decimal _price;

    // Определяем свойство "Цена"
    public decimal Price
    {
        get { return _price; }
        set
        {
            try
            {
                if (value < 0)
                {
                    throw new PriceLessThanZeroException("Цена не может быть меньше 0");
                }
                else
                {
                    _price = value;
                }
            }
            catch (PriceLessThanZeroException ex)
            {
                Console.WriteLine(ex.Message);
                _price = 0;
            }
            finally
            {
                Console.WriteLine("Цена товара: " + _price);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();
        product.Price = 100;
        product.Price = -50;
    }
}
