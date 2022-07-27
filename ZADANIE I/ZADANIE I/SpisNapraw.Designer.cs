
namespace ZADANIE_I
{
    partial class SpisNapraw
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DodajNaprawe = new System.Windows.Forms.Button();
            this.RozliczeniePracPrzy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // DodajNaprawe
            // 
            this.DodajNaprawe.Location = new System.Drawing.Point(12, 12);
            this.DodajNaprawe.Name = "DodajNaprawe";
            this.DodajNaprawe.Size = new System.Drawing.Size(178, 30);
            this.DodajNaprawe.TabIndex = 1;
            this.DodajNaprawe.Text = "Dodaj naprawę";
            this.DodajNaprawe.UseVisualStyleBackColor = true;
            this.DodajNaprawe.Click += new System.EventHandler(this.DodajNaprawe_Click);
            // 
            // RozliczeniePracPrzy
            // 
            this.RozliczeniePracPrzy.Location = new System.Drawing.Point(641, 12);
            this.RozliczeniePracPrzy.Name = "RozliczeniePracPrzy";
            this.RozliczeniePracPrzy.Size = new System.Drawing.Size(178, 30);
            this.RozliczeniePracPrzy.TabIndex = 2;
            this.RozliczeniePracPrzy.Text = "Rozliczenie pracownika";
            this.RozliczeniePracPrzy.UseVisualStyleBackColor = true;
            this.RozliczeniePracPrzy.Click += new System.EventHandler(this.RozliczeniePracPrzy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 577);
            this.Controls.Add(this.RozliczeniePracPrzy);
            this.Controls.Add(this.DodajNaprawe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DodajNaprawe;
        private System.Windows.Forms.Button RozliczeniePracPrzy;
    }
}

