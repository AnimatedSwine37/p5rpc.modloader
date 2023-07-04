﻿using Sewer56.StructuredDiff.Interfaces;

namespace Persona.Merger.Patching.Tbl.FieldResolvers.P4G.Model
{
    public struct ModelSegment0Resolver : IEncoderFieldResolver
    {
        public bool Resolve(nuint offset, out int moveBy, out int length)
        {
            // File is undocumented so assume it's all individual bytes
            moveBy = 0;
            length = 1;
            return false;
        }
    }
}
