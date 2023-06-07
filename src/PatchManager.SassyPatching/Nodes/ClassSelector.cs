﻿namespace PatchManager.SassyPatching.Nodes;

public class ClassSelector : Selector
{
    public string ClassName;
    public ClassSelector(Coordinate c, string className) : base(c)
    {
        ClassName = className;
    }
}