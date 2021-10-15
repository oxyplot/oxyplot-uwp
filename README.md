## OxyPlot is a cross-platform plotting library for .NET
### Function
You can draw a graph like below in a .NET UWP application.
![Plot](https://oxyplot.github.io/public/images/normal-distributions.png)

### Background
* This library contains some adjustment for Universal Windows Platform that are to be published as the NuGet package OxyPlot.Windows.
* This library was created simply to use the OxyPlot.Core version 2.1.0. I worked for just adjusting the existing oxyplot-uwp repository in oxyplot, so I'm not sure right now whether you can use all the functionarities of the oxyplot with this library.
* The current NuGet OxyPlot.Windows package is 2.0.0-unstable1035, which will be out of date in the near future because the OxyPlot.Core version 2.1.0 is totally different from version 2.0.0. I don't know how this package were built as the original repository oxyplot/oxyplot-uwp itself couldn't make its package.

#### Getting started

1. Use the NuGet package manager to add a reference to OxyPlot (see details below if you want to use pre-release packages)
2. Add a `PlotView` to your user interface
3. Create a `PlotModel` in your code
4. Bind the `PlotModel` to the `Model` property of your `PlotView`
