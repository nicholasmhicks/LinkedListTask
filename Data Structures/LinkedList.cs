﻿using System;
using System.Threading;
using System.Transactions;

namespace Data_Structures {
    public class LinkedListNode
    {
        public string Data;
        public LinkedListNode Next;


        public LinkedListNode(string data, LinkedListNode next) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedList
    {
        public LinkedListNode Head;

        public LinkedList()
        {
            Head = null;
        }

        public void AddToEnd(string newData)
        {
            LinkedListNode newNode = new LinkedListNode(newData, null);
            
            if (Head == null) {
                Head = newNode;
                return;
            } 
            
            LinkedListNode current = Head;

            while (current.Next != null) {
                current = current.Next;
            }

            current.Next = newNode;
        }
        
        public LinkedListNode GetNodeAt(int index) {
            int count = 0;

            if (index < 0) {
                return null;
            }
            
            LinkedListNode current = Head;
            while (count < index) {
                if (current.Next != null) {
                    current = current.Next;
                } else {
                    return null;
                }
                count++;
            }

            return current;
        }

        public bool Find(string searchTerm) {
            LinkedListNode current = Head;

            while (current != null) {
                if (current.Data == searchTerm) {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        /// <summary>
        /// Returns the number of nodes in the Linked List
        /// </summary>
        /// <returns>int: count</returns>
        public int Count()
        {
            LinkedListNode HeadNode = Head;
            int count = 0;
            while (Head != null)
            {
                Head = Head.Next;
                count += 1;
            }
            Head = HeadNode;
            return count;
        }

        /// <summary>
        /// Adds a node to the start of the list.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>success: true</returns>
        public bool AddToStart(string data)
        {
            LinkedListNode NewNode = new LinkedListNode(data, null);
            NewNode.Next = Head;
            Head = NewNode;
            return true;
        }

        public bool AddNodeAt(string data, int index)
        {
            LinkedListNode CurrentNode = Head;

            for (int i = 1; i < index; i++)
            {
                CurrentNode = CurrentNode.Next;
                if (index - i == 1)
                {
                    var TempNode = new LinkedListNode(data, CurrentNode.Next);
                    TempNode.Next = CurrentNode.Next;
                    CurrentNode.Next = TempNode;
                }
            }
            return true;
        }

        public bool DeleteNodeAt(int index)
        {
            LinkedListNode CurrentNode = Head;

            for (int i = 0; CurrentNode != null && i<index-1;i++)
            {
                CurrentNode = CurrentNode.Next;
            }
            CurrentNode.Next = CurrentNode.Next.Next;
            return true;
        }
    }
}