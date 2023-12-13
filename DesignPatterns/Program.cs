// See https://aka.ms/new-console-template for more information
using DesignPatterns.State;
using DesignPatterns.State.Tools;

Console.WriteLine("Hello, World!");

Canvas canvas = new();
canvas.setTool(new SelectionTool());
canvas.onMouseDown();
canvas.onMouseUp();
