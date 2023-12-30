﻿using PatchManager.SassyPatching.Exceptions;

namespace PatchManager.SassyPatching.Nodes.Expressions.Binary;
/// <summary>
/// Represents a binary expression that returns true if its left hand side is greater than or equal to its right hand side
/// </summary>
public class GreaterThanEqual : Binary
{
    internal GreaterThanEqual(Coordinate c, Expression leftHandSide, Expression rightHandSide) : base(c, leftHandSide, rightHandSide)
    {
    }

    internal override DataValue GetResult(DataValue leftHandSide, DataValue rightHandSide)
    { 
        try
        {
            return leftHandSide >= rightHandSide;
        }
        catch (DataValueOperationException)
        {
            throw new BinaryExpressionTypeException(Coordinate,"perform a relational comparison (>=)", leftHandSide.Type.ToString(),
                rightHandSide.Type.ToString());
        }
    }

    internal override bool ShortCircuitOn(DataValue dataValue) => false;

    internal override DataValue ShortCircuitDataValue => null;
}