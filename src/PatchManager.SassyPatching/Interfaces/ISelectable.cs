﻿namespace PatchManager.SassyPatching.Interfaces;

/// <summary>
/// Represents a selectable object
/// </summary>
public interface ISelectable
{
    /// <summary>
    /// Select all children
    /// </summary>
    /// <returns>All children</returns>
    public List<ISelectable> SelectEverything();
    
    /// <summary>
    /// Test if this selectable matches a name pattern
    /// </summary>
    /// <param name="name">The pattern being matched against</param>
    /// <returns>True if it matches the name pattern</returns>
    public bool MatchesName(string name);
    /// <summary>
    /// Test if this selectable has a class
    /// </summary>
    /// <param name="class">The class</param>
    /// <returns>True if it has the class</returns>
    public bool MatchesClass(string @class);

    /// <summary>
    /// Get the value for a class
    /// </summary>
    public bool MatchesClass(string @class, out DataValue classValue);
    
    
    /// <summary>
    /// Test if this selectable is an element
    /// </summary>
    /// <param name="element">The element</param>
    /// <returns>True if it is the element</returns>
    public bool MatchesElement(string element);
    
    /// <summary>
    /// Checks if this selectable is the same as another selectable
    /// </summary>
    /// <param name="other">The selectable to be checked against</param>
    /// <returns>True if they are the same</returns>
    public bool IsSameAs(ISelectable other);

    /// <summary>
    /// Opens up this selectable for modification
    /// </summary>
    /// <returns>The modifiable state of this selector or null if not modifiable</returns>
    public IModifiable OpenModification();

    /// <summary>
    /// Adds an element to this selectable and returns the selectable for it
    /// </summary>
    /// <exception cref="Exceptions.NotModifiableException">Thrown if this selectable cannot be modified</exception>
    public ISelectable AddElement(string elementType);

    /// <summary>
    /// Convert the ISelectable back to its string form, used to finalize a patch
    /// </summary>
    /// <returns>A string representing all the data contained in the ISelectable, usually in JSON</returns>
    public string Serialize();

    /// <summary>
    /// Converts the selectable into a DataValue
    /// </summary>
    /// <returns>The value representation of the selectable</returns>
    public DataValue GetValue();
}