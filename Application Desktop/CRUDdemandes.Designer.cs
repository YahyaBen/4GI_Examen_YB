namespace Application_Desktop
{
    partial class CRUDdemandes
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
            this.CB_Prof = new System.Windows.Forms.ComboBox();
            this.CB_Lycee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lab_Ancien = new System.Windows.Forms.Label();
            this.Lab_Nbr_Demandes = new System.Windows.Forms.Label();
            this.DGV_Demandes = new System.Windows.Forms.DataGridView();
            this.Btn_Demand_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Demand_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Demand_Modifier = new System.Windows.Forms.Button();
            this.Btn_Demand_Fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demandes)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Prof
            // 
            this.CB_Prof.FormattingEnabled = true;
            this.CB_Prof.Location = new System.Drawing.Point(126, 52);
            this.CB_Prof.Name = "CB_Prof";
            this.CB_Prof.Size = new System.Drawing.Size(181, 21);
            this.CB_Prof.TabIndex = 0;
            this.CB_Prof.SelectedIndexChanged += new System.EventHandler(this.CB_Prof_SelectedIndexChanged);
            // 
            // CB_Lycee
            // 
            this.CB_Lycee.FormattingEnabled = true;
            this.CB_Lycee.Location = new System.Drawing.Point(126, 104);
            this.CB_Lycee.Name = "CB_Lycee";
            this.CB_Lycee.Size = new System.Drawing.Size(181, 21);
            this.CB_Lycee.TabIndex = 1;
            this.CB_Lycee.SelectedIndexChanged += new System.EventHandler(this.CB_Lycee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professeur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lycee :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anciennte :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nbr Demandes :";
            // 
            // Lab_Ancien
            // 
            this.Lab_Ancien.AutoSize = true;
            this.Lab_Ancien.Location = new System.Drawing.Point(505, 55);
            this.Lab_Ancien.Name = "Lab_Ancien";
            this.Lab_Ancien.Size = new System.Drawing.Size(39, 13);
            this.Lab_Ancien.TabIndex = 6;
            this.Lab_Ancien.Text = ".... ans";
            // 
            // Lab_Nbr_Demandes
            // 
            this.Lab_Nbr_Demandes.AutoSize = true;
            this.Lab_Nbr_Demandes.Location = new System.Drawing.Point(505, 104);
            this.Lab_Nbr_Demandes.Name = "Lab_Nbr_Demandes";
            this.Lab_Nbr_Demandes.Size = new System.Drawing.Size(67, 13);
            this.Lab_Nbr_Demandes.TabIndex = 7;
            this.Lab_Nbr_Demandes.Text = "0 Demandes";
            // 
            // DGV_Demandes
            // 
            this.DGV_Demandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Demandes.Location = new System.Drawing.Point(143, 145);
            this.DGV_Demandes.Name = "DGV_Demandes";
            this.DGV_Demandes.Size = new System.Drawing.Size(446, 150);
            this.DGV_Demandes.TabIndex = 8;
            // 
            // Btn_Demand_Ajouter
            // 
            this.Btn_Demand_Ajouter.Location = new System.Drawing.Point(39, 175);
            this.Btn_Demand_Ajouter.Name = "Btn_Demand_Ajouter";
            this.Btn_Demand_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Demand_Ajouter.TabIndex = 9;
            this.Btn_Demand_Ajouter.Text = "Ajouter";
            this.Btn_Demand_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Demand_Ajouter.Click += new System.EventHandler(this.Btn_Demand_Ajouter_Click);
            // 
            // Btn_Demand_Supprimer
            // 
            this.Btn_Demand_Supprimer.Location = new System.Drawing.Point(39, 272);
            this.Btn_Demand_Supprimer.Name = "Btn_Demand_Supprimer";
            this.Btn_Demand_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Demand_Supprimer.TabIndex = 10;
            this.Btn_Demand_Supprimer.Text = "Supprimer";
            this.Btn_Demand_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Demand_Supprimer.Click += new System.EventHandler(this.Btn_Demand_Supprimer_Click);
            // 
            // Btn_Demand_Modifier
            // 
            this.Btn_Demand_Modifier.Location = new System.Drawing.Point(39, 221);
            this.Btn_Demand_Modifier.Name = "Btn_Demand_Modifier";
            this.Btn_Demand_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Demand_Modifier.TabIndex = 10;
            this.Btn_Demand_Modifier.Text = "Modifier";
            this.Btn_Demand_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Demand_Modifier.Click += new System.EventHandler(this.Btn_Demand_Modifier_Click);
            // 
            // Btn_Demand_Fermer
            // 
            this.Btn_Demand_Fermer.Location = new System.Drawing.Point(508, 313);
            this.Btn_Demand_Fermer.Name = "Btn_Demand_Fermer";
            this.Btn_Demand_Fermer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Demand_Fermer.TabIndex = 11;
            this.Btn_Demand_Fermer.Text = "Fermer";
            this.Btn_Demand_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Demand_Fermer.Click += new System.EventHandler(this.Btn_Demand_Fermer_Click);
            // 
            // CRUDdemandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 358);
            this.Controls.Add(this.Btn_Demand_Fermer);
            this.Controls.Add(this.Btn_Demand_Modifier);
            this.Controls.Add(this.Btn_Demand_Supprimer);
            this.Controls.Add(this.Btn_Demand_Ajouter);
            this.Controls.Add(this.DGV_Demandes);
            this.Controls.Add(this.Lab_Nbr_Demandes);
            this.Controls.Add(this.Lab_Ancien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Lycee);
            this.Controls.Add(this.CB_Prof);
            this.Name = "CRUDdemandes";
            this.Text = "CRUDdemandes";
            this.Load += new System.EventHandler(this.CRUDdemandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Demandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Prof;
        private System.Windows.Forms.ComboBox CB_Lycee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lab_Ancien;
        private System.Windows.Forms.Label Lab_Nbr_Demandes;
        private System.Windows.Forms.DataGridView DGV_Demandes;
        private System.Windows.Forms.Button Btn_Demand_Ajouter;
        private System.Windows.Forms.Button Btn_Demand_Supprimer;
        private System.Windows.Forms.Button Btn_Demand_Modifier;
        private System.Windows.Forms.Button Btn_Demand_Fermer;
    }
}