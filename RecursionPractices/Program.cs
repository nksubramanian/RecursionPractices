// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System.Linq;

Link link = new Link(1);
link.InsertAtEnd(3);
link.InsertAtEnd(3);
LinkListMethods.InsertAtStart(ref link,0);
int backcount = 0;
int count = 1;
link.PrinttheCount(ref backcount, ref count);
int j = link.GetCount();
link.Print();

int u = 0;








