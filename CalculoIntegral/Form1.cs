using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBackPack;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace CalculoIntegral {
    public partial class Form1 : Form {
        
        private System.Threading.CancellationTokenSource sourceTknCancel;
        public Form1()
        {
            InitializeComponent();
            MyInitComponents();
        }

        private void MyInitComponents()
        {
            sourceTknCancel = new System.Threading.CancellationTokenSource();
            __Grafica.InitExitoFalloFuncGraph(true);

            __TxtPolinomio.Text = "x^2";
            __TxtA.Text =  "" + -1;
            __TxtB.Text = "" + 1;
            __TxtConfianza.Text = "" + 5;
            __TxtCota.Text = "" + 4;

            __TSMMetodo_DropDownItemClicked(__TSMMetodo, new ToolStripItemClickedEventArgs(__TSMIRiemann));
        }

        private async void __BtnArea_Click(object sender, EventArgs e)
        {
            try {
                __PanelTblOutput.Controls.ReiniciarTextos(
                    new List<Type>() { typeof(Label) }, "...", new List<string>() { "__LblMetodo", "__LblDelta" });
                sourceTknCancel.Cancel();
                sourceTknCancel = new System.Threading.CancellationTokenSource();
                
                foreach (ToolStripMenuItem subMenu in __TSMMetodo.DropDownItems.GetEnumerable().Where(p => p.Checked)) {
                    //obtenemos los parametros
                    Control modulo = __PanelTblOutput.Controls[subMenu.Name.Replace("__TSMI", "__PanelTbl")];
                    var paramsFuncion = new JaceFunciones.R2(
                        __TxtPolinomio.Text, "x",
                        Convert.ToDouble(__TxtA.Text), Convert.ToDouble(__TxtB.Text),
                        Convert.ToDouble(modulo.Controls[0].Controls[1].Controls["__TxtIncremento"].Text));
                    var paramsGrafica = paramsFuncion;
                    paramsGrafica.Incremento = Math.Abs(paramsGrafica.B - paramsGrafica.A) / 100;

                    var paramsError = new CErrorCalc.ParamsError(
                        Convert.ToInt32(__TxtConfianza.Text),
                        ((CheckBox)modulo.Controls[0].Controls[1].Controls["__ChkVerdadero"]).Checked,
                        sourceTknCancel.Token);

                    //Identificamos el metodo por reflexion
                    string nameMethod = subMenu.Name.Replace("__TSMI", "");
                    MethodInfo metodo = typeof(CIntegralCalc).GetMethod(nameMethod);
                    object[] argumentos = !nameMethod.Equals("MonteCarlo") ?
                        new object[] { paramsFuncion, paramsError } :
                        new object[] { paramsFuncion, Convert.ToDouble(__TxtCota.Text), paramsError };
                    //Metodo
                    var result = await Task.Run(
                        () => (CResult.TimeCount<CIntegralCalc.RGeneric>)metodo.Invoke(null, argumentos));
                    if (result.Valor.Valor != null) {    //Control de cancelacion
                        modulo.Controls["__LblRIntegral"].Text = "" + result.Valor.Valor;
                        modulo.Controls["__LblRContador"].Text = "" + result.Conteo;

                        //Graficacion
                        __Grafica.GraficarFuncion(paramsGrafica, 0, sourceTknCancel.Token);
                        if (nameMethod.Equals("MonteCarlo")) {
                            __Grafica.GraficarPuntos(result.Valor.Exitos, 1, sourceTknCancel.Token);
                            __Grafica.GraficarPuntos(result.Valor.Fallos, 2, sourceTknCancel.Token);
                        }
                    }
                }
            } catch (Exception exc) { Console.WriteLine(exc); }
        }
        
        private TableLayoutPanel GenerarModuloResult(string key, string nombreMetodo, string incremento)
        {
            Label labelMet = new Label() { Name = "__LblMetodo", Text = nombreMetodo };
            Label labelDelta = new Label() { Name = "__LblDelta", Text = "Incremento" };
            Label labelResult = new Label() { Name = "__LblRIntegral", Text = "..." };
            Label labelTiempo = new Label() { Name = "__LblRTiempo", Text = "..." };
            Label labelContador = new Label() { Name = "__LblRContador", Text = "..." };
            TextBox textIncr = new TextBox() { Name = "__TxtIncremento", Text = incremento, Width = 50 };
            CheckBox chkVerdadero = new CheckBox() { Name = "__ChkVerdadero", Text = "V", Checked = false };

            var modulo = new TableLayoutPanel() {
                Name = "__PanelTbl" + key,
                ColumnCount = 1,
                RowCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };
            for (int i = 0; i < 3; i++)
                modulo.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 3));

            var div = new TableLayoutPanel() {
                Name = "__PanelTblDiv",
                ColumnCount = 2,
                RowCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            var div2 = new TableLayoutPanel() {
                Name = "__PanelTblDiv2",
                ColumnCount = 3,
                RowCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            for (int i = 0; i < 3; i++)
                div2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 3));

            div2.Controls.Add(labelDelta, 0, 0);
            div2.Controls.Add(textIncr, 1, 0);
            div2.Controls.Add(chkVerdadero, 2, 0);

            div.Controls.Add(labelMet, 0, 0);
            div.Controls.Add(div2, 1, 0);
            //div.Controls.Add(textIncr, 1, 0);

            modulo.Controls.Add(div, 0, 0);
            modulo.Controls.Add(labelResult, 0, 1);
            modulo.Controls.Add(labelContador, 0, 2);

            return modulo;
        }

        private void __TSMMetodo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = (ToolStripMenuItem)e.ClickedItem;
            if (item.Checked) {     //apagar
                item.Checked = false;
                __PanelTblOutput.Controls.RemoveByKey("__PanelTbl" + item.Name.Replace("__TSMI", ""));
            } else {                //encender
                item.Checked = true;
                __PanelTblOutput.Controls.Add(GenerarModuloResult(item.Name.Replace("__TSMI", ""), item.Text, (string)item.Tag));
            }
            __LblCota.Visible = __TxtCota.Visible = __TSMIMonteCarlo.Checked;
        }
    }
}
