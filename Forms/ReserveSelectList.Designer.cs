namespace BibliotecaPilar.Forms
{
    partial class ReserveSelectList
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
            grpReserves = new GroupBox();
            btnSelectReserve = new Button();
            dgvReserves = new DataGridView();
            grpReserves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReserves).BeginInit();
            SuspendLayout();
            // 
            // grpReserves
            // 
            grpReserves.Controls.Add(btnSelectReserve);
            grpReserves.Controls.Add(dgvReserves);
            grpReserves.Location = new Point(12, 12);
            grpReserves.Name = "grpReserves";
            grpReserves.Padding = new Padding(10, 5, 10, 10);
            grpReserves.Size = new Size(660, 567);
            grpReserves.TabIndex = 4;
            grpReserves.TabStop = false;
            grpReserves.Text = "Reservas do Livro Selecionado";
            // 
            // btnSelectReserve
            // 
            btnSelectReserve.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectReserve.Location = new Point(531, 526);
            btnSelectReserve.Name = "btnSelectReserve";
            btnSelectReserve.Size = new Size(116, 27);
            btnSelectReserve.TabIndex = 12;
            btnSelectReserve.Text = "Efetuar Retirada";
            btnSelectReserve.UseVisualStyleBackColor = true;
            btnSelectReserve.Click += BtnSelectReserve_Click;
            // 
            // dgvReserves
            // 
            dgvReserves.AllowUserToAddRows = false;
            dgvReserves.AllowUserToDeleteRows = false;
            dgvReserves.BorderStyle = BorderStyle.None;
            dgvReserves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserves.Location = new Point(13, 24);
            dgvReserves.Name = "dgvReserves";
            dgvReserves.ReadOnly = true;
            dgvReserves.RowHeadersVisible = false;
            dgvReserves.RowTemplate.Height = 25;
            dgvReserves.ScrollBars = ScrollBars.Horizontal;
            dgvReserves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReserves.Size = new Size(634, 496);
            dgvReserves.TabIndex = 2;
            // 
            // ReserveSelectList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 591);
            Controls.Add(grpReserves);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReserveSelectList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecione a Reserva";
            FormClosing += ReserveSelectList_FormClosing;
            grpReserves.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReserves).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpReserves;
        private DataGridView dgvReserves;
        private Button btnSelectReserve;
    }
}