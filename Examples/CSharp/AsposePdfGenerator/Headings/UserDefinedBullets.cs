using System;
using System.IO;
using Aspose.Pdf;

namespace Aspose.Pdf.Examples.CSharp.AsposePdfGenerator.Headings
{
    public class UserDefinedBullets
    {
        public static void Run()
        {
            // ExStart:UserDefinedBullets
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_AsposePdfGenerator_Headings();
            // Instntiate the Pdf object by calling its empty constructor
            Aspose.Pdf.Generator.Pdf pdf1 = new Aspose.Pdf.Generator.Pdf();

            // Create the section in the Pdf object
            Aspose.Pdf.Generator.Section sec1 = pdf1.Sections.Add();

            /*
             * Create 1st heading in the Pdf object's section with level=1. Then create a text 
             * segment and add it in the heading. Set its UserLabel="98" to use a user defined
             * bullet. You must set BulletFontName to "Symbol" or "ZapfDingbats". After setting
             * all properties, add heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading1 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 1);
            Aspose.Pdf.Generator.Segment segment1 = new Aspose.Pdf.Generator.Segment(heading1);
            heading1.Segments.Add(segment1);
            segment1.Content = "Symbol";
            heading1.BulletFontName = "Symbol";
            heading1.UserLabel = "98";
            sec1.Paragraphs.Add(heading1);

            /*
             * Create 2nd heading in the Pdf object's section with level=2. Then create a text 
             * segment and add it in the heading. Set its UserLabel="99" to use a user defined
             * bullet. You must set BulletFontName to "Symbol" or "ZapfDingbats". After setting
             * all properties, add heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading2 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 2);
            Aspose.Pdf.Generator.Segment segment2 = new Aspose.Pdf.Generator.Segment(heading2);
            heading2.Segments.Add(segment2);
            segment2.Content = "Symbol";
            heading2.BulletFontName = "Symbol";
            heading2.UserLabel = "99";
            sec1.Paragraphs.Add(heading2);

            /*
             * Create 3rd heading in the Pdf object's section with level=3. Then create a text 
             * segment and add it in the heading. Set its UserLabel="100" to use a user defined
             * bullet. You must set BulletFontName to "Symbol" or "ZapfDingbats". After setting
             * all properties, add heading into the paragraphs collection of the section
             */

            Aspose.Pdf.Generator.Heading heading3 = new Aspose.Pdf.Generator.Heading(pdf1, sec1, 3);
            Aspose.Pdf.Generator.Segment segment3 = new Aspose.Pdf.Generator.Segment(heading3);
            heading3.Segments.Add(segment3);
            segment3.Content = "Symbol";
            heading3.BulletFontName = "Symbol";
            heading3.UserLabel = "100";
            sec1.Paragraphs.Add(heading3); 

            pdf1.Save(dataDir + "UserDefinedBullets_out_.pdf");
            // ExEnd:UserDefinedBullets   
                
        }
    }
}