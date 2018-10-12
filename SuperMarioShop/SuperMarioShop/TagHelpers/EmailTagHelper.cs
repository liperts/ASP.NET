using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarioShop.TagHelpers
{
    // TagHelper is used to enable server-side code to be rendered inside of HTML
    public class EmailTagHelper : TagHelper
    {
        // It will show us a link, and when we click in this link
        // we'll send a email to a defined user

        // Email address to send the email
        public string Address { get; set; }

        // This is the text that the user will see
        public string Content { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            // We will use a hiperlink
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }
    }
}
