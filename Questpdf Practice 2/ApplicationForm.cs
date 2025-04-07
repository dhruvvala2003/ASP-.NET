using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data.Common;
using System.IO;

namespace ApplicationFormReport
{
    public class ApplicationForm : IDocument
    {
        private readonly ApplicationFormData _data;

        public ApplicationForm(ApplicationFormData data)
        {
            _data = data;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(1, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Times New Roman"));
             

                //header
                page.Header().BorderTop(3).BorderLeft(3).BorderRight(3).Padding(20).Column(r1 =>
                {
                    r1.Item().Row(headerRow =>
                    {

                        headerRow.ConstantItem(100).Height(70).Image("C:\\Users\\offic\\Desktop\\ConsoleApp1 (1)\\questpdf practice 2 letest\\images.jpg");


                        headerRow.ConstantItem(300).PaddingTop(20).AlignCenter().Column(col =>{

                            col.Item().AlignCenter().Text("DU LIBRARY").FontSize(18).Bold();
                            col.Item().Text(" LIBRARY FINE RECEIPT").FontSize(16).Bold();
                        });

                    });

                    
                });

                //content 
                page.Content().Element(ComposeContent);


                //footer

                page.Footer().BorderBottom(3).BorderLeft(3).BorderRight(3).Padding(20).Column(column =>
                {
                    column.Item().Row(row =>
                    {
                        row.ConstantItem(80).AlignLeft().Text("Print Date : ").FontSize(14).Bold();
                        row.ConstantItem(150).AlignLeft().Text($"{DateTime.Now}").FontSize(16);

                    });

                });
            });
        }

        private void ComposeContent(IContainer container)
        {
            container.BorderLeft(3).BorderRight(3).Padding(20).Column(col =>
            {


                col.Item().PaddingTop(20).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(5);

                    });

                    table.Cell().PaddingBottom(2).Text("Receipt No : ").FontSize(14).Bold();
                    table.Cell().PaddingBottom(2).Text("1072").FontSize(12);
                    table.Cell().PaddingBottom(2).Text("ERP ID : ").FontSize(14).Bold();
                    table.Cell().PaddingBottom(2).Text($"186624306002").FontSize(12);
                    table.Cell().PaddingBottom(2).Text("Name : ").FontSize(14).Bold();
                    table.Cell().PaddingBottom(2).Text("Madhav Kamleshbhai Kikani").FontSize(12);
                   
                });

                //LINE 
                col.Item()
                .PaddingTop(20)
               .LineHorizontal(2)
               .LineColor(Colors.Blue.Medium);

                col.Item().Padding(5).Table(table =>
                {
                   

                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(80);
                        columns.RelativeColumn();
                        columns.ConstantColumn(100);
                        columns.ConstantColumn(100);
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {

                        header.Cell().Padding(2).PaddingTop(5).PaddingBottom(5) .AlignCenter().Text("SR No.").FontSize(13).Bold();
                        header.Cell().Padding(2).PaddingTop(5).PaddingBottom(5).AlignCenter().Text("Accession No.").FontSize(13).Bold();
                        header.Cell().Padding(2).PaddingTop(5).PaddingBottom(5).AlignCenter().Text("Due Date").FontSize(13).Bold();
                        header.Cell().Padding(2).PaddingTop(5).PaddingBottom(5).AlignCenter().Text("Return Date").FontSize(13).Bold();
                        header.Cell().Padding(2).PaddingTop(5).PaddingBottom(5).AlignCenter().Text("Fine").FontSize(13).Bold();

                        //LINE 
                        col.Item()
                          .LineHorizontal(2)
                          .LineColor(Colors.Blue.Medium);
                    });

                    for (int i=0;i<4;i++)
                    {
                        table.Cell().PaddingBottom(2).AlignCenter().Text($"{i + 1}").Bold();
                        table.Cell().PaddingBottom(2).AlignCenter().Text($"P00{i+1}").Bold();
                        table.Cell().PaddingBottom(2).AlignCenter().Text($"{DateTime.Now}").Bold();
                        table.Cell().PaddingBottom(2).AlignCenter().Text($"{DateTime.Now}").Bold();
                        table.Cell().PaddingBottom(2).AlignCenter().Text("123456789010").Bold();
                    }
                });


                col.Item().AlignRight().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(150);
                        columns.ConstantColumn(50);
                     
                    });

                    
                    table.Cell().PaddingBottom(2).Text("Total Fine :").Bold();
                    table.Cell().PaddingBottom(2).Text("29789").Bold();

                });

                col.Item().AlignRight().Table(table =>
                {


                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(150);
                        columns.ConstantColumn(50);

                    });


                    table.Cell().PaddingBottom(2).Text("Received Amount :").Bold();
                    table.Cell().PaddingBottom(2).Text("277989").Bold();

                });






            });
        }
    }


    public class EducationDetail
    {
        public string Degree { get; set; }
        public string School { get; set; }
        public string Board { get; set; }
        public string Subject { get; set; }
        public string Result { get; set; }
        public int Year { get; set; }
        public int TotalMarks { get; set; }
        public int ObtainedMarks { get; set; }
        public string Percentage { get; set; }
    }

    public class ApplicationFormData
    {
        public List<EducationDetail> EducationDetails { get; set; } = new();
        public string EnquiryNumber { get; set; }
        public string ProgrammeName { get; set; }
        public string Specialization { get; set; }
        public string Salutation { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Nationality { get; set; }
        public string MobileNumber { get; set; }
        public string Religion { get; set; }
        public string FatherName { get; set; }
        public string CategoryCaste { get; set; }
        public string HouseNo { get; set; }
        public string VillageTown { get; set; }
        public string State { get; set; }
        public string AreaStreet { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }
    }
}
