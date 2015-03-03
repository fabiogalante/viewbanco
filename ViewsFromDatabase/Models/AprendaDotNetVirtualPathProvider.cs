using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace ViewsFromDatabase.Models
{
    public class AprendaDotNetVirtualPathProvider : VirtualPathProvider
    {
        public override bool FileExists(string virtualPath)
        {
            var view = ObterViewDoBanco(virtualPath);

            if (view == null)
            {
                return base.FileExists(virtualPath);
            }

            return true;
        }

        public override VirtualFile GetFile(string virtualPath)
        {
            var view = ObterViewDoBanco(virtualPath);

            if (view == null)
            {
                return base.GetFile(virtualPath);
            }
            else
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(view.ViewConteudo);
                return new AprendaDotNetVirtualFile(virtualPath, content);
            }
        }

       private Views ObterViewDoBanco(string virtualPath)
        {
            virtualPath = virtualPath.Replace("~", "");
            MvcMusicStoreContext db = new MvcMusicStoreContext();
            var view = from v in db.Views where v.ViewCaminho == virtualPath select v;
            return view.SingleOrDefault();
        }

    }
}