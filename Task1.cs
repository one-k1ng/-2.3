using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Практика2._3
{
    class Task1
    {
        static void CompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte); theByte = sourceFile.ReadByte();
            }
        }
        static void Main(string[] args)
        {
            CompressFile(@"d:\newfile.txt", @"d:\newfile.txt.gz");
        }
    }
}
