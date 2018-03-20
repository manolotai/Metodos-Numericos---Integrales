namespace CalculoIntegral {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.@__PanelMain = new System.Windows.Forms.Panel();
            this.@__PanelTblMain = new System.Windows.Forms.TableLayoutPanel();
            this.@__PanelTblInput = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.@__TxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.@__TxtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.@__TxtPolinomio = new System.Windows.Forms.TextBox();
            this.@__BtnArea = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.@__TxtCota = new System.Windows.Forms.TextBox();
            this.@__LblCota = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.@__TxtConfianza = new System.Windows.Forms.TextBox();
            this.@__Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.@__PanelTblOutput = new System.Windows.Forms.TableLayoutPanel();
            this.@__MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.@__TSMMetodo = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMIRiemann = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMITrapecio = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMISimpson = new System.Windows.Forms.ToolStripMenuItem();
            this.@__TSMIMonteCarlo = new System.Windows.Forms.ToolStripMenuItem();
            this.@__PanelMain.SuspendLayout();
            this.@__PanelTblMain.SuspendLayout();
            this.@__PanelTblInput.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.@__Grafica)).BeginInit();
            this.@__MenuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // __PanelMain
            // 
            this.@__PanelMain.Controls.Add(this.@__PanelTblMain);
            this.@__PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelMain.Location = new System.Drawing.Point(0, 24);
            this.@__PanelMain.Name = "__PanelMain";
            this.@__PanelMain.Size = new System.Drawing.Size(695, 310);
            this.@__PanelMain.TabIndex = 0;
            // 
            // __PanelTblMain
            // 
            this.@__PanelTblMain.ColumnCount = 2;
            this.@__PanelTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.@__PanelTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.@__PanelTblMain.Controls.Add(this.@__PanelTblInput, 0, 0);
            this.@__PanelTblMain.Controls.Add(this.@__PanelTblOutput, 1, 0);
            this.@__PanelTblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTblMain.Location = new System.Drawing.Point(0, 0);
            this.@__PanelTblMain.Name = "__PanelTblMain";
            this.@__PanelTblMain.RowCount = 1;
            this.@__PanelTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__PanelTblMain.Size = new System.Drawing.Size(695, 310);
            this.@__PanelTblMain.TabIndex = 0;
            // 
            // __PanelTblInput
            // 
            this.@__PanelTblInput.ColumnCount = 1;
            this.@__PanelTblInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__PanelTblInput.Controls.Add(this.panel2, 0, 1);
            this.@__PanelTblInput.Controls.Add(this.@__TxtPolinomio, 0, 0);
            this.@__PanelTblInput.Controls.Add(this.@__BtnArea, 0, 4);
            this.@__PanelTblInput.Controls.Add(this.panel1, 0, 2);
            this.@__PanelTblInput.Controls.Add(this.@__Grafica, 0, 3);
            this.@__PanelTblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTblInput.Location = new System.Drawing.Point(0, 0);
            this.@__PanelTblInput.Margin = new System.Windows.Forms.Padding(0);
            this.@__PanelTblInput.Name = "__PanelTblInput";
            this.@__PanelTblInput.RowCount = 5;
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.@__PanelTblInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.@__PanelTblInput.Size = new System.Drawing.Size(417, 310);
            this.@__PanelTblInput.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.@__TxtB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.@__TxtA);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 31);
            this.panel2.TabIndex = 1;
            // 
            // __TxtB
            // 
            this.@__TxtB.Location = new System.Drawing.Point(225, 6);
            this.@__TxtB.Name = "__TxtB";
            this.@__TxtB.Size = new System.Drawing.Size(90, 20);
            this.@__TxtB.TabIndex = 2;
            this.@__TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // __TxtA
            // 
            this.@__TxtA.Location = new System.Drawing.Point(90, 6);
            this.@__TxtA.Name = "__TxtA";
            this.@__TxtA.Size = new System.Drawing.Size(90, 20);
            this.@__TxtA.TabIndex = 1;
            this.@__TxtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // __TxtPolinomio
            // 
            this.@__TxtPolinomio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.@__TxtPolinomio.Location = new System.Drawing.Point(96, 5);
            this.@__TxtPolinomio.Name = "__TxtPolinomio";
            this.@__TxtPolinomio.Size = new System.Drawing.Size(225, 20);
            this.@__TxtPolinomio.TabIndex = 0;
            this.@__TxtPolinomio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // __BtnArea
            // 
            this.@__BtnArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.@__BtnArea.Location = new System.Drawing.Point(174, 282);
            this.@__BtnArea.Name = "__BtnArea";
            this.@__BtnArea.Size = new System.Drawing.Size(68, 25);
            this.@__BtnArea.TabIndex = 6;
            this.@__BtnArea.Text = "Area";
            this.@__BtnArea.UseVisualStyleBackColor = true;
            this.@__BtnArea.Click += new System.EventHandler(this.@__BtnArea_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.@__TxtCota);
            this.panel1.Controls.Add(this.@__LblCota);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.@__TxtConfianza);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 31);
            this.panel1.TabIndex = 5;
            // 
            // __TxtCota
            // 
            this.@__TxtCota.Location = new System.Drawing.Point(255, 3);
            this.@__TxtCota.Name = "__TxtCota";
            this.@__TxtCota.Size = new System.Drawing.Size(60, 20);
            this.@__TxtCota.TabIndex = 5;
            // 
            // __LblCota
            // 
            this.@__LblCota.AutoSize = true;
            this.@__LblCota.Location = new System.Drawing.Point(217, 6);
            this.@__LblCota.Name = "__LblCota";
            this.@__LblCota.Size = new System.Drawing.Size(32, 13);
            this.@__LblCota.TabIndex = 7;
            this.@__LblCota.Text = "Cota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confianza:";
            // 
            // __TxtConfianza
            // 
            this.@__TxtConfianza.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.@__TxtConfianza.Location = new System.Drawing.Point(137, 3);
            this.@__TxtConfianza.Name = "__TxtConfianza";
            this.@__TxtConfianza.Size = new System.Drawing.Size(60, 20);
            this.@__TxtConfianza.TabIndex = 4;
            // 
            // __Grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.@__Grafica.ChartAreas.Add(chartArea1);
            this.@__Grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.@__Grafica.Legends.Add(legend1);
            this.@__Grafica.Location = new System.Drawing.Point(0, 93);
            this.@__Grafica.Margin = new System.Windows.Forms.Padding(0);
            this.@__Grafica.Name = "__Grafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.@__Grafica.Series.Add(series1);
            this.@__Grafica.Size = new System.Drawing.Size(417, 186);
            this.@__Grafica.TabIndex = 7;
            this.@__Grafica.Text = "chart1";
            // 
            // __PanelTblOutput
            // 
            this.@__PanelTblOutput.ColumnCount = 1;
            this.@__PanelTblOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__PanelTblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PanelTblOutput.Location = new System.Drawing.Point(417, 0);
            this.@__PanelTblOutput.Margin = new System.Windows.Forms.Padding(0);
            this.@__PanelTblOutput.Name = "__PanelTblOutput";
            this.@__PanelTblOutput.RowCount = 4;
            this.@__PanelTblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.@__PanelTblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.@__PanelTblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.@__PanelTblOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.@__PanelTblOutput.Size = new System.Drawing.Size(278, 310);
            this.@__PanelTblOutput.TabIndex = 1;
            // 
            // __MenuStripMain
            // 
            this.@__MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__TSMMetodo});
            this.@__MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.@__MenuStripMain.Name = "__MenuStripMain";
            this.@__MenuStripMain.Size = new System.Drawing.Size(695, 24);
            this.@__MenuStripMain.TabIndex = 1;
            this.@__MenuStripMain.Text = "Menu";
            // 
            // __TSMMetodo
            // 
            this.@__TSMMetodo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.@__TSMIRiemann,
            this.@__TSMITrapecio,
            this.@__TSMISimpson,
            this.@__TSMIMonteCarlo});
            this.@__TSMMetodo.Name = "__TSMMetodo";
            this.@__TSMMetodo.Size = new System.Drawing.Size(61, 20);
            this.@__TSMMetodo.Text = "Metodo";
            this.@__TSMMetodo.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.@__TSMMetodo_DropDownItemClicked);
            // 
            // __TSMIRiemann
            // 
            this.@__TSMIRiemann.Name = "__TSMIRiemann";
            this.@__TSMIRiemann.Size = new System.Drawing.Size(152, 22);
            this.@__TSMIRiemann.Tag = "100";
            this.@__TSMIRiemann.Text = "Riemann";
            // 
            // __TSMITrapecio
            // 
            this.@__TSMITrapecio.Name = "__TSMITrapecio";
            this.@__TSMITrapecio.Size = new System.Drawing.Size(152, 22);
            this.@__TSMITrapecio.Tag = "1";
            this.@__TSMITrapecio.Text = "Trapecio";
            // 
            // __TSMISimpson
            // 
            this.@__TSMISimpson.Name = "__TSMISimpson";
            this.@__TSMISimpson.Size = new System.Drawing.Size(152, 22);
            this.@__TSMISimpson.Tag = "2";
            this.@__TSMISimpson.Text = "Simpson";
            // 
            // __TSMIMonteCarlo
            // 
            this.@__TSMIMonteCarlo.Name = "__TSMIMonteCarlo";
            this.@__TSMIMonteCarlo.Size = new System.Drawing.Size(152, 22);
            this.@__TSMIMonteCarlo.Tag = "10";
            this.@__TSMIMonteCarlo.Text = "Monte Carlo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 334);
            this.Controls.Add(this.@__PanelMain);
            this.Controls.Add(this.@__MenuStripMain);
            this.MainMenuStrip = this.@__MenuStripMain;
            this.Name = "Form1";
            this.Text = "Calculo Integral - Angel Emmanuel Ruiz Alcaraz";
            this.@__PanelMain.ResumeLayout(false);
            this.@__PanelTblMain.ResumeLayout(false);
            this.@__PanelTblInput.ResumeLayout(false);
            this.@__PanelTblInput.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.@__Grafica)).EndInit();
            this.@__MenuStripMain.ResumeLayout(false);
            this.@__MenuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel __PanelMain;
        private System.Windows.Forms.MenuStrip __MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem __TSMMetodo;
        private System.Windows.Forms.ToolStripMenuItem __TSMIRiemann;
        private System.Windows.Forms.ToolStripMenuItem __TSMITrapecio;
        private System.Windows.Forms.ToolStripMenuItem __TSMISimpson;
        private System.Windows.Forms.TableLayoutPanel __PanelTblMain;
        private System.Windows.Forms.TableLayoutPanel __PanelTblInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox __TxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox __TxtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox __TxtPolinomio;
        private System.Windows.Forms.Button __BtnArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox __TxtConfianza;
        private System.Windows.Forms.TextBox __TxtCota;
        private System.Windows.Forms.Label __LblCota;
        private System.Windows.Forms.ToolStripMenuItem __TSMIMonteCarlo;
        private System.Windows.Forms.TableLayoutPanel __PanelTblOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart __Grafica;
    }
}

