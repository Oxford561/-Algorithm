

using System;

public class SingleLinkedList
{
    private Node head;

    public SingleLinkedList() { }
    public SingleLinkedList(Node head) { this.head = head; }

    public void AddToHead(Node newNode)
    {
        if (head == null)
        {
            head = newNode;
            return;
        }
        newNode.next = head;
        head = newNode;
    }

    public void AddToHead(int value)
    {
        Node newNode = new Node(value,null);
        AddToHead(newNode);
    }

    public void AddToTail(Node newNode)
    {
        if(head == null)
        {
            head = newNode;
            return;
        }
        Node q = head;
        while(q.next != null)
        {
            q = q.next;
        }
        q.next = newNode;
    }

    public void AddToTail(int value)
    {
        Node newNode = new Node(value, null);
        AddToTail(newNode);
    }

    public Node FindByValue(int value)
    {
        Node p = head;
        while(p != null && p.data != value)
        {
            p = p.next;
        }

        return p;
    }

    public void InsertAfter(Node p,int value)
    {
        Node newNode = new Node(value);
        InsertAfter(p,newNode);
    }

    public void InsertAfter(Node p, Node newNode)
    {
        if (p == null) return;
        newNode.next = p.next;
        p.next = newNode;
    }

    public void InsertBefore(Node p,int value)
    {
        Node newNode = new Node(value);
        InsertBefore(p,newNode);
    }

    public void InsertBefore(Node p,Node newNode)
    {
        if (p == null) return;
        if(p == head)
        {
            AddToHead(newNode);
            return;
        }
        Node q = head;
        while(q != null && q.next != p)
        {
            q = q.next;
        }
        if (q == null) return;
        newNode.next = p;
        q.next = newNode;
    }

    public void DeleteByNode(Node p)
    {
        if(p== null || head == null) return;
        Node q = head;
        while(q != null && q.next != p)
        {
            q = q.next;
        }
        if(q==null) return;
        q.next = p.next;
    }

    public void DeleteByValue(int value)
    {
        if(head == null) return;
        Node q = head;
        Node pre = null;
        while(q != null)
        {
            if(q.data == value)
            {
                break;
            }
            pre = q;
            q = q.next;
        }
        if(q == null) return;
        if(pre == null)
        {
            head = head.next;
        }
        else
        {
            pre.next = q.next;
        }
    }

    public void ShowList()
    {
        if(head == null) return;
        Node q = head;
        while (q != null)
        {
            Console.WriteLine(q.data+" ");
            q = q.next;
        }
    }
}

