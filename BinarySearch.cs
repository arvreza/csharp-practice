public class BinarySearch {

   //for mid we can use mid = lo + (hi - lo) / 2
   public static object BinarySearchDisplay(int[] data, int item) {
         int min = 0;
         int N=data.Length;
         int max= N-1;
         do {
            int mid = (min+max) / 2;
            if (item > data[mid])
               min = mid + 1;
            else
               max = mid - 1;
            if (data[mid] == item)
               return mid;
            //if (min > max)
            //   break;
         } while(min <= max);
         return -1;
   }

   public static int RecursiveBinarySearch(int[] a, int min, int max, int t)
   {
      int mid = (min + max) / 2;
      if (a[mid] == t)
      {
         return mid;
      }
      if (a[mid] > t)
      {
         return   RecursiveBinarySearch(a, min, mid - 1, t);
      }
      if (max < min) return -1;
      
      return RecursiveBinarySearch(a, mid + 1, max, t);
   }
}