using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms;
public static class Graphs
{
    public static void DepthFirstTraversal(TreeNode node)
    {
        if (node == null)
            return;

        Stack<TreeNode> stack = new();
        stack.Push(node);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            Console.WriteLine(current.Value);

            foreach (var child in current.Children)
            {
                stack.Push(child);
            }
        }
    }

    public static void DepthFirstTraversalRecursion(TreeNode node)
    {
        if (node == null)
            return;

        Stack<TreeNode> stack = new();
        stack.Push(node);

        Console.WriteLine(node.Value);

        foreach (var item in node.Children)
        {
            DepthFirstTraversalRecursion(item);
        }
    }

    public static void BreadthFirstTraversal(TreeNode node)
    {
        if (node == null)
            return;

        Queue<TreeNode> queue = new();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            Console.WriteLine(current.Value);

            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }
    }

    public static void HasPath(TreeNode src, TreeNode dst)
    {

    }

    public class TreeNode(char value)
    {
        public char Value { get; } = value;
        public List<TreeNode> Children { get; } = [];

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }
    }
}