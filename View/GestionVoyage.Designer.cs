namespace TravelAgencyApp.View
{
    partial class GestionVoyage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zoneTitre = new System.Windows.Forms.TextBox();
            this.zoneDescription = new System.Windows.Forms.TextBox();
            this.dateDepartPicker = new System.Windows.Forms.DateTimePicker();
            this.zonePrix = new System.Windows.Forms.TextBox();
            this.zoneNbPlace = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.zoneDestination = new System.Windows.Forms.TextBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.zoneId = new System.Windows.Forms.TextBox();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.GuidecomboBox = new System.Windows.Forms.ComboBox();
            this.dateRetourPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1835, 66);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(92, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 608);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de Départ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre de place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(240, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Guide";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // zoneTitre
            // 
            this.zoneTitre.Location = new System.Drawing.Point(373, 189);
            this.zoneTitre.Name = "zoneTitre";
            this.zoneTitre.Size = new System.Drawing.Size(200, 22);
            this.zoneTitre.TabIndex = 11;
            // 
            // zoneDescription
            // 
            this.zoneDescription.Location = new System.Drawing.Point(373, 225);
            this.zoneDescription.Multiline = true;
            this.zoneDescription.Name = "zoneDescription";
            this.zoneDescription.Size = new System.Drawing.Size(200, 87);
            this.zoneDescription.TabIndex = 12;
            // 
            // dateDepartPicker
            // 
            this.dateDepartPicker.Location = new System.Drawing.Point(373, 365);
            this.dateDepartPicker.Name = "dateDepartPicker";
            this.dateDepartPicker.Size = new System.Drawing.Size(200, 22);
            this.dateDepartPicker.TabIndex = 13;
            // 
            // zonePrix
            // 
            this.zonePrix.Location = new System.Drawing.Point(373, 426);
            this.zonePrix.Name = "zonePrix";
            this.zonePrix.Size = new System.Drawing.Size(201, 22);
            this.zonePrix.TabIndex = 15;
            // 
            // zoneNbPlace
            // 
            this.zoneNbPlace.Location = new System.Drawing.Point(373, 462);
            this.zoneNbPlace.Name = "zoneNbPlace";
            this.zoneNbPlace.Size = new System.Drawing.Size(200, 22);
            this.zoneNbPlace.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 363);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(251, 594);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 38);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // zoneDestination
            // 
            this.zoneDestination.Location = new System.Drawing.Point(373, 329);
            this.zoneDestination.Name = "zoneDestination";
            this.zoneDestination.Size = new System.Drawing.Size(200, 22);
            this.zoneDestination.TabIndex = 21;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAfficher.Location = new System.Drawing.Point(415, 594);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(127, 38);
            this.btnAfficher.TabIndex = 22;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModifier.Location = new System.Drawing.Point(575, 594);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 38);
            this.btnModifier.TabIndex = 23;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "id";
            // 
            // zoneId
            // 
            this.zoneId.Location = new System.Drawing.Point(374, 155);
            this.zoneId.Name = "zoneId";
            this.zoneId.Size = new System.Drawing.Size(200, 22);
            this.zoneId.TabIndex = 25;
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSupprimer.Location = new System.Drawing.Point(734, 594);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(127, 38);
            this.BtnSupprimer.TabIndex = 26;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(234, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 31);
            this.label11.TabIndex = 28;
            this.label11.Text = "Gestion De Voyage";
            // 
            // GuidecomboBox
            // 
            this.GuidecomboBox.FormattingEnabled = true;
            this.GuidecomboBox.Location = new System.Drawing.Point(373, 494);
            this.GuidecomboBox.Name = "GuidecomboBox";
            this.GuidecomboBox.Size = new System.Drawing.Size(200, 24);
            this.GuidecomboBox.TabIndex = 17;
            // 
            // dateRetourPicker
            // 
            this.dateRetourPicker.Location = new System.Drawing.Point(373, 398);
            this.dateRetourPicker.Name = "dateRetourPicker";
            this.dateRetourPicker.Size = new System.Drawing.Size(200, 22);
            this.dateRetourPicker.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date de retour";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TravelAgencyApp.Properties.Resources.airplane;
            this.pictureBox2.Location = new System.Drawing.Point(57, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelAgencyApp.Properties.Resources.menu__2_;
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Image = global::TravelAgencyApp.Properties.Resources.booking;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(9, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 35);
            this.button4.TabIndex = 34;
            this.button4.Text = "Gestion Booking";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::TravelAgencyApp.Properties.Resources.customers;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 35);
            this.button3.TabIndex = 33;
            this.button3.Text = "Gestion Clients";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TravelAgencyApp.Properties.Resources.landscape;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(9, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 36);
            this.button1.TabIndex = 31;
            this.button1.Text = "Gestion Voyages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::TravelAgencyApp.Properties.Resources.tour_guide;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Gestion Guides";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 673);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.zoneId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.zoneDestination);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuidecomboBox);
            this.Controls.Add(this.zoneNbPlace);
            this.Controls.Add(this.zonePrix);
            this.Controls.Add(this.dateRetourPicker);
            this.Controls.Add(this.dateDepartPicker);
            this.Controls.Add(this.zoneDescription);
            this.Controls.Add(this.zoneTitre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GestionVoyage";
            this.Text = "GestionVoyage";
            this.Load += new System.EventHandler(this.GestionVoyage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zoneTitre;
        private System.Windows.Forms.TextBox zoneDescription;
        private System.Windows.Forms.DateTimePicker dateDepartPicker;
        private System.Windows.Forms.TextBox zonePrix;
        private System.Windows.Forms.TextBox zoneNbPlace;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox zoneDestination;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox zoneId;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox GuidecomboBox;
        private System.Windows.Forms.DateTimePicker dateRetourPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}