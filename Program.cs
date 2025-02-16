using Demo01.Data;
using System.Collections;
using System.ComponentModel.DataAnnotations;
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

            #region Generation Operators - Deferred Execution


            //Valid With Fluent Syntax Only
            //The Only Way To Call Them is As Static Methods from Enumerable Class

            //var Result = Enumerable.Range(0, 100); // 0....99
            //foreach (var item in Result)
            //    Console.Write( $" {item} " );

            //var Result = Enumerable.Repeat(2, 100);
            //foreach (var item in Result)
            //    Console.Write($" {item} ");   // Return IEnumerable Of  100 Element each One = 2

            //var Result = Enumerable.Repeat(new Product() , 100);
            ////Return IEnumerable Of 100 Product 
            //foreach (var item in Result)
            //    Console.Write($" {item} ");

            //   var arrayProduct = Enumerable.Empty<Product>().ToArray();
            //   Product[] Products = new Product[0];
            //   // Both Will Generate an Empty Array Of Products 

            //   var List = Enumerable.Empty<Product>().ToList();
            //   List<Product> products02 = new List<Product>();
            //   // Both Will Generate an Empty List  Of Products 


            //   foreach (var item in List)
            //       Console.Write($" {item} ");











            #endregion

            #region Set Operators [Union Family] - Deferred Execution
            /*
             Union => WithOut Duplication 

             Concat [UnionAll] => With Duplication
            
             Intersect => Return Elements in 1st Sequence and Exist in 2nd Sequence 

             Except=> Return Elements in 1st Sequence and Not Exist in 2nd Sequence

             Distinct => Remove Duplicates [Concat + Distinct => Act as Union]
             */


            //     var Seq01 = Enumerable.Range(0, 100); // 0 ....99 
            //     var Seq02 = Enumerable.Range(50, 100); // 50.....149
            // 
            //     //var Result = Seq01.Union(Seq02);  // 0...149 -> Remove Duplication        //     من نفس النوع    Two  Sequance  لا ال  
            //     //var Result = Seq01.Concat(Seq02); // 0 .. 99 +  50...149
            //     // Result = Result.Distinct();  // Remove Duplication
            // 
            //     //var Result = Seq01.Intersect(Seq02); // هيرجعلي المشترك بين الاتنين 
            //     var Result = Seq01.Except(Seq02);  //   Seq02  وف نفس الوقت مش موجود فال   Seq01 هيرجع الموجود فال 
            //     Console.WriteLine( "\n===========Seq01===========");
            //     foreach (var item in Seq01)
            //         Console.Write($" {item} ");
            //  
            //     Console.WriteLine("\n===========Seq02===========");
            //     foreach (var item in Seq02)
            //         Console.Write($" {item} ");
            //  
            //     Console.WriteLine("\n===========Result ===========");
            //  
            //     foreach (var item in Result)
            //         Console.Write($" {item} ");
            // 


            #endregion

            #region Quantifier Operator - Deferred Execution -  Return boolean
            //    var Result = ProductList.Any();
            //    // If Sequence Contain At Least One Element => True 
            //    Result = ProductList.Any(P => P.UnitsInStock > 1000);
            //    // If Sequence Contain At Least One Element  Match Condition  => True 
            //
            //
            //
            //    Result = ProductList.All(P => P.UnitsInStock > 1); // False 
            //                                                       //  All => If All Elements in Sequence Match Condition Will Return True
            //
            //
            //
            //
            //        var Seq01 = Enumerable.Range(0, 100); // 0 ....99 
            //        var Seq02 = Enumerable.Range(0, 100); // 0 ....99   // True 
            //        //var Seq02 = Enumerable.Range(50, 100); // 50.....149 // False 
            //
            //    Result = Seq01.SequenceEqual(Seq02);
            //    // SequenceEqual => If Two Sequences are Equal Will Return True 
            //
            //    Console.WriteLine(Result);
            //
            //
            //




            #endregion

            #region Zipping Operator - Deferred Execution - ZIP

            //      //ZIP => Produces a sequence with elements from the Two Or Three specific sequences.
            // 
            //      string[] Names = { "Omar", "Amr", "Ahmed", "May", "Aya" };
            //      int[] Numbers = Enumerable.Range(0, 10).ToArray();
            //      char[] Chars = { 'A', 'B', 'C', 'D' };
            // 
            //      //var Result = Names.Zip(Numbers);
            //      // (Omar, 0)
            //      // (Amr, 1)
            //      // (Ahmed, 2)
            //      // (May, 3)
            //      // (Aya, 4)
            // 
            // 
            //      //var Result = Names.Zip(Numbers, (Names, Numbers) => new { index = Numbers, Names });   //    OutPut  لو عايزين نتحكم ف شكل ال 
            // 
            //      var Result = Names.Zip(Names, Chars);  // OutPut =>   فيهم   Sequance    هيكون علي حسب اقل 
            //      foreach (var item  in Result)          //  علشان هو عندو اقل واحد فيهم   Chars  الي هو بتاع ال  Sequance  يعني مثلا هنا هيكون علي حسب ال 
            //          Console.WriteLine(item);
            // 


            #endregion


            #region Grouping Operators  

            #region Get Products Grouped by Category

            ///  // Query Syntax
            /// var Result = from P in ProductList
            ///             group P by P.Category;

            ///   // Fluent Syntax 
            ///   var Result = ProductList.GroupBy(P => P.Category);






            ///  foreach (var item  in Result)
            ///  {
            ///      Console.WriteLine(item);    //System.Linq.Grouping`2[System.String,Demo01.Data.Product]
            ///                                  //    كدا الطريقه دي مش هتنفع معانا 
            ///  }


            #endregion

            #region Get Products in Stock Grouped by Category
            ///   // Fluent Syntax
            ///   var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ///                                   .GroupBy( P =>P.Category );

            ///     // Query Syntax 
            ///     Result = from P in ProductList
            ///              where P.UnitsInStock > 0
            ///              group P by P.Category;
            #endregion

            #region Get Products in Stock Grouped by Category That Contains More Than 10 Product
            ///    // Fluent Syntax 
            /// var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ///                                 .GroupBy(P => P.Category)
            ///                                 .Where(P => P.Count() > 10);
            ///

            ///   //Query Syntax 
            ///   var Result =  from P in ProductList
            ///                 where P.UnitsInStock >0
            ///                 group P by P.Category
            ///                 into  Category 
            ///                 where Category.Count() >10 
            ///                 select Category;




            #endregion

            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            ///   // Fluent Syntax 
            ///   var Result = ProductList.Where(P => P.UnitsInStock > 0)
            ///                                   .GroupBy(P => P.Category)
            ///                                   .Where(P => P.Count() > 10)
            ///                                   .Select( X =>new 
            ///                                   {
            ///                                       CategoryName = X.Key,
            ///                                       Count = X.Count()
            ///                                   });
            ///          foreach (var Item in Result)
            ///          
            ///              Console.WriteLine(Item);


             ///   // Query Synatx        
       ///    var Result = from P in ProductList
      ///                 where P.UnitsInStock > 0
      ///                 group P by P.Category
      ///                 into Category
      ///                 where Category.Count() > 10
      ///                 select new
      ///                 {
      ///                     CategoryName = Category.Key,
      ///                     Count = Category.Count(),
      ///                 };
      ///    foreach (var Item in Result) 
      ///        Console.WriteLine(Item);   //    IEnemerable   لا الي راجع دلوقتي عباره   IGrouping    عملت كدا علشان الي راجع مش 

            #endregion








            ///    foreach (var Category in Result)
            ///  {
            ///      Console.WriteLine(Category.Key);  // Name Of Category       //         من جوه  Category   علي كل  Loop  محتاجين ن 
            ///      foreach (var Product in Category)
            ///          Console.WriteLine($"                      {Product.ProductName}");
            ///  }

            #endregion





        }
    }
}
