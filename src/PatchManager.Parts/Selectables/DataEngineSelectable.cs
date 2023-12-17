﻿using BepInEx.Logging;
using JetBrains.Annotations;
using KSP.Modules;
using Newtonsoft.Json.Linq;
using PatchManager.Parts.Attributes;
using PatchManager.SassyPatching;
using PatchManager.SassyPatching.Interfaces;
using PatchManager.SassyPatching.Modifiables;
using PatchManager.SassyPatching.Selectables;
using UnityEngine;

namespace PatchManager.Parts.Selectables;

[ModuleDataAdapter(typeof(Data_Engine))]
[UsedImplicitly]
public sealed class DataEngineSelectable : BaseSelectable
{
    public readonly JObject SerializedData;
    public readonly PartSelectable Selectable;

    public DataEngineSelectable(JObject moduleData, ModuleSelectable moduleSelectable)
    {
        SerializedData = (JObject)moduleData["DataObject"];
        Name = "Data_Engine";
        Selectable = moduleSelectable.Selectable;
        ElementType = moduleData["Name"].Value<string>();
        Classes = new();
        Children = new();
        foreach (var field in SerializedData)
        {
            Classes.Add(field.Key);
            if (field.Value.Type == JTokenType.Object)
            {
                Children.Add(new JTokenSelectable(Selectable.SetModified, field.Value, field.Key, field.Key));
            }
        }

        var index = 0;
        List<int> removals = new();
        foreach (var jToken in (JArray)SerializedData["engineModes"])
        {
            var currentIdx = index++;
            if (jToken.Type is JTokenType.Null or JTokenType.None)
            {
                removals.Add(currentIdx);
                continue;
            }
            var mode = (JObject)jToken;
            Classes.Add(mode["engineID"].Value<string>());
            Children.Add(new JTokenSelectable(Selectable.SetModified,mode,m => m["engineID"].Value<string>(),"engine_mode"));
        }

        removals.Reverse();
        foreach (var idx in removals)
            ((JArray)SerializedData["engineModes"])[idx].Remove();
    }

    /// <inheritdoc />
    public override List<ISelectable> Children { get; }
    public override string Name { get; }
    public override List<string> Classes { get; }

    public override bool MatchesClass(string @class, out DataValue classValue)
    {
        if (SerializedData.TryGetValue(@class, out var value))
        {
            classValue = DataValue.FromJToken(value);
            return true;
        }

        foreach (var jToken in (JArray)SerializedData["engineModes"])
        {
            var mode = (JObject)jToken;
            if (mode["engineID"].Value<string>() != @class)
            {
                continue;
            }

            classValue = DataValue.FromJToken(mode);
            return true;
        }

        classValue = DataValue.Null;
        return false;
    }

    public override bool IsSameAs(ISelectable other) =>
        (other is DataEngineSelectable dataEngineSelectable) &&
        SerializedData == dataEngineSelectable.SerializedData;

    public override IModifiable OpenModification() => new JTokenModifiable(SerializedData, Selectable.SetModified);

    public override ISelectable AddElement(string elementType)
    {
        var engineModeData = new Data_Engine.EngineMode()
        {
            engineID = elementType
        };
        var json = JObject.FromObject(engineModeData);
        ((JArray)SerializedData["engineModes"]).Add(json);
        return new JTokenSelectable(Selectable.SetModified, json, mode => mode["engineID"].Value<string>(),
            "engine_mode");
    }

    public override string Serialize() => SerializedData.ToString();

    public override DataValue GetValue() => DataValue.FromJToken(SerializedData);

    public override string ElementType { get; }
}