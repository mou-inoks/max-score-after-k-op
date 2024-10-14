public class Solution {
    public long MaxKelements(int[] nums, int k) {
        long score = 0;

        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        
        foreach (var num in nums) {
            pq.Enqueue(num, num);
        }

       while (k-- > 0) {
            int num = pq.Dequeue();
            score += num;

            if (num % 3 == 0) {
                pq.Enqueue(num / 3, num / 3);
            } else {
                pq.Enqueue(num / 3 + 1, num / 3 + 1);
            }
        }

        return score;
    }
}