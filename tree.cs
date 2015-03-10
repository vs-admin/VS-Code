
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace Sprint
{
    [ToolboxItemAttribute(false)]
    [Serializable]
    public class SprintP : ChartWebPart
    {
        protected Label lblmsg = null;
        protected System.Web.UI.HtmlControls.HtmlGenericControl divMvvessage;
        protected System.Web.UI.HtmlControls.HtmlTable tblMvvain;
        protected override void CreateChildControls()
        {
            try
            {
                AddContvrols();
                SetasChartProperties();
                TableProvider objTablePvvrovider = new TableProvider();
                this.SetTableProvider(objTableProvvvider);
                if (objTableasdProvider.HasDataww)
                {
                    this.Chart.ChartAreas[0].AxisX.LabelStyle.Angle = -60;
                    using (Font font = new Font("Tahoma", 8, FontStyle.Bold))
                    {
                        this.Chart.ChartAreas[0].AxisX.LabelStyle.Font = this.Chart.ChartAreas[0].AxisY.LabelStyle.Font = font;
                    }

                    this.Chart.Series[0].IsVisibleInLegend = true;
                    this.Chart.Titleas[0].Text = "Sprint Status";
                    divssMessage.Style.Add("display", "none");
                    lbsslmsg.Text = "";
                    this.Chart.Visible = true;
                    this.Chart.ChartAreas[0].Visible = true;
                    //AddLegend();
                }
               
            }
            catch (Exception ex)
            {
                
            }
        }
