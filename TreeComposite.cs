using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternTree
{
    internal class File : IFileSystemComponent
    {
        private string name;
        public File(string path)
        {
            name = System.IO.Path.GetFileName(path);
        }
        public string GetName()
        {
            return name;
        }
        public int CountFileElements()
        {
            return 1;
        }
        public int CountFolderElements()
        {
            return 1;
        }
    }
}
