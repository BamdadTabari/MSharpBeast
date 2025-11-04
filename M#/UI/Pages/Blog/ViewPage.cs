using MSharp;

namespace Blog
{
    public class ViewPage : SubPage<BlogPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.BlogView>();
        }
    }

}
