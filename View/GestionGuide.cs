using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyApp.Model;
using TravelAgencyApp.Repository;

namespace TravelAgencyApp.View
{
    public partial class GestionGuide : Form
    {
        UnitOfWork unitOfWork;
        public GestionGuide()
        {
            InitializeComponent();
            this.Size = new Size(1390, 570);
            this.StartPosition = FormStartPosition.CenterScreen;
            unitOfWork = new UnitOfWork();
        }

        private void GestionGuide_Load(object sender, EventArgs e)
        {


        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {

            IEnumerable<Guide> guides = unitOfWork.GuideRepository.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = guides;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int id = int.Parse(zoneId.Text);
            string nom=zoneNom.Text;
            string prenom=zonePrenom.Text;
            string addresse = zoneAdresse.Text;
            DateTime dateN=dateNaisctPicker.Value;
            String genre = zoneGenre.Text;
            int salaire=int.Parse(zoneSalaire.Text);
            String langue=zoneLangues.Text;
            Guide guide = new Guide() {
                PersonnelId = id,
                Nom = nom,
                Prenom = prenom,
                Adresse=addresse,
                DateNaissance=dateN,
                Genre=genre,
                Salaire=salaire,
                LanguesParlees=langue,
            };
            unitOfWork.GuideRepository.Insert(guide);
            unitOfWork.Save();
            MessageBox.Show("Le Guide a ete ajouter avec succes !");
            zoneNom.Text = null;
            zoneId.Text = null;
            zonePrenom.Text = null;
            zoneSalaire.Text = null;
            zoneLangues.Text = null;
            zoneAdresse.Text = null;
            zoneGenre.Text = null;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int id =int.Parse(zoneId.Text);
            Guide g = unitOfWork.GuideRepository.GetById(id);
            if(id == null) {
                MessageBox.Show("Le guide avec l'ID spécifié n'a pas été trouvé.");
            }
            string nom = zoneNom.Text;
            string prenom = zonePrenom.Text;
            string addresse = zoneAdresse.Text;
            DateTime dateN = dateNaisctPicker.Value;
            String genre = zoneGenre.Text;
            int salaire = int.Parse(zoneSalaire.Text);
            String langue = zoneLangues.Text;

            g.PersonnelId = id;
            g.Nom = nom;
            g.Prenom = prenom;
            g.Adresse = addresse;
            g.DateNaissance = dateN;
            g.Genre = genre;
            g.Salaire = salaire;
            g.LanguesParlees = langue;
            unitOfWork.GuideRepository.Update(g);
            unitOfWork.Save();
            MessageBox.Show("Le Guide a ete modifier avec succes !");
            zoneNom.Text = null;
            zoneId.Text = null;
            zonePrenom.Text = null;
            zoneSalaire.Text = null;
            zoneLangues.Text = null;
            zoneAdresse.Text = null;
            zoneGenre.Text = null;
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(zoneId.Text);
            Guide g = unitOfWork.GuideRepository.GetById(id);
            if (id == null)
            {
                MessageBox.Show("Le guide avec l'ID spécifié n'a pas été trouvé.");
            }
            unitOfWork.GuideRepository.Delete(id);
            unitOfWork.Save();
            MessageBox.Show("Le Guide a ete supprimer avec succes !");
            IEnumerable<Guide> guides = unitOfWork.GuideRepository.GetAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = guides;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVoyage gestionVoyage = new GestionVoyage();
            gestionVoyage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionGuide gestionGuide = new GestionGuide();
            gestionGuide.Show();
        }
    }
}
