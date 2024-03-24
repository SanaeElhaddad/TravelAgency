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
    public partial class TravelAgency : Form
    {
        UnitOfWork unitOfWork;
       
        private List<Voyage> Voyages;
        private int currentIndex = 0;

        public TravelAgency()
        {
           
            InitializeComponent();
            unitOfWork = new UnitOfWork();
            Voyages = unitOfWork.VoyageRepository.GetAll().ToList();
            
        }

        private void TravelAgency_Load(object sender, EventArgs e)
        {
            selectVoyage();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void selectVoyage() {
            if (Voyages != null && Voyages.Any())
            {
                Voyage voyage = Voyages[currentIndex];
                titre.Text = voyage.Titre;
                description.Text = voyage.Description;
                destination.Text = voyage.Description; 
                dateD.Text = voyage.DateDepart.ToString();
                DateR.Text = voyage.DateRetour.ToString();
                prix.Text = voyage.Prix.ToString();
                // Récupérer le guide associé à ce voyage
                Guide g = unitOfWork.GuideRepository.GetById(voyage.GuideId);
                guide.Text = $"{g.Nom} {g.Prenom}";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= Voyages.Count)
            {
                currentIndex = 0; 
            }
            selectVoyage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
