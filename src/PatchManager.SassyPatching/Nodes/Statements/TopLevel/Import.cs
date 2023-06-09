﻿namespace PatchManager.SassyPatching.Nodes.Statements.TopLevel;

/// <summary>
/// Represents a library import
/// </summary>
public class Import : Node
{
    /// <summary>
    /// <para>
    /// The library being imported, can take a few formats
    /// </para>
    /// <para>
    /// Local library: "name", imports a local (to the patch folder for the mod) file named "_name" or if there is any pathing it only prepends the underscore after the last slash
    /// </para>
    /// <para>
    /// External library: "guid:name", imports a file from another mod (defined in the guid) named "_name"
    /// </para>
    /// <para>
    /// Builtin library: "builtin:name", imports a builtin library named "name"
    /// </para>
    /// </summary>
    public readonly string Library;

    internal Import(Coordinate c, string library) : base(c)
    {
        Library = library;
    }
}