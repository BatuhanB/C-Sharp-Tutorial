using System;

namespace Algorithms;
public static class BinaryTree
{
    //              8
    //            /   \             
    //           /     \
    //          6      10
    //         / \     / \
    //        3   7   11  12
    //         \           \
    //          4          14
    public static void AddNode(Node rootNode, int value)
    {
        if (value < rootNode.Value)
        {
            if (rootNode.LeftNode is null)
            {
                rootNode.LeftNode = new Node(value);
                return;
            }
            else
            {
                AddNode(rootNode.LeftNode, value);
            }
        }
        else
        {
            if (rootNode.RightNode is null)
            {
                rootNode.RightNode = new Node(value);
                return;
            }
            else
            {
                AddNode(rootNode.RightNode, value);
            }
        }
    }

    public static void FindNode(Node rootNode,int target, int iterateCount = 0)
    {
        if(rootNode is null)
        {
            Console.WriteLine("Could not find the target in the node!");
            return;
        }

        if(rootNode.Value == target)
        {
            Console.WriteLine("{0} times iterated and found {1}",iterateCount,rootNode.Value);
                return;
        }

        iterateCount++;

        if (rootNode.Value < target)
        {            
            FindNode(rootNode.RightNode, target,iterateCount);
        }
        else
        {
            FindNode(rootNode.LeftNode, target,iterateCount);
        }
    }

    public static void Traverse(Node rootNode)
    {
        if (rootNode is null)
            return;

        Traverse(rootNode.LeftNode);
        Console.WriteLine(rootNode.Value);
        Traverse(rootNode.RightNode);
    }

    public class Node
    {
        public Node(int value)
        {
            Value = value;
        }

        public int Value { get; init; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }
    }
}
