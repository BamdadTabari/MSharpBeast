using MSharp;

namespace Blog
{
    public class EnterPage : SubPage<BlogPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Add<Modules.BlogForm>();
        }
    }

}
