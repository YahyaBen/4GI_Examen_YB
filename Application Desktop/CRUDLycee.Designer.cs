namespace Application_Desktop
{
    partial class CRUDLycee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Lycee_Ajout = new System.Windows.Forms.Button();
            this.Btn_Lycee_Modifier = new System.Windows.Forms.Button();
            this.Btn_Lycee_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Lycee__Fermer = new System.Windows.Forms.Button();
            this.DGV_Lycee = new System.Windows.Forms.DataGridView();
            this.Txt_Lycee_ID = new System.Windows.Forms.TextBox();
            this.Txt_Lycee_Nom = new System.Windows.Forms.TextBox();
            this.Txt_Lycee_Nbr = new System.Windows.Forms.TextBox();
            this.Btn_First = new System.Windows.Forms.Button();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lycee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nbr Places";
            // 
            // Btn_Lycee_Ajout
            // 
            this.Btn_Lycee_Ajout.Location = new System.Drawing.Point(370, 25);
            this.Btn_Lycee_Ajout.Name = "Btn_Lycee_Ajout";
            this.Btn_Lycee_Ajout.Size = new System.Drawing.Size(117, 52);
            this.Btn_Lycee_Ajout.TabIndex = 3;
            this.Btn_Lycee_Ajout.Text = "Ajouter";
            this.Btn_Lycee_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Lycee_Ajout.Click += new System.EventHandler(this.Btn_Lycee_Ajout_Click);
            // 
            // Btn_Lycee_Modifier
            // 
            this.Btn_Lycee_Modifier.Location = new System.Drawing.Point(370, 97);
            this.Btn_Lycee_Modifier.Name = "Btn_Lycee_Modifier";
            this.Btn_Lycee_Modifier.Size = new System.Drawing.Size(117, 57);
            this.Btn_Lycee_Modifier.TabIndex = 4;
            this.Btn_Lycee_Modifier.Text = "Modifier";
            this.Btn_Lycee_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Lycee_Modifier.Click += new System.EventHandler(this.Btn_Lycee_Modifier_Click);
            // 
            // Btn_Lycee_Supprimer
            // 
            this.Btn_Lycee_Supprimer.Location = new System.Drawing.Point(370, 179);
            this.Btn_Lycee_Supprimer.Name = "Btn_Lycee_Supprimer";
            this.Btn_Lycee_Supprimer.Size = new System.Drawing.Size(117, 64);
            this.Btn_Lycee_Supprimer.TabIndex = 5;
            this.Btn_Lycee_Supprimer.Text = "Supprimer";
            this.Btn_Lycee_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Lycee_Supprimer.Click += new System.EventHandler(this.Btn_Lycee_Supprimer_Click);
            // 
            // Btn_Lycee__Fermer
            // 
            this.Btn_Lycee__Fermer.Location = new System.Drawing.Point(370, 264);
            this.Btn_Lycee__Fermer.Name = "Btn_Lycee__Fermer";
            this.Btn_Lycee__Fermer.Size = new System.Drawing.Size(117, 63);
            this.Btn_Lycee__Fermer.TabIndex = 6;
            this.Btn_Lycee__Fermer.Text = "Fermer";
            this.Btn_Lycee__Fermer.UseVisualStyleBackColor = true;
            this.Btn_Lycee__Fermer.Click += new System.EventHandler(this.Btn_Lycee__Fermer_Click);
            // 
            // DGV_Lycee
            // 
            this.DGV_Lycee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Lycee.Location = new System.Drawing.Point(12, 179);
            this.DGV_Lycee.Name = "DGV_Lycee";
            this.DGV_Lycee.Size = new System.Drawing.Size(332, 165);
            this.DGV_Lycee.TabIndex = 7;
            // 
            // Txt_Lycee_ID
            // 
            this.Txt_Lycee_ID.Enabled = false;
            this.Txt_Lycee_ID.Location = new System.Drawing.Point(148, 36);
            this.Txt_Lycee_ID.Name = "Txt_Lycee_ID";
            this.Txt_Lycee_ID.Size = new System.Drawing.Size(155, 20);
            this.Txt_Lycee_ID.TabIndex = 8;
            // 
            // Txt_Lycee_Nom
            // 
            this.Txt_Lycee_Nom.Location = new System.Drawing.Point(148, 87);
            this.Txt_Lycee_Nom.Name = "Txt_Lycee_Nom";
            this.Txt_Lycee_Nom.Size = new System.Drawing.Size(155, 20);
            this.Txt_Lycee_Nom.TabIndex = 9;
            // 
            // Txt_Lycee_Nbr
            // 
            this.Txt_Lycee_Nbr.Location = new System.Drawing.Point(148, 134);
            this.Txt_Lycee_Nbr.Name = "Txt_Lycee_Nbr";
            this.Txt_Lycee_Nbr.Size = new System.Drawing.Size(155, 20);
            this.Txt_Lycee_Nbr.TabIndex = 10;
            // 
            // Btn_First
            // 
            this.Btn_First.Location = new System.Drawing.Point(12, 350);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(36, 30);
            this.Btn_First.TabIndex = 11;
            this.Btn_First.Text = "<<";
            this.Btn_First.UseVisualStyleBackColor = true;
            this.Btn_First.Click += new System.EventHandler(this.Btn_First_Click);
            // 
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(43, 350);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(24, 30);
            this.Btn_Precedent.TabIndex = 12;
            this.Btn_Precedent.Text = "<";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Location = new System.Drawing.Point(310, 350);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(32, 30);
            this.Btn_Last.TabIndex = 13;
            this.Btn_Last.Text = ">>";
            this.Btn_Last.UseVisualStyleBackColor = true;
            this.Btn_Last.Click += new System.EventHandler(this.Btn_Last_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(288, 350);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(24, 30);
            this.Btn_Next.TabIndex = 14;
            this.Btn_Next.Text = ">";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // CRUDLycee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 407);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Last);
            this.Controls.Add(this.Btn_Precedent);
            this.Controls.Add(this.Btn_First);
            this.Controls.Add(this.Txt_Lycee_Nbr);
            this.Controls.Add(this.Txt_Lycee_Nom);
            this.Controls.Add(this.Txt_Lycee_ID);
            this.Controls.Add(this.DGV_Lycee);
            this.Controls.Add(this.Btn_Lycee__Fermer);
            this.Controls.Add(this.Btn_Lycee_Supprimer);
            this.Controls.Add(this.Btn_Lycee_Modifier);
            this.Controls.Add(this.Btn_Lycee_Ajout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUDLycee";
            this.Text = "CRUDLycee";
            this.Load += new System.EventHandler(this.CRUDLycee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Lycee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Lycee_Ajout;
        private System.Windows.Forms.Button Btn_Lycee_Modifier;
        private System.Windows.Forms.Button Btn_Lycee_Supprimer;
        private System.Windows.Forms.Button Btn_Lycee__Fermer;
        private System.Windows.Forms.DataGridView DGV_Lycee;
        private System.Windows.Forms.TextBox Txt_Lycee_ID;
        private System.Windows.Forms.TextBox Txt_Lycee_Nom;
        private System.Windows.Forms.TextBox Txt_Lycee_Nbr;
        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Button Btn_Precedent;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Button Btn_Next;
    }
}