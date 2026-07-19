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
            _.Resize();
        }

        _.array[_.size] = n;
        _.size++;
    }

    public int PopBack() {
        int element = _.array[_.size - 1];
        _.array[_.size - 1] = -1;
        _.size--;
        return element;
    }

    private void Resize() {
        int[] newArr = new int[_.capacity * 2];
        for (int i = 0; i < _.array.Length; i++) {
            newArr[i] = _.array[i];
        }

        _.array = newArr;
        _.capacity = _.capacity * 2;
    }

    public int GetSize() {
        return _.size;
    }

    public int GetCapacity() {
        return _.capacity;
    }
}
