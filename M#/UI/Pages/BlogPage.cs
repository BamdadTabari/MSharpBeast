using MSharp;

namespace Root;

public class BlogPage : RootPage
{
    public BlogPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<Blog.BlogPage>().RunServerSide());
    }
}
