﻿using PatchManager.SassyPatching.Exceptions;

namespace PatchManager.SassyPatching.Nodes.Expressions.Unary;

/// <summary>
/// Represents a negation operation which returns the negative value of its child
/// </summary>
public class Negate : Unary
{
    internal Negate(Coordinate c, Expression child) : base(c, child)
    {
    }

    internal override DataValue GetResult(DataValue child)
    {
        if (child.IsInteger)
        {
            return -child.Integer;
        }
        if (child.IsReal)
        {
            return -child.Real;
        }

        throw new UnaryTypeException(Coordinate, "negate", child.Type.ToString());
    }
}