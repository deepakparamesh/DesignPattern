// See https://aka.ms/new-console-template for more information
using DesignPatterns.State;
using DesignPatterns.State.Tools;
using DesignPatterns.strategy;
using DesignPatterns.strategy.CompressorStrategy;
using DesignPatterns.strategy.FilterStrategies;

Console.WriteLine("Hello, World!");

// State Design Pattern
Canvas canvas = new(new SelectionTool());
canvas.onMouseDown();
canvas.onMouseUp();

// Strategy Design Pattern
ImageStorage imageStorage = new ImageStorage();
imageStorage.store("beautiful", new PNGCompressor(), new BlackAndWhiteFilter());
imageStorage.store("beautiful", new JpegCompressor(), new BlackAndWhiteFilter());