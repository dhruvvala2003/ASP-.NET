using ApplicationFormReport;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.Reflection;

class Program
{
    static void Main()
    {
        QuestPDF.Settings.License = LicenseType.Community;

        var formData = new ApplicationFormData
        {
            
                EnquiryNumber = "12345",
                ProgrammeName = "Computer Science",
                Specialization = "AI & ML",
                Salutation = "Mr.",
                FullName = "John Doe",
                DateOfBirth = new DateTime(2000, 5, 15),
                Gender = "Male",
                Email = "johndoe@example.com",
                MobileNumber = "9876543210",
                HouseNo = "123",
                VillageTown = "Sample Town",
                State = "Gujarat",
                AreaStreet = "Main Street",
                District = "Ahmedabad",
                Pincode = "380001"
            
        };

        var document = new ApplicationForm(formData);

        //string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "Application_Form.pdf");
        //document.GeneratePdf(downloadPath);
        // Open in QuestPDF Companion
        document.ShowInCompanion();
    }
}
