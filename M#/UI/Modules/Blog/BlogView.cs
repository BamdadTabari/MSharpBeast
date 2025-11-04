using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BlogView : ViewModule<Domain.Blog>
    {
        public BlogView()
        {
            HeaderText("@item.BlogTitle Details");

            Field(x => x.BlogTitle);

            Field(x => x.BlogContent);

            Button("Back")
                .IsDefault()
                .Icon(FA.ChevronLeft)
                .OnClick(x => x.ReturnToPreviousPage());

            Button("Delete")
                .ConfirmQuestion("Are you sure you want to delete this Blog?")
                .CssClass("btn-danger")
                .Icon(FA.Remove)
                .OnClick(x =>
                {
                    x.DeleteItem();
                    x.GentleMessage("Deleted successfully.");
                    x.ReturnToPreviousPage();
                });
        }
    }
}
