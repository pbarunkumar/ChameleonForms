﻿using System.Net.Http;
using System.Web;

namespace ChameleonForms.Templates
{
    public class DefaultFormTemplate : IFormTemplate
    {
        public IHtmlString BeginForm(string action, HttpMethod method, string enctype)
        {
            return HtmlHelpers.BeginForm(action, method, enctype);
        }

        public IHtmlString EndForm()
        {
            return HtmlHelpers.EndForm();
        }

        public IHtmlString BeginSection(string title)
        {
            return HtmlHelpers.BeginSection(title);
        }

        public IHtmlString EndSection()
        {
            return HtmlHelpers.EndSection();
        }

        public IHtmlString Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml)
        {
            return HtmlHelpers.Field(labelHtml, elementHtml, validationHtml);
        }

        public IHtmlString BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml)
        {
            return HtmlHelpers.BeginField(labelHtml, elementHtml, validationHtml);
        }

        public IHtmlString EndField()
        {
            return HtmlHelpers.EndField();
        }
    }
}