using System;
using System.Text;

namespace _02_动态数组
{
    /// <summary>
    /// 动态数组
    /// </summary>
    public class ArrayList<T>
    {
        private const int ELEMENT_NOT_FOUND = -1;
        private const int DEFAULT_CAPATICY = 10;

        /// <summary>
        /// 元素数量
        /// </summary>
        private int size;
        /// <summary>
        /// 元素数据
        /// </summary>
        private T[] elements;

        public ArrayList() : this(DEFAULT_CAPATICY) { }

        public ArrayList(int capaticy)
        {
            // 默认开辟长度为 default_capaticy 的长度数组
            capaticy = (capaticy < DEFAULT_CAPATICY) ? DEFAULT_CAPATICY : capaticy;
            elements = new T[capaticy];
        }

        /// <summary>
        /// 清除所有元素
        /// </summary>
        public void Clean()
        {
            for (int i = 0; i < size; i++)
            {
                elements[i] = default;
            }
            size = 0;
            // 为null时需要重新new
            //elements = null;
        }

        /// <summary>
        /// 元素的数量
        /// </summary>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// 是否为空
        /// </summary>
        public bool IsEmpty()
        {
            return size == 0;
        }

        /// <summary>
        /// 是否包含某个元素
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            return IndexOf(element) != ELEMENT_NOT_FOUND;
        }

        /// <summary>
        /// 添加元素到尾部
        /// <param name="element"></param>
        /// </summary>
        public void Add(T element)
        {
            Add(size, element);
        }

        /// <summary>
        /// 获取index位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns>element</returns>
        public T Get(int index)
        {
            RangeCheck(index);

            return elements[index];
        }

        /// <summary>
        /// 设置index位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        /// <returns>返回原元素值</returns>
        public T Set(int index, T element)
        {
            RangeCheck(index);

            T old = elements[index];
            elements[index] = element;
            return old;
        }

        /// <summary>
        /// 在index位置插入一个元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        /// <returns>返回原元素值</returns>
        public void Add(int index, T element)
        {
            RangeCheckForAdd(index);
            EnsureCapacity(size + 1);

            for (int i = size; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = element;
            size++;
        }

        /// <summary>
        /// 删除index位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns>返回原元素值</returns>
        public T Remove(int index)
        {
            RangeCheck(index);

            T old = elements[index];
            for (int i = index + 1; i < size; i++)
            {
                elements[i - 1] = elements[i];
            }

            elements[--size] = default;

            return old;
        }

        /// <summary>
        /// 查看元素的索引
        /// </summary>
        /// <param name="element"></param>
        /// <returns>index</returns>
        public int IndexOf(T element)
        {
            if(element == null)
            {
                for (int i = 0; i < size; i++)
                {
                    if (elements[i] == null) return i;
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (elements[i].Equals(element)) return i;
            }
            return -1;
        }

        /// <summary>
        /// 保证要有capacity的容量
        /// </summary>
        /// <param name="capacity"></param>
        private void EnsureCapacity(int capacity)
        {
            // 不考虑线程安全
            int oldCapacity = elements.Length;
            if (capacity <= oldCapacity) return;

            int newCapacity = oldCapacity + (oldCapacity >> 1);
            T[] newElements = new T[newCapacity];
            for (int i = 0; i < size; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
            //newElements.CopyTo(elements, 0);
        }

        private void OutOfBounds(int index)
        {
            throw new IndexOutOfRangeException($"Index:{index},Size:{size}");
        }

        private void RangeCheck(int index)
        {
            if (index < 0 || index >= size) OutOfBounds(index);
        }

        private void RangeCheckForAdd(int index)
        {
            if (index < 0 || index > size) OutOfBounds(index);
        }

        /// <summary>
        /// 输出数组时默认调用ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"size={size}, [");
            for (int i = 0; i < size; i++)
            {
                if (i != 0) stringBuilder.Append(", ");
                stringBuilder.Append(elements[i]);
                //if (i != size - 1) stringBuilder.Append(", ");
            }
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }
    }
}
