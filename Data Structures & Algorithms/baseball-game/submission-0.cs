public class Solution {
    public class Stack {
        private int[] _array;
        private int _size;
        private int _capacity;

        public Stack(int capacity) {
            _capacity = capacity;
            _array = new int[capacity];
            _size = 0;
        }

        public int Pop() {
            int element = _array[_size - 1];
            _size--;
            return element;
        }

        public void Push(int n) {
            if (_size == _capacity && _size != 0) {

            }
            _array[_size] = n;
            _size++;
        }

        public int Peek() {
            return _array[_size - 1];
        }
    }

    public int CalPoints(string[] operations) {
        int operationsLen = operations.Length;

        Stack scoreRecords = new Stack(operationsLen);

        int resultScore = 0;

        for (int i = 0; i < operationsLen; i++) {
            string op = operations[i];

            if (int.TryParse(op, out int value)) {
                scoreRecords.Push(value);
                resultScore += value;
            } else if (op == "+") {
                int popped = scoreRecords.Pop();
                int prevBeforePopped = scoreRecords.Peek();
                int sum = popped + prevBeforePopped;

                scoreRecords.Push(popped);
                scoreRecords.Push(sum);
                resultScore += sum;
            } else if (op == "C") {
                int invalid = scoreRecords.Pop();
                resultScore -= invalid;
            } else if (op == "D") {
                int prev = scoreRecords.Peek();
                int doubleScore = prev * 2;
                scoreRecords.Push(doubleScore);
                resultScore += doubleScore;
            }
        }

        return resultScore;
    }
}