namespace ProyectoFinalVista.ReportesVista
{
    partial class Detallesdatos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonesDiseño1 = new ProyectoFinalVista.Controles.BotonesDiseño();
            this.botonesDiseño2 = new ProyectoFinalVista.Controles.BotonesDiseño();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(561, 369);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // botonesDiseño1
            // 
            this.botonesDiseño1.BackColor = System.Drawing.Color.DarkRed;
            this.botonesDiseño1.BackgroundColor = System.Drawing.Color.DarkRed;
            this.botonesDiseño1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.botonesDiseño1.BorderRadius = 30;
            this.botonesDiseño1.BorderSize = 0;
            this.botonesDiseño1.FlatAppearance.BorderSize = 0;
            this.botonesDiseño1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesDiseño1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonesDiseño1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.botonesDiseño1.Location = new System.Drawing.Point(117, 390);
            this.botonesDiseño1.Name = "botonesDiseño1";
            this.botonesDiseño1.Size = new System.Drawing.Size(174, 48);
            this.botonesDiseño1.TabIndex = 10;
            this.botonesDiseño1.Text = "VER DETALLE ";
            this.botonesDiseño1.TextColor = System.Drawing.Color.BlanchedAlmond;
            this.botonesDiseño1.UseVisualStyleBackColor = false;
            this.botonesDiseño1.Click += new System.EventHandler(this.botonesDiseño1_Click);
            // 
            // botonesDiseño2
            // 
            this.botonesDiseño2.BackColor = System.Drawing.Color.DarkRed;
            this.botonesDiseño2.BackgroundColor = System.Drawing.Color.DarkRed;
            this.botonesDiseño2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.botonesDiseño2.BorderRadius = 30;
            this.botonesDiseño2.BorderSize = 0;
            this.botonesDiseño2.FlatAppearance.BorderSize = 0;
            this.botonesDiseño2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonesDiseño2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botonesDiseño2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.botonesDiseño2.Location = new System.Drawing.Point(297, 390);
            this.botonesDiseño2.Name = "botonesDiseño2";
            this.botonesDiseño2.Size = new System.Drawing.Size(188, 48);
            this.botonesDiseño2.TabIndex = 11;
            this.botonesDiseño2.Text = "VER INGRESO";
            this.botonesDiseño2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(141)))));
            this.botonesDiseño2.UseVisualStyleBackColor = false;
            this.botonesDiseño2.Click += new System.EventHandler(this.botonesDiseño2_Click);
            // 
            // Detallesdatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.botonesDiseño2);
            this.Controls.Add(this.botonesDiseño1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Detallesdatos";
            this.Text = "Detallesdatos";
            this.Load += new System.EventHandler(this.Detallesdatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Controles.BotonesDiseño botonesDiseño1;
        private Controles.BotonesDiseño botonesDiseño2;
    }
}