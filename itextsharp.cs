private void btnSignerRencontre_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Resultat.pdf", FileMode.Create));
            doc.Open(); // ouvrir le document ecrit
                        // ecrire le contenant du document
            iTextSharp.text.Image jpeg = iTextSharp.text.Image.GetInstance("logo.jpg");
            jpeg.ScalePercent(25f);
            jpeg.Alignment = 1;
            // Fonction pour background image
            iTextSharp.text.Image filigrane = iTextSharp.text.Image.GetInstance("Campo.png");
            filigrane.SetAbsolutePosition(20, 200);
            doc.Add(filigrane);
            //Watermark Background = new Watermark(Image.GetInstance("watermark.jpg"), 200, 420);
            //doc.Add(Background);
            // pour positionner l'image 
            //jpeg.SetAbsolutePosition(doc.PageSize.Width - 36f - 72f, doc.PageSize.Height - 30f - 216f);
            Paragraph date = new Paragraph(" Date________________\n\n\n");
            date.Alignment = 2;// 0= left , 1 = centre , 2 = right
            doc.Add(date);
            doc.Add(jpeg);
            Paragraph paragraph = new Paragraph("COMPETITION INTERNATIONAL DE FOOTBALL D'EUROPE..\n\n\n", new iTextSharp.text.Font(
                iTextSharp.text.Font.NORMAL, 30f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE));
            Paragraph Corp = new Paragraph("\n\n   Suite a la rencontre qui s'est effectuée le " + dgvResultat.CurrentRow.Cells["DateRen"].Value.ToString() + " Nous ressortons avec un de score de "+ dgvResultat.CurrentRow.Cells["EquipeDomic"].Value.ToString() + " " + dgvResultat.CurrentRow.Cells["vsresultat"].Value.ToString() + " " + dgvResultat.CurrentRow.Cells["EquipeAdv"].Value.ToString() + "  \n\n\n");
            paragraph.Alignment = 1;// 0= left , 1 = centre , 2 = right
            PdfPTable table = new PdfPTable(1);
            PdfPCell entête = new PdfPCell(new Phrase("RESULTAT DE LA RENCONTRE \n", new iTextSharp.text.Font(
                iTextSharp.text.Font.NORMAL, 20f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            entête.BackgroundColor = new iTextSharp.text.BaseColor(150, 150, 50);
            entête.Colspan = 8;
            entête.HorizontalAlignment = 1;// 0= left , 1 = centre , 2 = right
            doc.Add(paragraph);
            table.AddCell(entête);
            doc.Add(table);
            doc.Add(Corp);
            doc.Close(); // fermer le document