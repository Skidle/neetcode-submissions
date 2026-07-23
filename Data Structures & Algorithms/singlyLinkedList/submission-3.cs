public class LinkedList {
    private class Node {
        public int val { get; set; }
        public Node next { get; set; }
    }

    private Node _head { get; set; }
    private Node _tail { get; set; }
    private int _count { get; set; }

    public LinkedList() {
        _head = null;
        _tail = _head;
        _count = 0;
    }

    public int Get(int index) {
        if (index < 0 || index >= _count) {
            return -1;
        }

        int counter = 0;
        Node dummy = _head;

        while (dummy != null && counter != index) {
            dummy = dummy.next;
            counter++;
        }

        return dummy.val;
    }

    public void InsertHead(int val) {
        Node newHead = new Node();
        newHead.val = val;
        newHead.next = _head;

        if (_head == null) {
            _tail = newHead;
        }

        _head = newHead;
        _count++;
    }

    public void InsertTail(int val) {
        Node newTail = new Node();
        newTail.val = val;
        newTail.next = null;

        if (_head == null) {
            _head = newTail;
            _tail = newTail;
            _count++;
            return;
        }

        _tail.next = newTail;
        _tail = newTail;
        _count++;
    }

    public bool Remove(int index) {
        if (index < 0 || index >= _count) {
            return false;
        }

        if (index == 0) {
            _head = _head.next;
            _count--;

            if (_head == null) {
                _tail = null;
            }

            return true;
        }

        Node dummy = _head;
        Node prev = dummy;
        int counter = 0;

        while (dummy != null) {
            if (counter == index) {
                if (dummy.next == null) {
                    _tail = prev;
                }

                prev.next = dummy.next;
                _count--;
                break;
            }

            prev = dummy;
            dummy = dummy.next;
            counter++;
        }

        return true;
    }

    public List<int> GetValues() {
        List<int> arr = new List<int>();
        Node dummy = _head;

        while (dummy != null) {
            arr.Add(dummy.val);
            dummy = dummy.next;
        }

        return arr;
    }
}