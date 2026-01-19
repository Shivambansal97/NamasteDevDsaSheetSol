using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeQuesSol.LinkedList
{
    /// <summary>
    /// Problem link: https://leetcode.com/problems/design-linked-list/
    /// </summary>
    public class Node
    {
        public int? value;
        public Node? next;

        public Node()
        {
            value = null;
            next = null;
        }

        public Node(int val)
        {
            value = val;
            next = null;
        }
    }

    public class MyLinkedList
    {
        private Node head;

        public MyLinkedList()
        {
            head = new Node();
        }

        public int Get(int index)
        {
            Node? temp = head.next;
            int i = 0;
            while (temp != null)
            {
                if (i == index)
                { 
                    return temp.value ?? -1; 
                }
                temp = temp.next;
                i++;
            }
            return -1;
        }

        public void AddAtHead(int val)
        {
            Node newNode = new(val);
            newNode.next = head.next;
            head.next = newNode;
        }

        public void AddAtTail(int val)
        {
            Node newNode = new(val);

            Node temp = head;

            while(temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }

        public void AddAtIndex(int index, int val)
        {
            Node prev = head;
            int i = 0;
            while (i < index && prev.next != null)
            {
                prev = prev.next;
                i++;
            }
            if (i == index)
            {
                Node newNode = new(val);
                newNode.next = prev.next;
                prev.next = newNode;
            }
            // If index > length, do nothing
        }

        public void DeleteAtIndex(int index)
        {
            Node prev = head;
            int i = 0;
            while (i < index && prev.next != null)
            {
                prev = prev.next;
                i++;
            }
            if (prev.next != null && i == index)
            {
                prev.next = prev.next.next;
            }
            // If index >= length, do nothing
        }
    }
}
