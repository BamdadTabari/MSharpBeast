using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BlogsList : ListModule<Domain.Blog>
    {
        public BlogsList()
        {
            HeaderText("Blogs")
                .UseDatabasePaging(true)
                .Sortable()
                .PageSize(10)
                .ShowFooterRow()
                .ShowHeaderRow()
                .PagerPosition(PagerAt.Bottom);

            Search(GeneralSearch.AllFields).Label("Find");

            SearchButton("Search").OnClick(x => x.Reload());

            ButtonColumn("c#:item.BlogTitle")
                .Style(ButtonStyle.Link)
                .HeaderText("Blog Title")
                .OnClick(x => x.Go<Blog.ViewPage>()
                .Send("item", "item.ID"));

            Column(x => x.ViewCount);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.PopUp<Blog.EnterPage>()
                .Send("item", "item.ID").SendReturnUrl(false));

            ButtonColumn("Delete")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .ConfirmQuestion("Are you sure you want to delete this Blog?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.RefreshPage();
                });

            Button("New Blog")
                .Icon(FA.Plus)
                .OnClick(x => x.PopUp<Blog.EnterPage>().SendReturnUrl(false));
        }
    }
}
