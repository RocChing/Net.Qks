namespace Net.Qks.Web.Common
{
    public static class WebConsts
    {
        public const string SwaggerUiEndPoint = "/swagger";
        public const string HangfireDashboardEndPoint = "/hangfire";
      
        public static bool SwaggerUiEnabled = true;
        public static bool HangfireDashboardEnabled = false;

        public static class GraphQL
        {
            public const string PlaygroundEndPoint = "/ui/playground";
            public const string EndPoint = "/graphql";

            public static bool PlaygroundEnabled = false;
            public static bool Enabled = false;
        }

        public const string ModalHeaderName = "~/Areas/Admin/Views/Common/Modals/_ModalHeader.cshtml";

        public const string ModalFooterName = "~/Areas/Admin/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml";
    }
}
