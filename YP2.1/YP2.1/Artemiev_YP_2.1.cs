

//ЗАдание 1
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите строку с драгоценностями:");
//         string J = Console.ReadLine();
//
//         Console.WriteLine("Введите строку с камнями:");
//         string S = Console.ReadLine();
//
//         int count = 0;
//     
//        
//         foreach (char c in S){
//             if (J.Contains(c)) {
//                 count++;
//             }
//         }
//     
//         Console.WriteLine(count); // выводим результат
//     }
// }



//Задание 2
// class MainClass {
//     static void Main() {
//         Console.Write("Введите элементы массива через пробел: ");
//         int[] candidates = Console.ReadLine().Split().Select(int.Parse).ToArray();
//
//         Console.Write("Введите целевое значение: ");
//         int target = int.Parse(Console.ReadLine());
//
//         var result = CombinationSum(candidates, target);
//
//         Console.WriteLine("Уникальные комбинации чисел, сумма которых равна цели:");
//         foreach (var combination in result) {
//             Console.WriteLine(string.Join(", ", combination));
//         }
//     }
//
//     static IList<IList<int>> CombinationSum(int[] candidates, int target) {
//         var result = new List<IList<int>>();
//         Array.Sort(candidates);
//         Backtrack(result, new List<int>(), candidates, target, 0);
//         return result;
//     }
//
//     static void Backtrack(IList<IList<int>> result, IList<int> current, int[] candidates, int target, int start) {
//         if (target == 0) {
//             result.Add(new List<int>(current));
//             return;
//         }
//
//         for (int i = start; i < candidates.Length && candidates[i] <= target; i++) {
//             if (i > start && candidates[i] == candidates[i - 1]) continue;
//             current.Add(candidates[i]);
//             Backtrack(result, current, candidates, target - candidates[i], i + 1);
//             current.RemoveAt(current.Count - 1);
//         }
//     }
// }



//Задание 3
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите целочисленные значения через пробел:");
//         int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
//         bool result = ContainsDuplicate(nums);
//         Console.WriteLine(result);
//     }
//
//     public static bool ContainsDuplicate(int[] nums) {
//         Array.Sort(nums); 
//         for (int i = 1; i < nums.Length; i++) {
//             if (nums[i] == nums[i - 1]) {
//                 return true;
//             }
//         }
//         return false;
//     }
// }




