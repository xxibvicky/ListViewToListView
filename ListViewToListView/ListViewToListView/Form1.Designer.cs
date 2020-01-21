namespace ListViewToListView
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEinsRechts = new System.Windows.Forms.Button();
            this.btnEinsLinks = new System.Windows.Forms.Button();
            this.btnAlleRechts = new System.Windows.Forms.Button();
            this.btnAlleLinks = new System.Windows.Forms.Button();
            this.btnListeEinlesen = new System.Windows.Forms.Button();
            this.btnInListeSpeichern = new System.Windows.Forms.Button();
            this.btnLV1Clear = new System.Windows.Forms.Button();
            this.btnLV2Clear = new System.Windows.Forms.Button();
            this.btnInDBSpeichern = new System.Windows.Forms.Button();
            this.btnDBeinlesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(546, 467);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Text = "Marke";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 2;
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 3;
            this.columnHeader3.Text = "Farbe";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 4;
            this.columnHeader4.Text = "PS";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Kennzeichen";
            this.columnHeader5.Width = 120;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(676, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(546, 467);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Marke";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "Type";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 3;
            this.columnHeader8.Text = "Farbe";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 4;
            this.columnHeader9.Text = "PS";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 0;
            this.columnHeader10.Text = "Kennzeichen";
            this.columnHeader10.Width = 120;
            // 
            // btnEinsRechts
            // 
            this.btnEinsRechts.Location = new System.Drawing.Point(582, 29);
            this.btnEinsRechts.Name = "btnEinsRechts";
            this.btnEinsRechts.Size = new System.Drawing.Size(72, 67);
            this.btnEinsRechts.TabIndex = 2;
            this.btnEinsRechts.Text = ">";
            this.btnEinsRechts.UseVisualStyleBackColor = true;
            // 
            // btnEinsLinks
            // 
            this.btnEinsLinks.Location = new System.Drawing.Point(582, 147);
            this.btnEinsLinks.Name = "btnEinsLinks";
            this.btnEinsLinks.Size = new System.Drawing.Size(72, 67);
            this.btnEinsLinks.TabIndex = 2;
            this.btnEinsLinks.Text = "<";
            this.btnEinsLinks.UseVisualStyleBackColor = true;
            // 
            // btnAlleRechts
            // 
            this.btnAlleRechts.Location = new System.Drawing.Point(582, 268);
            this.btnAlleRechts.Name = "btnAlleRechts";
            this.btnAlleRechts.Size = new System.Drawing.Size(72, 67);
            this.btnAlleRechts.TabIndex = 2;
            this.btnAlleRechts.Text = ">>";
            this.btnAlleRechts.UseVisualStyleBackColor = true;
            // 
            // btnAlleLinks
            // 
            this.btnAlleLinks.Location = new System.Drawing.Point(582, 392);
            this.btnAlleLinks.Name = "btnAlleLinks";
            this.btnAlleLinks.Size = new System.Drawing.Size(72, 67);
            this.btnAlleLinks.TabIndex = 2;
            this.btnAlleLinks.Text = "<<";
            this.btnAlleLinks.UseVisualStyleBackColor = true;
            // 
            // btnListeEinlesen
            // 
            this.btnListeEinlesen.Location = new System.Drawing.Point(12, 485);
            this.btnListeEinlesen.Name = "btnListeEinlesen";
            this.btnListeEinlesen.Size = new System.Drawing.Size(226, 52);
            this.btnListeEinlesen.TabIndex = 3;
            this.btnListeEinlesen.Text = "Liste einlesen";
            this.btnListeEinlesen.UseVisualStyleBackColor = true;
            this.btnListeEinlesen.Click += new System.EventHandler(this.btnListeEinlesen_Click);
            // 
            // btnInListeSpeichern
            // 
            this.btnInListeSpeichern.Location = new System.Drawing.Point(244, 485);
            this.btnInListeSpeichern.Name = "btnInListeSpeichern";
            this.btnInListeSpeichern.Size = new System.Drawing.Size(214, 52);
            this.btnInListeSpeichern.TabIndex = 3;
            this.btnInListeSpeichern.Text = "in Liste speichern";
            this.btnInListeSpeichern.UseVisualStyleBackColor = true;
            this.btnInListeSpeichern.Click += new System.EventHandler(this.btnInListeSpeichern_Click);
            // 
            // btnLV1Clear
            // 
            this.btnLV1Clear.Location = new System.Drawing.Point(464, 485);
            this.btnLV1Clear.Name = "btnLV1Clear";
            this.btnLV1Clear.Size = new System.Drawing.Size(94, 52);
            this.btnLV1Clear.TabIndex = 4;
            this.btnLV1Clear.Text = "CLR";
            this.btnLV1Clear.UseVisualStyleBackColor = true;
            this.btnLV1Clear.Click += new System.EventHandler(this.btnLV1Clear_Click);
            // 
            // btnLV2Clear
            // 
            this.btnLV2Clear.Location = new System.Drawing.Point(1128, 485);
            this.btnLV2Clear.Name = "btnLV2Clear";
            this.btnLV2Clear.Size = new System.Drawing.Size(94, 52);
            this.btnLV2Clear.TabIndex = 7;
            this.btnLV2Clear.Text = "CLR";
            this.btnLV2Clear.UseVisualStyleBackColor = true;
            // 
            // btnInDBSpeichern
            // 
            this.btnInDBSpeichern.Location = new System.Drawing.Point(908, 485);
            this.btnInDBSpeichern.Name = "btnInDBSpeichern";
            this.btnInDBSpeichern.Size = new System.Drawing.Size(214, 52);
            this.btnInDBSpeichern.TabIndex = 5;
            this.btnInDBSpeichern.Text = "in DB speichern";
            this.btnInDBSpeichern.UseVisualStyleBackColor = true;
            // 
            // btnDBeinlesen
            // 
            this.btnDBeinlesen.Location = new System.Drawing.Point(676, 485);
            this.btnDBeinlesen.Name = "btnDBeinlesen";
            this.btnDBeinlesen.Size = new System.Drawing.Size(226, 52);
            this.btnDBeinlesen.TabIndex = 6;
            this.btnDBeinlesen.Text = "DB einlesen";
            this.btnDBeinlesen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 580);
            this.Controls.Add(this.btnLV2Clear);
            this.Controls.Add(this.btnInDBSpeichern);
            this.Controls.Add(this.btnDBeinlesen);
            this.Controls.Add(this.btnLV1Clear);
            this.Controls.Add(this.btnInListeSpeichern);
            this.Controls.Add(this.btnListeEinlesen);
            this.Controls.Add(this.btnAlleLinks);
            this.Controls.Add(this.btnAlleRechts);
            this.Controls.Add(this.btnEinsLinks);
            this.Controls.Add(this.btnEinsRechts);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "From ListView To ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnEinsRechts;
        private System.Windows.Forms.Button btnEinsLinks;
        private System.Windows.Forms.Button btnAlleRechts;
        private System.Windows.Forms.Button btnAlleLinks;
        private System.Windows.Forms.Button btnListeEinlesen;
        private System.Windows.Forms.Button btnInListeSpeichern;
        private System.Windows.Forms.Button btnLV1Clear;
        private System.Windows.Forms.Button btnLV2Clear;
        private System.Windows.Forms.Button btnInDBSpeichern;
        private System.Windows.Forms.Button btnDBeinlesen;
    }
}

