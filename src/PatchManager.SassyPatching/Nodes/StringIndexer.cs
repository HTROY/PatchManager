﻿namespace PatchManager.SassyPatching.Nodes;

public class StringIndexer : Indexer
{
    public string Index;
    public StringIndexer(Coordinate c, string index) : base(c)
    {
        Index = index;
    }
}