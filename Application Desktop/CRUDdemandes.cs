using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Desktop
{
    public partial class CRUDdemandes : Form
    {
        public CRUDdemandes()
        {
            InitializeComponent();
        }
        NetExamenEntities DB = new NetExamenEntities();
        Demande D = new Demande();
        private void CRUDdemandes_Load(object sender, EventArgs e)
        {
            Demandes_Load();
        }

        public void Demandes_Load()
        {
            foreach (Professeur P in DB.Professeurs)
            {
                CB_Prof.Items.Add(P.Matricule+" -- "+ P.NomComplet);
            }
            foreach (Lycee L in DB.Lycees)
            {
                CB_Lycee.Items.Add(L.Nom);
            }
        }
        public string Count_Demandes()
        {
            int A = DB.Demandes.Count(x => x.).where;
            return A.ToString();
        }
        private void CB_Prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            int A = int.Parse(CB_Prof.SelectedItem.ToString());
            Demande Dem = DB.Demandes.Where(x => x.Professeur_id == A).First();
            DateTime X = Dem.Date_Demande.Value;
            DateTime Y = DateTime.Now;
            TimeSpan Z = X - Y;
            Lab_Ancien.Text =Z.ToString()+" ans";
            Lab_Nbr_Demandes.Text = "";
            DGV_Demandes.DataSource = DB.Demandes.Where(x => x.Professeur_id == A).Select(p => new { ID = p.Lycee_id, ID_Mat = p.Lycee.Nom}).ToList();
        }

        private void CB_Lycee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Demand_Ajouter_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Demand_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Demand_Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Demand_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
