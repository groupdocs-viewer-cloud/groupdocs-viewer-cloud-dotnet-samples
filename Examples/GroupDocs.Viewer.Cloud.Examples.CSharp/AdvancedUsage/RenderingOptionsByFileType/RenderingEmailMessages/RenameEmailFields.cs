using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingEmailMessages
{
    /// <summary>
    /// This example demonstrates how to use custom field labels
    /// </summary>
    public class RenameEmailFields
    {
        public static void Run()
        {
            var apiInstance = new ViewApi(Constants.GetConfig());
            try
            {
                var viewOptions = new ViewOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "SampleFiles/sample.msg"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new HtmlOptions
                    {
                        EmailOptions = new EmailOptions
                        {
                            FieldLabels = new List<FieldLabel>
                            {
                                new FieldLabel {Field = "From", Label = "Sender"},
                                new FieldLabel {Field = "To", Label = "Receiver"},
                                new FieldLabel {Field = "Sent", Label = "Date"},
                                new FieldLabel {Field = "Subject", Label = "Topic"}
                            }
                        }
                    }
                };

                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("RenameEmailFields completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}