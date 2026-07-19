public class DynamicArray {
    private int[] array;
    private int size;
    private int capacity;
    
    public DynamicArray(int capacity) {
        this.array = new int[capacity];
        this.capacity = capacity;
        this.size = 0;
    }

    public int Get(int i) {
        return this.array[i];
    }

    public void Set(int i, int n) {
        this.array[i] = n;
    }

    public void PushBack(int n) {
        if (size == capacity) {
            this.Resize();
        }

        this.array[this.size] = n;
        this.size++;
    }

    public int PopBack() {
        int element = this.array[this.size - 1];
        this.array[this.size - 1] = -1;
        this.size--;
        return element;
    }

    private void Resize() {
        int[] newArr = new int[this.capacity * 2];
        for (int i = 0; i < this.array.Length; i++) {
            newArr[i] = this.array[i];
        }

        this.array = newArr;
        this.capacity = this.capacity * 2;
    }

    public int GetSize() {
        return this.size;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}
