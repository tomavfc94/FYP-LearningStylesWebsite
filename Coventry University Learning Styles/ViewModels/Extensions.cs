using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel;
using System;
using System.Text;

namespace Coventry_University_Learning_Styles.HtmlHelpers 
{
    public static class ActionImageLinkExtension
    {
        //public static MvcHtmlString ActionImage(
        //    this HtmlHelper helper,
        //    string imageUrl,
        //    string title,
        //    string actionName,
        //    string controllerName,
        //    object routeValues)
        //{
        //    var imgBuilder = new TagBuilder("img");
        //    imgBuilder.MergeAttribute("src", imageUrl);
        //    imgBuilder.MergeAttribute("title", title);
        //    var urlHelper = new UrlHelper(helper.ViewContext.RequestContext, helper.RouteCollection);
        //    var linkBuilder = new TagBuilder("a");
        //    linkBuilder.MergeAttribute("href", urlHelper.Action(actionName, controllerName, routeValues));
        //    var text = linkBuilder.ToString(TagRenderMode.StartTag);
        //    text += imgBuilder.ToString(TagRenderMode.SelfClosing);
        //    text += linkBuilder.ToString(TagRenderMode.EndTag);
        //    return MvcHtmlString.Create(text.ToString());
        //}

        public static MvcHtmlString ActionImage(this HtmlHelper helper, string imageUrl, string title,
            string action, string controller, Object routeValues, string alt = "")
        {
            TagBuilder tagBuilder = new TagBuilder("img");
            UrlHelper urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            string url = urlHelper.Action(action, controller, routeValues);
            string imgUrl = urlHelper.Content(imageUrl);
            string image = "";
            StringBuilder html = new StringBuilder();

            // build the image tag.
            tagBuilder.MergeAttribute("src", imgUrl);
            tagBuilder.MergeAttribute("alt", alt);
            tagBuilder.MergeAttribute("title", title);
            image = tagBuilder.ToString(TagRenderMode.SelfClosing);

            html.Append("<a href=\"");
            html.Append(url);
            html.Append("\">");
            html.Append(image);
            html.Append("</a>");

            return MvcHtmlString.Create(html.ToString());
        }

        private static Dictionary<string, object> AnonymousObjectToKeyValue(object anonymousObject)
        {
            var dictionary = new Dictionary<string, object>();
            if (anonymousObject != null)
            {
                foreach (PropertyDescriptor propertyDescriptor in TypeDescriptor.GetProperties(anonymousObject))
                {
                    dictionary.Add(propertyDescriptor.Name, propertyDescriptor.GetValue(anonymousObject));
                }
            }
            return dictionary;
        }
    }
}