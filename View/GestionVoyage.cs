using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Model;
using TravelAgencyApp.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelAgencyApp.View
{

    public partial class GestionVoyage : Form
    {
        private UnitOfWork unitOfWork;

        public GestionVoyage()

        {
            unitOfWork=new UnitOfWork();
            InitializeComponent();
            this.Size = new Size(1390,570 );
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
            string titre = zoneTitre.Text;
            string description = zoneDescription.Text;
            String destination=zoneDestination.Text;
            DateTime dateDepart = dateDepartPicker.Value;
            DateTime dateRetour = dateRetourPicker.Value;
            int prix = int.Parse(zonePrix.Text);
            int placesDisponibles = int.Parse(zoneNbPlace.Text);
            int guideId = int.Parse(GuidecomboBox.SelectedItem.ToString());
            Voyage nouveauVoyage = new Voyage()
            {
                Titre = titre,
                Description = description,
                Destinations=destination,
                DateDepart = dateDepart,
                DateRetour = dateRetour,
                Prix = prix,
                NombrePlacesDisponibles = placesDisponibles,
                GuideId = guideId
            };
            unitOfWork.VoyageRepository.Insert(nouveauVoyage);
            unitOfWork.Save();
                MessageBox.Show("Le voyage a été ajouté avec succès !");
                zoneId.Text = null;
                zoneTitre.Text = null;
                zoneDescription.Text = null;
                zoneDestination.Text = null;
                zonePrix.Text = null;
                zoneNbPlace.Text = null;
            }
            catch (DbEntityValidationException ex)
            {
                // Parcourir toutes les erreurs de validation pour chaque entité
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    // Parcourir toutes les erreurs de validation pour une entité spécifique
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        // Afficher les détails de l'erreur de validation (par exemple, la propriété affectée et le message d'erreur)
                        MessageBox.Show($"Erreur de validation pour la propriété : {validationError.PropertyName}");
                        MessageBox.Show($"Message d'erreur : {validationError.ErrorMessage}");
                    }
                }
               

            }
        }

        private void GestionVoyage_Load(object sender, EventArgs e)
        {
            IEnumerable<Guide> guides = unitOfWork.GuideRepository.GetAll();
            foreach (Guide guide in guides)
            {
                GuidecomboBox.Items.Add(guide.PersonnelId);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            IEnumerable<Voyage> voyages=unitOfWork.VoyageRepository.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= voyages;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(zoneId.Text);
            Voyage v=unitOfWork.VoyageRepository.GetById(id);
            if (v == null)
            {
                MessageBox.Show("Le voyage avec l'ID spécifié n'a pas été trouvé.");
                
            }
            string titre = zoneTitre.Text;
            string description = zoneDescription.Text;
            String destination = zoneDestination.Text;
            DateTime dateDepart = dateDepartPicker.Value;
            DateTime dateRetour = dateRetourPicker.Value;
            int prix = int.Parse(zonePrix.Text);
            int placesDisponibles = int.Parse(zoneNbPlace.Text);
            int guideId = int.Parse(GuidecomboBox.SelectedItem.ToString());
            v.Titre = titre;
            v.Description = description;
            v.Destinations = destination;
            v.DateDepart = dateDepart;
            v.DateRetour = dateRetour;
            v.Prix = prix;
            v.NombrePlacesDisponibles = placesDisponibles;
            v.GuideId = guideId;
           
            unitOfWork.VoyageRepository.Update(v);
            unitOfWork.Save();
            MessageBox.Show("Le voyage a ete modifier avec succes !");
            dataGridView1.DataSource=unitOfWork.VoyageRepository.GetAll();
            zoneTitre.Text=null;
            zoneDescription=null;
            zoneDestination.Text=null;
            zonePrix.Text=null;
            zoneNbPlace.Text=null;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(zoneId.Text);
            Voyage v = unitOfWork.VoyageRepository.GetById(id);
            if (v == null)
            {
                MessageBox.Show("Le voyage avec l'ID spécifié n'a pas été trouvé.");

            }
            unitOfWork.VoyageRepository.Delete(id);
            unitOfWork.Save();
            MessageBox.Show("Le voyage a ete supprimer avec succes !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVoyage gestionVoyage = new GestionVoyage();
            gestionVoyage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionGuide gestionGuide = new GestionGuide();
            gestionGuide.Show();
        }
    }
}
