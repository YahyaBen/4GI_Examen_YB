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
    public partial class CRUDLycee : Form
    {
        public CRUDLycee()
        {
            InitializeComponent();
        }
        Lycee L = new Lycee();
        NetExamenEntities DB = new NetExamenEntities();
        private void CRUDLycee_Load(object sender, EventArgs e)
        {
            DGV_Load();
        }
        public void DGV_Load()
        {
            DGV_Lycee.DataSource = DB.Lycees.Select(x => new { ID = x.ID, Nom = x.Nom, NbrPlaces = x.NbrPlacs }).ToList();
            Txt_Lycee_ID.Text = Count_ID();
        }
        public void Clear()
        {
            Txt_Lycee_Nbr.Text = "";
            Txt_Lycee_Nom.Text = "";
        }
        public string Count_ID()
        {
            int A = DB.Lycees.Max(x => x.ID)+1;
            return A.ToString();
        }
        private void Btn_Lycee_Ajout_Click(object sender, EventArgs e)
        {
            //L.ID = int.Parse(Txt_Lycee_ID.Text); Auto increment!!!!!!
            L.Nom = Txt_Lycee_Nom.Text;
            L.NbrPlacs = int.Parse(Txt_Lycee_Nbr.Text);
            DB.Lycees.Add(L);
            DB.SaveChanges();
            Clear();
            DGV_Load();
        }

        private void Btn_Lycee_Modifier_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous modifier ce Lycee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(DGV_Lycee.CurrentRow.Cells[0].Value.ToString());
                Lycee Lyc = DB.Lycees.Where(x => x.ID == ID).First();
                Lyc.Nom = Txt_Lycee_Nom.Text;
                Lyc.NbrPlacs = int.Parse(Txt_Lycee_Nbr.Text);
                DB.SaveChanges();
                Clear();
                DGV_Load();
                MessageBox.Show("Donnee Lycee Modifier !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Btn_Lycee_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez-vous Supprimer ce Lycee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                int ID = int.Parse(DGV_Lycee.CurrentRow.Cells[0].Value.ToString());
                Lycee Lyc = DB.Lycees.Where(x => x.ID == ID).First();
                DB.Lycees.Remove(Lyc);
                DB.SaveChanges();
                Clear();
                DGV_Load();
                MessageBox.Show("Lycee Supprimer !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Lycee__Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            DGV_Lycee.CurrentCell = DGV_Lycee.Rows[0].Cells[DGV_Lycee.CurrentCell.ColumnIndex];
        }

        private void Btn_Precedent_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV_Lycee.CurrentRow.Index - 1;
                DGV_Lycee.CurrentCell = DGV_Lycee.Rows[A].Cells[DGV_Lycee.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Max Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            try
            {
                int A = DGV_Lycee.CurrentRow.Index + 1;
                DGV_Lycee.CurrentCell = DGV_Lycee.Rows[A].Cells[DGV_Lycee.CurrentCell.ColumnIndex];
            }
            catch (Exception)
            {
                MessageBox.Show("Max Atteint", "Stop !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Last_Click(object sender, EventArgs e)
        {
            int A = DGV_Lycee.Rows.Count - 1;
            DGV_Lycee.CurrentCell = DGV_Lycee.Rows[A].Cells[DGV_Lycee.CurrentCell.ColumnIndex];
        }
    }
}
