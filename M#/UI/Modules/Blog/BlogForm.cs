using MSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
    public class BlogForm : FormModule<Domain.Blog>
    {
        public BlogForm()
        {
            HeaderText("Blog Details");

            Field(x => x.BlogTitle).Control(ControlType.Textbox).Mandatory();

            Field(x => x.BlogContent).Control(ControlType.HtmlEditor).Mandatory();


            Button("Cancel").CausesValidation(false)
                .OnClick(x => x.CloseModal());

            Button("Save").IsDefault().Icon(FA.Check)
                .OnClick(x =>
                {
                    x.SaveInDatabase();
                    x.GentleMessage("Saved successfully.");
                    x.CloseModal(Refresh.Ajax);
                });
        }
    }
}
