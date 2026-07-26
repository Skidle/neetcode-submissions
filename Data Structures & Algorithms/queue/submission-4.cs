class Deque {
    private class ListNode {
        public int _val;
        public ListNode _next;
        public ListNode _prev;

        public ListNode(int value = 0) {
            _val = value;
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
        return _count == 0;
    }

    public void append(int value) {
        ListNode node = new ListNode(value);

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
        ListNode node = new ListNode(value);

        if (isEmpty()) {
            _left = node;
            _right = _left;
        }
        else
        {
            ListNode temp = _left;
            _left._prev = node;
            _left = node;
            _left._next = temp;
        }

        _count++;
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }

        int resultVal = _right._val;

        if (_count == 1) {
            _left = null;
            _right = null;
            _count--;
            return resultVal;
        }

        ListNode prevRight = _right._prev;
        prevRight._next = null;
        _right = prevRight;
        _count--;

        return resultVal;
    }

    public int popleft() {
        if (isEmpty()) {
            return -1;
        }

        int resultVal = _left._val;

        if (_count == 1) {
            _left = null;
            _right = null;
            _count--;
            return resultVal;
        }

        ListNode nextLeft = _left._next;
        nextLeft._prev = null;
        _left = nextLeft;
        _count--;

        return resultVal;
    }
}
