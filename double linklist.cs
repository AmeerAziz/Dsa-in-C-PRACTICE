using System ;

class nodee
{
    public int data;
    public nodee next;
    public nodee prev;
    public static nodee head;
    public static nodee tail;
}
class doublelinkedlist
{
    static void Main()
    {
        nodee FN= new nodee(){ };
        nodee LN= new nodee(){  };
        nodee TN= new nodee(){  };
FN.data=10;
LN.data=20; 
TN.data=30;
FN.next=LN;
LN.next=TN;
nodee.tail=TN;
nodee.head=FN;
FN.prev=null;
LN.prev=FN;
TN.prev=LN;
FN.next=LN;
LN.next=TN;
TN.next=null;

//you see this is simple double linked ist with three nodes and head is pointing to first node and tail is pointing to last node

// insertion of new node at the beginning of  double linked list
nodee NN= new nodee(){  };
NN.data=40;
NN.next=nodee.head;
nodee.head=NN;
NN.prev=null;

nodee.head.next.prev=NN;

// insertion of new node at the end of double linked list
nodee QN= new nodee(){  };
QN.data=50;
nodee.tail.next=QN;
QN.prev=nodee.tail;
nodee.tail=QN;
// insertion of new node in between two nodes
nodee BN = new nodee(); 
BN.data = 15;
BN.next = FN.next;
BN.prev=FN;
FN.next.prev=BN;
FN.next = BN;
nodee current=nodee.head;

while(current!=null)
{   Console.WriteLine(current.data);
    current=current.next;
}
    }}
