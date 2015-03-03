using System.IO;
using System.Web.Hosting;

namespace ViewsFromDatabase.Models
{
    public class AprendaDotNetVirtualFile : VirtualFile
    {
        private readonly byte[] _viewContent;

        public AprendaDotNetVirtualFile(string virtualPath, byte[] viewContent) : base(virtualPath)
        {
            _viewContent = viewContent;
        }

        public override Stream Open()
        {
            return new MemoryStream(_viewContent);
        }
    }
}