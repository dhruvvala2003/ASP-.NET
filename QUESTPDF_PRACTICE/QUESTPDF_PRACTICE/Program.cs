using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

// code in your main method
QuestPDF.Settings.License = LicenseType.Community;
var filename = "text2.pdf";

Document.Create(container =>
{
    container.Page(page =>
    {
        page.Size(PageSizes.A4);
        page.Margin(2, Unit.Centimetre);
        page.PageColor(Colors.White);
        page.DefaultTextStyle(x => x.FontSize(20));

        page.Header().Element(Header);
        page.Content().Element(Content);
        page.Footer().Element(Footer);



        void Header(IContainer container)
        {
            container.Row(r =>
            {

                //->  total 400 point are there. here section 1 occcupy 25% of it due to 100 points 

                //section1 :begin 
                r.ConstantItem(100)
                .Hyperlink("http://www.google.com")  // after clicking on it it redirects to google home page 
                .Background(Colors.Red.Accent4)
                 .Height(50)
                 .Width(50)
                .Image("C:/Users/offic/Pictures/extra/ana.png");
                //section1 :end


                //section 2 :begin
                // in reletivepath there are 4 point occupy for total remaining lengt . out of it 25 % is taken by below first one & rest 75% is taken by second below one .

                r.RelativeItem(1)
                .DebugArea()             //for debuging
                .Background(Colors.Green.Accent1)
                  .Text("suiiiiiii");

                r.RelativeItem(3)
                .Padding(25)
                .Background(Colors.Yellow.Accent4)
                 .Column(column =>
                 {
                     // below 2 comes up& down wise 
                     column.Item().Text("fajhdbf").FontSize(34);

                     column.Item().Text("saa").FontSize(30);

                 });


                //section2:end
            });
        }

        void Content(IContainer container)
        {
            container.PaddingVertical(1, Unit.Centimetre)
            .Column(x =>
            {
                x.Spacing(20);
                x.Item().Component<MyComponent>();  // udf component (alternative one can use extesion methord)

                x.Item().Text(Placeholders.LoremIpsum());
                x.Item().Image(Placeholders.Image(200, 100));
                x.Item().Text("The Arabic word for programming is البرمجة.");

                x.Item().Text("Popular emojis include 😊, 😂, ❤️, 👍, and 😎.")
                  .FontFamily("Lato", "Noto Emoji");
                x.Item().Text(Placeholders.LoremIpsum());

                x.Item().Text(Placeholders.LoremIpsum());
                //.FontFamily("Lato", "Noto Sans Arabic");


                x.Item().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                {
                    // no. name, qty, price per item, total price
                    columns.ConstantColumn(50);
                    columns.RelativeColumn();
                    columns.ConstantColumn(50);
                    columns.ConstantColumn(80);
                    columns.ConstantColumn(70);
                });

                    table.Header(header =>
                    {

                        header.Cell().Text("#");
                        header.Cell().Text("name of product");
                        header.Cell().Text("qty");
                        header.Cell().Text("price per item");
                        header.Cell().AlignRight().Text("total price");
                    });


                    for (var i = 1; i <= 20; i++)
                    {
                        var qty = Placeholders.Random.Next(1, 10);
                        var price = Placeholders.Random.NextDouble() * 100;
                        var total = qty * price;

                        table.Cell().Text(i.ToString());
                        table.Cell().Text(Placeholders.Label());
                        table.Cell().Text("" + qty);
                        table.Cell().Text(price.ToString());
                        table.Cell().Text(total.ToString());
                    }



                });


            });

        }

        void Footer(IContainer container)
        {
            container.AlignCenter()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
            });

        }

    }

    );

    //second page (just for reference)
    container.Page(p1 =>
    {
        p1.Margin(2, Unit.Centimetre);

        p1.Header()
            .Background(Colors.Green.Lighten2)
            .Height(1, Unit.Inch)
            .Text("dahcad")
            .SemiBold().FontSize(36).FontColor(Colors.Red.Medium);


        p1.Content()
            .PaddingVertical(1, Unit.Centimetre)

            .Column(col =>
            {
                col.Spacing(50);

                for (int i = 0; i < 4; i++)
                {
                    col.Item()

                    .Border(3)
                    .BorderColor(Colors.Red.Medium)
                    .Background(Colors.Amber.Medium)
                    .Height(100)
                   .Text("The Arabic word for programming is البرمجة.");


                }

                col.Item().Background(Colors.Blue.Accent4)
                        .Text("dfbjhsbk");


                col.Item().Background(Colors.Red.Accent4)
                  .Text("bdgdghfjkgkiukugkjjgfhfhdghdg");


                //.FontFamily("Lato", "Noto Sans Arabic");


            });

        p1.Footer()
            .Background(Colors.Blue.Lighten2)
            .Height(1, Unit.Inch)
            .AlignRight()
            .Text(x =>
            {
                x.Span("Page ");
                x.CurrentPageNumber();
                x.Span("OF");
                x.TotalPages();

            });
    });



})
//.ShowInPreviewerAsync() // Use the new async previewer method
//      .GetAwaiter()
//      .GetResult();

.GeneratePdf(filename);



var p = new Process();
p.StartInfo = new ProcessStartInfo(Path.Combine(Directory.GetCurrentDirectory(), filename))
{
    UseShellExecute = true
};
p.Start();


// componet 
public class MyComponent : IComponent
{
    public void Compose(IContainer container)
    {
        container.Text("my own methord");

    }
}