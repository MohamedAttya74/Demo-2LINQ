using Demo01.Data;
using System.Collections;
using static Demo_2LINQ.ListGenerator;
namespace Demo_2LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting [Conversion] Operators - Immediate Execution

            ///   // ToList 
            ///   List<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToList(); // Casting To List 
            ///   //ToList => the ToList operator takes the element from the given source, and it returns a new List.

            ///  // ToArray
            ///  Product[] Result = ProductList.Where(P => P.UnitsInStock == 0).ToArray();  // Casting To Array 
            ///  //ToArray => is used to convert the input elements in the collection to an Array.

            ///   // ToDictionary
            ///   //Dictionary<long,Product> Result  = ProductList.Where(P => P.UnitsInStock ==0)
            ///   //                                                .ToDictionary(P => P.ProductID ); // بتاعي  Key   يعني بقوله مين هو ال  KeySelecror  هنا بحدد ال 
            ///   //foreach (var Product in Result)
            ///   //    Console.WriteLine($"Key : {Product.Key} , Value :{Product.Value}  ");
            /// 
            ///   //Dictionary<long, string> Result = ProductList.Where(P => P.UnitsInStock == 0)  // ProductID  بتاعي  Key هنا اعتبرت ان ال 
            ///   //    .ToDictionary(P => P.ProductID, P => P.ProductName);                       //  ProductName بتاعتي هي ال  Value  واعتبرت ان ال 
            /// 
            /// 
            ///   //foreach (var Product in Result)
            ///   //    Console.WriteLine($"Key : {Product.Key} , Value :{Product.Value}  ");

            ///  // ToHashSet() 
            ///  HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();
            ///  foreach (Product Product in Result)      // Value = Null  علطول 
            ///      Console.WriteLine(Product);
            ///   //   ToHashSet() =>  is used to convert the input elements in the collection to an Hashset.

            ///     // OfType() 
        ///     //ArrayList :   DataType   مش من نفس ال   Element  يعني بيقدرو يشيلوا  Hetrogenise   دي حاجه اسمها 
        ///     //OfType() => operator is used to return the element of the specific type, and another element will be ignored from the list/collection.
        ///     ArrayList Obj =  new ArrayList() 
        ///     { 
        ///          "Omar" ,
        ///          "Ahmed",
        ///          "Mona",
        ///          "Aliaa",
        ///
        ///          1,
        ///          2,
        ///          3
        ///     };
        ///     var Result = Obj.OfType<string  /*int*/ >();   
        ///     foreach (var i in Result) 
        ///         Console.WriteLine(i);  // Omar   Ahmed  Mona   Aliaa



            #endregion
        }
    }
}
