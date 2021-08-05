using System;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.CommonRenderingOptions;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.LoadingOptions;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingArchiveFiles;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingCadDrawings;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingEmailMessages;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingLotusNotesDatabase;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingMsProjectDocuments;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingOutlookDataFiles;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingPdfDocuments;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingSpreadsheets;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingTextFiles;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingVisioDocuments;
using GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingWordProcessingDocuments;
using GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage;
using GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.HtmlViewer;
using GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.ImageViewer;
using GroupDocs.Viewer.Cloud.Examples.CSharp.BasicUsage.PdfViewer;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	public class RunExamples
	{
		public static void Main(string[] args)
		{
            //// ***********************************************************
            ////          GroupDocs.Viewer Cloud API Examples
            //// ***********************************************************

            //TODO: Get your Client Id and Client Secret at https://dashboard.groupdocs.cloud (free registration is required).
            Constants.MyClientId = "XXXX-XXXX-XXXX-XXXX";
            Constants.MyClientSecret = "XXXXXXXXXXXXXXXX";
            Constants.MyStorage = "First Storage";

            // Uploading sample test files from local disk to cloud storage
            Constants.UploadSampleTestFiles();

            #region Basic usage
            GetSupportedFormats.Run();
            GetDocumentInformation.Run();
            GetAttachments.Run();
            HtmlViewerExcludeFonts.Run();
            HtmlViewerMinifyHtml.Run();
            HtmlViewerResponsiveLayout.Run();
            ImageViewerAddTextOverlay.Run();
            ImageViewerAdjustImageSize.Run();
            ImageViewerAdjustJpgQuality.Run();
            ImageViewerGetTextCoordinates.Run();
            PdfViewerAdjustJpgQuality.Run();
            PdfViewerProtectPdf.Run();
            #endregion

            #region AdvancedUsage
            ViewProtectedDocument.Run();
            SpecifyEncoding.Run();
            RenderWithCustomFonts.Run();
            AddWatermark.Run();
            RenderComments.Run();
            RenderNotes.Run();
            RenderHiddenPages.Run();
            RenderConsecutivePages.Run();
            RenderSelectedPages.Run();
            ReplaceMissingFont.Run();
            ReorderPages.Run();
            FlipRotatePages.Run();
            GetInfoForArchiveFile.Run();
            RenderArchiveFolder.Run();
            AdjustOutputImageSize.Run();
            GetInfoForCadDrawing.Run();
            RenderAllLayouts.Run();
            RenderLayers.Run();
            RenderSingleLayout.Run();
            SplitIntoTiles.Run();
            AdjustPageSize.Run();
            RenameEmailFields.Run();
            GetInfoForProjectFile.Run();
            AdjustTimeUnit.Run();
            RenderTimeInterval.Run();
            GetInfoForOutlookDataFile.Run();
            LimitCountOfItemsToRender.Run();
            RenderFolder.Run();
            FilterMessages.Run();
            AdjustImageQuality.Run();
            DisableCharsGrouping.Run();
            EnableFontHinting.Run();
            EnableLayeredRendering.Run();
            GetInfoForPdfFile.Run();
            RenderOriginalPageSize.Run();
            AdjustTextOverflowInCells.Run();
            RenderSpreadsheetWithGridLines.Run();
            RenderHiddenColumnsAndRows.Run();
            RenderPrintAreas.Run();
            SkipRenderingOfEmptyColumns.Run();
            SkipRenderingOfEmptyRows.Run();
            SplitWorksheetsIntoPages.Run();
            RenderTrackedChanges.Run();

            SpecifyMaxCharsAndRows.Run();
            RenderVisioDocumentFigures.Run();
            FilterMailStorage.Run();
            HtmlViewerLimitImageSize.Run();
            HtmlViewerOptimizeForPrinting.Run();
            #endregion

            Console.WriteLine("Completed!");
            Console.ReadKey();
        }
	}
}