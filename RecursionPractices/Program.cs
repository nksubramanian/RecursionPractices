﻿// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System.Linq;

DoublyLink node = new DoublyLink(3);
DoublyLinkMethods.InsertAtStart(ref node, new DoublyLink(2));
DoublyLinkMethods.InsertAtStart(ref node, new DoublyLink(1));
//var g = DoublyLinkMethods.RemoveAtStart(ref node);
DoublyLinkMethods.Reverse(ref node);
node.Print();
Console.WriteLine("___________________________________________________");
ProxyMain.linkmain();







