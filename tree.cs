
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace Sprint
{
    [ToolboxItemAttribute(false)]

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

                   
                }
               
            }
            catch (Exception ex)
            {
            }
        }
