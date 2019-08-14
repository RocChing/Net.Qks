using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace Net.Qks.Web.Startup
{
    public class MyHtmlHelper : HtmlHelper, IHtmlHelper
    {
        private readonly IHtmlGenerator _htmlGenerator;
        public MyHtmlHelper(
           IHtmlGenerator htmlGenerator,
           ICompositeViewEngine viewEngine,
           IModelMetadataProvider metadataProvider,
           IViewBufferScope bufferScope,
           HtmlEncoder htmlEncoder,
           UrlEncoder urlEncoder) : base(htmlGenerator, viewEngine, metadataProvider, bufferScope, htmlEncoder, urlEncoder)
        {
            _htmlGenerator = htmlGenerator;
        }

        protected override IHtmlContent GenerateCheckBox(ModelExplorer modelExplorer, string expression, bool? isChecked, object htmlAttributes)
        {
            var checkbox = _htmlGenerator.GenerateCheckBox(
                ViewContext,
                modelExplorer,
                expression,
                isChecked,
                htmlAttributes);

            return new HtmlContentBuilder(capacity: 2)
               .AppendHtml(checkbox);
        }
    }

    public class MyHtmlHelper<TModel> : HtmlHelper<TModel>, IHtmlHelper<TModel>
    {
        private readonly IHtmlGenerator _htmlGenerator;
        public MyHtmlHelper(
           IHtmlGenerator htmlGenerator,
           ICompositeViewEngine viewEngine,
           IModelMetadataProvider metadataProvider,
           IViewBufferScope bufferScope,
           HtmlEncoder htmlEncoder,
           UrlEncoder urlEncoder,
            ExpressionTextCache expressionTextCache
           )
           : base(
                 htmlGenerator,
                 viewEngine,
                 metadataProvider,
                 bufferScope,
                 htmlEncoder,
                 urlEncoder, expressionTextCache)
        {
            _htmlGenerator = htmlGenerator;
        }

        protected override IHtmlContent GenerateCheckBox(ModelExplorer modelExplorer, string expression, bool? isChecked, object htmlAttributes)
        {
            var checkbox = _htmlGenerator.GenerateCheckBox(
                ViewContext,
                modelExplorer,
                expression,
                isChecked,
                htmlAttributes);

            return new HtmlContentBuilder(capacity: 2)
               .AppendHtml(checkbox);
        }
    }
}
