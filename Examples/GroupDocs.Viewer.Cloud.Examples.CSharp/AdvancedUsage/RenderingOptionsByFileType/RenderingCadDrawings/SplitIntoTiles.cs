using System;
using System.Collections.Generic;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Viewer.Cloud.Examples.CSharp.AdvancedUsage.RenderingOptionsByFileType.RenderingCadDrawings
{
    /// <summary>
    /// This example demonstrates how to render DWG drawing into an image by dividing into four equal parts
    /// </summary>
    public class SplitIntoTiles
    {
        public static void Run()
        {
            try
            {
                var infoApiInstance = new InfoApi(Constants.GetConfig());
                var viewOptions = new ViewOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "SampleFiles/with_layers_and_layouts.dwg"
                    }
                };

                var infoResponse = infoApiInstance.GetInfo(new GetInfoRequest(viewOptions));

                // Get width and height
                var width = infoResponse.Pages[0].Width.Value;
                var height = infoResponse.Pages[0].Height.Value;

                // Set tile width and height as a half of image total width
                var tileWidth = width / 2;
                var tileHeight = height / 2;
                var pointX = 0;
                var pointY = 0;

                //Create image options and add four tiles, one for each quarter

                viewOptions = new ViewOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "SampleFiles/with_layers_and_layouts.dwg"
                    },
                    ViewFormat = ViewOptions.ViewFormatEnum.HTML,
                    RenderOptions = new HtmlOptions
                    {
                        CadOptions = new CadOptions()
                    }
                };

                viewOptions.RenderOptions.CadOptions.Tiles = new List<Tile>();
                var tile = new Tile { StartPointX = pointX, StartPointY = pointY, Width = tileWidth, Height = tileHeight };
                viewOptions.RenderOptions.CadOptions.Tiles.Add(tile);
                pointX += tileWidth;
                tile = new Tile { StartPointX = pointX, StartPointY = pointY, Width = tileWidth, Height = tileHeight };
                viewOptions.RenderOptions.CadOptions.Tiles.Add(tile);
                pointX = 0;
                pointY += tileHeight;
                tile = new Tile { StartPointX = pointX, StartPointY = pointY, Width = tileWidth, Height = tileHeight };
                viewOptions.RenderOptions.CadOptions.Tiles.Add(tile);
                pointX += tileWidth;
                tile = new Tile { StartPointX = pointX, StartPointY = pointY, Width = tileWidth, Height = tileHeight };
                viewOptions.RenderOptions.CadOptions.Tiles.Add(tile);

                var apiInstance = new ViewApi(Constants.GetConfig());
                var response = apiInstance.CreateView(new CreateViewRequest(viewOptions));
                Console.WriteLine("SplitIntoTiles completed: " + response.Pages.Count);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}