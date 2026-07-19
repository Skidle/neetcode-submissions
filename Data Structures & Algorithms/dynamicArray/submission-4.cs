public class DynamicArray {
    private int[] _array;
    private int _size;
    private int _capacity;
    
    public DynamicArray(int capacity) {
        _array = new int[capacity];
        _capacity = capacity;
        _size = 0;
    }

    public int Get(int i) {
        return _array[i];
    }

    public void Set(int i, int n) {
        _array[i] = n;
    }

    public void PushBack(int n) {
        if (_size == _capacity) {
            Resize();
        }

        _array[_size] = n;
        _size++;
    }

    public int PopBack() {
        int element = _array[_size - 1];
        _array[_size - 1] = -1;
        _size--;
        return element;
    }

    private void Resize() {
        _capacity *= 2;
        int[] newArr = new int[_capacity];
        for (int i = 0; i < _array.Length; i++) {
            newArr[i] = _array[i];
        }

        _array = newArr;
    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
