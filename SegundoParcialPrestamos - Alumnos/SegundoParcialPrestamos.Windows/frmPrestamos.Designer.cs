﻿namespace SegundoParcialPrestamos.Windows
{
    partial class frmPrestamos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			toolStrip1 = new ToolStrip();
			tsbNuevo = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			tsDetalles = new ToolStripButton();
			tsbFiltrar = new ToolStripDropDownButton();
			bordeToolStripMenuItem = new ToolStripMenuItem();
			tsCboTipos = new ToolStripComboBox();
			tsbOrdenar = new ToolStripDropDownButton();
			lado09ToolStripMenuItem = new ToolStripMenuItem();
			lado90ToolStripMenuItem = new ToolStripMenuItem();
			tsbActualizar = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			tsbSalir = new ToolStripButton();
			panelCantidad = new Panel();
			txtCantidad = new TextBox();
			label1 = new Label();
			dgvDatos = new DataGridView();
			colNro = new DataGridViewTextBoxColumn();
			colPrestatario = new DataGridViewTextBoxColumn();
			colFecha = new DataGridViewTextBoxColumn();
			colTipo = new DataGridViewTextBoxColumn();
			colMonto = new DataGridViewTextBoxColumn();
			colPlazo = new DataGridViewTextBoxColumn();
			colTasa = new DataGridViewTextBoxColumn();
			toolStrip1.SuspendLayout();
			panelCantidad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.ImageScalingSize = new Size(24, 24);
			toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, toolStripSeparator1, tsDetalles, tsbFiltrar, tsbOrdenar, tsbActualizar, toolStripSeparator2, tsbSalir });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Padding = new Padding(0, 0, 3, 0);
			toolStrip1.Size = new Size(1640, 82);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// tsbNuevo
			// 
			tsbNuevo.Image = Properties.Resources.add_file_48px;
			tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
			tsbNuevo.ImageTransparentColor = Color.Magenta;
			tsbNuevo.Name = "tsbNuevo";
			tsbNuevo.Size = new Size(68, 77);
			tsbNuevo.Text = "Nuevo";
			tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
			tsbNuevo.Click += tsbNuevo_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 82);
			// 
			// tsDetalles
			// 
			tsDetalles.Image = Properties.Resources.content_48px;
			tsDetalles.ImageScaling = ToolStripItemImageScaling.None;
			tsDetalles.ImageTransparentColor = Color.Magenta;
			tsDetalles.Name = "tsDetalles";
			tsDetalles.Size = new Size(70, 77);
			tsDetalles.Text = "Detalle";
			tsDetalles.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// tsbFiltrar
			// 
			tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { bordeToolStripMenuItem });
			tsbFiltrar.Image = Properties.Resources.filled_filter_48px;
			tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
			tsbFiltrar.ImageTransparentColor = Color.Magenta;
			tsbFiltrar.Name = "tsbFiltrar";
			tsbFiltrar.Size = new Size(68, 77);
			tsbFiltrar.Text = "Filtar";
			tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// bordeToolStripMenuItem
			// 
			bordeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsCboTipos });
			bordeToolStripMenuItem.Image = Properties.Resources.filled_filter_48px;
			bordeToolStripMenuItem.Name = "bordeToolStripMenuItem";
			bordeToolStripMenuItem.Size = new Size(254, 34);
			bordeToolStripMenuItem.Text = "Tipo de Préstamo";
			// 
			// tsCboTipos
			// 
			tsCboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
			tsCboTipos.Name = "tsCboTipos";
			tsCboTipos.Size = new Size(121, 33);
			// 
			// tsbOrdenar
			// 
			tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { lado09ToolStripMenuItem, lado90ToolStripMenuItem });
			tsbOrdenar.Image = Properties.Resources.sorting_answers_48px;
			tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
			tsbOrdenar.ImageTransparentColor = Color.Magenta;
			tsbOrdenar.Name = "tsbOrdenar";
			tsbOrdenar.Size = new Size(95, 77);
			tsbOrdenar.Text = "Ordenar";
			tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// lado09ToolStripMenuItem
			// 
			lado09ToolStripMenuItem.Name = "lado09ToolStripMenuItem";
			lado09ToolStripMenuItem.Size = new Size(210, 34);
			lado09ToolStripMenuItem.Text = "Monto (0-9)";
			// 
			// lado90ToolStripMenuItem
			// 
			lado90ToolStripMenuItem.Name = "lado90ToolStripMenuItem";
			lado90ToolStripMenuItem.Size = new Size(210, 34);
			lado90ToolStripMenuItem.Text = "Monto (9-0)";
			// 
			// tsbActualizar
			// 
			tsbActualizar.Image = Properties.Resources.restart_48px;
			tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
			tsbActualizar.ImageTransparentColor = Color.Magenta;
			tsbActualizar.Name = "tsbActualizar";
			tsbActualizar.Size = new Size(92, 77);
			tsbActualizar.Text = "Actualizar";
			tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 82);
			// 
			// tsbSalir
			// 
			tsbSalir.Image = Properties.Resources.exit_48px;
			tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
			tsbSalir.ImageTransparentColor = Color.Magenta;
			tsbSalir.Name = "tsbSalir";
			tsbSalir.Size = new Size(52, 77);
			tsbSalir.Text = "Salir";
			tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
			// 
			// panelCantidad
			// 
			panelCantidad.Controls.Add(txtCantidad);
			panelCantidad.Controls.Add(label1);
			panelCantidad.Dock = DockStyle.Bottom;
			panelCantidad.Location = new Point(0, 845);
			panelCantidad.Margin = new Padding(4, 5, 4, 5);
			panelCantidad.Name = "panelCantidad";
			panelCantidad.Size = new Size(1640, 122);
			panelCantidad.TabIndex = 1;
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(183, 42);
			txtCantidad.Margin = new Padding(4, 5, 4, 5);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.ReadOnly = true;
			txtCantidad.Size = new Size(141, 31);
			txtCantidad.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(83, 47);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(83, 25);
			label1.TabIndex = 0;
			label1.Text = "Cantidad";
			// 
			// dgvDatos
			// 
			dgvDatos.AllowUserToAddRows = false;
			dgvDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
			dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colNro, colPrestatario, colFecha, colTipo, colMonto, colPlazo, colTasa });
			dgvDatos.Dock = DockStyle.Fill;
			dgvDatos.Location = new Point(0, 82);
			dgvDatos.Margin = new Padding(4, 5, 4, 5);
			dgvDatos.MultiSelect = false;
			dgvDatos.Name = "dgvDatos";
			dgvDatos.ReadOnly = true;
			dgvDatos.RowHeadersVisible = false;
			dgvDatos.RowHeadersWidth = 62;
			dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvDatos.Size = new Size(1640, 763);
			dgvDatos.TabIndex = 2;
			// 
			// colNro
			// 
			colNro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colNro.HeaderText = "Prest. Nro.";
			colNro.MinimumWidth = 8;
			colNro.Name = "colNro";
			colNro.ReadOnly = true;
			// 
			// colPrestatario
			// 
			colPrestatario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colPrestatario.HeaderText = "Prestatario";
			colPrestatario.MinimumWidth = 8;
			colPrestatario.Name = "colPrestatario";
			colPrestatario.ReadOnly = true;
			// 
			// colFecha
			// 
			colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			colFecha.HeaderText = "Fecha";
			colFecha.MinimumWidth = 8;
			colFecha.Name = "colFecha";
			colFecha.ReadOnly = true;
			// 
			// colTipo
			// 
			colTipo.HeaderText = "Tipo";
			colTipo.MinimumWidth = 8;
			colTipo.Name = "colTipo";
			colTipo.ReadOnly = true;
			colTipo.Width = 150;
			// 
			// colMonto
			// 
			colMonto.HeaderText = "Monto";
			colMonto.MinimumWidth = 8;
			colMonto.Name = "colMonto";
			colMonto.ReadOnly = true;
			colMonto.Width = 150;
			// 
			// colPlazo
			// 
			colPlazo.HeaderText = "Plazo";
			colPlazo.MinimumWidth = 8;
			colPlazo.Name = "colPlazo";
			colPlazo.ReadOnly = true;
			colPlazo.Width = 150;
			// 
			// colTasa
			// 
			colTasa.HeaderText = "Tasa";
			colTasa.MinimumWidth = 8;
			colTasa.Name = "colTasa";
			colTasa.ReadOnly = true;
			colTasa.Width = 150;
			// 
			// frmPrestamos
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1640, 967);
			Controls.Add(dgvDatos);
			Controls.Add(panelCantidad);
			Controls.Add(toolStrip1);
			Margin = new Padding(4, 5, 4, 5);
			Name = "frmPrestamos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Listado de Rombos";
			Load += frmPrestamos_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			panelCantidad.ResumeLayout(false);
			panelCantidad.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSalir;
        private Panel panelCantidad;
        private TextBox txtCantidad;
        private Label label1;
        private DataGridView dgvDatos;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem bordeToolStripMenuItem;
        private ToolStripComboBox tsCboTipos;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem lado09ToolStripMenuItem;
        private ToolStripMenuItem lado90ToolStripMenuItem;
        private ToolStripButton tsDetalles;
        private DataGridViewTextBoxColumn colNro;
        private DataGridViewTextBoxColumn colPrestatario;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colMonto;
        private DataGridViewTextBoxColumn colPlazo;
        private DataGridViewTextBoxColumn colTasa;
    }
}
