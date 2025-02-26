using Modul7CronOpg;

List<Invoice> invoices = new List<Invoice>();

invoices.Add(new StandardInvoice(){Amount = 2000, Description = "Massage with ending ;)"});
invoices.Add(new NoVATInvoice(){Amount = 300, Description = "Shitty car"});
invoices.Add(new NoVATInvoice() { Amount = 500, Description = "Office Supplies"});
invoices.Add(new StandardInvoice(){Amount = 231, Description = "Military supplies"});
invoices.Add(new NoVATInvoice() {Amount = 9.99m, Description = "Handicap aid"});


foreach (var inboice in invoices)
{
    inboice.Display();
}