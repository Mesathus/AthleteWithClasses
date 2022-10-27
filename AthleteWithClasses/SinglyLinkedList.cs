using System;

namespace AthleteWithClasses
{
    public class SinglyLinkedList
    {
        //internal Node class
        internal class Node
        {
            private object _data;
            private Node _next;

            internal Node(object data, Node next)
            {
                _data = data;
                _next = next;
            }
            internal Node(object data)
            {
                _data = data;
            }
            internal Node Next {
                get { return _next; }
                set { _next = value; }
            }
            internal object Data
            {
                get { return _data; }
            }
        }
        //class fields
        private int _length;
        private Node _head;
        //constructors
        public SinglyLinkedList()
        {
            _length = 0;
            _head = null;
        }

        //getters
        public int Length
        {
            get { return _length; }
        }

        //insert
        public bool Insert(object data)  //return true if the node is inserted, false if it fails
        {
            try
            {
                Node insert = new Node(data, null);
                if (_head == null)      //special case, insert into an empty list
                {
                    _head = insert;
                }
                else
                {
                    Node curr = _head;  //find tail and insert
                    while (curr.Next != null)
                    {
                        curr = curr.Next;
                    }
                    curr.Next = insert;
                }
                this._length++;
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        //delete
        public bool Delete(object data)  //return true if the node is removed, false if it fails
        {
            try
            {
                Node prev = null;
                Node curr = _head;
                while(curr != null)
                {
                    if (curr.Data.Equals(data))
                    {
                        if(prev == null)  //deletion at the head of the list
                        {
                            _head = curr.Next;
                            curr = null;
                        }
                        else  //delete elsewhere
                        {
                            prev.Next = curr.Next.Next;
                            curr = null;
                        }
                        this._length--;
                        return true;
                    }
                    else  //iterate the list
                    {
                        prev = curr;
                        curr = curr.Next;
                    }
                }
                return false;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public object GetValueAtIndex(int position)  //allow us to search the SLL by index
        {
            try
            {
                if (position > this.Length - 1) throw new IndexOutOfRangeException();
                Node target = _head;
                while(position > 0)  //iterate until we find the intended index
                {
                    target = target.Next;
                    position--;
                }
                return target.Data;
            }
            catch(Exception ex)
            {
                Logger.LogEvent(ex);
                return null;
            }
        }

        //search
        private Node Search(object data)  //return a node containing a value if present, otherwise return null
        {
            Node target = _head;
            while(target != null)
            {
                if (target.Data.Equals(data)) return target;
                else target = target.Next;
            }
            return null;
        }

        private bool Clear()
        {
            try
            {
                if (_head == null) return true;
                Node curr = _head;
                Node next;
                while (curr != null)
                {
                    next = curr.Next;
                    curr = null;
                    curr = next;                    
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.LogEvent(ex);
                return false;
            }
        }
    }
}
