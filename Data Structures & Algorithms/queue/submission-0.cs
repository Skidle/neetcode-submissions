class Deque {
    private class ListNode {
        public int _val;
        public ListNode _next;
        public ListNode _prev;

        public ListNode() {
            _val = 0;
            _next = null;
            _prev = null;
        }
    }

    private ListNode _left;
    private ListNode _right;
    private int _count;

    public Deque() {
        _left = null;
        _right = null;
        _count = 0;
    }

    public bool isEmpty() {
        if (_count == 0) {
            return true;
        }

        return false;
    }

    public void append(int value) {
        ListNode node = new ListNode()
        {
            _val = value;
            _next = null;
            _prev = null;
        }

        if (isEmpty()) {
            _right = node;
            _left = _right;
        }
        else
        {
            ListNode temp = _right;
            _right._next = node;
            _right = node;
            _right._prev = temp;
        }

        _count++;
    }

    public void appendleft(int value) {
        ListNode node = new ListNode()
        {
            _val = value;
            _next = null;
        }

        if (isEmpty()) {
            _left = node;
            _right = _left;
        }

        ListNode temp = _left;
        _left = node;
        _left._next = temp;

        _count++;
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }

        int temp = _right._val;



        _count--;
    }

    public int popleft() {

    }
}
