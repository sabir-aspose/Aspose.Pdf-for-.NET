using System.IO;
using System;
using System.Net;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePDF.DocumentConversion
{
    public class WebPageToPDF
    {
        public static void Run()
        {
            try
            {
                // ExStart:WebPageToPDF
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_AsposePdf_DocumentConversion();
                // Create a request for the URL.
                WebRequest request = WebRequest.Create("https://en.wikipedia.org/wiki/Main_Page");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // time out in miliseconds before the request times out
                // request.Timeout = 100;

                // Get the response.
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(responseFromServer));
                HtmlLoadOptions options = new HtmlLoadOptions("https://en.wikipedia.org/wiki/");


                // Load HTML file
                Document pdfDocument = new Document(stream, options);

                options.PageInfo.IsLandscape = true;

                // Save output as PDF format
                pdfDocument.Save(dataDir + "WebPageToPDF_out_.pdf");
                // ExEnd:WebPageToPDF
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}