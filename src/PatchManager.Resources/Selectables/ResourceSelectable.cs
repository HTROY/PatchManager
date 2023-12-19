﻿using Newtonsoft.Json.Linq;
using PatchManager.SassyPatching;
using PatchManager.SassyPatching.Interfaces;
using PatchManager.SassyPatching.Modifiables;

namespace PatchManager.Resources.Selectables;

/// <summary>
/// Represents a selectable for the selection and transformation of resource data
/// </summary>
public class ResourceSelectable : BaseSelectable
{
    private bool _modified = false;
    private bool _deleted = false;


    /// <summary>
    /// Marks this resource selectable as having been modified any level down
    /// </summary>
    public void SetModified()
    {
        _modified = true;
    }

    /// <summary>
    /// Marks this resource as goneso
    /// </summary>
    public void SetDeleted()
    {
        SetModified();
        _deleted = true;
    }

    private readonly string _originalData;
    internal readonly JObject JObject;

    internal ResourceSelectable(string data)
    {
        _originalData = data;
        JObject = JObject.Parse(data);
        Classes = new() { "resource" };
        Children = new();
        var resourceData = JObject["data"];
        Name = (string)resourceData["name"];
        ElementType = "resource";
    }

    /// <inheritdoc />
    public override List<ISelectable> Children { get; }

    /// <inheritdoc />
    public override string Name { get; }

    /// <inheritdoc />
    public override List<string> Classes { get; }

    /// <inheritdoc />
    public override bool MatchesClass(string @class, out DataValue classValue)
    {
        classValue = null;
        if (@class == "resource")
        {
            classValue = DataValue.FromJToken(JObject["data"]);
            return true;
        }
        return false;
    }

    /// <inheritdoc />
    public override string ElementType { get; }

    /// <inheritdoc />
    public override bool IsSameAs(ISelectable other) => other is ResourceSelectable rs && rs.Name == Name;

    /// <inheritdoc />
    public override IModifiable OpenModification() => new JTokenModifiable(JObject["data"], SetModified);

    /// <inheritdoc />
    public override ISelectable AddElement(string elementType) => throw new InvalidOperationException();

    /// <inheritdoc />
    public override string Serialize() => _modified ? _deleted ? "" : JObject.ToString() : _originalData;

    /// <inheritdoc />
    public override DataValue GetValue() => OpenModification().Get();
}