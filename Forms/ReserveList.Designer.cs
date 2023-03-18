namespace BibliotecaPilar.Forms
{
    partial class ReserveList
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
            dgvReserves = new DataGridView();
            grpReserves = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvReserves).BeginInit();
            grpReserves.SuspendLayout();
            SuspendLayout();
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
            dgvReserves.Size = new Size(634, 530);
            dgvReserves.TabIndex = 2;
            // 
            // grpReserves
            // 
            grpReserves.Controls.Add(dgvReserves);
            grpReserves.Location = new Point(12, 12);
            grpReserves.Name = "grpReserves";
            grpReserves.Padding = new Padding(10, 5, 10, 10);
            grpReserves.Size = new Size(660, 567);
            grpReserves.TabIndex = 3;
            grpReserves.TabStop = false;
            grpReserves.Text = "Minhas Reservas";
            // 
            // ReserveList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 591);
            Controls.Add(grpReserves);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReserveList";
            Text = "ReserveList";
            ((System.ComponentModel.ISupportInitialize)dgvReserves).EndInit();
            grpReserves.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvReserves;
        private GroupBox grpReserves;
    }
}