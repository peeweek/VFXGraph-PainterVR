using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.VFX;

[VFXInfo]
class GetSpawnCount : VFXOperator
{
    public override string name { get { return "Spawn Count"; }  }

    public class OutputProperties
    {
        public uint SpawnCount;
    }

    protected override VFXExpression[] BuildExpression(VFXExpression[] inputExpression)
    {
        return new VFXExpression[] { new VFXExpressionCastFloatToUint(new VFXAttributeExpression(new VFXAttribute("spawnCount", UnityEngine.Experimental.VFX.VFXValueType.Float), VFXAttributeLocation.Source))  };
    }
}
