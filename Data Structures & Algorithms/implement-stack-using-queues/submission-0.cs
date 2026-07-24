public class MyStack {
    private Queue _stack;
    private Queue _temp;
    private int _topElement;

    private class ListNode {
        public int _val;
        public ListNode _next;

        public ListNode(int val) {
            _val = val;
            _next = null;
        }
    }

    private class Queue {
        public ListNode _left;
        public ListNode _right;
        public int _size;

        public Queue() {
            _left = null;
            _right = null;
            _size = 0;
        }

        public void Enqueue(int val) {
            ListNode newNode = new ListNode(val);

            if (_right != null)
            {
                _right._next = newNode;
                _right = newNode;
            }
            else
            {
                _left = newNode;
                _right = newNode;
            }
            _size++;
        }

        public int Dequeue() {
            if (_left == null)
            {
                return -1;
            }

            int val = _left._val;
            _left = _left._next;
            _size--;

            if (_left == null)
            {
                _right = null;
                _size = 0;
            }

            return val;
        }

        public bool IsEmpty() {
            if (_left == null && _right == null)
            {
                return true;
            }
            
            return false;
        }
    }

    public MyStack() {
        _stack = new Queue();
        _temp = new Queue();
    }
    
    public void Push(int x) {
        _stack.Enqueue(x);
        _topElement = x;
    }
    
    public int Pop() {
        int counter = 0;
        int val = 0;
        int stackSize = _stack._size;

        while (counter != stackSize - 1)
        {
            val = _stack.Dequeue();
            _topElement = val;
            _temp.Enqueue(val);
            counter++;
        }

        val = _stack.Dequeue();

        _stack = _temp;
        _temp = new Queue();
    
        return val;
    }
    
    public int Top() {
        return _topElement;
    }
    
    public bool Empty() {
        return _stack.IsEmpty();
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */