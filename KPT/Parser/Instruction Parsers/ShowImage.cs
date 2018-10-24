﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KPT.Parser.Instruction_Parsers
{
    // This appears to be some "fetch X file from Y archive function" based on an initial look at the arguments. Having actually run it, it seems to be an image display. That said, it's still possible it has other functionality yet undiscovered.
    class ShowImage : IInstruction
    {
        Opcode opcode;
        string archiveFile;
        string subFile;

        public bool Read(BinaryReader br)
        {
            opcode = ElementReader.ReadOpcode(br);
            archiveFile = ElementReader.ReadFixedLengthString(br, 0x20);
            subFile = ElementReader.ReadFixedLengthString(br, 0x20);
            return true;
        }

        public bool Write(BinaryWriter bw)
        {
            return true;
        }

    }
}
