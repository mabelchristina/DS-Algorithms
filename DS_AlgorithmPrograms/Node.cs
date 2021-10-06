﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DS_AlgorithmPrograms
{
    class Node <T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
}
