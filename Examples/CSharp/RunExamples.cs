using System;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp
{
	class RunExamples
	{
		static void Main(string[] args)
		{
			//// ***********************************************************
			////          GroupDocs.Viewer Cloud API Examples
			//// ***********************************************************

			//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
			Common.MyAppSid = "XXXXX-XXXXX-XXXXX";
			Common.MyAppKey = "XXXXXX";

			// 
			//// Working with Common


			// Uploading sample test files from local to default storage under folder 'viewerdocs'
			Common.UploadSampleTestFiles();

			// 
			//// Working with Supported Formats


			// Get All Supported Formats
			Get_All_Supported_Formats.Run();

			// 
			//// Working with Fonts


			// Delete All Fonts Cache
			Delete_Font_Cache.Run();

			// Get All Fonts Resources
			Font_Resoruces.Run();


			// 
			//// Working with Page Resources


			// Get Responsive HTML
			Get_Responsive_HTML.Run();

			// 
			//// Working with Document Information


			// Create CAD Layers Cache HTML
			Create_CAD_Layers_Cache_HTML.Run();

			// Create CAD Layers Cache Image
			Create_CAD_Layers_Cache_Image.Run();

			// Get CAD Document Information Html
			Get_CAD_DocumentInfo_Html.Run();

			// Get CAD Document Information Image
			Get_CAD_DocumentInfo_Image.Run();

			// Get Document Infomation From Request Html
			Get_DocumentInfo_From_Request_Html.Run();

			// Get Document Infomation From Request Image
			Get_DocumentInfo_From_Request_Image.Run();

			// Get Document Information Html
			Get_DocumentInfo_Html.Run();

			// Get Document Information Image
			Get_DocumentInfo_Image.Run();

			// Get DocumentInformation URL HTML
			Get_DocumentInfo_URL_HTML.Run();

			// Get Document Information with Options HTML
			Get_DocumentInfo_with_Options_HTML.Run();

			// Get Document Information with Options Image
			Get_DocumentInfo_with_Options_Image.Run();

			// Get Document Information with Options URL HTML
			Get_DocumentInfo_with_Options_URL_HTML.Run();

			// Get Document Information with Options URL Image
			Get_DocumentInfo_with_Options_URL_Image.Run();

			// 
			//// Working with PDF Rendering


			// Create PDF File from Url HTML
			Create_Pdf_File_from_Url_HTML.Run();

			// Create PDF File from Url Image
			Create_Pdf_File_from_Url_Image.Run();

			// Create PDF File Request HTML
			Create_Pdf_File_Request_HTML.Run();

			// Create PDF File Request Image
			Create_Pdf_File_Request_Image.Run();

			// Create PDF File from URL HTML
			Get_Pdf_File_from_Url_HTML.Run();

			// Create PDF File from URL Image
			Get_Pdf_File_from_Url_Image.Run();

			// Get PDF File HTML
			Get_Pdf_File_HTML.Run();

			// Get PDF File Image
			Get_Pdf_File_Image.Run();

			// Get PDF File with Watermark HTML
			Get_Watermark_Pdf_File_HTML.Run();

			// Get PDF File with Watermark Image
			Get_Watermark_Pdf_File_Image.Run();

			// 
			////// Working with Document Pages


			// Create Pages Cache Minified HTML
			Create_Pages_Cache_Minified_HTML.Run();

			// Get Responsive HTML with Options
			Get_Responsive_HTML_Options.Run();

			// Render Email Header
			Render_Email_Header.Run();

			// Render Email Image PageSize
			Render_Email_Image_PageSize.Run();

			// Get Attachment Informmation Html
			Get_Attachment_Info_Html.Run();

			// Get Attachment Informmation Image
			Get_Attachment_Info_Image.Run();

			// Get Attachment Information With Options HTML
			Get_Attachment_Info_WithOptions_HTML.Run();

			// Get Attachment Information With Options Image
			Get_Attachment_Info_WithOptions_Image.Run();

			// Get Attachment Page Resource Html
			Get_Attachment_Page_Resource_Html.Run();

			// Get Attachment from Email Html
			Get_Attachment_From_Email_Html.Run();

			// Get Attachment from Email Image
			Get_Attachment_From_Email_Image.Run();

			// Get Attachmenst Html
			Get_Attachments_Html.Run();

			// Get Attachmenst Image
			Get_Attachments_Image.Run();

			// Create Attachment Pages Cache Html
			Create_Attachment_Pages_Cache_Html.Run();

			// Create Attachment Pages Cache Image
			Create_Attachment_Pages_Cache_Image.Run();

			// Delete Attachment Pages Cache HTML
			Delete_Attachment_Pages_Cache_Html.Run();

			// Delete Attachment Pages Cache Image
			Delete_Attachment_Pages_Cache_Image.Run();

			// Get Attachment Page Html
			Get_Attachment_Page_Html.Run();

			// Get Attachment Page Image
			Get_Attachment_Page_Image.Run();

			// Get Attachment Pages Html
			Get_Attachment_Pages_Html.Run();

			// Get Attachment Pages Image
			Get_Attachment_Pages_Image.Run();

			// Get Attachment Pages Zip Html
			Get_Attachment_Pages_ZIP_Html.Run();

			// Get Attachment Pages Zip Image
			Get_Attachment_Pages_ZIP_Image.Run();

			// Create Document Cache HTML
			Create_Document_Cache_HTML.Run();

			// Create Document Cache Image
			Create_Document_Cache_Image.Run();

			// Create Document Cache URL with HTML Options
			Create_Document_Cache_Url_With_HTMLOptions.Run();

			// Create Document Cache URL with Image Options
			Create_Document_Cache_Url_With_ImageLOptions.Run();

			// Create Pages Cache Request HTML
			Create_Pages_Cache_Request_HTML.Run();

			// Create Pages Cache Request Image
			Create_Pages_Cache_Request_Image.Run();

			// Create Project Page Cache HTML
			Create_Project_Page_Cache_HTML.Run();

			// Create Project Page Cache Image
			Create_Project_Page_Cache_Image.Run();

			// Download Document Page HTML
			Download_Document_Page_HTML.Run();

			// Download Document Page Image
			Download_Document_Page_Image.Run();

			// Exclude Fonts from Pages
			Exclude_Fonts.Run();

			// Get Pages HTML
			Get_Pages_HTML.Run();

			// Get Pages Image
			Get_Pages_Image.Run();

			// Get Pages from URL HTML
			Get_Pages_URL_HTML.Run();

			// Get Pages from URL Image
			Get_Pages_URL_Image.Run();

			// Get ZIP With Pages HTML
			Get_ZIP_With_Pages_HTML.Run();

			// Get ZIP With Pages Image
			Get_ZIP_With_Pages_Image.Run();

			// Get Page Resoruces HTML
			Page_Resoruces_API_HTML.Run();

			// Remove Document Cache for HTML & Image
			Remove_Document_Cache_for_HTML_Image.Run();

			// Remove Document Cache for Pages
			Remove_Document_Cache_for_HTML_Pages.Run();

			// Render CAD Tiles
			Render_CAD_Tiles.Run();

			// Render Email PDF
			Render_Email_PDF.Run();

			// Render Hidden Rows
			Render_Hidden_Rows.Run();

			// Render PDF Default Fonts
			Render_PDF_DefaultFont.Run();

			// Render Print Area Only
			Render_PrintArea_Only.Run();

			// Render Page HTML
			Reorder_Page_HTML.Run();

			// Render Page Image
			Reorder_Page_Image.Run();

			// Rotate Page HTML
			Rotate_Page_HTML.Run();

			// Rotate Page Image
			Rotate_Page_Image.Run();

			// Set Image Quality
			Set_image_quality.Run();

			// Text Overflow Mode Auto Fit to Column
			Text_Overflow_Mode.Run();
		}
	}
}