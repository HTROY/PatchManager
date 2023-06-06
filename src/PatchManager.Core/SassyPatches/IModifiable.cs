﻿namespace PatchManager.Core.SassyPatches;

public interface IModifiable
{
    // Used for the x[y}: {...}; transformation
    public List<IModifiable> GetFieldForIndexing(string fieldName);
    public Value GetFieldValue(string fieldName);
    public void SetFieldValue(string fieldName, Value value);
}