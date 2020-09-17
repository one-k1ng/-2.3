using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Практика2._3
{
    class Task2
    {
        static void UncompressFile(string inFilename, string outFilename)
        {
            FileStream sourceFile = File.OpenRead(inFilename);
            FileStream destFile = File.Create(outFilename);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = compStream.ReadByte();
            while (theByte != -1)
            {
                destFile.WriteByte((byte)theByte); theByte = compStream.ReadByte();
            }
        }
        static void Main(string[] args)
        {
            UncompressFile(@"d:\newfile.txt.gz", @"d:\newfile2.txt");
        }
    }
}
