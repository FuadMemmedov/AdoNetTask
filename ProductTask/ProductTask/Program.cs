using Business.Enums;
using ProductTask.Controllers;

namespace ProductTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new ProductController();
            CategoryController categoryController = new CategoryController();

            int answer;

            do
            {
                Console.WriteLine("1.AddCategory\n" +
                    "2.DeleteCategory\n" +
                    "3.UpdateCategory\n" +
                    "4.GetCategory\n" +
                    "5.GetAllCategory\n" +
                    "6.AddProduct\n" +
                    "7.DeleteProduct\n" +
                    "8.UpdateProduct\n" +
                    "9.GetProduct\n" +
                    "10.GetAllProduct\n" +
                    "0.Exit");

                do
                {
                    Console.Write(" Bir secim edin: ");
                }
                while (!int.TryParse(Console.ReadLine(), out answer));

                switch (answer)
                {
                    case (byte)Menu.AddCategory:
                        categoryController.AddCategory();
                        break;
                    case (byte)Menu.DeleteCategory:
                        categoryController.DeleteCategory();
                        break;
                    case (byte)Menu.UpdateCategory:
                        categoryController.UpdateCategory();
                        break;
                    case (byte)Menu.GetCategory:
                        categoryController.Get();
                        break;
                    case (byte)Menu.GetAllCategory:
                        categoryController.ShowAllCategory();
                        break;
                    case (byte)Menu.AddProduct:
                        productController.AddProduct();
                        break;
                    case (byte)Menu.DeleteProduct:
                        productController.DeleteProduct();
                        break;
                    case (byte)Menu.UpdateProduct:
                        productController.UpdateProduct();
                        break;
                    case (byte)Menu.GetProduct:
                        productController.Get();
                        break;
                    case (byte)Menu.GetAllProduct:
                        productController.ShowAllProduct();
                        break;
                }
            }
            while (answer != 0);
        }



    }
    
}

