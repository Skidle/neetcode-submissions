public class Solution {
    public class Stack {
        List<int> stack;

        public Stack() {
            stack = new List<int>();
        }

        public void Push(int value) {
            stack.Add(value);
        }

        public int Pop() {
            if (stack.Count == 0) {
                return -1;
            }

            int temp = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            return temp;
        }

        public int Peek() {
            if (stack.Count == 0) {
                return -1;
            }

            return stack[stack.Count - 1];
        }

        public bool IsEmpty() {
            return stack.Count == 0;
        }

        public int Count() {
            return stack.Count;
        }

        public bool Contains(int value) {
            return stack.Contains(value);
        }
    }

    public class Queue {
        List<int> queue;

        public Queue() {
            queue = new List<int>();
        }

        public void Enqueue(int value) {
            queue.Add(value);
        }

        public int Dequeue() {
            if (queue.Count == 0) {
                return -1;
            }

            int temp = queue[0];
            queue.RemoveAt(0);
            return temp;
        }

        public int Peek() {
            if (queue.Count == 0) {
                return -1;
            }

            return queue[0];
        }

        public bool IsEmpty() {
            return queue.Count == 0;
        }

        public int Count() {
            return queue.Count;
        }

        public bool Contains(int value) {
            return queue.Contains(value);
        }
    }

    public int CountStudents(int[] students, int[] sandwiches) {
        Queue studentQueue = new Queue();
        Stack sandwichStack = new Stack();

        int result = students.Length;

        foreach (var student in students) {
            studentQueue.Enqueue(student);
        }

        for (int i = sandwiches.Length - 1; i >= 0; i--) {
            sandwichStack.Push(sandwiches[i]);
        }

        while (studentQueue.Contains(sandwichStack.Peek())) {
            int frontStudent = studentQueue.Peek();
            int topSandwich = sandwichStack.Peek();

            if (frontStudent == topSandwich) {
                studentQueue.Dequeue();
                sandwichStack.Pop();
                result--;
            }
            else {
                studentQueue.Dequeue();
                studentQueue.Enqueue(frontStudent);
            }
        }

        return result < 0 ? 0 : result;
    }
}