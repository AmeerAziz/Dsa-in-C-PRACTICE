

using System ;

class node
{
    public int data;
    public node next;
    public static node head;
}
class linkedlist
{
    static void Main()
    {
        node FN= new node(){ };
        node LN= new node(){  };
        node TN= new node(){  };
FN.data=10;
LN.data=20; 
TN.data=30;
FN.next=LN;
LN.next=TN;
TN.next=null;
node.head=FN;
//you see this is simple linked ist with three nodes and head is pointing to first node

// insertion of new node at the beginning of linked list
node NN= new node(){  };
NN.data=40;

NN.next=node.head;
node.head=NN;

node current=node.head;

// insertion of new node at the end of linked list
Console.WriteLine("After adding new node");
node QN= new node(){  };
QN.data=50;

current = node.head;
while (current.next != null)
{
    current = current.next;
}
current.next = QN;
QN.next = null;
// insertion of new node in between two nodes
node BN = new node();
BN.data = 15;
BN.next = FN.next;
FN.next = BN;
current = node.head;
while(current!=null)
{
    Console.WriteLine(current.data);
    current=current.next;


}




}}