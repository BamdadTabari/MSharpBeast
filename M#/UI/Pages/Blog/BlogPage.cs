using MSharp;

namespace Blog
{
    public class BlogPage : SubPage<Root.BlogPage>
    {
        public BlogPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.BlogsList>();
        }
    }
}
